using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using ReservaLaboratorios.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace ReservaLaboratorios.Views
{
    public partial class Login : System.Web.UI.Page
    {
        string cadenaConexion;
        SqlConnection conexion;

        string rol = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            this.cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBddProductos"].ConnectionString;
            this.conexion = new SqlConnection(this.cadenaConexion);
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string usuario = Usuario.Text.Trim();
                string password = Password.Text.Trim();

                if (iniarSecion(usuario, password))
                {
                    FormsAuthentication.SetAuthCookie(usuario, false);
                    string returnUrl = Request.QueryString["ReturnUrl"];
                    if (!String.IsNullOrEmpty(returnUrl))
                    {
                        Response.Redirect(returnUrl);
                    }
                    else
                    {
                        if (rol == "DOCENTE" || rol == "ESTUDIANTE")
                        {
                            string url = "../Views/Docentes/Laboratorios.aspx";
                            string script = $"mostrarNotificacion('success', 'Inicio de sesión exitoso', '{url}');";
                            ClientScript.RegisterStartupScript(this.GetType(), "notificacionExito", script, true);
                        }
                        else if (rol == "ADMINISTRADOR" | rol == "LABORATORISTA")
                        {
                            string url = "../Views/Laboratoristas/GestionLaborarios.aspx";
                            string script = $"mostrarNotificacion('success', 'Inicio de sesión exitoso', '{url}');";
                            ClientScript.RegisterStartupScript(this.GetType(), "notificacionExito", script, true);
                        }
                        else
                        {
                            string url = "../Views/Login.aspx";
                            string script = $"mostrarNotificacion('error', 'Error al iniciar sesion', '{url}');";
                            ClientScript.RegisterStartupScript(this.GetType(), "LoginError", script, true);
                        }
                    }
                }
            }
        }
        /*Metodo con parametros para iniciar sesion y con retorno booleano*/
        public bool iniarSecion(string usuario, string password)
        {
            bool validacion = true;
            /*llamado al sp*/
            SqlCommand comandoConsulta = new SqlCommand("loginPlataforma", this.conexion);
            /*Envio de parametros*/
            comandoConsulta.Parameters.AddWithValue("@usuario", usuario);
            comandoConsulta.Parameters.AddWithValue("@contrasena", password);
            comandoConsulta.CommandType = CommandType.StoredProcedure;
            try
            {
                this.conexion.Open();
                SqlDataReader dr = comandoConsulta.ExecuteReader();
                /*retorno de parametros una vez validado*/
                if (dr.Read())
                {
                    string ci = dr["CEDULA_ALU"].ToString();
                    Session["Cedula"] = ci;
                    Session["Permisos"] = dr["strNombre_rol"].ToString();
                    rol = dr["strNombre_rol"].ToString();

                    //User.Identity.Name = ci;
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                FailureText.Text = "ERROR: " + ex.Message;
                ErrorMessage.Visible = true;
            }
            return validacion;
        }
    }
}