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

        public LAB_RESERVA() { }

        public LAB_RESERVA(
        string _strCod_reser,
        string _strCod_lab,
        string _strCod_motRes,
        string _strTema_reser,
        string _strDescripcion_reser,
        string _strMateriales_reser,
        DateTime _dtFechainicio_reser,
        DateTime _dtFechaFin_reser,
        int _intTotalAsistente_reser,
        bool _bitEstado_reser,
        DateTime _dtFecha_log,
        string _strUser_log,
        string _strObs1_reser,
        string _strObs2_reser,
        bool _bitObs1_reser,
        bool _bitObs2_reser,
        decimal _decObs1_reser,
        decimal _decObs2_reser,
        DateTime _dtObs1_reser,
        DateTime _dtObs2_reser
    )
        {
            strCod_reser = _strCod_reser;
            strCod_lab = _strCod_lab;
            strCod_motRes = _strCod_motRes;
            strTema_reser = _strTema_reser;
            strDescripcion_reser = _strDescripcion_reser;
            strMateriales_reser = _strMateriales_reser;
            dtFechainicio_reser = _dtFechainicio_reser;
            dtFechaFin_reser = _dtFechaFin_reser;
            intTotalAsistente_reser = _intTotalAsistente_reser;
            bitEstado_reser = _bitEstado_reser;
            dtFecha_log = _dtFecha_log;
            strUser_log = _strUser_log;
            strObs1_reser = _strObs1_reser;
            strObs2_reser = _strObs2_reser;
            bitObs1_reser = _bitObs1_reser;
            bitObs2_reser = _bitObs2_reser;
            decObs1_reser = _decObs1_reser;
            decObs2_reser = _decObs2_reser;
            dtObs1_reser = _dtObs1_reser;
            dtObs2_reser = _dtObs2_reser;


            numerr = 0;
            msg = string.Empty;
            resultado = false;
        }

        private string STRCOD_RESER;
        private string STRCOD_LAB;
        private string STRCOD_MOTRES;
        private string STRTEMA_RESER;
        private string STRDESCRIPCION_RESER;
        private string STRMATERIALES_RESER;
        private DateTime DTFECHAINICIO_RESER;
        private DateTime DTFECHAFIN_RESER;
        private int INTTOTALASISTENTE_RESER;
        private bool BITESTADO_RESER;
        private DateTime DTFECHA_LOG;
        private string STRUSER_LOG;
        private string STROBS1_RESER;
        private string STROBS2_RESER;
        private bool BITOBS1_RESER;
        private bool BITOBS2_RESER;
        private decimal DECOBS1_RESER;
        private decimal DECOBS2_RESER;
        private DateTime DTOBS1_RESER;
        private DateTime DTOBS2_RESER;

        private int NUMERR;
        private string MSG;
        private bool RESULTADO;

        ///////////////////// Generacion de propiedades/////////////////

        public string strCod_reser
        {
            get
            {
                return STRCOD_RESER;
            }
            set
            {
                STRCOD_RESER = value;
            }
        }

        public string strCod_lab
        {
            get
            {
                return STRCOD_LAB;
            }
            set
            {
                STRCOD_LAB = value;
            }
        }

        public string strCod_motRes
        {
            get
            {
                return STRCOD_MOTRES;
            }
            set
            {
                STRCOD_MOTRES = value;
            }
        }

        public string strTema_reser
        {
            get
            {
                return STRTEMA_RESER;
            }
            set
            {
                STRTEMA_RESER = value;
            }
        }

        public string strDescripcion_reser
        {
            get
            {
                return STRDESCRIPCION_RESER;
            }
            set
            {
                STRDESCRIPCION_RESER = value;
            }
        }

        public string strMateriales_reser
        {
            get
            {
                return STRMATERIALES_RESER;
            }
            set
            {
                STRMATERIALES_RESER = value;
            }
        }

        public DateTime dtFechainicio_reser
        {
            get
            {
                return DTFECHAINICIO_RESER;
            }
            set
            {
                DTFECHAINICIO_RESER = value;
            }
        }

        public DateTime dtFechaFin_reser
        {
            get
            {
                return DTFECHAFIN_RESER;
            }
            set
            {
                DTFECHAFIN_RESER = value;
            }
        }

        public int intTotalAsistente_reser
        {
            get
            {
                return INTTOTALASISTENTE_RESER;
            }
            set
            {
                INTTOTALASISTENTE_RESER = value;
            }
        }

        public bool bitEstado_reser
        {
            get
            {
                return BITESTADO_RESER;
            }
            set
            {
                BITESTADO_RESER = value;
            }
        }

        public DateTime dtFecha_log
        {
            get
            {
                return DTFECHA_LOG;
            }
            set
            {
                DTFECHA_LOG = value;
            }
        }

        public string strUser_log
        {
            get
            {
                return STRUSER_LOG;
            }
            set
            {
                STRUSER_LOG = value;
            }
        }

        public string strObs1_reser
        {
            get
            {
                return STROBS1_RESER;
            }
            set
            {
                STROBS1_RESER = value;
            }
        }

        public string strObs2_reser
        {
            get
            {
                return STROBS2_RESER;
            }
            set
            {
                STROBS2_RESER = value;
            }
        }

        public bool bitObs1_reser
        {
            get
            {
                return BITOBS1_RESER;
            }
            set
            {
                BITOBS1_RESER = value;
            }
        }

        public bool bitObs2_reser
        {
            get
            {
                return BITOBS2_RESER;
            }
            set
            {
                BITOBS2_RESER = value;
            }
        }

        public decimal decObs1_reser
        {
            get
            {
                return DECOBS1_RESER;
            }
            set
            {
                DECOBS1_RESER = value;
            }
        }

        public decimal decObs2_reser
        {
            get
            {
                return DECOBS2_RESER;
            }
            set
            {
                DECOBS2_RESER = value;
            }
        }

        public DateTime dtObs1_reser
        {
            get
            {
                return DTOBS1_RESER;
            }
            set
            {
                DTOBS1_RESER = value;
            }
        }

        public DateTime dtObs2_reser
        {
            get
            {
                return DTOBS2_RESER;
            }
            set
            {
                DTOBS2_RESER = value;
            }
        }

        public int numerr
        {
            get
            {
                return NUMERR;
            }
            set
            {
                NUMERR = value;
            }
        }

        public string msg
        {
            get
            {
                return MSG;
            }
            set
            {
                MSG = value;
            }
        }

        public bool resultado
        {
            get
            {
                return RESULTADO;
            }
            set
            {
                RESULTADO = value;
            }
        }


        ///////////////// Método Get /////////////////







        //    public string strCod_reser { get; set; }
        //    public string strTema_reser { get; set; }
        //    public string strDescripcion_reser { get; set; }
        //    public string strMateriales_reser { get; set; }
        //    public DateTime dtFechaInicio_reser { get; set; }
        //    public DateTime dtFechaFin_reser { get; set; }
        //    public string strTipo_rese { get; set; }
        //    public int intTotalAsistente_reser { get; set; }
        //    public bool bitEstado_reser { get; set; }
        //    public string strCod_lab { get; set; }
        //    public string strId_HORARIO { get; set; }


        //    string cadenaConexion;
        //    SqlConnection conexion;


        //    public LAB_RESERVA()
        //    {

        //    }

        //    public LAB_RESERVA(string cadenaConexion)
        //    {
        //        this.cadenaConexion = cadenaConexion;
        //        this.conexion = new SqlConnection(this.cadenaConexion);
        //    }

        //    public string obtnerDetallePersona(Object[] obj1)
        //    {
        //        string idDetPersona = "";

        //        SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetDetallePersona", conexion);
        //        comandoConsulta.Parameters.AddWithValue("@FILTRO1", obj1[0]);
        //        comandoConsulta.Parameters.AddWithValue("@FILTRO2", obj1[1]);
        //        comandoConsulta.Parameters.AddWithValue("@FILTRO3", obj1[2]);
        //        comandoConsulta.CommandType = CommandType.StoredProcedure;
        //        try
        //        {
        //            this.conexion.Open();
        //            SqlDataReader reader = comandoConsulta.ExecuteReader();

        //            if (reader.Read())
        //            {
        //                idDetPersona = reader["strId_DETALLES_PERSONAL"].ToString();
        //            }
        //            reader.Close();
        //            conexion.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.Write("ERROR: " + ex.Message);
        //        }
        //        conexion.Close();
        //        return idDetPersona;
        //    }

        //    public void registrarReservacion()
        //    {
        //        string mensaje = "";
        //        SqlCommand comandoInsercion = new SqlCommand("SIGUTC_AddReservaciones", this.conexion);
        //        comandoInsercion.CommandType = CommandType.StoredProcedure;

        //        comandoInsercion.Parameters.AddWithValue("@strCod_reser", strCod_reser);
        //        comandoInsercion.Parameters.AddWithValue("@strTema_reser", strTema_reser);
        //        comandoInsercion.Parameters.AddWithValue("@strDescripcion_reser", strDescripcion_reser);
        //        comandoInsercion.Parameters.AddWithValue("@strMateriales_reser", strMateriales_reser);
        //        comandoInsercion.Parameters.AddWithValue("@dtFechaInicio_reser", dtFechaInicio_reser);
        //        comandoInsercion.Parameters.AddWithValue("@dtFechaFin_reser", dtFechaFin_reser);
        //        comandoInsercion.Parameters.AddWithValue("@strTipo_reser", strTipo_rese);
        //        comandoInsercion.Parameters.AddWithValue("@intTotalAsistente_reser", intTotalAsistente_reser);
        //        comandoInsercion.Parameters.AddWithValue("@strCod_lab", strCod_lab);
        //        comandoInsercion.Parameters.AddWithValue("@strId_HORARIO", strId_HORARIO);

        //        try
        //        {
        //            this.conexion.Open();
        //            comandoInsercion.ExecuteNonQuery();
        //            mensaje = "guardado ";
        //            conexion.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            mensaje = "TIENES UN ERROE: " + ex.Message;

        //        }
        //    }

        //    public List<LAB_RESERVA> ObtenerReservas(string tipoConsulta, string codLab)
        //    {
        //        List<LAB_RESERVA> eventos = new List<LAB_RESERVA>();

        //        SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetReservas", conexion);
        //        comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConsulta);
        //        comandoConsulta.Parameters.AddWithValue("@FILTRO1", codLab);
        //        comandoConsulta.CommandType = CommandType.StoredProcedure;

        //        SqlDataReader reader = null;

        //        try
        //        {
        //            conexion.Open();
        //            reader = comandoConsulta.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                eventos.Add(new LAB_RESERVA
        //                {
        //                    strCod_reser = reader["strCod_reser"].ToString(),
        //                    strTema_reser = reader["strTema_reser"].ToString(),
        //                    dtFechaInicio_reser = Convert.ToDateTime(reader["dtFechaInicio_reser"]),
        //                    dtFechaFin_reser = Convert.ToDateTime(reader["dtFechaFin_reser"]),
        //                });
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Error al obtener las reservas: " + ex.Message);
        //        }

        //        return eventos;
        //    }

        //    public object[] detarEvento(string id)
        //    {
        //        object[] detalleEvento = new object[14];

        //        SqlCommand comandoConsulta = new SqlCommand("SIGUTC_GetReservas", conexion);

        //        string tipoConulta = "xPkReservas";

        //        comandoConsulta.Parameters.AddWithValue("@Comodin", tipoConulta);
        //        comandoConsulta.Parameters.AddWithValue("@FILTRO1", id);

        //        comandoConsulta.CommandType = CommandType.StoredProcedure;
        //        SqlDataReader reader = null;

        //        try
        //        {
        //            conexion.Open();
        //            reader = comandoConsulta.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                detalleEvento[0] = reader["strNombre_PERSONAL"].ToString();
        //                detalleEvento[1] = reader["strUsuario_PERSONAL"].ToString();
        //                detalleEvento[2] = reader["dtFechaInicio_reser"].ToString();
        //                detalleEvento[3] = reader["dtFechaFin_reser"].ToString();
        //                detalleEvento[4] = reader["strId_dist"].ToString();
        //                detalleEvento[5] = reader["strNombre_dist"].ToString();
        //                detalleEvento[6] = reader["strNombre_Car"].ToString();
        //                detalleEvento[7] = reader["strNombre_Cur"].ToString();
        //                detalleEvento[8] = reader["strParalelo_Cur"].ToString();
        //                detalleEvento[9] = reader["intTotalAsistente_reser"].ToString();
        //                detalleEvento[10] = reader["strTipo_reser"].ToString();
        //                detalleEvento[11] = reader["strTema_reser"].ToString();
        //                detalleEvento[12] = reader["strDescripcion_reser"].ToString();
        //                detalleEvento[13] = reader["strMateriales_reser"].ToString();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error: " + ex);
        //        }
        //        reader.Close();
        //        conexion.Close();

        //        return detalleEvento;
        //    }
    }
}
