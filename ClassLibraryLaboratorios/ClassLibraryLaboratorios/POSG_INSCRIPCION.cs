using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace ClassLibraryLaboratorios
{
    public class POSG_INSCRIPCION
    {
        public POSG_INSCRIPCION()
        {
        }
        public POSG_INSCRIPCION(
        string _strid_ins,
        string _strcod_per,
        string _strcod_matric,
        string _strid_per,
        string _strtema_ins,
        string _strmodalidad_ins,
        string _strmecanismo_ins,
        DateTime _dtfechacreacion_ins,
        bool _bitmatrizaprobada_ins,
        DateTime _dtfechamatrizaprobada_ins,
        string _strcedapruebamatriz_ins1,
        bool _bitmatrizrevisada_ins,
        DateTime _dtfechamatrizrevisada_ins,
        string _strcedrevisamatriz_ins,
        bool _bitpagado_ins,
        DateTime _dtfechapago_ins,
        string _strcedregistrapago_ins,
        string _strobservaciones_ins,
        string _strsugerencias_ins,
        string _strurl_ins,
        bool _bitaprobadoperfil_ins,
        string _strperiodoacademico_ins,
        string _struserlog,
        DateTime _dtfechalog,
        string _strobs1_ins,
        string _strobs2_ins,
        string _strobs3_ins,
        string _strvacio1_ins,
        string _strvacio2_ins,
        decimal _decobs1_ins,
        decimal _decobs2_ins,
        bool _bitobs1_ins,
        bool _bitobs2_ins,
        DateTime _dtobs1_ins,
        DateTime _dtobs2_ins,
        string _strid_per2,
        string _strcoid_per)
        {
            strid_ins = _strid_ins;
            strcod_per = _strcod_per;
            strcod_matric = _strcod_matric;
            strid_per = _strid_per;
            strtema_ins = _strtema_ins;
            strmodalidad_ins = _strmodalidad_ins;
            strmecanismo_ins = _strmecanismo_ins;
            dtfechacreacion_ins = _dtfechacreacion_ins;
            bitmatrizaprobada_ins = _bitmatrizaprobada_ins;
            dtfechamatrizaprobada_ins = _dtfechamatrizaprobada_ins;
            strcedapruebamatriz_ins1 = _strcedapruebamatriz_ins1;
            bitmatrizrevisada_ins = _bitmatrizrevisada_ins;
            dtfechamatrizrevisada_ins = _dtfechamatrizrevisada_ins;
            strcedrevisamatriz_ins = _strcedrevisamatriz_ins;
            bitpagado_ins = _bitpagado_ins;
            dtfechapago_ins = _dtfechapago_ins;
            strcedregistrapago_ins = _strcedregistrapago_ins;
            strobservaciones_ins = _strobservaciones_ins;
            strsugerencias_ins = _strsugerencias_ins;
            strurl_ins = _strurl_ins;
            bitaprobadoperfil_ins = _bitaprobadoperfil_ins;
            strperiodoacademico_ins = _strperiodoacademico_ins;
            struserlog = _struserlog;
            dtfechalog = _dtfechalog;
            strobs1_ins = _strobs1_ins;
            strobs2_ins = _strobs2_ins;
            strobs3_ins = _strobs3_ins;
            strvacio1_ins = _strvacio1_ins;
            strvacio2_ins = _strvacio2_ins;
            decobs1_ins = _decobs1_ins;
            decobs2_ins = _decobs2_ins;
            bitobs1_ins = _bitobs1_ins;
            bitobs2_ins = _bitobs2_ins;
            dtobs1_ins = _dtobs1_ins;
            dtobs2_ins = _dtobs2_ins;
            strid_per2 = _strid_per2;
            strcoid_per = _strcoid_per;

            numerr = 0;
            msg = string.Empty;
            resultado = false;
        }
        private string STRID_INS;
        private string STRCOD_PER;
        private string STRCOD_MATRIC;
        private string STRID_PER;
        private string STRTEMA_INS;
        private string STRMODALIDAD_INS;
        private string STRMECANISMO_INS;
        private DateTime DTFECHACREACION_INS;
        private bool BITMATRIZAPROBADA_INS;
        private DateTime DTFECHAMATRIZAPROBADA_INS;
        private string STRCEDAPRUEBAMATRIZ_INS1;
        private bool BITMATRIZREVISADA_INS;
        private DateTime DTFECHAMATRIZREVISADA_INS;
        private string STRCEDREVISAMATRIZ_INS;
        private bool BITPAGADO_INS;
        private DateTime DTFECHAPAGO_INS;
        private string STRCEDREGISTRAPAGO_INS;
        private string STROBSERVACIONES_INS;
        private string STRSUGERENCIAS_INS;
        private string STRURL_INS;
        private bool BITAPROBADOPERFIL_INS;
        private string STRPERIODOACADEMICO_INS;
        private string STRUSERLOG;
        private DateTime DTFECHALOG;
        private string STROBS1_INS;
        private string STROBS2_INS;
        private string STROBS3_INS;
        private string STRVACIO1_INS;
        private string STRVACIO2_INS;
        private decimal DECOBS1_INS;
        private decimal DECOBS2_INS;
        private bool BITOBS1_INS;
        private bool BITOBS2_INS;
        private DateTime DTOBS1_INS;
        private DateTime DTOBS2_INS;
        private string STRID_PER2;
        private string STRCOID_PER;
        private int NUMERR;
        private string MSG;
        private bool RESULTADO;
        ///////////////////// Generacion de propiedades/////////////////


        public string strid_ins
        {
            get
            {
                return STRID_INS;
            }
            set
            {
                STRID_INS = value;
            }
        }
        public string strcod_per
        {
            get
            {
                return STRCOD_PER;
            }
            set
            {
                STRCOD_PER = value;
            }
        }
        public string strcod_matric
        {
            get
            {
                return STRCOD_MATRIC;
            }
            set
            {
                STRCOD_MATRIC = value;
            }
        }
        public string strid_per
        {
            get
            {
                return STRID_PER;
            }
            set
            {
                STRID_PER = value;
            }
        }
        public string strtema_ins
        {
            get
            {
                return STRTEMA_INS;
            }
            set
            {
                STRTEMA_INS = value;
            }
        }
        public string strmodalidad_ins
        {
            get
            {
                return STRMODALIDAD_INS;
            }
            set
            {
                STRMODALIDAD_INS = value;
            }
        }
        public string strmecanismo_ins
        {
            get
            {
                return STRMECANISMO_INS;
            }
            set
            {
                STRMECANISMO_INS = value;
            }
        }
        public DateTime dtfechacreacion_ins
        {
            get
            {
                return DTFECHACREACION_INS;
            }
            set
            {
                DTFECHACREACION_INS = value;
            }
        }
        public bool bitmatrizaprobada_ins
        {
            get
            {
                return BITMATRIZAPROBADA_INS;
            }
            set
            {
                BITMATRIZAPROBADA_INS = value;
            }
        }
        public DateTime dtfechamatrizaprobada_ins
        {
            get
            {
                return DTFECHAMATRIZAPROBADA_INS;
            }
            set
            {
                DTFECHAMATRIZAPROBADA_INS = value;
            }
        }
        public string strcedapruebamatriz_ins1
        {
            get
            {
                return STRCEDAPRUEBAMATRIZ_INS1;
            }
            set
            {
                STRCEDAPRUEBAMATRIZ_INS1 = value;
            }
        }
        public bool bitmatrizrevisada_ins
        {
            get
            {
                return BITMATRIZREVISADA_INS;
            }
            set
            {
                BITMATRIZREVISADA_INS = value;
            }
        }
        public DateTime dtfechamatrizrevisada_ins
        {
            get
            {
                return DTFECHAMATRIZREVISADA_INS;
            }
            set
            {
                DTFECHAMATRIZREVISADA_INS = value;
            }
        }
        public string strcedrevisamatriz_ins
        {
            get
            {
                return STRCEDREVISAMATRIZ_INS;
            }
            set
            {
                STRCEDREVISAMATRIZ_INS = value;
            }
        }
        public bool bitpagado_ins
        {
            get
            {
                return BITPAGADO_INS;
            }
            set
            {
                BITPAGADO_INS = value;
            }
        }
        public DateTime dtfechapago_ins
        {
            get
            {
                return DTFECHAPAGO_INS;
            }
            set
            {
                DTFECHAPAGO_INS = value;
            }
        }
        public string strcedregistrapago_ins
        {
            get
            {
                return STRCEDREGISTRAPAGO_INS;
            }
            set
            {
                STRCEDREGISTRAPAGO_INS = value;
            }
        }
        public string strobservaciones_ins
        {
            get
            {
                return STROBSERVACIONES_INS;
            }
            set
            {
                STROBSERVACIONES_INS = value;
            }
        }
        public string strsugerencias_ins
        {
            get
            {
                return STRSUGERENCIAS_INS;
            }
            set
            {
                STRSUGERENCIAS_INS = value;
            }
        }
        public string strurl_ins
        {
            get
            {
                return STRURL_INS;
            }
            set
            {
                STRURL_INS = value;
            }
        }
        public bool bitaprobadoperfil_ins
        {
            get
            {
                return BITAPROBADOPERFIL_INS;
            }
            set
            {
                BITAPROBADOPERFIL_INS = value;
            }
        }
        public string strperiodoacademico_ins
        {
            get
            {
                return STRPERIODOACADEMICO_INS;
            }
            set
            {
                STRPERIODOACADEMICO_INS = value;
            }
        }
        public string struserlog
        {
            get
            {
                return STRUSERLOG;
            }
            set
            {
                STRUSERLOG = value;
            }
        }
        public DateTime dtfechalog
        {
            get
            {
                return DTFECHALOG;
            }
            set
            {
                DTFECHALOG = value;
            }
        }
        public string strobs1_ins
        {
            get
            {
                return STROBS1_INS;
            }
            set
            {
                STROBS1_INS = value;
            }
        }
        public string strobs2_ins
        {
            get
            {
                return STROBS2_INS;
            }
            set
            {
                STROBS2_INS = value;
            }
        }
        public string strobs3_ins
        {
            get
            {
                return STROBS3_INS;
            }
            set
            {
                STROBS3_INS = value;
            }
        }
        public string strvacio1_ins
        {
            get
            {
                return STRVACIO1_INS;
            }
            set
            {
                STRVACIO1_INS = value;
            }
        }
        public string strvacio2_ins
        {
            get
            {
                return STRVACIO2_INS;
            }
            set
            {
                STRVACIO2_INS = value;
            }
        }
        public decimal decobs1_ins
        {
            get
            {
                return DECOBS1_INS;
            }
            set
            {
                DECOBS1_INS = value;
            }
        }
        public decimal decobs2_ins
        {
            get
            {
                return DECOBS2_INS;
            }
            set
            {
                DECOBS2_INS = value;
            }
        }
        public bool bitobs1_ins
        {
            get
            {
                return BITOBS1_INS;
            }
            set
            {
                BITOBS1_INS = value;
            }
        }
        public bool bitobs2_ins
        {
            get
            {
                return BITOBS2_INS;
            }
            set
            {
                BITOBS2_INS = value;
            }
        }
        public DateTime dtobs1_ins
        {
            get
            {
                return DTOBS1_INS;
            }
            set
            {
                DTOBS1_INS = value;
            }
        }
        public DateTime dtobs2_ins
        {
            get
            {
                return DTOBS2_INS;
            }
            set
            {
                DTOBS2_INS = value;
            }
        }
        public string strid_per2
        {
            get
            {
                return STRID_PER2;
            }
            set
            {
                STRID_PER2 = value;
            }
        }
        public string strcoid_per
        {
            get
            {
                return STRCOID_PER;
            }
            set
            {
                STRCOID_PER = value;
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
        public List<POSG_INSCRIPCION> LoadPOSG_INSCRIPCION(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<POSG_INSCRIPCION>();
            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["POSG_ConnectionString"]))
            {
                using (SqlCommand myCommand = new SqlCommand("TESIS_GetPOSG_INSCRIPCION", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter prmComodin = new SqlParameter("@COMODIN", SqlDbType.VarChar);
                    prmComodin.Value = comodin;
                    myCommand.Parameters.Add(prmComodin);

                    SqlParameter prmFiltro1 = new SqlParameter("@FILTRO1", SqlDbType.VarChar);
                    prmFiltro1.Value = filtro1;
                    myCommand.Parameters.Add(prmFiltro1);

                    SqlParameter prmFiltro2 = new SqlParameter("@FILTRO2", SqlDbType.VarChar);
                    prmFiltro2.Value = filtro2;
                    myCommand.Parameters.Add(prmFiltro2);

                    SqlParameter prmFiltro3 = new SqlParameter("@FILTRO3", SqlDbType.VarChar);
                    prmFiltro3.Value = filtro3;
                    myCommand.Parameters.Add(prmFiltro3);

                    SqlParameter prmFiltro4 = new SqlParameter("@FILTRO4", SqlDbType.VarChar);
                    prmFiltro4.Value = filtro4;
                    myCommand.Parameters.Add(prmFiltro4);

                    try
                    {
                        myConnection.Open();
                        using (SqlDataReader reader1 = myCommand.ExecuteReader())
                        {
                            while (reader1.Read())
                            {
                                POSG_INSCRIPCION miClase = new POSG_INSCRIPCION()
                                {
                                    strid_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strid_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strid_ins"))),
                                    strcod_per = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strcod_per"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strcod_per"))),
                                    strcod_matric = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strcod_matric"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strcod_matric"))),
                                    strid_per = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strid_per"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strid_per"))),
                                    strtema_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strtema_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strtema_ins"))),
                                    strmodalidad_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strmodalidad_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strmodalidad_ins"))),
                                    strmecanismo_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strmecanismo_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strmecanismo_ins"))),
                                    dtfechacreacion_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtfechacreacion_ins"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtfechacreacion_ins"))),
                                    bitmatrizaprobada_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitmatrizaprobada_ins"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitmatrizaprobada_ins"))),
                                    dtfechamatrizaprobada_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtfechamatrizaprobada_ins"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtfechamatrizaprobada_ins"))),
                                    strcedapruebamatriz_ins1 = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strcedapruebamatriz_ins1"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strcedapruebamatriz_ins1"))),
                                    bitmatrizrevisada_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitmatrizrevisada_ins"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitmatrizrevisada_ins"))),
                                    dtfechamatrizrevisada_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtfechamatrizrevisada_ins"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtfechamatrizrevisada_ins"))),
                                    strcedrevisamatriz_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strcedrevisamatriz_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strcedrevisamatriz_ins"))),
                                    bitpagado_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitpagado_ins"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitpagado_ins"))),
                                    dtfechapago_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtfechapago_ins"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtfechapago_ins"))),
                                    strcedregistrapago_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strcedregistrapago_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strcedregistrapago_ins"))),
                                    strobservaciones_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strobservaciones_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strobservaciones_ins"))),
                                    strsugerencias_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strsugerencias_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strsugerencias_ins"))),
                                    strurl_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strurl_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strurl_ins"))),
                                    bitaprobadoperfil_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitaprobadoperfil_ins"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitaprobadoperfil_ins"))),
                                    strperiodoacademico_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strperiodoacademico_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strperiodoacademico_ins"))),
                                    struserlog = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("struserlog"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("struserlog"))),
                                    dtfechalog = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtfechalog"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtfechalog"))),
                                    strobs1_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strobs1_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strobs1_ins"))),
                                    strobs2_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strobs2_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strobs2_ins"))),
                                    strobs3_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strobs3_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strobs3_ins"))),
                                    strvacio1_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strvacio1_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strvacio1_ins"))),
                                    strvacio2_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strvacio2_ins"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strvacio2_ins"))),
                                    decobs1_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decobs1_ins"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decobs1_ins"))),
                                    decobs2_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decobs2_ins"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decobs2_ins"))),
                                    bitobs1_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitobs1_ins"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitobs1_ins"))),
                                    bitobs2_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitobs2_ins"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitobs2_ins"))),
                                    dtobs1_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtobs1_ins"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtobs1_ins"))),
                                    dtobs2_ins = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtobs2_ins"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtobs2_ins"))),
                                    strid_per2 = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strid_per2"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strid_per2"))),
                                    strcoid_per = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strcoid_per"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strcoid_per"))),
                                    numerr = 0,
                                    msg = "Datos extraidos satisfactoriamente...",
                                    resultado = true


                                };
                                listG.Add(miClase);

                            }

                        }
                        myConnection.Close();

                    }
                    catch (SqlException er)
                    {
                        numerr = er.Number;
                        resultado = false;
                        msg = er.Message;
                    }
                }
                return listG;
            }

        }


        ///////////////// Método Add /////////////////
        public int AddPOSG_INSCRIPCION(POSG_INSCRIPCION miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["POSG_ConnectionString"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("TESIS_AddPOSG_INSCRIPCION", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRID_INS = new SqlParameter("@STRID_INS", SqlDbType.NVarChar);
            prmSTRID_INS.Value = miClass.strid_ins;
            myCommand.Parameters.Add(prmSTRID_INS);

            SqlParameter prmSTRCOD_PER = new SqlParameter("@STRCOD_PER", SqlDbType.NVarChar);
            prmSTRCOD_PER.Value = miClass.strcod_per;
            myCommand.Parameters.Add(prmSTRCOD_PER);

            SqlParameter prmSTRCOD_MATRIC = new SqlParameter("@STRCOD_MATRIC", SqlDbType.NVarChar);
            prmSTRCOD_MATRIC.Value = miClass.strcod_matric;
            myCommand.Parameters.Add(prmSTRCOD_MATRIC);

            SqlParameter prmSTRID_PER = new SqlParameter("@STRID_PER", SqlDbType.NVarChar);
            prmSTRID_PER.Value = miClass.strid_per;
            myCommand.Parameters.Add(prmSTRID_PER);

            SqlParameter prmSTRTEMA_INS = new SqlParameter("@STRTEMA_INS", SqlDbType.NVarChar);
            prmSTRTEMA_INS.Value = miClass.strtema_ins;
            myCommand.Parameters.Add(prmSTRTEMA_INS);

            SqlParameter prmSTRMODALIDAD_INS = new SqlParameter("@STRMODALIDAD_INS", SqlDbType.NVarChar);
            prmSTRMODALIDAD_INS.Value = miClass.strmodalidad_ins;
            myCommand.Parameters.Add(prmSTRMODALIDAD_INS);

            SqlParameter prmSTRMECANISMO_INS = new SqlParameter("@STRMECANISMO_INS", SqlDbType.NVarChar);
            prmSTRMECANISMO_INS.Value = miClass.strmecanismo_ins;
            myCommand.Parameters.Add(prmSTRMECANISMO_INS);

            SqlParameter prmDTFECHACREACION_INS = new SqlParameter("@DTFECHACREACION_INS", SqlDbType.DateTime);
            prmDTFECHACREACION_INS.Value = miClass.dtfechacreacion_ins;
            myCommand.Parameters.Add(prmDTFECHACREACION_INS);

            SqlParameter prmBITMATRIZAPROBADA_INS = new SqlParameter("@BITMATRIZAPROBADA_INS", SqlDbType.Bit);
            prmBITMATRIZAPROBADA_INS.Value = miClass.bitmatrizaprobada_ins;
            myCommand.Parameters.Add(prmBITMATRIZAPROBADA_INS);

            SqlParameter prmDTFECHAMATRIZAPROBADA_INS = new SqlParameter("@DTFECHAMATRIZAPROBADA_INS", SqlDbType.DateTime);
            prmDTFECHAMATRIZAPROBADA_INS.Value = miClass.dtfechamatrizaprobada_ins;
            myCommand.Parameters.Add(prmDTFECHAMATRIZAPROBADA_INS);

            SqlParameter prmSTRCEDAPRUEBAMATRIZ_INS1 = new SqlParameter("@STRCEDAPRUEBAMATRIZ_INS1", SqlDbType.NVarChar);
            prmSTRCEDAPRUEBAMATRIZ_INS1.Value = miClass.strcedapruebamatriz_ins1;
            myCommand.Parameters.Add(prmSTRCEDAPRUEBAMATRIZ_INS1);

            SqlParameter prmBITMATRIZREVISADA_INS = new SqlParameter("@BITMATRIZREVISADA_INS", SqlDbType.Bit);
            prmBITMATRIZREVISADA_INS.Value = miClass.bitmatrizrevisada_ins;
            myCommand.Parameters.Add(prmBITMATRIZREVISADA_INS);

            SqlParameter prmDTFECHAMATRIZREVISADA_INS = new SqlParameter("@DTFECHAMATRIZREVISADA_INS", SqlDbType.DateTime);
            prmDTFECHAMATRIZREVISADA_INS.Value = miClass.dtfechamatrizrevisada_ins;
            myCommand.Parameters.Add(prmDTFECHAMATRIZREVISADA_INS);

            SqlParameter prmSTRCEDREVISAMATRIZ_INS = new SqlParameter("@STRCEDREVISAMATRIZ_INS", SqlDbType.NVarChar);
            prmSTRCEDREVISAMATRIZ_INS.Value = miClass.strcedrevisamatriz_ins;
            myCommand.Parameters.Add(prmSTRCEDREVISAMATRIZ_INS);

            SqlParameter prmBITPAGADO_INS = new SqlParameter("@BITPAGADO_INS", SqlDbType.Bit);
            prmBITPAGADO_INS.Value = miClass.bitpagado_ins;
            myCommand.Parameters.Add(prmBITPAGADO_INS);

            SqlParameter prmDTFECHAPAGO_INS = new SqlParameter("@DTFECHAPAGO_INS", SqlDbType.DateTime);
            prmDTFECHAPAGO_INS.Value = miClass.dtfechapago_ins;
            myCommand.Parameters.Add(prmDTFECHAPAGO_INS);

            SqlParameter prmSTRCEDREGISTRAPAGO_INS = new SqlParameter("@STRCEDREGISTRAPAGO_INS", SqlDbType.NVarChar);
            prmSTRCEDREGISTRAPAGO_INS.Value = miClass.strcedregistrapago_ins;
            myCommand.Parameters.Add(prmSTRCEDREGISTRAPAGO_INS);

            SqlParameter prmSTROBSERVACIONES_INS = new SqlParameter("@STROBSERVACIONES_INS", SqlDbType.NVarChar);
            prmSTROBSERVACIONES_INS.Value = miClass.strobservaciones_ins;
            myCommand.Parameters.Add(prmSTROBSERVACIONES_INS);

            SqlParameter prmSTRSUGERENCIAS_INS = new SqlParameter("@STRSUGERENCIAS_INS", SqlDbType.NVarChar);
            prmSTRSUGERENCIAS_INS.Value = miClass.strsugerencias_ins;
            myCommand.Parameters.Add(prmSTRSUGERENCIAS_INS);

            SqlParameter prmSTRURL_INS = new SqlParameter("@STRURL_INS", SqlDbType.NVarChar);
            prmSTRURL_INS.Value = miClass.strurl_ins;
            myCommand.Parameters.Add(prmSTRURL_INS);

            SqlParameter prmBITAPROBADOPERFIL_INS = new SqlParameter("@BITAPROBADOPERFIL_INS", SqlDbType.Bit);
            prmBITAPROBADOPERFIL_INS.Value = miClass.bitaprobadoperfil_ins;
            myCommand.Parameters.Add(prmBITAPROBADOPERFIL_INS);

            SqlParameter prmSTRPERIODOACADEMICO_INS = new SqlParameter("@STRPERIODOACADEMICO_INS", SqlDbType.NVarChar);
            prmSTRPERIODOACADEMICO_INS.Value = miClass.strperiodoacademico_ins;
            myCommand.Parameters.Add(prmSTRPERIODOACADEMICO_INS);

            SqlParameter prmSTRUSERLOG = new SqlParameter("@STRUSERLOG", SqlDbType.NVarChar);
            prmSTRUSERLOG.Value = miClass.struserlog;
            myCommand.Parameters.Add(prmSTRUSERLOG);

            SqlParameter prmDTFECHALOG = new SqlParameter("@DTFECHALOG", SqlDbType.DateTime);
            prmDTFECHALOG.Value = miClass.dtfechalog;
            myCommand.Parameters.Add(prmDTFECHALOG);

            SqlParameter prmSTROBS1_INS = new SqlParameter("@STROBS1_INS", SqlDbType.NVarChar);
            prmSTROBS1_INS.Value = miClass.strobs1_ins;
            myCommand.Parameters.Add(prmSTROBS1_INS);

            SqlParameter prmSTROBS2_INS = new SqlParameter("@STROBS2_INS", SqlDbType.NVarChar);
            prmSTROBS2_INS.Value = miClass.strobs2_ins;
            myCommand.Parameters.Add(prmSTROBS2_INS);

            SqlParameter prmSTROBS3_INS = new SqlParameter("@STROBS3_INS", SqlDbType.NVarChar);
            prmSTROBS3_INS.Value = miClass.strobs3_ins;
            myCommand.Parameters.Add(prmSTROBS3_INS);

            SqlParameter prmSTRVACIO1_INS = new SqlParameter("@STRVACIO1_INS", SqlDbType.NVarChar);
            prmSTRVACIO1_INS.Value = miClass.strvacio1_ins;
            myCommand.Parameters.Add(prmSTRVACIO1_INS);

            SqlParameter prmSTRVACIO2_INS = new SqlParameter("@STRVACIO2_INS", SqlDbType.NVarChar);
            prmSTRVACIO2_INS.Value = miClass.strvacio2_ins;
            myCommand.Parameters.Add(prmSTRVACIO2_INS);

            SqlParameter prmDECOBS1_INS = new SqlParameter("@DECOBS1_INS", SqlDbType.Decimal);
            prmDECOBS1_INS.Value = miClass.decobs1_ins;
            myCommand.Parameters.Add(prmDECOBS1_INS);

            SqlParameter prmDECOBS2_INS = new SqlParameter("@DECOBS2_INS", SqlDbType.Decimal);
            prmDECOBS2_INS.Value = miClass.decobs2_ins;
            myCommand.Parameters.Add(prmDECOBS2_INS);

            SqlParameter prmBITOBS1_INS = new SqlParameter("@BITOBS1_INS", SqlDbType.Bit);
            prmBITOBS1_INS.Value = miClass.bitobs1_ins;
            myCommand.Parameters.Add(prmBITOBS1_INS);

            SqlParameter prmBITOBS2_INS = new SqlParameter("@BITOBS2_INS", SqlDbType.Bit);
            prmBITOBS2_INS.Value = miClass.bitobs2_ins;
            myCommand.Parameters.Add(prmBITOBS2_INS);

            SqlParameter prmDTOBS1_INS = new SqlParameter("@DTOBS1_INS", SqlDbType.DateTime);
            prmDTOBS1_INS.Value = miClass.dtobs1_ins;
            myCommand.Parameters.Add(prmDTOBS1_INS);

            SqlParameter prmDTOBS2_INS = new SqlParameter("@DTOBS2_INS", SqlDbType.DateTime);
            prmDTOBS2_INS.Value = miClass.dtobs2_ins;
            myCommand.Parameters.Add(prmDTOBS2_INS);

            SqlParameter prmSTRID_PER2 = new SqlParameter("@STRID_PER2", SqlDbType.NVarChar);
            prmSTRID_PER2.Value = miClass.strid_per2;
            myCommand.Parameters.Add(prmSTRID_PER2);

            SqlParameter prmSTRCOID_PER = new SqlParameter("@STRCOID_PER", SqlDbType.NVarChar);
            prmSTRCOID_PER.Value = miClass.strcoid_per;
            myCommand.Parameters.Add(prmSTRCOID_PER);



            int intReturb = -1;
            try
            {
                myConnection.Open();
                intReturb = myCommand.ExecuteNonQuery(); //devuelve el número de registros afectados en la bd
                resultado = true;
                msg = "Los datos se registraron satisfactoriamente...";
            }
            catch (SqlException er)
            {
                if (er.Number == 2627)
                {
                    msg = "Este registro de datos ya existe, no se realizó ningún cambio...";
                }
                else
                {
                    msg = er.Message;
                }
                numerr = er.Number;
                resultado = false;
            }
            finally
            {
                myCommand.Dispose();
                myConnection.Close();
                myConnection.Dispose();
            }
            return intReturb;

        }

        ///////////////// Método Add SobreCargado /////////////////
        public int AddPOSG_INSCRIPCION(
        string _strid_ins,
        string _strcod_per,
        string _strcod_matric,
        string _strid_per,
        string _strtema_ins,
        string _strmodalidad_ins,
        string _strmecanismo_ins,
        DateTime _dtfechacreacion_ins,
        bool _bitmatrizaprobada_ins,
        DateTime _dtfechamatrizaprobada_ins,
        string _strcedapruebamatriz_ins1,
        bool _bitmatrizrevisada_ins,
        DateTime _dtfechamatrizrevisada_ins,
        string _strcedrevisamatriz_ins,
        bool _bitpagado_ins,
        DateTime _dtfechapago_ins,
        string _strcedregistrapago_ins,
        string _strobservaciones_ins,
        string _strsugerencias_ins,
        string _strurl_ins,
        bool _bitaprobadoperfil_ins,
        string _strperiodoacademico_ins,
        string _struserlog,
        DateTime _dtfechalog,
        string _strobs1_ins,
        string _strobs2_ins,
        string _strobs3_ins,
        string _strvacio1_ins,
        string _strvacio2_ins,
        decimal _decobs1_ins,
        decimal _decobs2_ins,
        bool _bitobs1_ins,
        bool _bitobs2_ins,
        DateTime _dtobs1_ins,
        DateTime _dtobs2_ins,
        string _strid_per2,
        string _strcoid_per)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["POSG_ConnectionString"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("TESIS_AddPOSG_INSCRIPCION", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRID_INS = new SqlParameter("@STRID_INS", SqlDbType.NVarChar);
            prmSTRID_INS.Value = _strid_ins;
            myCommand.Parameters.Add(prmSTRID_INS);

            SqlParameter prmSTRCOD_PER = new SqlParameter("@STRCOD_PER", SqlDbType.NVarChar);
            prmSTRCOD_PER.Value = _strcod_per;
            myCommand.Parameters.Add(prmSTRCOD_PER);

            SqlParameter prmSTRCOD_MATRIC = new SqlParameter("@STRCOD_MATRIC", SqlDbType.NVarChar);
            prmSTRCOD_MATRIC.Value = _strcod_matric;
            myCommand.Parameters.Add(prmSTRCOD_MATRIC);

            SqlParameter prmSTRID_PER = new SqlParameter("@STRID_PER", SqlDbType.NVarChar);
            prmSTRID_PER.Value = _strid_per;
            myCommand.Parameters.Add(prmSTRID_PER);

            SqlParameter prmSTRTEMA_INS = new SqlParameter("@STRTEMA_INS", SqlDbType.NVarChar);
            prmSTRTEMA_INS.Value = _strtema_ins;
            myCommand.Parameters.Add(prmSTRTEMA_INS);

            SqlParameter prmSTRMODALIDAD_INS = new SqlParameter("@STRMODALIDAD_INS", SqlDbType.NVarChar);
            prmSTRMODALIDAD_INS.Value = _strmodalidad_ins;
            myCommand.Parameters.Add(prmSTRMODALIDAD_INS);

            SqlParameter prmSTRMECANISMO_INS = new SqlParameter("@STRMECANISMO_INS", SqlDbType.NVarChar);
            prmSTRMECANISMO_INS.Value = _strmecanismo_ins;
            myCommand.Parameters.Add(prmSTRMECANISMO_INS);

            SqlParameter prmDTFECHACREACION_INS = new SqlParameter("@DTFECHACREACION_INS", SqlDbType.DateTime);
            prmDTFECHACREACION_INS.Value = _dtfechacreacion_ins;
            myCommand.Parameters.Add(prmDTFECHACREACION_INS);

            SqlParameter prmBITMATRIZAPROBADA_INS = new SqlParameter("@BITMATRIZAPROBADA_INS", SqlDbType.Bit);
            prmBITMATRIZAPROBADA_INS.Value = _bitmatrizaprobada_ins;
            myCommand.Parameters.Add(prmBITMATRIZAPROBADA_INS);

            SqlParameter prmDTFECHAMATRIZAPROBADA_INS = new SqlParameter("@DTFECHAMATRIZAPROBADA_INS", SqlDbType.DateTime);
            prmDTFECHAMATRIZAPROBADA_INS.Value = _dtfechamatrizaprobada_ins;
            myCommand.Parameters.Add(prmDTFECHAMATRIZAPROBADA_INS);

            SqlParameter prmSTRCEDAPRUEBAMATRIZ_INS1 = new SqlParameter("@STRCEDAPRUEBAMATRIZ_INS1", SqlDbType.NVarChar);
            prmSTRCEDAPRUEBAMATRIZ_INS1.Value = _strcedapruebamatriz_ins1;
            myCommand.Parameters.Add(prmSTRCEDAPRUEBAMATRIZ_INS1);

            SqlParameter prmBITMATRIZREVISADA_INS = new SqlParameter("@BITMATRIZREVISADA_INS", SqlDbType.Bit);
            prmBITMATRIZREVISADA_INS.Value = _bitmatrizrevisada_ins;
            myCommand.Parameters.Add(prmBITMATRIZREVISADA_INS);

            SqlParameter prmDTFECHAMATRIZREVISADA_INS = new SqlParameter("@DTFECHAMATRIZREVISADA_INS", SqlDbType.DateTime);
            prmDTFECHAMATRIZREVISADA_INS.Value = _dtfechamatrizrevisada_ins;
            myCommand.Parameters.Add(prmDTFECHAMATRIZREVISADA_INS);

            SqlParameter prmSTRCEDREVISAMATRIZ_INS = new SqlParameter("@STRCEDREVISAMATRIZ_INS", SqlDbType.NVarChar);
            prmSTRCEDREVISAMATRIZ_INS.Value = _strcedrevisamatriz_ins;
            myCommand.Parameters.Add(prmSTRCEDREVISAMATRIZ_INS);

            SqlParameter prmBITPAGADO_INS = new SqlParameter("@BITPAGADO_INS", SqlDbType.Bit);
            prmBITPAGADO_INS.Value = _bitpagado_ins;
            myCommand.Parameters.Add(prmBITPAGADO_INS);

            SqlParameter prmDTFECHAPAGO_INS = new SqlParameter("@DTFECHAPAGO_INS", SqlDbType.DateTime);
            prmDTFECHAPAGO_INS.Value = _dtfechapago_ins;
            myCommand.Parameters.Add(prmDTFECHAPAGO_INS);

            SqlParameter prmSTRCEDREGISTRAPAGO_INS = new SqlParameter("@STRCEDREGISTRAPAGO_INS", SqlDbType.NVarChar);
            prmSTRCEDREGISTRAPAGO_INS.Value = _strcedregistrapago_ins;
            myCommand.Parameters.Add(prmSTRCEDREGISTRAPAGO_INS);

            SqlParameter prmSTROBSERVACIONES_INS = new SqlParameter("@STROBSERVACIONES_INS", SqlDbType.NVarChar);
            prmSTROBSERVACIONES_INS.Value = _strobservaciones_ins;
            myCommand.Parameters.Add(prmSTROBSERVACIONES_INS);

            SqlParameter prmSTRSUGERENCIAS_INS = new SqlParameter("@STRSUGERENCIAS_INS", SqlDbType.NVarChar);
            prmSTRSUGERENCIAS_INS.Value = _strsugerencias_ins;
            myCommand.Parameters.Add(prmSTRSUGERENCIAS_INS);

            SqlParameter prmSTRURL_INS = new SqlParameter("@STRURL_INS", SqlDbType.NVarChar);
            prmSTRURL_INS.Value = _strurl_ins;
            myCommand.Parameters.Add(prmSTRURL_INS);

            SqlParameter prmBITAPROBADOPERFIL_INS = new SqlParameter("@BITAPROBADOPERFIL_INS", SqlDbType.Bit);
            prmBITAPROBADOPERFIL_INS.Value = _bitaprobadoperfil_ins;
            myCommand.Parameters.Add(prmBITAPROBADOPERFIL_INS);

            SqlParameter prmSTRPERIODOACADEMICO_INS = new SqlParameter("@STRPERIODOACADEMICO_INS", SqlDbType.NVarChar);
            prmSTRPERIODOACADEMICO_INS.Value = _strperiodoacademico_ins;
            myCommand.Parameters.Add(prmSTRPERIODOACADEMICO_INS);

            SqlParameter prmSTRUSERLOG = new SqlParameter("@STRUSERLOG", SqlDbType.NVarChar);
            prmSTRUSERLOG.Value = _struserlog;
            myCommand.Parameters.Add(prmSTRUSERLOG);

            SqlParameter prmDTFECHALOG = new SqlParameter("@DTFECHALOG", SqlDbType.DateTime);
            prmDTFECHALOG.Value = _dtfechalog;
            myCommand.Parameters.Add(prmDTFECHALOG);

            SqlParameter prmSTROBS1_INS = new SqlParameter("@STROBS1_INS", SqlDbType.NVarChar);
            prmSTROBS1_INS.Value = _strobs1_ins;
            myCommand.Parameters.Add(prmSTROBS1_INS);

            SqlParameter prmSTROBS2_INS = new SqlParameter("@STROBS2_INS", SqlDbType.NVarChar);
            prmSTROBS2_INS.Value = _strobs2_ins;
            myCommand.Parameters.Add(prmSTROBS2_INS);

            SqlParameter prmSTROBS3_INS = new SqlParameter("@STROBS3_INS", SqlDbType.NVarChar);
            prmSTROBS3_INS.Value = _strobs3_ins;
            myCommand.Parameters.Add(prmSTROBS3_INS);

            SqlParameter prmSTRVACIO1_INS = new SqlParameter("@STRVACIO1_INS", SqlDbType.NVarChar);
            prmSTRVACIO1_INS.Value = _strvacio1_ins;
            myCommand.Parameters.Add(prmSTRVACIO1_INS);

            SqlParameter prmSTRVACIO2_INS = new SqlParameter("@STRVACIO2_INS", SqlDbType.NVarChar);
            prmSTRVACIO2_INS.Value = _strvacio2_ins;
            myCommand.Parameters.Add(prmSTRVACIO2_INS);

            SqlParameter prmDECOBS1_INS = new SqlParameter("@DECOBS1_INS", SqlDbType.Decimal);
            prmDECOBS1_INS.Value = _decobs1_ins;
            myCommand.Parameters.Add(prmDECOBS1_INS);

            SqlParameter prmDECOBS2_INS = new SqlParameter("@DECOBS2_INS", SqlDbType.Decimal);
            prmDECOBS2_INS.Value = _decobs2_ins;
            myCommand.Parameters.Add(prmDECOBS2_INS);

            SqlParameter prmBITOBS1_INS = new SqlParameter("@BITOBS1_INS", SqlDbType.Bit);
            prmBITOBS1_INS.Value = _bitobs1_ins;
            myCommand.Parameters.Add(prmBITOBS1_INS);

            SqlParameter prmBITOBS2_INS = new SqlParameter("@BITOBS2_INS", SqlDbType.Bit);
            prmBITOBS2_INS.Value = _bitobs2_ins;
            myCommand.Parameters.Add(prmBITOBS2_INS);

            SqlParameter prmDTOBS1_INS = new SqlParameter("@DTOBS1_INS", SqlDbType.DateTime);
            prmDTOBS1_INS.Value = _dtobs1_ins;
            myCommand.Parameters.Add(prmDTOBS1_INS);

            SqlParameter prmDTOBS2_INS = new SqlParameter("@DTOBS2_INS", SqlDbType.DateTime);
            prmDTOBS2_INS.Value = _dtobs2_ins;
            myCommand.Parameters.Add(prmDTOBS2_INS);

            SqlParameter prmSTRID_PER2 = new SqlParameter("@STRID_PER2", SqlDbType.NVarChar);
            prmSTRID_PER2.Value = _strid_per2;
            myCommand.Parameters.Add(prmSTRID_PER2);

            SqlParameter prmSTRCOID_PER = new SqlParameter("@STRCOID_PER", SqlDbType.NVarChar);
            prmSTRCOID_PER.Value = _strcoid_per;
            myCommand.Parameters.Add(prmSTRCOID_PER);


            int intReturb = -1;
            try
            {
                myConnection.Open();
                intReturb = myCommand.ExecuteNonQuery(); //devuelve el número de registros afectados en la bd
                resultado = true;
                msg = "Los datos se registraron satisfactoriamente...";
            }
            catch (SqlException er)
            {
                if (er.Number == 2627)
                {
                    msg = "Este registro de datos ya existe, no se realizó ningún cambio...";
                }
                else
                {
                    msg = er.Message;
                }
                numerr = er.Number;
                resultado = false;
            }
            finally
            {
                myCommand.Dispose();
                myConnection.Close();
                myConnection.Dispose();
            }
            return intReturb;

        }

        ///////////////// Método Update /////////////////
        public int UpdatePOSG_INSCRIPCION(POSG_INSCRIPCION miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["POSG_ConnectionString"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("TESIS_UpdatePOSG_INSCRIPCION", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRID_INS = new SqlParameter("@STRID_INS", SqlDbType.NVarChar);
            prmSTRID_INS.Value = miClass.strid_ins;
            myCommand.Parameters.Add(prmSTRID_INS);

            SqlParameter prmSTRCOD_PER = new SqlParameter("@STRCOD_PER", SqlDbType.NVarChar);
            prmSTRCOD_PER.Value = miClass.strcod_per;
            myCommand.Parameters.Add(prmSTRCOD_PER);

            SqlParameter prmSTRCOD_MATRIC = new SqlParameter("@STRCOD_MATRIC", SqlDbType.NVarChar);
            prmSTRCOD_MATRIC.Value = miClass.strcod_matric;
            myCommand.Parameters.Add(prmSTRCOD_MATRIC);

            SqlParameter prmSTRID_PER = new SqlParameter("@STRID_PER", SqlDbType.NVarChar);
            prmSTRID_PER.Value = miClass.strid_per;
            myCommand.Parameters.Add(prmSTRID_PER);

            SqlParameter prmSTRTEMA_INS = new SqlParameter("@STRTEMA_INS", SqlDbType.NVarChar);
            prmSTRTEMA_INS.Value = miClass.strtema_ins;
            myCommand.Parameters.Add(prmSTRTEMA_INS);

            SqlParameter prmSTRMODALIDAD_INS = new SqlParameter("@STRMODALIDAD_INS", SqlDbType.NVarChar);
            prmSTRMODALIDAD_INS.Value = miClass.strmodalidad_ins;
            myCommand.Parameters.Add(prmSTRMODALIDAD_INS);

            SqlParameter prmSTRMECANISMO_INS = new SqlParameter("@STRMECANISMO_INS", SqlDbType.NVarChar);
            prmSTRMECANISMO_INS.Value = miClass.strmecanismo_ins;
            myCommand.Parameters.Add(prmSTRMECANISMO_INS);

            SqlParameter prmDTFECHACREACION_INS = new SqlParameter("@DTFECHACREACION_INS", SqlDbType.DateTime);
            prmDTFECHACREACION_INS.Value = miClass.dtfechacreacion_ins;
            myCommand.Parameters.Add(prmDTFECHACREACION_INS);

            SqlParameter prmBITMATRIZAPROBADA_INS = new SqlParameter("@BITMATRIZAPROBADA_INS", SqlDbType.Bit);
            prmBITMATRIZAPROBADA_INS.Value = miClass.bitmatrizaprobada_ins;
            myCommand.Parameters.Add(prmBITMATRIZAPROBADA_INS);

            SqlParameter prmDTFECHAMATRIZAPROBADA_INS = new SqlParameter("@DTFECHAMATRIZAPROBADA_INS", SqlDbType.DateTime);
            prmDTFECHAMATRIZAPROBADA_INS.Value = miClass.dtfechamatrizaprobada_ins;
            myCommand.Parameters.Add(prmDTFECHAMATRIZAPROBADA_INS);

            SqlParameter prmSTRCEDAPRUEBAMATRIZ_INS1 = new SqlParameter("@STRCEDAPRUEBAMATRIZ_INS1", SqlDbType.NVarChar);
            prmSTRCEDAPRUEBAMATRIZ_INS1.Value = miClass.strcedapruebamatriz_ins1;
            myCommand.Parameters.Add(prmSTRCEDAPRUEBAMATRIZ_INS1);

            SqlParameter prmBITMATRIZREVISADA_INS = new SqlParameter("@BITMATRIZREVISADA_INS", SqlDbType.Bit);
            prmBITMATRIZREVISADA_INS.Value = miClass.bitmatrizrevisada_ins;
            myCommand.Parameters.Add(prmBITMATRIZREVISADA_INS);

            SqlParameter prmDTFECHAMATRIZREVISADA_INS = new SqlParameter("@DTFECHAMATRIZREVISADA_INS", SqlDbType.DateTime);
            prmDTFECHAMATRIZREVISADA_INS.Value = miClass.dtfechamatrizrevisada_ins;
            myCommand.Parameters.Add(prmDTFECHAMATRIZREVISADA_INS);

            SqlParameter prmSTRCEDREVISAMATRIZ_INS = new SqlParameter("@STRCEDREVISAMATRIZ_INS", SqlDbType.NVarChar);
            prmSTRCEDREVISAMATRIZ_INS.Value = miClass.strcedrevisamatriz_ins;
            myCommand.Parameters.Add(prmSTRCEDREVISAMATRIZ_INS);

            SqlParameter prmBITPAGADO_INS = new SqlParameter("@BITPAGADO_INS", SqlDbType.Bit);
            prmBITPAGADO_INS.Value = miClass.bitpagado_ins;
            myCommand.Parameters.Add(prmBITPAGADO_INS);

            SqlParameter prmDTFECHAPAGO_INS = new SqlParameter("@DTFECHAPAGO_INS", SqlDbType.DateTime);
            prmDTFECHAPAGO_INS.Value = miClass.dtfechapago_ins;
            myCommand.Parameters.Add(prmDTFECHAPAGO_INS);

            SqlParameter prmSTRCEDREGISTRAPAGO_INS = new SqlParameter("@STRCEDREGISTRAPAGO_INS", SqlDbType.NVarChar);
            prmSTRCEDREGISTRAPAGO_INS.Value = miClass.strcedregistrapago_ins;
            myCommand.Parameters.Add(prmSTRCEDREGISTRAPAGO_INS);

            SqlParameter prmSTROBSERVACIONES_INS = new SqlParameter("@STROBSERVACIONES_INS", SqlDbType.NVarChar);
            prmSTROBSERVACIONES_INS.Value = miClass.strobservaciones_ins;
            myCommand.Parameters.Add(prmSTROBSERVACIONES_INS);

            SqlParameter prmSTRSUGERENCIAS_INS = new SqlParameter("@STRSUGERENCIAS_INS", SqlDbType.NVarChar);
            prmSTRSUGERENCIAS_INS.Value = miClass.strsugerencias_ins;
            myCommand.Parameters.Add(prmSTRSUGERENCIAS_INS);

            SqlParameter prmSTRURL_INS = new SqlParameter("@STRURL_INS", SqlDbType.NVarChar);
            prmSTRURL_INS.Value = miClass.strurl_ins;
            myCommand.Parameters.Add(prmSTRURL_INS);

            SqlParameter prmBITAPROBADOPERFIL_INS = new SqlParameter("@BITAPROBADOPERFIL_INS", SqlDbType.Bit);
            prmBITAPROBADOPERFIL_INS.Value = miClass.bitaprobadoperfil_ins;
            myCommand.Parameters.Add(prmBITAPROBADOPERFIL_INS);

            SqlParameter prmSTRPERIODOACADEMICO_INS = new SqlParameter("@STRPERIODOACADEMICO_INS", SqlDbType.NVarChar);
            prmSTRPERIODOACADEMICO_INS.Value = miClass.strperiodoacademico_ins;
            myCommand.Parameters.Add(prmSTRPERIODOACADEMICO_INS);

            SqlParameter prmSTRUSERLOG = new SqlParameter("@STRUSERLOG", SqlDbType.NVarChar);
            prmSTRUSERLOG.Value = miClass.struserlog;
            myCommand.Parameters.Add(prmSTRUSERLOG);

            SqlParameter prmDTFECHALOG = new SqlParameter("@DTFECHALOG", SqlDbType.DateTime);
            prmDTFECHALOG.Value = miClass.dtfechalog;
            myCommand.Parameters.Add(prmDTFECHALOG);

            SqlParameter prmSTROBS1_INS = new SqlParameter("@STROBS1_INS", SqlDbType.NVarChar);
            prmSTROBS1_INS.Value = miClass.strobs1_ins;
            myCommand.Parameters.Add(prmSTROBS1_INS);

            SqlParameter prmSTROBS2_INS = new SqlParameter("@STROBS2_INS", SqlDbType.NVarChar);
            prmSTROBS2_INS.Value = miClass.strobs2_ins;
            myCommand.Parameters.Add(prmSTROBS2_INS);

            SqlParameter prmSTROBS3_INS = new SqlParameter("@STROBS3_INS", SqlDbType.NVarChar);
            prmSTROBS3_INS.Value = miClass.strobs3_ins;
            myCommand.Parameters.Add(prmSTROBS3_INS);

            SqlParameter prmSTRVACIO1_INS = new SqlParameter("@STRVACIO1_INS", SqlDbType.NVarChar);
            prmSTRVACIO1_INS.Value = miClass.strvacio1_ins;
            myCommand.Parameters.Add(prmSTRVACIO1_INS);

            SqlParameter prmSTRVACIO2_INS = new SqlParameter("@STRVACIO2_INS", SqlDbType.NVarChar);
            prmSTRVACIO2_INS.Value = miClass.strvacio2_ins;
            myCommand.Parameters.Add(prmSTRVACIO2_INS);

            SqlParameter prmDECOBS1_INS = new SqlParameter("@DECOBS1_INS", SqlDbType.Decimal);
            prmDECOBS1_INS.Value = miClass.decobs1_ins;
            myCommand.Parameters.Add(prmDECOBS1_INS);

            SqlParameter prmDECOBS2_INS = new SqlParameter("@DECOBS2_INS", SqlDbType.Decimal);
            prmDECOBS2_INS.Value = miClass.decobs2_ins;
            myCommand.Parameters.Add(prmDECOBS2_INS);

            SqlParameter prmBITOBS1_INS = new SqlParameter("@BITOBS1_INS", SqlDbType.Bit);
            prmBITOBS1_INS.Value = miClass.bitobs1_ins;
            myCommand.Parameters.Add(prmBITOBS1_INS);

            SqlParameter prmBITOBS2_INS = new SqlParameter("@BITOBS2_INS", SqlDbType.Bit);
            prmBITOBS2_INS.Value = miClass.bitobs2_ins;
            myCommand.Parameters.Add(prmBITOBS2_INS);

            SqlParameter prmDTOBS1_INS = new SqlParameter("@DTOBS1_INS", SqlDbType.DateTime);
            prmDTOBS1_INS.Value = miClass.dtobs1_ins;
            myCommand.Parameters.Add(prmDTOBS1_INS);

            SqlParameter prmDTOBS2_INS = new SqlParameter("@DTOBS2_INS", SqlDbType.DateTime);
            prmDTOBS2_INS.Value = miClass.dtobs2_ins;
            myCommand.Parameters.Add(prmDTOBS2_INS);

            SqlParameter prmSTRID_PER2 = new SqlParameter("@STRID_PER2", SqlDbType.NVarChar);
            prmSTRID_PER2.Value = miClass.strid_per2;
            myCommand.Parameters.Add(prmSTRID_PER2);

            SqlParameter prmSTRCOID_PER = new SqlParameter("@STRCOID_PER", SqlDbType.NVarChar);
            prmSTRCOID_PER.Value = miClass.strcoid_per;
            myCommand.Parameters.Add(prmSTRCOID_PER);



            int intReturb = -1;
            try
            {
                myConnection.Open();
                intReturb = myCommand.ExecuteNonQuery(); //devuelve el número de registros afectados en la bd
                if (intReturb == 0)
                {
                    resultado = false;
                    msg = "No se puede actualizar este registro...";
                }
                else
                {
                    resultado = true;
                    msg = "El registro se actualizó satisfactoriamente...";
                }
            }
            catch (SqlException er)
            {
                if (er.Number == 2627)
                {
                    msg = "Este registro de datos ya existe, no se realizó ningún cambio...";
                }
                else
                {
                    msg = er.Message;
                }
                numerr = er.Number;
                resultado = false;
            }
            finally
            {
                myCommand.Dispose();
                myConnection.Close();
                myConnection.Dispose();
            }
            return intReturb;

        }
        ///////////////// Método Update SobreCargado  /////////////////
        public int UpdatePOSG_INSCRIPCION(string _strid_ins,
        string _strcod_per,
        string _strcod_matric,
        string _strid_per,
        string _strtema_ins,
        string _strmodalidad_ins,
        string _strmecanismo_ins,
        DateTime _dtfechacreacion_ins,
        bool _bitmatrizaprobada_ins,
        DateTime _dtfechamatrizaprobada_ins,
        string _strcedapruebamatriz_ins1,
        bool _bitmatrizrevisada_ins,
        DateTime _dtfechamatrizrevisada_ins,
        string _strcedrevisamatriz_ins,
        bool _bitpagado_ins,
        DateTime _dtfechapago_ins,
        string _strcedregistrapago_ins,
        string _strobservaciones_ins,
        string _strsugerencias_ins,
        string _strurl_ins,
        bool _bitaprobadoperfil_ins,
        string _strperiodoacademico_ins,
        string _struserlog,
        DateTime _dtfechalog,
        string _strobs1_ins,
        string _strobs2_ins,
        string _strobs3_ins,
        string _strvacio1_ins,
        string _strvacio2_ins,
        decimal _decobs1_ins,
        decimal _decobs2_ins,
        bool _bitobs1_ins,
        bool _bitobs2_ins,
        DateTime _dtobs1_ins,
        DateTime _dtobs2_ins,
        string _strid_per2,
        string _strcoid_per)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["POSG_ConnectionString"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("TESIS_UpdatePOSG_INSCRIPCION", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRID_INS = new SqlParameter("@STRID_INS", SqlDbType.NVarChar);
            prmSTRID_INS.Value = _strid_ins;
            myCommand.Parameters.Add(prmSTRID_INS);

            SqlParameter prmSTRCOD_PER = new SqlParameter("@STRCOD_PER", SqlDbType.NVarChar);
            prmSTRCOD_PER.Value = _strcod_per;
            myCommand.Parameters.Add(prmSTRCOD_PER);

            SqlParameter prmSTRCOD_MATRIC = new SqlParameter("@STRCOD_MATRIC", SqlDbType.NVarChar);
            prmSTRCOD_MATRIC.Value = _strcod_matric;
            myCommand.Parameters.Add(prmSTRCOD_MATRIC);

            SqlParameter prmSTRID_PER = new SqlParameter("@STRID_PER", SqlDbType.NVarChar);
            prmSTRID_PER.Value = _strid_per;
            myCommand.Parameters.Add(prmSTRID_PER);

            SqlParameter prmSTRTEMA_INS = new SqlParameter("@STRTEMA_INS", SqlDbType.NVarChar);
            prmSTRTEMA_INS.Value = _strtema_ins;
            myCommand.Parameters.Add(prmSTRTEMA_INS);

            SqlParameter prmSTRMODALIDAD_INS = new SqlParameter("@STRMODALIDAD_INS", SqlDbType.NVarChar);
            prmSTRMODALIDAD_INS.Value = _strmodalidad_ins;
            myCommand.Parameters.Add(prmSTRMODALIDAD_INS);

            SqlParameter prmSTRMECANISMO_INS = new SqlParameter("@STRMECANISMO_INS", SqlDbType.NVarChar);
            prmSTRMECANISMO_INS.Value = _strmecanismo_ins;
            myCommand.Parameters.Add(prmSTRMECANISMO_INS);

            SqlParameter prmDTFECHACREACION_INS = new SqlParameter("@DTFECHACREACION_INS", SqlDbType.DateTime);
            prmDTFECHACREACION_INS.Value = _dtfechacreacion_ins;
            myCommand.Parameters.Add(prmDTFECHACREACION_INS);

            SqlParameter prmBITMATRIZAPROBADA_INS = new SqlParameter("@BITMATRIZAPROBADA_INS", SqlDbType.Bit);
            prmBITMATRIZAPROBADA_INS.Value = _bitmatrizaprobada_ins;
            myCommand.Parameters.Add(prmBITMATRIZAPROBADA_INS);

            SqlParameter prmDTFECHAMATRIZAPROBADA_INS = new SqlParameter("@DTFECHAMATRIZAPROBADA_INS", SqlDbType.DateTime);
            prmDTFECHAMATRIZAPROBADA_INS.Value = _dtfechamatrizaprobada_ins;
            myCommand.Parameters.Add(prmDTFECHAMATRIZAPROBADA_INS);

            SqlParameter prmSTRCEDAPRUEBAMATRIZ_INS1 = new SqlParameter("@STRCEDAPRUEBAMATRIZ_INS1", SqlDbType.NVarChar);
            prmSTRCEDAPRUEBAMATRIZ_INS1.Value = _strcedapruebamatriz_ins1;
            myCommand.Parameters.Add(prmSTRCEDAPRUEBAMATRIZ_INS1);

            SqlParameter prmBITMATRIZREVISADA_INS = new SqlParameter("@BITMATRIZREVISADA_INS", SqlDbType.Bit);
            prmBITMATRIZREVISADA_INS.Value = _bitmatrizrevisada_ins;
            myCommand.Parameters.Add(prmBITMATRIZREVISADA_INS);

            SqlParameter prmDTFECHAMATRIZREVISADA_INS = new SqlParameter("@DTFECHAMATRIZREVISADA_INS", SqlDbType.DateTime);
            prmDTFECHAMATRIZREVISADA_INS.Value = _dtfechamatrizrevisada_ins;
            myCommand.Parameters.Add(prmDTFECHAMATRIZREVISADA_INS);

            SqlParameter prmSTRCEDREVISAMATRIZ_INS = new SqlParameter("@STRCEDREVISAMATRIZ_INS", SqlDbType.NVarChar);
            prmSTRCEDREVISAMATRIZ_INS.Value = _strcedrevisamatriz_ins;
            myCommand.Parameters.Add(prmSTRCEDREVISAMATRIZ_INS);

            SqlParameter prmBITPAGADO_INS = new SqlParameter("@BITPAGADO_INS", SqlDbType.Bit);
            prmBITPAGADO_INS.Value = _bitpagado_ins;
            myCommand.Parameters.Add(prmBITPAGADO_INS);

            SqlParameter prmDTFECHAPAGO_INS = new SqlParameter("@DTFECHAPAGO_INS", SqlDbType.DateTime);
            prmDTFECHAPAGO_INS.Value = _dtfechapago_ins;
            myCommand.Parameters.Add(prmDTFECHAPAGO_INS);

            SqlParameter prmSTRCEDREGISTRAPAGO_INS = new SqlParameter("@STRCEDREGISTRAPAGO_INS", SqlDbType.NVarChar);
            prmSTRCEDREGISTRAPAGO_INS.Value = _strcedregistrapago_ins;
            myCommand.Parameters.Add(prmSTRCEDREGISTRAPAGO_INS);

            SqlParameter prmSTROBSERVACIONES_INS = new SqlParameter("@STROBSERVACIONES_INS", SqlDbType.NVarChar);
            prmSTROBSERVACIONES_INS.Value = _strobservaciones_ins;
            myCommand.Parameters.Add(prmSTROBSERVACIONES_INS);

            SqlParameter prmSTRSUGERENCIAS_INS = new SqlParameter("@STRSUGERENCIAS_INS", SqlDbType.NVarChar);
            prmSTRSUGERENCIAS_INS.Value = _strsugerencias_ins;
            myCommand.Parameters.Add(prmSTRSUGERENCIAS_INS);

            SqlParameter prmSTRURL_INS = new SqlParameter("@STRURL_INS", SqlDbType.NVarChar);
            prmSTRURL_INS.Value = _strurl_ins;
            myCommand.Parameters.Add(prmSTRURL_INS);

            SqlParameter prmBITAPROBADOPERFIL_INS = new SqlParameter("@BITAPROBADOPERFIL_INS", SqlDbType.Bit);
            prmBITAPROBADOPERFIL_INS.Value = _bitaprobadoperfil_ins;
            myCommand.Parameters.Add(prmBITAPROBADOPERFIL_INS);

            SqlParameter prmSTRPERIODOACADEMICO_INS = new SqlParameter("@STRPERIODOACADEMICO_INS", SqlDbType.NVarChar);
            prmSTRPERIODOACADEMICO_INS.Value = _strperiodoacademico_ins;
            myCommand.Parameters.Add(prmSTRPERIODOACADEMICO_INS);

            SqlParameter prmSTRUSERLOG = new SqlParameter("@STRUSERLOG", SqlDbType.NVarChar);
            prmSTRUSERLOG.Value = _struserlog;
            myCommand.Parameters.Add(prmSTRUSERLOG);

            SqlParameter prmDTFECHALOG = new SqlParameter("@DTFECHALOG", SqlDbType.DateTime);
            prmDTFECHALOG.Value = _dtfechalog;
            myCommand.Parameters.Add(prmDTFECHALOG);

            SqlParameter prmSTROBS1_INS = new SqlParameter("@STROBS1_INS", SqlDbType.NVarChar);
            prmSTROBS1_INS.Value = _strobs1_ins;
            myCommand.Parameters.Add(prmSTROBS1_INS);

            SqlParameter prmSTROBS2_INS = new SqlParameter("@STROBS2_INS", SqlDbType.NVarChar);
            prmSTROBS2_INS.Value = _strobs2_ins;
            myCommand.Parameters.Add(prmSTROBS2_INS);

            SqlParameter prmSTROBS3_INS = new SqlParameter("@STROBS3_INS", SqlDbType.NVarChar);
            prmSTROBS3_INS.Value = _strobs3_ins;
            myCommand.Parameters.Add(prmSTROBS3_INS);

            SqlParameter prmSTRVACIO1_INS = new SqlParameter("@STRVACIO1_INS", SqlDbType.NVarChar);
            prmSTRVACIO1_INS.Value = _strvacio1_ins;
            myCommand.Parameters.Add(prmSTRVACIO1_INS);

            SqlParameter prmSTRVACIO2_INS = new SqlParameter("@STRVACIO2_INS", SqlDbType.NVarChar);
            prmSTRVACIO2_INS.Value = _strvacio2_ins;
            myCommand.Parameters.Add(prmSTRVACIO2_INS);

            SqlParameter prmDECOBS1_INS = new SqlParameter("@DECOBS1_INS", SqlDbType.Decimal);
            prmDECOBS1_INS.Value = _decobs1_ins;
            myCommand.Parameters.Add(prmDECOBS1_INS);

            SqlParameter prmDECOBS2_INS = new SqlParameter("@DECOBS2_INS", SqlDbType.Decimal);
            prmDECOBS2_INS.Value = _decobs2_ins;
            myCommand.Parameters.Add(prmDECOBS2_INS);

            SqlParameter prmBITOBS1_INS = new SqlParameter("@BITOBS1_INS", SqlDbType.Bit);
            prmBITOBS1_INS.Value = _bitobs1_ins;
            myCommand.Parameters.Add(prmBITOBS1_INS);

            SqlParameter prmBITOBS2_INS = new SqlParameter("@BITOBS2_INS", SqlDbType.Bit);
            prmBITOBS2_INS.Value = _bitobs2_ins;
            myCommand.Parameters.Add(prmBITOBS2_INS);

            SqlParameter prmDTOBS1_INS = new SqlParameter("@DTOBS1_INS", SqlDbType.DateTime);
            prmDTOBS1_INS.Value = _dtobs1_ins;
            myCommand.Parameters.Add(prmDTOBS1_INS);

            SqlParameter prmDTOBS2_INS = new SqlParameter("@DTOBS2_INS", SqlDbType.DateTime);
            prmDTOBS2_INS.Value = _dtobs2_ins;
            myCommand.Parameters.Add(prmDTOBS2_INS);

            SqlParameter prmSTRID_PER2 = new SqlParameter("@STRID_PER2", SqlDbType.NVarChar);
            prmSTRID_PER2.Value = _strid_per2;
            myCommand.Parameters.Add(prmSTRID_PER2);

            SqlParameter prmSTRCOID_PER = new SqlParameter("@STRCOID_PER", SqlDbType.NVarChar);
            prmSTRCOID_PER.Value = _strcoid_per;
            myCommand.Parameters.Add(prmSTRCOID_PER);



            int intReturb = -1;
            try
            {
                myConnection.Open();
                intReturb = myCommand.ExecuteNonQuery(); //devuelve el número de registros afectados en la bd
                if (intReturb == 0)
                {
                    resultado = false;
                    msg = "No se puede actualizar este registro...";
                }
                else
                {
                    resultado = true;
                    msg = "El registro se actualizó satisfactoriamente...";
                }
            }
            catch (SqlException er)
            {
                if (er.Number == 2627)
                {
                    msg = "Este registro de datos ya existe, no se realizó ningún cambio...";
                }
                else
                {
                    msg = er.Message;
                }
                numerr = er.Number;
                resultado = false;
            }
            finally
            {
                myCommand.Dispose();
                myConnection.Close();
                myConnection.Dispose();
            }
            return intReturb;

        }

        ///////////////// Método Delete /////////////////
        public int DelPOSG_INSCRIPCION(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("TESIS_DelPOSG_INSCRIPCION", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter prmComodin = new SqlParameter("@COMODIN", SqlDbType.VarChar);
            prmComodin.Value = comodin;
            myCommand.Parameters.Add(prmComodin);

            SqlParameter prmFiltro1 = new SqlParameter("@FILTRO1", SqlDbType.VarChar);
            prmFiltro1.Value = filtro1;
            myCommand.Parameters.Add(prmFiltro1);

            SqlParameter prmFiltro2 = new SqlParameter("@FILTRO2", SqlDbType.VarChar);
            prmFiltro2.Value = filtro2;
            myCommand.Parameters.Add(prmFiltro2);

            SqlParameter prmFiltro3 = new SqlParameter("@FILTRO3", SqlDbType.VarChar);
            prmFiltro3.Value = filtro3;
            myCommand.Parameters.Add(prmFiltro3);

            SqlParameter prmFiltro4 = new SqlParameter("@FILTRO4", SqlDbType.VarChar);
            prmFiltro4.Value = filtro4;
            myCommand.Parameters.Add(prmFiltro4);

            int intReturb = -1;
            try
            {
                myConnection.Open();
                intReturb = myCommand.ExecuteNonQuery(); //devuelve el número de registros afectados en la bd
                if (intReturb == 0)
                {
                    resultado = false;
                    msg = "No se puede eliminar este registro...";
                }
                else
                {
                    resultado = true;
                    msg = "El registro se eliminó satisfactoriamente...";
                }
            }
            catch (SqlException er)
            {
                if (er.Number == 2627)
                {
                    msg = "***Este registro de datos ya existe, no se realizó ningún cambio...";
                }
                else
                {
                    msg = er.Message;
                }
                numerr = er.Number;
                resultado = false;
            }
            finally
            {
                myCommand.Dispose();
                myConnection.Close();
                myConnection.Dispose();
            }
            return intReturb;

        }


    }
}
