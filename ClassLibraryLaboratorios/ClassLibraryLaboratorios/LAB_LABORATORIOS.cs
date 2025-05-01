using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryLaboratorios
{
    public class LAB_LABORATORIOS
    {
        // Propiedades de la clase
        public string strCod_Lab { get; set; }
        public string strCod_Sede { get; set; }
        public string strCod_Fac { get; set; }
        public string strNombre_Lab { get; set; }
        public int intNumeroEquipos_lab { get; set; }
        public string strUbicacion_Lab { get; set; }
        public string strCod_tipoLab { get; set; }
        public string strCod_areac { get; set; }
        public string strFotografia1_Lab { get; set; }
        public string strFotografia2_Lab { get; set; }
        public DateTime dtFechaRegistro_lab { get; set; }
        public bool bitEstado_Lab { get; set; }
        public DateTime dtFecha_log { get; set; }
        public string strUser_log { get; set; }
        public string strObs1_lab { get; set; }
        public string strObs2_lab { get; set; }
        public bool bitObs1_lab { get; set; }
        public bool bitObs2_lab { get; set; }
        public decimal decObs1_lab { get; set; }
        public decimal decObs2_lab { get; set; }
        public DateTime dtObs1_lab { get; set; }
        public DateTime dtObs2_lab { get; set; }

        SqlConnection conexion;

        // Constructor que recibe la cadena de conexión
        public LAB_LABORATORIOS(string cadenaConexion)
        {
            this.conexion = new SqlConnection(cadenaConexion);
        }

        // Constructor sin parámetros
        public LAB_LABORATORIOS() {

        }

        // Método para registrar un laboratorio
        public bool registrarLaboratorio()
        {
            bool confirmacion;
            SqlCommand comandoInsercion = new SqlCommand("SIGUTC_AddLAB_LABORATORIOS", this.conexion);
            comandoInsercion.CommandType = CommandType.StoredProcedure;

            // Asignamos los parámetros
            comandoInsercion.Parameters.AddWithValue("@strNombre_lab", strNombre_Lab);
            comandoInsercion.Parameters.AddWithValue("@intNumeroEquipos_lab", intNumeroEquipos_lab);
            comandoInsercion.Parameters.AddWithValue("@strUbicacion_lab", strUbicacion_Lab);
            comandoInsercion.Parameters.AddWithValue("@strCod_tipoLab", strCod_tipoLab);
            comandoInsercion.Parameters.AddWithValue("@strCod_areac", strCod_areac);
            comandoInsercion.Parameters.AddWithValue("@strFotografia1_lab", strFotografia1_Lab);
            comandoInsercion.Parameters.AddWithValue("@strFotografia2_lab", strFotografia2_Lab);
            comandoInsercion.Parameters.AddWithValue("@dtFechaRegistro_lab", dtFechaRegistro_lab);
            comandoInsercion.Parameters.AddWithValue("@dtFecha_log", dtFecha_log);
            comandoInsercion.Parameters.AddWithValue("@strUser_log", strUser_log);
            comandoInsercion.Parameters.AddWithValue("@strCod_Fac", strCod_Fac);
            comandoInsercion.Parameters.AddWithValue("@strCod_Sede", strCod_Sede);
            comandoInsercion.Parameters.AddWithValue("@strCod_lab", strCod_Lab);

            try
            {
                this.conexion.Open();
                comandoInsercion.ExecuteNonQuery();                
                conexion.Close();
                confirmacion = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                confirmacion = false;
            }

            return confirmacion;
        }

        public DataTable obtenerLaboratorios(string tipoConsulta, string filtro)
        {
            // Configura el comando SQL para obtener todos los laboratorios
            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetLAB_LABORATORIOS", this.conexion);

            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", strCod_Fac);
            comandoConsulta.Parameters.AddWithValue("@FILTRO2", filtro);
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

        // Método para obtener los datos de un laboratorio por su ID
        public void listarLaboratorioPorId()
        {
            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetLAB_LABORATORIOS", conexion);
            string tipoConsulta = "xPK";

            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", strCod_Lab);
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
                    strCod_Lab = reader["strCod_lab"].ToString();
                    strNombre_Lab = reader["strNombre_lab"].ToString();
                    intNumeroEquipos_lab = Convert.ToInt32(reader["intNumeroEquipos_lab"]);
                    strUbicacion_Lab = reader["strUbicacion_lab"].ToString();
                    strCod_tipoLab = reader["strCod_tipoLab"].ToString();
                    strCod_areac = reader["strCod_areac"].ToString();
                    strFotografia1_Lab = reader["strFotografia1_lab"].ToString();
                    strFotografia2_Lab = reader["strFotografia2_lab"].ToString();
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

        // Método para actualizar los datos del laboratorio
        public bool actualizarLaboratorio()
        {
            bool registro;

            SqlCommand comandoActualizacion = new SqlCommand("SIGUTC_UpdateLAB_LABORATORIOS", conexion);
            comandoActualizacion.CommandType = CommandType.StoredProcedure;

            comandoActualizacion.Parameters.AddWithValue("@strCod_lab", strCod_Lab);
            comandoActualizacion.Parameters.AddWithValue("@strNombre_Lab", strNombre_Lab);
            comandoActualizacion.Parameters.AddWithValue("@intNumeroEquipos_lab", intNumeroEquipos_lab);
            comandoActualizacion.Parameters.AddWithValue("@strUbicacion_Lab", strUbicacion_Lab);
            comandoActualizacion.Parameters.AddWithValue("@strCod_tipoLab", strCod_tipoLab);
            comandoActualizacion.Parameters.AddWithValue("@strCod_areac", strCod_areac);
            comandoActualizacion.Parameters.AddWithValue("@strFotografia1_Lab", strFotografia1_Lab);
            comandoActualizacion.Parameters.AddWithValue("@strFotografia2_Lab", strFotografia2_Lab);
            comandoActualizacion.Parameters.AddWithValue("@dtFecha_log", dtFecha_log);
            comandoActualizacion.Parameters.AddWithValue("@strUser_log", strUser_log);
            comandoActualizacion.Parameters.AddWithValue("@strCod_Fac", strCod_Fac);
            comandoActualizacion.Parameters.AddWithValue("@strCod_Sede", strCod_Sede);

            try
            {
                conexion.Open();
                comandoActualizacion.ExecuteNonQuery();
                registro = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                registro = false;
            }
            conexion.Close();
            return registro;
        }

        public void detalleLaboratorio()
        {
            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetLAB_LABORATORIOS", conexion);
            string tipoConsulta = "xPK";
            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", strCod_Lab);
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
                    strCod_Lab = reader["strCod_lab"].ToString();
                    strNombre_Lab = reader["strNombre_lab"].ToString();
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


        // Método para eliminar un laboratorio
        public bool eliminarLaboratorio(string tipoConsulta)
        {
            bool eliminar;

            SqlCommand comandoEliminacion = new SqlCommand("SIGUTC_DelLAB_LABORATORIOS", this.conexion);
            comandoEliminacion.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO1", strCod_Lab);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO2", "");
            comandoEliminacion.Parameters.AddWithValue("@FILTRO3", "");
            comandoEliminacion.Parameters.AddWithValue("@FILTRO4", "");
            comandoEliminacion.CommandType = CommandType.StoredProcedure;

            try
            {
                this.conexion.Open();
                comandoEliminacion.ExecuteNonQuery();
                conexion.Close();
                eliminar = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                eliminar = false;
            }
            return eliminar;
        }
    }
}