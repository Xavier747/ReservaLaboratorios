using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLaboratorios
{
    public class LAB_EXCLUSIVO
    {
        public string strCod_labEx { get; set; }
        public string strCod_Sede { get; set; }
        public string strCod_Fac { get; set; }
        public string strCod_Car { get; set; }
        public string strCod_lab { get; set; }
        public DateTime dtFechaRegistro_labEx { get; set; }
        public bool bitEstado_labEx { get; set; }
        public DateTime dtFecha_log { get; set; }
        public string strUser_log { get; set; }
        public string strObs1_labEx { get; set; }
        public string strObs2_labEx { get; set; }
        public bool bitObs1_labEx { get; set; }
        public bool bitObs2_labEx { get; set; }
        public decimal decObs1_labEx { get; set; }
        public decimal decObs2_labEx { get; set; }
        public DateTime dtObs1_labEx { get; set; }
        public DateTime dtObs2_labEx { get; set; }

        string cadenaConexion;
        SqlConnection conexion;

        public LAB_EXCLUSIVO(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            this.conexion = new SqlConnection(this.cadenaConexion);
        }

        public DataTable obtenerLaboratorios(string tipoConsulta, string filtro)
        {
            // Configura el comando SQL para obtener todos los laboratorios
            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetLAB_LABORATORIOS", this.conexion);

            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", filtro);
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

        public bool registrarLaboratorioExclusivo()
        {
            bool confirmacion;
            SqlCommand comandoInsercion = new SqlCommand("SIGUTC_AddLAB_EXCLUSIVO", this.conexion);
            comandoInsercion.CommandType = CommandType.StoredProcedure;

            // Asignamos los parámetros
            comandoInsercion.Parameters.AddWithValue("@strCod_labEx", strCod_labEx);
            comandoInsercion.Parameters.AddWithValue("@dtFechaRegistro_labEx", dtFechaRegistro_labEx);
            comandoInsercion.Parameters.AddWithValue("@dtFecha_log", dtFecha_log);
            comandoInsercion.Parameters.AddWithValue("@strUser_log", strUser_log);
            comandoInsercion.Parameters.AddWithValue("@strCod_lab", strCod_lab);
            comandoInsercion.Parameters.AddWithValue("@strCod_Car", strCod_Car);
            comandoInsercion.Parameters.AddWithValue("@strCod_Fac", strCod_Fac);
            comandoInsercion.Parameters.AddWithValue("@strCod_Sede", strCod_Sede);

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

        public int validarCarreraUnico(string tipoConsulta)
        {
            int aum = 0;

            // Configura el comando SQL para obtener todos los laboratorios
            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetLAB_LABORATORIOS", this.conexion);
            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", strCod_Car);
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
                    aum++;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Muestra un error si ocurre
                Console.WriteLine("ERROR: " + ex.Message);
            }
            conexion.Close();
            return aum;
        }

        public bool eliminarCarrera()
        {
            bool eliminar;

            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_DelLAB_EXCLUSIVO", this.conexion);
            comandoConsulta.Parameters.AddWithValue("@Comodin", "xLabExclusivo");
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", strCod_labEx);
            comandoConsulta.Parameters.AddWithValue("@FILTRO2", dtFecha_log);
            comandoConsulta.Parameters.AddWithValue("@FILTRO3", strUser_log);
            comandoConsulta.Parameters.AddWithValue("@FILTRO4", "");

            comandoConsulta.CommandType = CommandType.StoredProcedure;

            try
            {
                this.conexion.Open();
                comandoConsulta.ExecuteNonQuery();
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
