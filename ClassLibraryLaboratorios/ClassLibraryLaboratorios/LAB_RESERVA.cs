using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLaboratorios
{
    public class LAB_RESERVA
    {
        public string strCod_reser { get; set; }
        public string strTema_reser { get; set; }
        public string strDescripcion_reser { get; set; }
        public string strMateriales_reser { get; set; }
        public DateTime dtFechaInicio_reser { get; set; }
        public DateTime dtFechaFin_reser { get; set; }
        public string strTipo_rese { get; set; }
        public int intTotalAsistente_reser { get; set; }
        public bool bitEstado_reser { get; set; }
        public string strCod_lab { get; set; }
        public string strId_HORARIO { get; set; }


        string cadenaConexion;
        SqlConnection conexion;


        public LAB_RESERVA()
        {

        }

        public LAB_RESERVA(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            this.conexion = new SqlConnection(this.cadenaConexion);
        }

        public string obtnerDetallePersona(Object[] obj1)
        {
            string idDetPersona = "";

            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetDetallePersona", conexion);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", obj1[0]);
            comandoConsulta.Parameters.AddWithValue("@FILTRO2", obj1[1]);
            comandoConsulta.Parameters.AddWithValue("@FILTRO3", obj1[2]);
            comandoConsulta.CommandType = CommandType.StoredProcedure;
            try
            {
                this.conexion.Open();
                SqlDataReader reader = comandoConsulta.ExecuteReader();

                if (reader.Read())
                {
                    idDetPersona = reader["strId_DETALLES_PERSONAL"].ToString();
                }
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.Write("ERROR: " + ex.Message);
            }
            conexion.Close();
            return idDetPersona;
        }

        public void registrarReservacion()
        {
            string mensaje = "";
            SqlCommand comandoInsercion = new SqlCommand("SIGUTC_AddReservaciones", this.conexion);
            comandoInsercion.CommandType = CommandType.StoredProcedure;

            comandoInsercion.Parameters.AddWithValue("@strCod_reser", strCod_reser);
            comandoInsercion.Parameters.AddWithValue("@strTema_reser", strTema_reser);
            comandoInsercion.Parameters.AddWithValue("@strDescripcion_reser", strDescripcion_reser);
            comandoInsercion.Parameters.AddWithValue("@strMateriales_reser", strMateriales_reser);
            comandoInsercion.Parameters.AddWithValue("@dtFechaInicio_reser", dtFechaInicio_reser);
            comandoInsercion.Parameters.AddWithValue("@dtFechaFin_reser", dtFechaFin_reser);
            comandoInsercion.Parameters.AddWithValue("@strTipo_reser", strTipo_rese);
            comandoInsercion.Parameters.AddWithValue("@intTotalAsistente_reser", intTotalAsistente_reser);
            comandoInsercion.Parameters.AddWithValue("@strCod_lab", strCod_lab);
            comandoInsercion.Parameters.AddWithValue("@strId_HORARIO", strId_HORARIO);

            try
            {
                this.conexion.Open();
                comandoInsercion.ExecuteNonQuery();
                mensaje = "guardado ";
                conexion.Close();
            }
            catch (Exception ex)
            {
                mensaje = "TIENES UN ERROE: " + ex.Message;

            }
        }

        public List<LAB_RESERVA> ObtenerReservas(string tipoConsulta, string codLab)
        {
            List<LAB_RESERVA> eventos = new List<LAB_RESERVA>();

            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetReservas", conexion);
            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", codLab);
            comandoConsulta.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = null;

            try
            {
                conexion.Open();
                reader = comandoConsulta.ExecuteReader();
                while (reader.Read())
                {
                    eventos.Add(new LAB_RESERVA
                    {
                        strCod_reser = reader["strCod_reser"].ToString(),
                        strTema_reser = reader["strTema_reser"].ToString(),
                        dtFechaInicio_reser = Convert.ToDateTime(reader["dtFechaInicio_reser"]),
                        dtFechaFin_reser = Convert.ToDateTime(reader["dtFechaFin_reser"]),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las reservas: " + ex.Message);
            }

            return eventos;
        }

        public object[] detarEvento(string id)
        {
            object[] detalleEvento = new object[14];

            SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetReservas", conexion);

            string tipoConulta = "xPkReservas";

            comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConulta);
            comandoConsulta.Parameters.AddWithValue("@FILTRO1", id);

            comandoConsulta.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = null;

            try
            {
                conexion.Open();
                reader = comandoConsulta.ExecuteReader();

                while (reader.Read())
                {
                    detalleEvento[0] = reader["strNombre_PERSONAL"].ToString();
                    detalleEvento[1] = reader["strUsuario_PERSONAL"].ToString();
                    detalleEvento[2] = reader["dtFechaInicio_reser"].ToString();
                    detalleEvento[3] = reader["dtFechaFin_reser"].ToString();
                    detalleEvento[4] = reader["strId_dist"].ToString();
                    detalleEvento[5] = reader["strNombre_dist"].ToString();
                    detalleEvento[6] = reader["strNombre_Car"].ToString();
                    detalleEvento[7] = reader["strNombre_Cur"].ToString();
                    detalleEvento[8] = reader["strParalelo_Cur"].ToString();
                    detalleEvento[9] = reader["intTotalAsistente_reser"].ToString();
                    detalleEvento[10] = reader["strTipo_reser"].ToString();
                    detalleEvento[11] = reader["strTema_reser"].ToString();
                    detalleEvento[12] = reader["strDescripcion_reser"].ToString();
                    detalleEvento[13] = reader["strMateriales_reser"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            reader.Close();
            conexion.Close();

            return detalleEvento;
        }
    }
}
