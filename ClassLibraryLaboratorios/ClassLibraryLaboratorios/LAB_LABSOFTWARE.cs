using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLaboratorios
{
    public class LAB_LABSOFTWARE
    {
        public string strCod_labSoft { get; set; }
        public string strCod_Sede { get; set; }
        public string strCod_Fac { get; set; }
        public string strCod_sof { get; set; }
        public string strCod_lab { get; set; }
        public DateTime dtFechaRegistro_labSoft { get; set;  }
        public bool bitEstado_labSoft { get; set; }
        public DateTime dtFecha_log { get; set; }
        public string strUser_log { get; set; }
        public string strObs1_labSoft { get; set; }
        public string strObs2_labSoft { get; set; }
        public bool bitObs1_labSoft { get; set; }
        public bool bitObs2_labSoft { get; set; }
        public decimal decObs1_labSoft { get; set; }
        public decimal decObs2_labSoft { get; set; }
        public DateTime dtObs1_labSoft { get; set; }
        public DateTime dtObs2_labSoft { get; set; }

        SqlConnection conexion;

        public LAB_LABSOFTWARE(string cadenaConexion)
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public LAB_LABSOFTWARE()
        {

        }

        public void relacionarSoftwareLaboratorio()
        {
            SqlCommand comandoInsercion = new SqlCommand("SIGUTC_AddLAB_LABSOFTWARE", this.conexion);
            comandoInsercion.CommandType = CommandType.StoredProcedure;

            // Asignamos los parámetros
            comandoInsercion.Parameters.AddWithValue("@strCod_labSoft", strCod_labSoft);
            comandoInsercion.Parameters.AddWithValue("@dtFechaRegistro_labSoft", dtFechaRegistro_labSoft);
            comandoInsercion.Parameters.AddWithValue("@dtFecha_log", dtFecha_log);
            comandoInsercion.Parameters.AddWithValue("@strUser_log", strUser_log);
            comandoInsercion.Parameters.AddWithValue("@strCod_lab", strCod_lab);
            comandoInsercion.Parameters.AddWithValue("@strCod_sof", strCod_sof);
            comandoInsercion.Parameters.AddWithValue("@strCod_Fac", strCod_Fac);
            comandoInsercion.Parameters.AddWithValue("@strCod_Sede", strCod_Sede);

            try
            {
                this.conexion.Open();
                comandoInsercion.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public DataTable consultarRelacion(string tipoConsulta)
        {
            // Configura el comando SQL para obtener todos los laboratorios
            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetLAB_SOFTWARE", this.conexion);

            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", strCod_lab);
            comandoConsulta.Parameters.AddWithValue("@FILTRO2", strCod_sof);
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

        public void eliminarRelacion(string tipoConsulta)
        {
            SqlCommand comandoEliminacion = new SqlCommand("SIGUTC_DelLAB_LABSOFTWARE", this.conexion);
            comandoEliminacion.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO1", strCod_lab);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO2", strCod_sof);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO3", dtFecha_log);
            comandoEliminacion.Parameters.AddWithValue("@FILTRO4", strUser_log);
            comandoEliminacion.CommandType = CommandType.StoredProcedure;

            try
            {
                conexion.Open();
                comandoEliminacion.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                // Muestra un error si ocurre
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}
