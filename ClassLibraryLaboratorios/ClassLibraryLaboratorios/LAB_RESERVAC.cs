
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
    public class LAB_RESERVAC
    {
        public LAB_RESERVAC() { }

        public LAB_RESERVAC(
            string _strCod_reserc,
            string _strCod_lab,
            string _strCod_Mate,
            string _cedula_alu,
            string _strCod_unidTem,
            string _strTema_reserc,
            string _strProposito_reserc,
            bool _bitTipo_reserc,
            string _strDescripcion_reserc,
            string _strMateriales_reserc,
            DateTime _dtFechainicio_reserc,
            DateTime _dtFechaFin_reserc,
            int _intTotalAsistente_reserc,
            string _strColor_reserc,
            DateTime _dtFechaRegistro_reserc,
            bool _bitEstado_reserc,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_reserc,
            string _strObs2_reserc,
            bool _bitObs1_reserc,
            bool _bitObs2_reserc,
            decimal _decObs1_reserc,
            decimal _decObs2_reserc,
            DateTime _dtObs1_reserc,
            DateTime _dtObs2_reserc
        )
        {
            strCod_reserc = _strCod_reserc;
            strCod_lab = _strCod_lab;
            strCod_Mate = _strCod_Mate;
            cedula_alu = _cedula_alu;
            strCod_unidTem = _strCod_unidTem;
            strTema_reserc = _strTema_reserc;
            strProposito_reserc = _strProposito_reserc;
            bitTipo_reserc = _bitTipo_reserc;
            strDescripcion_reserc = _strDescripcion_reserc;
            strMateriales_reserc = _strMateriales_reserc;
            dtFechainicio_reserc = _dtFechainicio_reserc;
            dtFechaFin_reserc = _dtFechaFin_reserc;
            intTotalAsistente_reserc = _intTotalAsistente_reserc;
            strColor_reserc = _strColor_reserc;
            dtFechaRegistro_reserc = _dtFechaRegistro_reserc;
            bitEstado_reserc = _bitEstado_reserc;
            dtFecha_log = _dtFecha_log;
            strUser_log = _strUser_log;
            strObs1_reserc = _strObs1_reserc;
            strObs2_reserc = _strObs2_reserc;
            bitObs1_reserc = _bitObs1_reserc;
            bitObs2_reserc = _bitObs2_reserc;
            decObs1_reserc = _decObs1_reserc;
            decObs2_reserc = _decObs2_reserc;
            dtObs1_reserc = _dtObs1_reserc;
            dtObs2_reserc = _dtObs2_reserc;


            numerr = 0;
            msg = string.Empty;
            resultado = false;
        }

        private string STRCOD_RESERC;
        private string STRCOD_LAB;
        private string STRCOD_MATE;
        private string CEDULA_ALU;
        private string STRCOD_UNIDTEM;
        private string STRTEMA_RESERC;
        private string STRPROPOSITO_RESERC;
        private bool BITTIPO_RESERC;
        private string STRDESCRIPCION_RESERC;
        private string STRMATERIALES_RESERC;
        private DateTime DTFECHAINICIO_RESERC;
        private DateTime DTFECHAFIN_RESERC;
        private int INTTOTALASISTENTE_RESERC;
        private string STRCOLOR_RESERC;
        private DateTime DTFECHAREGISTRO_RESERC;
        private bool BITESTADO_RESERC;
        private DateTime DTFECHA_LOG;
        private string STRUSER_LOG;
        private string STROBS1_RESERC;
        private string STROBS2_RESERC;
        private bool BITOBS1_RESERC;
        private bool BITOBS2_RESERC;
        private decimal DECOBS1_RESERC;
        private decimal DECOBS2_RESERC;
        private DateTime DTOBS1_RESERC;
        private DateTime DTOBS2_RESERC;
        private int NUMERR;
        private string MSG;
        private bool RESULTADO;

        ///////////////////// Generacion de propiedades/////////////////
        public string strCod_reserc
        {
            get
            {
                return STRCOD_RESERC;
            }
            set
            {
                STRCOD_RESERC = value;
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

        public string strTema_reserc
        {
            get
            {
                return STRTEMA_RESERC;
            }
            set
            {
                STRTEMA_RESERC = value;
            }
        }

        public string strProposito_reserc
        {
            get
            {
                return STRPROPOSITO_RESERC;
            }
            set
            {
                STRPROPOSITO_RESERC = value;
            }
        }

        public bool bitTipo_reserc
        {
            get
            {
                return BITTIPO_RESERC;
            }
            set
            {
                BITTIPO_RESERC = value;
            }
        }

        public string strDescripcion_reserc
        {
            get
            {
                return STRDESCRIPCION_RESERC;
            }
            set
            {
                STRDESCRIPCION_RESERC = value;
            }
        }

        public string strMateriales_reserc
        {
            get
            {
                return STRMATERIALES_RESERC;
            }
            set
            {
                STRMATERIALES_RESERC = value;
            }
        }

        public DateTime dtFechainicio_reserc
        {
            get
            {
                return DTFECHAINICIO_RESERC;
            }
            set
            {
                DTFECHAINICIO_RESERC = value;
            }
        }

        public DateTime dtFechaFin_reserc
        {
            get
            {
                return DTFECHAFIN_RESERC;
            }
            set
            {
                DTFECHAFIN_RESERC = value;
            }
        }

        public int intTotalAsistente_reserc
        {
            get
            {
                return INTTOTALASISTENTE_RESERC;
            }
            set
            {
                INTTOTALASISTENTE_RESERC = value;
            }
        }

        public string strColor_reserc
        {
            get
            {
                return STRCOLOR_RESERC;
            }
            set
            {
                STRCOLOR_RESERC = value;
            }
        }

        public DateTime dtFechaRegistro_reserc
        {
            get
            {
                return DTFECHAREGISTRO_RESERC;
            }
            set
            {
                DTFECHAREGISTRO_RESERC = value;
            }
        }

        public bool bitEstado_reserc
        {
            get
            {
                return BITESTADO_RESERC;
            }
            set
            {
                BITESTADO_RESERC = value;
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

        public string strObs1_reserc
        {
            get
            {
                return STROBS1_RESERC;
            }
            set
            {
                STROBS1_RESERC = value;
            }
        }

        public string strObs2_reserc
        {
            get
            {
                return STROBS2_RESERC;
            }
            set
            {
                STROBS2_RESERC = value;
            }
        }

        public bool bitObs1_reserc
        {
            get
            {
                return BITOBS1_RESERC;
            }
            set
            {
                BITOBS1_RESERC = value;
            }
        }

        public bool bitObs2_reserc
        {
            get
            {
                return BITOBS2_RESERC;
            }
            set
            {
                BITOBS2_RESERC = value;
            }
        }

        public decimal decObs1_reserc
        {
            get
            {
                return DECOBS1_RESERC;
            }
            set
            {
                DECOBS1_RESERC = value;
            }
        }

        public decimal decObs2_reserc
        {
            get
            {
                return DECOBS2_RESERC;
            }
            set
            {
                DECOBS2_RESERC = value;
            }
        }

        public DateTime dtObs1_reserc
        {
            get
            {
                return DTOBS1_RESERC;
            }
            set
            {
                DTOBS1_RESERC = value;
            }
        }

        public DateTime dtObs2_reserc
        {
            get
            {
                return DTOBS2_RESERC;
            }
            set
            {
                DTOBS2_RESERC = value;
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
        public List<LAB_RESERVAC> LoadLAB_RESERVAC(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<LAB_RESERVAC>();

            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
            {
                using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_RESERVAC", myConnection))
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
                                LAB_RESERVAC miClase = new LAB_RESERVAC()
                                {
                                    strCod_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_reserc"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_reserc"))),
                                    strCod_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))),
                                    strCod_Mate = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Mate"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Mate"))),
                                    cedula_alu = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("cedula_alu"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("cedula_alu"))),
                                    strCod_unidTem = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_unidTem"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_unidTem"))),
                                    strTema_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strTema_reserc"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strTema_reserc"))),
                                    strProposito_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strProposito_reserc"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strProposito_reserc"))),
                                    bitTipo_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitTipo_reserc"))) ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitTipo_reserc"))),
                                    strDescripcion_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strDescripcion_reserc"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strDescripcion_reserc"))),
                                    strMateriales_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strMateriales_reserc"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strMateriales_reserc"))),
                                    dtFechainicio_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechainicio_reserc"))) ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechainicio_reserc"))),
                                    dtFechaFin_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaFin_reserc"))) ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaFin_reserc"))),
                                    intTotalAsistente_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("intTotalAsistente_reserc"))) ? 0 : Convert.ToInt32(reader1.GetValue(reader1.GetOrdinal("intTotalAsistente_reserc"))),
                                    strColor_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strColor_reserc"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strColor_reserc"))),
                                    dtFechaRegistro_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_reserc"))) ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_reserc"))),
                                    bitEstado_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitEstado_reserc"))) ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitEstado_reserc"))),
                                    dtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    strUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strObs1_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_reserc"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_reserc"))),
                                    strObs2_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_reserc"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_reserc"))),
                                    bitObs1_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_reserc"))) ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_reserc"))),
                                    bitObs2_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_reserc"))) ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_reserc"))),
                                    decObs1_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_reserc"))) ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_reserc"))),
                                    decObs2_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_reserc"))) ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_reserc"))),
                                    dtObs1_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_reserc"))) ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_reserc"))),
                                    dtObs2_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_reserc"))) ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_reserc"))),

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
        public int AddLAB_RESERVAC(LAB_RESERVAC miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_RESERVAC", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESERC = new SqlParameter("@STRCOD_RESERC", SqlDbType.NVarChar);
            prmSTRCOD_RESERC.Value = miClass.strCod_reserc;
            myCommand.Parameters.Add(prmSTRCOD_RESERC);

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

            SqlParameter prmSTRTEMA_RESERC = new SqlParameter("@STRTEMA_RESERC", SqlDbType.NVarChar);
            prmSTRTEMA_RESERC.Value = miClass.strTema_reserc;
            myCommand.Parameters.Add(prmSTRTEMA_RESERC);

            SqlParameter prmSTRPROPOSITO_RESERC = new SqlParameter("@STRPROPOSITO_RESERC", SqlDbType.NVarChar);
            prmSTRPROPOSITO_RESERC.Value = miClass.strProposito_reserc;
            myCommand.Parameters.Add(prmSTRPROPOSITO_RESERC);

            SqlParameter prmBITTIPO_RESERC = new SqlParameter("@BITTIPO_RESERC", SqlDbType.Bit);
            prmBITTIPO_RESERC.Value = miClass.bitTipo_reserc;
            myCommand.Parameters.Add(prmBITTIPO_RESERC);

            SqlParameter prmSTRDESCRIPCION_RESERC = new SqlParameter("@STRDESCRIPCION_RESERC", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_RESERC.Value = miClass.strDescripcion_reserc;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_RESERC);

            SqlParameter prmSTRMATERIALES_RESERC = new SqlParameter("@STRMATERIALES_RESERC", SqlDbType.NVarChar);
            prmSTRMATERIALES_RESERC.Value = miClass.strMateriales_reserc;
            myCommand.Parameters.Add(prmSTRMATERIALES_RESERC);

            SqlParameter prmDTFECHAINICIO_RESERC = new SqlParameter("@DTFECHAINICIO_RESERC", SqlDbType.DateTime);
            prmDTFECHAINICIO_RESERC.Value = miClass.dtFechainicio_reserc;
            myCommand.Parameters.Add(prmDTFECHAINICIO_RESERC);

            SqlParameter prmDTFECHAFIN_RESERC = new SqlParameter("@DTFECHAFIN_RESERC", SqlDbType.DateTime);
            prmDTFECHAFIN_RESERC.Value = miClass.dtFechaFin_reserc;
            myCommand.Parameters.Add(prmDTFECHAFIN_RESERC);

            SqlParameter prmINTTOTALASISTENTE_RESERC = new SqlParameter("@INTTOTALASISTENTE_RESERC", SqlDbType.Int);
            prmINTTOTALASISTENTE_RESERC.Value = miClass.intTotalAsistente_reserc;
            myCommand.Parameters.Add(prmINTTOTALASISTENTE_RESERC);

            SqlParameter prmSTRCOLOR_RESERC = new SqlParameter("@STRCOLOR_RESERC", SqlDbType.NVarChar);
            prmSTRCOLOR_RESERC.Value = miClass.strColor_reserc;
            myCommand.Parameters.Add(prmSTRCOLOR_RESERC);

            SqlParameter prmDTFECHAREGISTRO_RESERC = new SqlParameter("@DTFECHAREGISTRO_RESERC", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_RESERC.Value = miClass.dtFechaRegistro_reserc;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_RESERC);

            SqlParameter prmBITESTADO_RESERC = new SqlParameter("@BITESTADO_RESERC", SqlDbType.Bit);
            prmBITESTADO_RESERC.Value = miClass.bitEstado_reserc;
            myCommand.Parameters.Add(prmBITESTADO_RESERC);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESERC = new SqlParameter("@STROBS1_RESERC", SqlDbType.NVarChar);
            prmSTROBS1_RESERC.Value = miClass.strObs1_reserc;
            myCommand.Parameters.Add(prmSTROBS1_RESERC);

            SqlParameter prmSTROBS2_RESERC = new SqlParameter("@STROBS2_RESERC", SqlDbType.NVarChar);
            prmSTROBS2_RESERC.Value = miClass.strObs2_reserc;
            myCommand.Parameters.Add(prmSTROBS2_RESERC);

            SqlParameter prmBITOBS1_RESERC = new SqlParameter("@BITOBS1_RESERC", SqlDbType.Bit);
            prmBITOBS1_RESERC.Value = miClass.bitObs1_reserc;
            myCommand.Parameters.Add(prmBITOBS1_RESERC);

            SqlParameter prmBITOBS2_RESERC = new SqlParameter("@BITOBS2_RESERC", SqlDbType.Bit);
            prmBITOBS2_RESERC.Value = miClass.bitObs2_reserc;
            myCommand.Parameters.Add(prmBITOBS2_RESERC);

            SqlParameter prmDECOBS1_RESERC = new SqlParameter("@DECOBS1_RESERC", SqlDbType.Decimal);
            prmDECOBS1_RESERC.Value = miClass.decObs1_reserc;
            myCommand.Parameters.Add(prmDECOBS1_RESERC);

            SqlParameter prmDECOBS2_RESERC = new SqlParameter("@DECOBS2_RESERC", SqlDbType.Decimal);
            prmDECOBS2_RESERC.Value = miClass.decObs2_reserc;
            myCommand.Parameters.Add(prmDECOBS2_RESERC);

            SqlParameter prmDTOBS1_RESERC = new SqlParameter("@DTOBS1_RESERC", SqlDbType.DateTime);
            prmDTOBS1_RESERC.Value = miClass.dtObs1_reserc;
            myCommand.Parameters.Add(prmDTOBS1_RESERC);

            SqlParameter prmDTOBS2_RESERC = new SqlParameter("@DTOBS2_RESERC", SqlDbType.DateTime);
            prmDTOBS2_RESERC.Value = miClass.dtObs2_reserc;
            myCommand.Parameters.Add(prmDTOBS2_RESERC);

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
        public int AddLAB_RESERVAC(
            string _strCod_reserc,
            string _strCod_lab,
            string _strCod_Mate,
            string _cedula_alu,
            string _strCod_unidTem,
            string _strTema_reserc,
            string _strProposito_reserc,
            bool _bitTipo_reserc,
            string _strDescripcion_reserc,
            string _strMateriales_reserc,
            DateTime _dtFechainicio_reserc,
            DateTime _dtFechaFin_reserc,
            int _intTotalAsistente_reserc,
            string _strColor_reserc,
            DateTime _dtFechaRegistro_reserc,
            bool _bitEstado_reserc,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_reserc,
            string _strObs2_reserc,
            bool _bitObs1_reserc,
            bool _bitObs2_reserc,
            decimal _decObs1_reserc,
            decimal _decObs2_reserc,
            DateTime _dtObs1_reserc,
            DateTime _dtObs2_reserc
        )
        {

            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_RESERVAC", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESERC = new SqlParameter("@STRCOD_RESERC", SqlDbType.NVarChar);
            prmSTRCOD_RESERC.Value = _strCod_reserc;
            myCommand.Parameters.Add(prmSTRCOD_RESERC);

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

            SqlParameter prmSTRTEMA_RESERC = new SqlParameter("@STRTEMA_RESERC", SqlDbType.NVarChar);
            prmSTRTEMA_RESERC.Value = _strTema_reserc;
            myCommand.Parameters.Add(prmSTRTEMA_RESERC);

            SqlParameter prmSTRPROPOSITO_RESERC = new SqlParameter("@STRPROPOSITO_RESERC", SqlDbType.NVarChar);
            prmSTRPROPOSITO_RESERC.Value = _strProposito_reserc;
            myCommand.Parameters.Add(prmSTRPROPOSITO_RESERC);

            SqlParameter prmBITTIPO_RESERC = new SqlParameter("@BITTIPO_RESERC", SqlDbType.Bit);
            prmBITTIPO_RESERC.Value = _bitTipo_reserc;
            myCommand.Parameters.Add(prmBITTIPO_RESERC);

            SqlParameter prmSTRDESCRIPCION_RESERC = new SqlParameter("@STRDESCRIPCION_RESERC", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_RESERC.Value = _strDescripcion_reserc;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_RESERC);

            SqlParameter prmSTRMATERIALES_RESERC = new SqlParameter("@STRMATERIALES_RESERC", SqlDbType.NVarChar);
            prmSTRMATERIALES_RESERC.Value = _strMateriales_reserc;
            myCommand.Parameters.Add(prmSTRMATERIALES_RESERC);

            SqlParameter prmDTFECHAINICIO_RESERC = new SqlParameter("@DTFECHAINICIO_RESERC", SqlDbType.DateTime);
            prmDTFECHAINICIO_RESERC.Value = _dtFechainicio_reserc;
            myCommand.Parameters.Add(prmDTFECHAINICIO_RESERC);

            SqlParameter prmDTFECHAFIN_RESERC = new SqlParameter("@DTFECHAFIN_RESERC", SqlDbType.DateTime);
            prmDTFECHAFIN_RESERC.Value = _dtFechaFin_reserc;
            myCommand.Parameters.Add(prmDTFECHAFIN_RESERC);

            SqlParameter prmINTTOTALASISTENTE_RESERC = new SqlParameter("@INTTOTALASISTENTE_RESERC", SqlDbType.Int);
            prmINTTOTALASISTENTE_RESERC.Value = _intTotalAsistente_reserc;
            myCommand.Parameters.Add(prmINTTOTALASISTENTE_RESERC);

            SqlParameter prmSTRCOLOR_RESERC = new SqlParameter("@STRCOLOR_RESERC", SqlDbType.NVarChar);
            prmSTRCOLOR_RESERC.Value = _strColor_reserc;
            myCommand.Parameters.Add(prmSTRCOLOR_RESERC);

            SqlParameter prmDTFECHAREGISTRO_RESERC = new SqlParameter("@DTFECHAREGISTRO_RESERC", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_RESERC.Value = _dtFechaRegistro_reserc;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_RESERC);

            SqlParameter prmBITESTADO_RESERC = new SqlParameter("@BITESTADO_RESERC", SqlDbType.Bit);
            prmBITESTADO_RESERC.Value = _bitEstado_reserc;
            myCommand.Parameters.Add(prmBITESTADO_RESERC);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESERC = new SqlParameter("@STROBS1_RESERC", SqlDbType.NVarChar);
            prmSTROBS1_RESERC.Value = _strObs1_reserc;
            myCommand.Parameters.Add(prmSTROBS1_RESERC);

            SqlParameter prmSTROBS2_RESERC = new SqlParameter("@STROBS2_RESERC", SqlDbType.NVarChar);
            prmSTROBS2_RESERC.Value = _strObs2_reserc;
            myCommand.Parameters.Add(prmSTROBS2_RESERC);

            SqlParameter prmBITOBS1_RESERC = new SqlParameter("@BITOBS1_RESERC", SqlDbType.Bit);
            prmBITOBS1_RESERC.Value = _bitObs1_reserc;
            myCommand.Parameters.Add(prmBITOBS1_RESERC);

            SqlParameter prmBITOBS2_RESERC = new SqlParameter("@BITOBS2_RESERC", SqlDbType.Bit);
            prmBITOBS2_RESERC.Value = _bitObs2_reserc;
            myCommand.Parameters.Add(prmBITOBS2_RESERC);

            SqlParameter prmDECOBS1_RESERC = new SqlParameter("@DECOBS1_RESERC", SqlDbType.Decimal);
            prmDECOBS1_RESERC.Value = _decObs1_reserc;
            myCommand.Parameters.Add(prmDECOBS1_RESERC);

            SqlParameter prmDECOBS2_RESERC = new SqlParameter("@DECOBS2_RESERC", SqlDbType.Decimal);
            prmDECOBS2_RESERC.Value = _decObs2_reserc;
            myCommand.Parameters.Add(prmDECOBS2_RESERC);

            SqlParameter prmDTOBS1_RESERC = new SqlParameter("@DTOBS1_RESERC", SqlDbType.DateTime);
            prmDTOBS1_RESERC.Value = _dtObs1_reserc;
            myCommand.Parameters.Add(prmDTOBS1_RESERC);

            SqlParameter prmDTOBS2_RESERC = new SqlParameter("@DTOBS2_RESERC", SqlDbType.DateTime);
            prmDTOBS2_RESERC.Value = _dtObs2_reserc;
            myCommand.Parameters.Add(prmDTOBS2_RESERC);

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


        ///////////////// Método Update /////////////////
        public int UpdateLAB_RESERVAC(LAB_RESERVAC miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_RESERVAC", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESERC = new SqlParameter("@STRCOD_RESERC", SqlDbType.NVarChar);
            prmSTRCOD_RESERC.Value = miClass.strCod_reserc;
            myCommand.Parameters.Add(prmSTRCOD_RESERC);

            SqlParameter prmSTRCOD_UNIDTEM = new SqlParameter("@STRCOD_UNIDTEM", SqlDbType.NVarChar);
            prmSTRCOD_UNIDTEM.Value = miClass.strCod_unidTem;
            myCommand.Parameters.Add(prmSTRCOD_UNIDTEM);

            SqlParameter prmSTRTEMA_RESERC = new SqlParameter("@STRTEMA_RESERC", SqlDbType.NVarChar);
            prmSTRTEMA_RESERC.Value = miClass.strTema_reserc;
            myCommand.Parameters.Add(prmSTRTEMA_RESERC);

            SqlParameter prmSTRPROPOSITO_RESERC = new SqlParameter("@STRPROPOSITO_RESERC", SqlDbType.NVarChar);
            prmSTRPROPOSITO_RESERC.Value = miClass.strProposito_reserc;
            myCommand.Parameters.Add(prmSTRPROPOSITO_RESERC);

            SqlParameter prmSTRDESCRIPCION_RESERC = new SqlParameter("@STRDESCRIPCION_RESERC", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_RESERC.Value = miClass.strDescripcion_reserc;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_RESERC);

            SqlParameter prmSTRMATERIALES_RESERC = new SqlParameter("@STRMATERIALES_RESERC", SqlDbType.NVarChar);
            prmSTRMATERIALES_RESERC.Value = miClass.strMateriales_reserc;
            myCommand.Parameters.Add(prmSTRMATERIALES_RESERC);

            SqlParameter prmSTRCOLOR_RESERC = new SqlParameter("@STRCOLOR_RESERC", SqlDbType.NVarChar);
            prmSTRCOLOR_RESERC.Value = miClass.strColor_reserc;
            myCommand.Parameters.Add(prmSTRCOLOR_RESERC);

            SqlParameter prmBITESTADO_RESERC = new SqlParameter("@BITESTADO_RESERC", SqlDbType.Bit);
            prmBITESTADO_RESERC.Value = miClass.bitEstado_reserc;
            myCommand.Parameters.Add(prmBITESTADO_RESERC);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESERC = new SqlParameter("@STROBS1_RESERC", SqlDbType.NVarChar);
            prmSTROBS1_RESERC.Value = miClass.strObs1_reserc;
            myCommand.Parameters.Add(prmSTROBS1_RESERC);

            SqlParameter prmSTROBS2_RESERC = new SqlParameter("@STROBS2_RESERC", SqlDbType.NVarChar);
            prmSTROBS2_RESERC.Value = miClass.strObs2_reserc;
            myCommand.Parameters.Add(prmSTROBS2_RESERC);

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
        public int UpdateLAB_RESERVAC(
            string _strCod_reserc,
            string _strCod_unidTem,
            string _strTema_reserc,
            string _strProposito_reserc,
            string _strDescripcion_reserc,
            string _strMateriales_reserc,
            string _strColor_reserc,
            bool _bitEstado_reserc,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_reserc,
            string _strObs2_reserc
        )
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_RESERVAC", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESERC = new SqlParameter("@STRCOD_RESERC", SqlDbType.NVarChar);
            prmSTRCOD_RESERC.Value = _strCod_reserc;
            myCommand.Parameters.Add(prmSTRCOD_RESERC);

            SqlParameter prmSTRCOD_UNIDTEM = new SqlParameter("@STRCOD_UNIDTEM", SqlDbType.NVarChar);
            prmSTRCOD_UNIDTEM.Value = _strCod_unidTem;
            myCommand.Parameters.Add(prmSTRCOD_UNIDTEM);

            SqlParameter prmSTRTEMA_RESERC = new SqlParameter("@STRTEMA_RESERC", SqlDbType.NVarChar);
            prmSTRTEMA_RESERC.Value = _strTema_reserc;
            myCommand.Parameters.Add(prmSTRTEMA_RESERC);

            SqlParameter prmSTRPROPOSITO_RESERC = new SqlParameter("@STRPROPOSITO_RESERC", SqlDbType.NVarChar);
            prmSTRPROPOSITO_RESERC.Value = _strProposito_reserc;
            myCommand.Parameters.Add(prmSTRPROPOSITO_RESERC);

            SqlParameter prmSTRDESCRIPCION_RESERC = new SqlParameter("@STRDESCRIPCION_RESERC", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_RESERC.Value = _strDescripcion_reserc;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_RESERC);

            SqlParameter prmSTRMATERIALES_RESERC = new SqlParameter("@STRMATERIALES_RESERC", SqlDbType.NVarChar);
            prmSTRMATERIALES_RESERC.Value = _strMateriales_reserc;
            myCommand.Parameters.Add(prmSTRMATERIALES_RESERC);

            SqlParameter prmSTRCOLOR_RESERC = new SqlParameter("@STRCOLOR_RESERC", SqlDbType.NVarChar);
            prmSTRCOLOR_RESERC.Value = _strColor_reserc;
            myCommand.Parameters.Add(prmSTRCOLOR_RESERC);

            SqlParameter prmBITESTADO_RESERC = new SqlParameter("@BITESTADO_RESERC", SqlDbType.Bit);
            prmBITESTADO_RESERC.Value = _bitEstado_reserc;
            myCommand.Parameters.Add(prmBITESTADO_RESERC);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESERC = new SqlParameter("@STROBS1_RESERC", SqlDbType.NVarChar);
            prmSTROBS1_RESERC.Value = _strObs1_reserc;
            myCommand.Parameters.Add(prmSTROBS1_RESERC);

            SqlParameter prmSTROBS2_RESERC = new SqlParameter("@STROBS2_RESERC", SqlDbType.NVarChar);
            prmSTROBS2_RESERC.Value = _strObs2_reserc;
            myCommand.Parameters.Add(prmSTROBS2_RESERC);

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

        public int DeleteLAB_RESERVAC(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_DelLAB_RESERVAC", myConnection);
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