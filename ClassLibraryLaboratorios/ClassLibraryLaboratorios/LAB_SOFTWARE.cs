using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLaboratorios
{
    public class LAB_SOFTWARE
    {
        public string strCod_sof { get; set; }
        public string strCod_Sede { get; set; }
        public string strCod_Fac { get; set; }
        public string strNombre_sof { get; set; }
        public string strTipoLicencia_sof { get; set; }
        public string strNombreLicencia_sof { get; set; }
        public int intCantidad_sof { get; set; }
        public decimal decCostoUnitario { get; set; }
        public decimal decCostoTotal { get; set; }
        public string strDescripcion_sof { get; set; }
        public string strImagen_sof { get; set; }
        public string strUrl_sof { get; set; }
        public DateTime dtFechaRegistro_sof { get; set; }
        public bool bitEstado_sof { get; set; }
        public DateTime dtFecha_log { get; set; }
        public string strUser_log { get; set; }
        public string strObs1_sof { get; set; }
        public string strObs2_sof { get; set; }
        public bool bitObs1_sof { get; set; }
        public bool bitObs2_sof { get; set; }
        public decimal decObs1_sof { get; set; }
        public decimal decObs2_sof { get; set; }
        public DateTime dtObs1_sof { get; set; }
        public DateTime dtObs2_sof { get; set; }

        string cadenaConexion;
        SqlConnection conexion;

        public LAB_SOFTWARE(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            this.conexion = new SqlConnection(this.cadenaConexion);
        }

        public bool guardarSoftware()
        {
            bool registro;

            SqlCommand comandoInsercion = new SqlCommand("SIGUTC_AddLAB_SOFTWARE", this.conexion);
            comandoInsercion.CommandType = CommandType.StoredProcedure;
            comandoInsercion.Parameters.AddWithValue("@strCod_sof", strCod_sof);
            comandoInsercion.Parameters.AddWithValue("@strNombre_sof", strNombre_sof);
            comandoInsercion.Parameters.AddWithValue("@strTipoLicencia_sof", strTipoLicencia_sof);
            comandoInsercion.Parameters.AddWithValue("@strNombreLicencia_sof", strNombreLicencia_sof);
            comandoInsercion.Parameters.AddWithValue("@intCantidad_sof", intCantidad_sof);
            comandoInsercion.Parameters.AddWithValue("@decCostoUnitario_sof", decCostoUnitario);
            comandoInsercion.Parameters.AddWithValue("@decCostoTotal_sof", decCostoTotal);
            comandoInsercion.Parameters.AddWithValue("@strDescripcion_sof", strDescripcion_sof);
            comandoInsercion.Parameters.AddWithValue("@strImagen_sof", strImagen_sof);
            comandoInsercion.Parameters.AddWithValue("@strUrl_sof", strUrl_sof);
            comandoInsercion.Parameters.AddWithValue("@dtFechaRegistro_sof", dtFechaRegistro_sof);
            comandoInsercion.Parameters.AddWithValue("@dtFecha_log", dtFecha_log);
            comandoInsercion.Parameters.AddWithValue("@strUser_log", strUser_log);
            comandoInsercion.Parameters.AddWithValue("@strCod_Fac", strCod_Fac);
            comandoInsercion.Parameters.AddWithValue("@strCod_Sede", strCod_Sede);

            try
            {
                this.conexion.Open();
                comandoInsercion.ExecuteNonQuery();
                conexion.Close();

                registro = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex);
                registro = false;
            }

            return registro;
        }

        public DataTable obtenerSoftware(string tipoConsulta)
        {
            // Configura el comando SQL para obtener todos los laboratorios
            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetLAB_SOFTWARE", this.conexion);

            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", strCod_Fac);
            comandoConsulta.Parameters.AddWithValue("@FILTRO2", strCod_Sede);
            comandoConsulta.Parameters.AddWithValue("@FILTRO3", "");
            comandoConsulta.Parameters.AddWithValue("@FILTRO4", "");
            comandoConsulta.CommandType = CommandType.StoredProcedure;

            DataTable tablaDatos = new DataTable();

            try
            {
                conexion.Open();

                // Llena un DataTable con los datos de los laboratorios
                SqlDataAdapter adaptadorAlbum = new SqlDataAdapter(comandoConsulta);
                adaptadorAlbum.Fill(tablaDatos);
            }
            catch (Exception ex)
            {
                // Muestra un error si ocurre
                Console.WriteLine("ERROR: " + ex.Message);
            }
            conexion.Close();

            return tablaDatos;
        }

        public void listadoLaboratorioId()
        {
            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetLAB_SOFTWARE", conexion);
            string tipoConsulta = "xPK";

            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", strCod_sof);
            comandoConsulta.Parameters.AddWithValue("@FILTRO2", "");
            comandoConsulta.Parameters.AddWithValue("@FILTRO3", "");
            comandoConsulta.Parameters.AddWithValue("@FILTRO4", "");
            comandoConsulta.CommandType = CommandType.StoredProcedure;

            try
            {
                conexion.Open();
                SqlDataReader reader = comandoConsulta.ExecuteReader();
                while (reader.Read())
                {
                    strCod_sof = reader["strCod_sof"].ToString();
                    strNombre_sof = reader["strNombre_sof"].ToString();
                    strTipoLicencia_sof = reader["strTipoLicencia_sof"].ToString();
                    strNombreLicencia_sof = reader["strNombreLicencia_sof"].ToString();
                    intCantidad_sof = Convert.ToInt32(reader["intCantidad_sof"]);
                    decCostoUnitario = decimal.Parse(reader["decCostoUnitario_sof"].ToString());
                    strDescripcion_sof = reader["strDescripcion_sof"].ToString();
                    strImagen_sof = reader["strImagen_sof"].ToString();
                    strUrl_sof = reader["strUrl_sof"].ToString();
                    strCod_Fac = reader["strCod_Fac"].ToString();
                    strCod_Sede = reader["strCod_Sede"].ToString();
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.Write("ERROR: " + ex.Message);
            }
            conexion.Close();
        }

        public bool actualizarSoftware()
        {
            bool registro;

            SqlCommand comandoInsercion = new SqlCommand("SIGUTC_UpdateLAB_SOFTWARE", this.conexion);
            comandoInsercion.CommandType = CommandType.StoredProcedure;
            comandoInsercion.Parameters.AddWithValue("@strCod_sof", strCod_sof);
            comandoInsercion.Parameters.AddWithValue("@strNombre_sof", strNombre_sof);
            comandoInsercion.Parameters.AddWithValue("@strTipoLicencia_sof", strTipoLicencia_sof);
            comandoInsercion.Parameters.AddWithValue("@strNombreLicencia_sof", strNombreLicencia_sof);
            comandoInsercion.Parameters.AddWithValue("@intCantidad_sof", intCantidad_sof);
            comandoInsercion.Parameters.AddWithValue("@decCostoUnitario_sof", decCostoUnitario);
            comandoInsercion.Parameters.AddWithValue("@decCostoTotal_sof", decCostoTotal);
            comandoInsercion.Parameters.AddWithValue("@strDescripcion_sof", strDescripcion_sof);
            comandoInsercion.Parameters.AddWithValue("@strImagen_sof", strImagen_sof);
            comandoInsercion.Parameters.AddWithValue("@strUrl_sof", strUrl_sof);
            comandoInsercion.Parameters.AddWithValue("@dtFecha_log", dtFecha_log);
            comandoInsercion.Parameters.AddWithValue("@strUser_log", strUser_log);
            comandoInsercion.Parameters.AddWithValue("@strCod_Fac", strCod_Fac);
            comandoInsercion.Parameters.AddWithValue("@strCod_Sede", strCod_Sede);

            try
            {
                this.conexion.Open();
                comandoInsercion.ExecuteNonQuery();
                conexion.Close();

                registro = true;
            }
            catch (Exception ex)
            {
                Console.Write("ERROR: " + ex.Message);
                registro = false;
            }

            return registro;
        }

        public bool eliminarSoftware(string comodin)
        {
            bool registro;

            SqlCommand comandoEliminacion = new SqlCommand("SIGUTC_DelLAB_SOFTWARE", this.conexion);
            comandoEliminacion.CommandType = CommandType.StoredProcedure;
            comandoEliminacion.Parameters.AddWithValue("@Comodin", comodin);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO1", strCod_sof);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO2", dtFecha_log);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO3", strUser_log);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO4", "");

            try
            {
                this.conexion.Open();
                comandoEliminacion.ExecuteNonQuery();
                conexion.Close();

                registro = true;
            }
            catch (Exception ex)
            {
                Console.Write("ERROR: " + ex.Message);
                registro = false;
            }

            return registro;
        }
    }
}
