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
    public class LAB_RESERVA
    {
        public LAB_RESERVA() { }

        public LAB_RESERVA(
            string _strCod_reser,
            string _strCod_lab,
            string _strCod_Mate,
            string _cedula_alu,
            string _strCod_unidTem,
            string _strTema_reser,
            string _strDescripcion_reser,
            string _strMateriales_reser,
            DateTime _dtFechainicio_reser,
            DateTime _dtFechaFin_reser,
            int _intTotalAsistente_reser,
            string _strColor_reser,
            string _strEstado_reser,
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
            strCod_Mate = _strCod_Mate;
            cedula_alu = _cedula_alu;
            strCod_unidTem = _strCod_unidTem;
            strTema_reser = _strTema_reser;
            strDescripcion_reser = _strDescripcion_reser;
            strMateriales_reser = _strMateriales_reser;
            dtFechainicio_reser = _dtFechainicio_reser;
            dtFechaFin_reser = _dtFechaFin_reser;
            intTotalAsistente_reser = _intTotalAsistente_reser;
            strColor_reser = _strColor_reser;
            strEstado_reser = _strEstado_reser;
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
        private string STRCOD_MATE;
        private string CEDULA_ALU;
        private string STRCOD_UNIDTEM;
        private string STRTEMA_RESER;
        private string STRDESCRIPCION_RESER;
        private string STRMATERIALES_RESER;
        private DateTime DTFECHAINICIO_RESER;
        private DateTime DTFECHAFIN_RESER;
        private int INTTOTALASISTENTE_RESER;
        private string STRCOLOR_RESER;
        private string STRESTADO_RESER;
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

        public string strCod_Mate
        {
            get
            {
                return STRCOD_MATE;
            }
            set
            {
                STRCOD_MATE = value;
            }
        }

        public string cedula_alu
        {
            get
            {
                return CEDULA_ALU;
            }
            set
            {
                CEDULA_ALU = value;
            }
        }

        public string strCod_unidTem
        {
            get
            {
                return STRCOD_UNIDTEM;
            }
            set
            {
                STRCOD_UNIDTEM = value;
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

        public string strColor_reser
        {
            get
            {
                return STRCOLOR_RESER;
            }
            set
            {
                STRCOLOR_RESER = value;
            }
        }

        public string strEstado_reser
        {
            get
            {
                return STRESTADO_RESER;
            }
            set
            {
                STRESTADO_RESER = value;
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
        public List<LAB_RESERVA> LoadLAB_RESERVA(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<LAB_RESERVA>();

            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
            {
                using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_RESERVA", myConnection))
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
                                LAB_RESERVA miClase = new LAB_RESERVA()
                                {
                                    strCod_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_reser"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_reser"))),
                                    strCod_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))),
                                    strCod_Mate = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Mate"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Mate"))),
                                    cedula_alu = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("cedula_alu"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("cedula_alu"))),
                                    strCod_unidTem = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_unidTem"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_unidTem"))),
                                    strTema_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strTema_reser"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strTema_reser"))),
                                    strDescripcion_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strDescripcion_reser"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strDescripcion_reser"))),
                                    strMateriales_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strMateriales_reser"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strMateriales_reser"))),
                                    dtFechainicio_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechainicio_reser"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechainicio_reser"))),
                                    dtFechaFin_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaFin_reser"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaFin_reser"))),
                                    intTotalAsistente_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("intTotalAsistente_reser"))) == true ? 0 : Convert.ToInt32(reader1.GetValue(reader1.GetOrdinal("intTotalAsistente_reser"))),
                                    strColor_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strColor_reser"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strColor_reser"))),
                                    strEstado_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strEstado_reser"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strEstado_reser"))),
                                    bitEstado_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitEstado_reser"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitEstado_reser"))),
                                    dtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    strUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strObs1_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_reser"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_reser"))),
                                    strObs2_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_reser"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_reser"))),
                                    bitObs1_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_reser"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_reser"))),
                                    bitObs2_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_reser"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_reser"))),
                                    decObs1_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_reser"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_reser"))),
                                    decObs2_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_reser"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_reser"))),
                                    dtObs1_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_reser"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_reser"))),
                                    dtObs2_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_reser"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_reser"))),

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
            }
            return listG;
        }

        ///////////////// Método Add /////////////////
        public int AddLAB_RESERVA(LAB_RESERVA miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_RESERVA", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = miClass.strCod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@STRCOD_LAB", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = miClass.strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmSTRCOD_MATE = new SqlParameter("@STRCOD_MATE", SqlDbType.NVarChar);
            prmSTRCOD_MATE.Value = miClass.strCod_Mate;
            myCommand.Parameters.Add(prmSTRCOD_MATE);

            SqlParameter prmCEDULA_ALU = new SqlParameter("@CEDULA_ALU", SqlDbType.NVarChar);
            prmCEDULA_ALU.Value = miClass.cedula_alu;
            myCommand.Parameters.Add(prmCEDULA_ALU);

            SqlParameter prmSTRCOD_UNIDTEM = new SqlParameter("@STRCOD_UNIDTEM", SqlDbType.NVarChar);
            prmSTRCOD_UNIDTEM.Value = miClass.strCod_unidTem;
            myCommand.Parameters.Add(prmSTRCOD_UNIDTEM);

            SqlParameter prmSTRTEMA_RESER = new SqlParameter("@STRTEMA_RESER", SqlDbType.NVarChar);
            prmSTRTEMA_RESER.Value = miClass.strTema_reser;
            myCommand.Parameters.Add(prmSTRTEMA_RESER);

            SqlParameter prmSTRDESCRIPCION_RESER = new SqlParameter("@STRDESCRIPCION_RESER", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_RESER.Value = miClass.strDescripcion_reser;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_RESER);

            SqlParameter prmSTRMATERIALES_RESER = new SqlParameter("@STRMATERIALES_RESER", SqlDbType.NVarChar);
            prmSTRMATERIALES_RESER.Value = miClass.strMateriales_reser;
            myCommand.Parameters.Add(prmSTRMATERIALES_RESER);

            SqlParameter prmDTFECHAINICIO_RESER = new SqlParameter("@DTFECHAINICIO_RESER", SqlDbType.DateTime);
            prmDTFECHAINICIO_RESER.Value = miClass.dtFechainicio_reser;
            myCommand.Parameters.Add(prmDTFECHAINICIO_RESER);

            SqlParameter prmDTFECHAFIN_RESER = new SqlParameter("@DTFECHAFIN_RESER", SqlDbType.DateTime);
            prmDTFECHAFIN_RESER.Value = miClass.dtFechaFin_reser;
            myCommand.Parameters.Add(prmDTFECHAFIN_RESER);

            SqlParameter prmINTTOTALASISTENTE_RESER = new SqlParameter("@INTTOTALASISTENTE_RESER", SqlDbType.Int);
            prmINTTOTALASISTENTE_RESER.Value = miClass.intTotalAsistente_reser;
            myCommand.Parameters.Add(prmINTTOTALASISTENTE_RESER);

            SqlParameter prmSTRCOLOR_RESER = new SqlParameter("@STRCOLOR_RESER", SqlDbType.NVarChar);
            prmSTRCOLOR_RESER.Value = miClass.strColor_reser;
            myCommand.Parameters.Add(prmSTRCOLOR_RESER);

            SqlParameter prmSTRESTADO_RESER = new SqlParameter("@STRESTADO_RESER", SqlDbType.NVarChar);
            prmSTRESTADO_RESER.Value = miClass.strEstado_reser;
            myCommand.Parameters.Add(prmSTRESTADO_RESER);

            SqlParameter prmBITESTADO_RESER = new SqlParameter("@BITESTADO_RESER", SqlDbType.Bit);
            prmBITESTADO_RESER.Value = miClass.bitEstado_reser;
            myCommand.Parameters.Add(prmBITESTADO_RESER);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESER = new SqlParameter("@STROBS1_RESER", SqlDbType.NVarChar);
            prmSTROBS1_RESER.Value = miClass.strObs1_reser;
            myCommand.Parameters.Add(prmSTROBS1_RESER);

            SqlParameter prmSTROBS2_RESER = new SqlParameter("@STROBS2_RESER", SqlDbType.NVarChar);
            prmSTROBS2_RESER.Value = miClass.strObs2_reser;
            myCommand.Parameters.Add(prmSTROBS2_RESER);

            SqlParameter prmBITOBS1_RESER = new SqlParameter("@BITOBS1_RESER", SqlDbType.Bit);
            prmBITOBS1_RESER.Value = miClass.bitObs1_reser;
            myCommand.Parameters.Add(prmBITOBS1_RESER);

            SqlParameter prmBITOBS2_RESER = new SqlParameter("@BITOBS2_RESER", SqlDbType.Bit);
            prmBITOBS2_RESER.Value = miClass.bitObs2_reser;
            myCommand.Parameters.Add(prmBITOBS2_RESER);

            SqlParameter prmDECOBS1_RESER = new SqlParameter("@DECOBS1_RESER", SqlDbType.Decimal);
            prmDECOBS1_RESER.Value = miClass.decObs1_reser;
            myCommand.Parameters.Add(prmDECOBS1_RESER);

            SqlParameter prmDECOBS2_RESER = new SqlParameter("@DECOBS2_RESER", SqlDbType.Decimal);
            prmDECOBS2_RESER.Value = miClass.decObs2_reser;
            myCommand.Parameters.Add(prmDECOBS2_RESER);

            SqlParameter prmDTOBS1_RESER = new SqlParameter("@DTOBS1_RESER", SqlDbType.DateTime);
            prmDTOBS1_RESER.Value = miClass.dtObs1_reser;
            myCommand.Parameters.Add(prmDTOBS1_RESER);

            SqlParameter prmDTOBS2_RESER = new SqlParameter("@DTOBS2_RESER", SqlDbType.DateTime);
            prmDTOBS2_RESER.Value = miClass.dtObs2_reser;
            myCommand.Parameters.Add(prmDTOBS2_RESER);

            int intReturb = 0;
            try
            {
                myConnection.Open();
                intReturb = myCommand.ExecuteNonQuery();
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
                myConnection.Close();
                myCommand.Dispose();
                myConnection.Dispose();
            }
            return intReturb;
        }

        ///////////////// Método Add SobreCargado /////////////////
        public int Add(
            string _strCod_reser,
            string _strCod_lab,
            string _strCod_Mate,
            string _cedula_alu,
            string _strCod_unidTem,
            string _strTema_reser,
            string _strDescripcion_reser,
            string _strMateriales_reser,
            DateTime _dtFechainicio_reser,
            DateTime _dtFechaFin_reser,
            int _intTotalAsistente_reser,
            string _strColor_reser,
            string _strEstado_reser,
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
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_RESERVA", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = _strCod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@STRCOD_LAB", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = _strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmSTRCOD_MATE = new SqlParameter("@STRCOD_MATE", SqlDbType.NVarChar);
            prmSTRCOD_MATE.Value = _strCod_Mate;
            myCommand.Parameters.Add(prmSTRCOD_MATE);

            SqlParameter prmCEDULA_ALU = new SqlParameter("@CEDULA_ALU", SqlDbType.NVarChar);
            prmCEDULA_ALU.Value = _cedula_alu;
            myCommand.Parameters.Add(prmCEDULA_ALU);

            SqlParameter prmSTRCOD_UNIDTEM = new SqlParameter("@STRCOD_UNIDTEM", SqlDbType.NVarChar);
            prmSTRCOD_UNIDTEM.Value = _strCod_unidTem;
            myCommand.Parameters.Add(prmSTRCOD_UNIDTEM);

            SqlParameter prmSTRTEMA_RESER = new SqlParameter("@STRTEMA_RESER", SqlDbType.NVarChar);
            prmSTRTEMA_RESER.Value = _strTema_reser;
            myCommand.Parameters.Add(prmSTRTEMA_RESER);

            SqlParameter prmSTRDESCRIPCION_RESER = new SqlParameter("@STRDESCRIPCION_RESER", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_RESER.Value = _strDescripcion_reser;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_RESER);

            SqlParameter prmSTRMATERIALES_RESER = new SqlParameter("@STRMATERIALES_RESER", SqlDbType.NVarChar);
            prmSTRMATERIALES_RESER.Value = _strMateriales_reser;
            myCommand.Parameters.Add(prmSTRMATERIALES_RESER);

            SqlParameter prmDTFECHAINICIO_RESER = new SqlParameter("@DTFECHAINICIO_RESER", SqlDbType.DateTime);
            prmDTFECHAINICIO_RESER.Value = _dtFechainicio_reser;
            myCommand.Parameters.Add(prmDTFECHAINICIO_RESER);

            SqlParameter prmDTFECHAFIN_RESER = new SqlParameter("@DTFECHAFIN_RESER", SqlDbType.DateTime);
            prmDTFECHAFIN_RESER.Value = _dtFechaFin_reser;
            myCommand.Parameters.Add(prmDTFECHAFIN_RESER);

            SqlParameter prmINTTOTALASISTENTE_RESER = new SqlParameter("@INTTOTALASISTENTE_RESER", SqlDbType.Int);
            prmINTTOTALASISTENTE_RESER.Value = _intTotalAsistente_reser;
            myCommand.Parameters.Add(prmINTTOTALASISTENTE_RESER);

            SqlParameter prmSTRCOLOR_RESER = new SqlParameter("@STRCOLOR_RESER", SqlDbType.NVarChar);
            prmSTRCOLOR_RESER.Value = _strColor_reser;
            myCommand.Parameters.Add(prmSTRCOLOR_RESER);

            SqlParameter prmSTRESTADO_RESER = new SqlParameter("@STRESTADO_RESER", SqlDbType.NVarChar);
            prmSTRESTADO_RESER.Value = _strEstado_reser;
            myCommand.Parameters.Add(prmSTRESTADO_RESER);

            SqlParameter prmBITESTADO_RESER = new SqlParameter("@BITESTADO_RESER", SqlDbType.Bit);
            prmBITESTADO_RESER.Value = _bitEstado_reser;
            myCommand.Parameters.Add(prmBITESTADO_RESER);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESER = new SqlParameter("@STROBS1_RESER", SqlDbType.NVarChar);
            prmSTROBS1_RESER.Value = _strObs1_reser;
            myCommand.Parameters.Add(prmSTROBS1_RESER);

            SqlParameter prmSTROBS2_RESER = new SqlParameter("@STROBS2_RESER", SqlDbType.NVarChar);
            prmSTROBS2_RESER.Value = _strObs2_reser;
            myCommand.Parameters.Add(prmSTROBS2_RESER);

            SqlParameter prmBITOBS1_RESER = new SqlParameter("@BITOBS1_RESER", SqlDbType.Bit);
            prmBITOBS1_RESER.Value = _bitObs1_reser;
            myCommand.Parameters.Add(prmBITOBS1_RESER);

            SqlParameter prmBITOBS2_RESER = new SqlParameter("@BITOBS2_RESER", SqlDbType.Bit);
            prmBITOBS2_RESER.Value = _bitObs2_reser;
            myCommand.Parameters.Add(prmBITOBS2_RESER);

            SqlParameter prmDECOBS1_RESER = new SqlParameter("@DECOBS1_RESER", SqlDbType.Decimal);
            prmDECOBS1_RESER.Value = _decObs1_reser;
            myCommand.Parameters.Add(prmDECOBS1_RESER);

            SqlParameter prmDECOBS2_RESER = new SqlParameter("@DECOBS2_RESER", SqlDbType.Decimal);
            prmDECOBS2_RESER.Value = _decObs2_reser;
            myCommand.Parameters.Add(prmDECOBS2_RESER);

            SqlParameter prmDTOBS1_RESER = new SqlParameter("@DTOBS1_RESER", SqlDbType.DateTime);
            prmDTOBS1_RESER.Value = _dtObs1_reser;
            myCommand.Parameters.Add(prmDTOBS1_RESER);

            SqlParameter prmDTOBS2_RESER = new SqlParameter("@DTOBS2_RESER", SqlDbType.DateTime);
            prmDTOBS2_RESER.Value = _dtObs2_reser;
            myCommand.Parameters.Add(prmDTOBS2_RESER);

            int intReturb = -1;
            try
            {
                myConnection.Open();
                intReturb = myCommand.ExecuteNonQuery();
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
                myConnection.Close();
                myCommand.Dispose();
                myConnection.Dispose();
            }
            return intReturb;
        }

        ///////////////// Método Update /////////////////
        public int UpdateLAB_RESERVA(LAB_RESERVA miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_RESERVA", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = miClass.strCod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmCEDULA_ALU = new SqlParameter("@CEDULA_ALU", SqlDbType.NVarChar);
            prmCEDULA_ALU.Value = miClass.cedula_alu;
            myCommand.Parameters.Add(prmCEDULA_ALU);

            SqlParameter prmSTRCOD_UNIDTEM = new SqlParameter("@STRCOD_UNIDTEM", SqlDbType.NVarChar);
            prmSTRCOD_UNIDTEM.Value = miClass.strCod_unidTem;
            myCommand.Parameters.Add(prmSTRCOD_UNIDTEM);

            SqlParameter prmSTRTEMA_RESER = new SqlParameter("@STRTEMA_RESER", SqlDbType.NVarChar);
            prmSTRTEMA_RESER.Value = miClass.strTema_reser;
            myCommand.Parameters.Add(prmSTRTEMA_RESER);

            SqlParameter prmSTRDESCRIPCION_RESER = new SqlParameter("@STRDESCRIPCION_RESER", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_RESER.Value = miClass.strDescripcion_reser;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_RESER);

            SqlParameter prmSTRMATERIALES_RESER = new SqlParameter("@STRMATERIALES_RESER", SqlDbType.NVarChar);
            prmSTRMATERIALES_RESER.Value = miClass.strMateriales_reser;
            myCommand.Parameters.Add(prmSTRMATERIALES_RESER);

            SqlParameter prmSTRCOLOR_RESER = new SqlParameter("@STRCOLOR_RESER", SqlDbType.NVarChar);
            prmSTRCOLOR_RESER.Value = miClass.strColor_reser;
            myCommand.Parameters.Add(prmSTRCOLOR_RESER);

            SqlParameter prmSTRESTADO_RESER = new SqlParameter("@STRESTADO_RESER", SqlDbType.NVarChar);
            prmSTRESTADO_RESER.Value = miClass.strEstado_reser;
            myCommand.Parameters.Add(prmSTRESTADO_RESER);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            int intReturb = -1;
            try
            {
                myConnection.Open();
                intReturb = myCommand.ExecuteNonQuery();
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
                myConnection.Close();
                myCommand.Dispose();
                myConnection.Dispose();
            }
            return intReturb;
        }

        ///////////////// Método Update SobreCargado  /////////////////
        public int UpdateLAB_RESERVA(
            string _strCod_reser,
            string _cedula_alu,
            string _strCod_unidTem,
            string _strTema_reser,
            string _strDescripcion_reser,
            string _strMateriales_reser,
            string _strColor_reser,
            string _strEstado_reser,
            DateTime _dtFecha_log,
            string _strUser_log
            )
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_RESERVA", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = _strCod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmCEDULA_ALU = new SqlParameter("@CEDULA_ALU", SqlDbType.NVarChar);
            prmCEDULA_ALU.Value = _cedula_alu;
            myCommand.Parameters.Add(prmCEDULA_ALU);

            SqlParameter prmSTRCOD_UNIDTEM = new SqlParameter("@STRCOD_UNIDTEM", SqlDbType.NVarChar);
            prmSTRCOD_UNIDTEM.Value = _strCod_unidTem;
            myCommand.Parameters.Add(prmSTRCOD_UNIDTEM);

            SqlParameter prmSTRTEMA_RESER = new SqlParameter("@STRTEMA_RESER", SqlDbType.NVarChar);
            prmSTRTEMA_RESER.Value = _strTema_reser;
            myCommand.Parameters.Add(prmSTRTEMA_RESER);

            SqlParameter prmSTRDESCRIPCION_RESER = new SqlParameter("@STRDESCRIPCION_RESER", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_RESER.Value = _strDescripcion_reser;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_RESER);

            SqlParameter prmSTRMATERIALES_RESER = new SqlParameter("@STRMATERIALES_RESER", SqlDbType.NVarChar);
            prmSTRMATERIALES_RESER.Value = _strMateriales_reser;
            myCommand.Parameters.Add(prmSTRMATERIALES_RESER);

            SqlParameter prmSTRCOLOR_RESER = new SqlParameter("@STRCOLOR_RESER", SqlDbType.NVarChar);
            prmSTRCOLOR_RESER.Value = _strColor_reser;
            myCommand.Parameters.Add(prmSTRCOLOR_RESER);

            SqlParameter prmSTRESTADO_RESER = new SqlParameter("@STRESTADO_RESER", SqlDbType.NVarChar);
            prmSTRESTADO_RESER.Value = _strEstado_reser;
            myCommand.Parameters.Add(prmSTRESTADO_RESER);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            int intReturb = -1;

            try
            {
                myConnection.Open();
                intReturb = myCommand.ExecuteNonQuery();
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
                myConnection.Close();
                myCommand.Dispose();
                myConnection.Dispose();
            }
            return intReturb;
        }

        ///////////////// Método Delete /////////////////
        public int DeleteLAB_RESERVA(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_DeleteLAB_RESERVA", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmComodin = new SqlParameter("@Comodin", SqlDbType.VarChar);
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