using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryLaboratorios
{
    public class LAB_RESPONSABLE
    {
       
        public string strCod_respo { get; set; }
        public string strCod_lab { get; set; }
        public string strCod_res { get; set; }
        public string strTipo_respo { get; set; }
        public DateTime dtFechaInicio_respo { get; set; }
        public bool bitEstado_respo { get; set; }
        public DateTime dtFecha_log { get; set; }
        public string strUser_log { get; set; }
        public string strObs1_respo { get; set; }
        public string strObs2_respo { get; set; }
        public bool bitObs1_respo { get; set; }
        public bool bitObs2_respo { get; set; }
        public decimal decObs1_respo { get; set; }
        public decimal decObs2_respo { get; set; }
        public DateTime dtObs1_respo { get; set; }
        public DateTime dtObs2_respo { get; set; }

        private SqlConnection conexion;

        // Constructor vacío
        public LAB_RESPONSABLE()
        {

        }       

        // Constructor con cadena de conexión
        public LAB_RESPONSABLE(string cadenaConexion)
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        
        // Método para consultar permisos del personal
        public Object[] consultarPersonalPermiso(String codLab)
        {
            Object[] responsable = new Object[7];
            string tipoConsulta = "xPkPersonalPermiso";

            for (int i = 0; i < codLab.Length; i++)
            {
                SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetPERSONAL", conexion);

                comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
                comandoConsulta.Parameters.AddWithValue("@FILTRO1", codLab);
                comandoConsulta.Parameters.AddWithValue("@FILTRO2", "");
                comandoConsulta.CommandType = CommandType.StoredProcedure;

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comandoConsulta.ExecuteReader();
                    while (reader.Read())
                    {
                        responsable[i] = reader["strId_PERSONAL_PERMISOS"].ToString();
                    }
                    reader.Close();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    Console.Write("ERROR: " + ex.Message);
                }
            }
            return responsable;
        }

        public bool guardarResponsables()
        {
            bool guardado;
            SqlCommand comandoInsercion = new SqlCommand("SIGUTC_AddLAB_RESPONSABLE", conexion);
            comandoInsercion.CommandType = CommandType.StoredProcedure;
            comandoInsercion.Parameters.AddWithValue("@strCod_respo", strCod_respo);
            comandoInsercion.Parameters.AddWithValue("@strTipo_respo", strTipo_respo);
            comandoInsercion.Parameters.AddWithValue("@dtFechaInicio_respo", dtFechaInicio_respo);
            comandoInsercion.Parameters.AddWithValue("@dtFecha_log", dtFecha_log);
            comandoInsercion.Parameters.AddWithValue("@strUser_log", strUser_log);
            comandoInsercion.Parameters.AddWithValue("@strCod_res", strCod_res);
            comandoInsercion.Parameters.AddWithValue("@strCod_lab", strCod_lab);

            try
            {
                conexion.Open();
                comandoInsercion.ExecuteNonQuery();                
                guardado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("TIENES UN ERROE: " + ex.Message);
                guardado = false;
            }
            conexion.Close();
            return guardado;
        }

        public List<LAB_RESPONSABLE> detalleResponsableLaboratorio(string tipoConsulta)
        {
            List<LAB_RESPONSABLE> listaResponsables = new List<LAB_RESPONSABLE>();

            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetLAB_RESPONSABLE", conexion);

            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", strCod_lab);
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
                    LAB_RESPONSABLE resp = new LAB_RESPONSABLE
                    {
                        strCod_respo = reader["strCod_respo"].ToString(),
                        strTipo_respo = reader["strTipo_respo"].ToString(),
                        dtFechaInicio_respo = reader.GetDateTime(reader.GetOrdinal("dtFechaInicio_respo")),
                        bitEstado_respo = reader.GetBoolean(reader.GetOrdinal("bitEstado_respo")),
                        dtFecha_log = reader.GetDateTime(reader.GetOrdinal("dtFecha_log")),
                        strUser_log = reader["strUser_log"].ToString(),
                        strCod_res = reader["strCod_res"].ToString(),
                        strCod_lab = reader["strCod_lab"].ToString(),
                        strObs1_respo = reader["Responsable"].ToString(),
                        strObs2_respo = reader["IMAGEN_ALU"].ToString(),
                    };

                    listaResponsables.Add(resp);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.Write("ERROR: " + ex.Message);
            }
            conexion.Close();
            return listaResponsables;
        }

        public void actualizarResponsables(string comodin)
        {
            SqlCommand comandoActualizacion = new SqlCommand("SIGUTC_UpdateLAB_RESPONSABLE", conexion);
            comandoActualizacion.CommandType = CommandType.StoredProcedure;

            comandoActualizacion.Parameters.AddWithValue("@Comodin", comodin);
            comandoActualizacion.Parameters.AddWithValue("@dtFecha_log", dtFecha_log);
            comandoActualizacion.Parameters.AddWithValue("@strUser_log", strUser_log);
            comandoActualizacion.Parameters.AddWithValue("@strCod_respo", strCod_respo);
            comandoActualizacion.Parameters.AddWithValue("@strTipo_respo", strTipo_respo);

            try
            {
                conexion.Open();
                comandoActualizacion.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                Console.WriteLine("TIENES UN ERROE: " + ex.Message);
            }
            conexion.Close();
        }
    }
}
