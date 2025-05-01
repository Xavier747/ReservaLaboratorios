using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLaboratorios
{
    public class LAB_TIPO
    {
        public string strCod_tipoLab { get; set; }
        public string strNombre_tipoLab { get; set; }
        public DateTime dtFechaRegistro_tipoLab { get; set; }
        public bool bitEstado_tipoLab { get; set; }
        public DateTime dtFecha_log { get; set; }
        public string strUser_log { get; set; }
        public string strObs1_tipoLab { get; set; }
        public string strObs2_tipoLab { get; set; }
        public bool bitObs1_tipoLab { get; set; }
        public bool bitObs2_tipoLab { get; set; }
        public decimal decObs1_tipoLab { get; set; }
        public decimal decObs2_tipoLab { get; set; }
        public DateTime dtObs1_tipoLab { get; set; }
        public DateTime dtObs2_tipoLab { get; set; }

        private SqlConnection conexion;

        public LAB_TIPO(string cadenaConexion)
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public LAB_TIPO()
        {

        }

        public bool crearSoftwareLaboratorio()
        {
            bool registro;

            SqlCommand comandoInsercion = new SqlCommand("SIGUTC_AddLAB_TIPO", this.conexion);
            comandoInsercion.CommandType = CommandType.StoredProcedure;

            // Asignamos los parámetros
            comandoInsercion.Parameters.AddWithValue("@strCod_tipoLab", strCod_tipoLab);
            comandoInsercion.Parameters.AddWithValue("@strNombre_tipoLab", strNombre_tipoLab);
            comandoInsercion.Parameters.AddWithValue("@dtFechaRegistro_tipoLab", dtFechaRegistro_tipoLab);
            comandoInsercion.Parameters.AddWithValue("@dtFecha_log", dtFecha_log);
            comandoInsercion.Parameters.AddWithValue("@strUser_log", strUser_log);

            try
            {
                this.conexion.Open();
                comandoInsercion.ExecuteNonQuery();
                conexion.Close();
                registro = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                registro = false;
            }

            return registro;
        }

        public DataTable consultarTipoLaboratorio(string tipoConsulta)
        {
            // Configura el comando SQL para obtener todos los laboratorios
            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetLAB_TIPO", this.conexion);

            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", strCod_tipoLab);
            comandoConsulta.Parameters.AddWithValue("@FILTRO2", "");
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
            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetLAB_TIPO", conexion);
            string tipoConsulta = "xPK";

            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", strCod_tipoLab);
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
                    strCod_tipoLab = reader["strCod_tipoLab"].ToString();
                    strNombre_tipoLab = reader["strNombre_tipoLab"].ToString();

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.Write("ERROR: " + ex.Message);
            }
            conexion.Close();
        }

        public bool actualizarTipoLaboratorio()
        {
            bool registro;

            SqlCommand comandoInsercion = new SqlCommand("SIGUTC_UpdateLAB_TIPO", this.conexion);
            comandoInsercion.CommandType = CommandType.StoredProcedure;

            // Asignamos los parámetros
            comandoInsercion.Parameters.AddWithValue("@strCod_tipoLab", strCod_tipoLab);
            comandoInsercion.Parameters.AddWithValue("@strNombre_tipoLab", strNombre_tipoLab);
            comandoInsercion.Parameters.AddWithValue("@dtFecha_log", dtFecha_log);
            comandoInsercion.Parameters.AddWithValue("@strUser_log", strUser_log);

            try
            {
                this.conexion.Open();
                comandoInsercion.ExecuteNonQuery();
                conexion.Close();
                registro = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                registro = false;
            }

            return registro;
        }

        public bool eliminarRelacion(string tipoConsulta)
        {
            bool eliminar;

            SqlCommand comandoEliminacion = new SqlCommand("SIGUTC_DelLAB_TIPO", this.conexion);
            comandoEliminacion.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO1", strCod_tipoLab);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO2", dtFecha_log);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO3", strUser_log);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO4", "");
            comandoEliminacion.CommandType = CommandType.StoredProcedure;

            try
            {
                conexion.Open();
                comandoEliminacion.ExecuteNonQuery();
                conexion.Close();
                eliminar = true;
            }
            catch (Exception ex)
            {
                // Muestra un error si ocurre
                Console.WriteLine("ERROR: " + ex.Message);
                eliminar = false;
            }

            return eliminar;
        }
    }
}
