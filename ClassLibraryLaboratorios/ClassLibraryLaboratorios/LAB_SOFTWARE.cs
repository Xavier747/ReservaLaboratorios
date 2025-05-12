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
    public class LAB_SOFTWARE
    {
        public LAB_SOFTWARE()
        {
        }

        public LAB_SOFTWARE(
        string _strCod_sof,
        string _strCod_Sede,
        string _strCod_Fac,
        string _strNombre_sof,
        string _strTipoLicencia_sof,
        string _strNombreLicencia_sof,
        int _intCantidad_sof,
        decimal _decCostoUnitario_sof,
        decimal _decCostoTotal_sof,
        string _strDescripcion_sof,
        string _strImagen_sof,
        string _strUrl_sof,
        DateTime _dtFechaRegistro_sof,
        bool _bitEstado_sof,
        DateTime _dtFecha_log,
        string _strUser_log,
        string _strObs1_sof,
        string _strObs2_sof,
        bool _bitObs1_sof,
        bool _bitObs2_sof,
        decimal _decObs1_sof,
        decimal _decObs2_sof,
        DateTime _dtObs1_sof,
        DateTime _dtObs2_sof)
        {
            strCod_sof = _strCod_sof;
            strCod_Sede = _strCod_Sede;
            strCod_Fac = _strCod_Fac;
            strNombre_sof = _strNombre_sof;
            strTipoLicencia_sof = _strTipoLicencia_sof;
            strNombreLicencia_sof = _strNombreLicencia_sof;
            intCantidad_sof = _intCantidad_sof;
            decCostoUnitario_sof = _decCostoUnitario_sof;
            decCostoTotal_sof = _decCostoTotal_sof;
            strDescripcion_sof = _strDescripcion_sof;
            strImagen_sof = _strImagen_sof;
            strUrl_sof = _strUrl_sof;
            dtFechaRegistro_sof = _dtFechaRegistro_sof;
            bitEstado_sof = _bitEstado_sof;
            dtFecha_log = _dtFecha_log;
            strUser_log = _strUser_log;
            strObs1_sof = _strObs1_sof;
            strObs2_sof = _strObs2_sof;
            bitObs1_sof = _bitObs1_sof;
            bitObs2_sof = _bitObs2_sof;
            decObs1_sof = _decObs1_sof;
            decObs2_sof = _decObs2_sof;
            dtObs1_sof = _dtObs1_sof;
            dtObs2_sof = _dtObs2_sof;

            numerr = 0;
            msg = string.Empty;
            resultado = false;
        }


        private string STRCOD_SOF;
        private string STRCOD_SEDE;
        private string STRCOD_FAC;
        private string STRNOMBRE_SOF;
        private string STRTIPOLICENCIA_SOF;
        private string STRNOMBRELICENCIA_SOF;
        private int INTCANTIDAD_SOF;
        private decimal DECCOSTOUNITARIO_SOF;
        private decimal DECCOSTOTOTAL_SOF;
        private string STRDESCRIPCION_SOF;
        private string STRIMAGEN_SOF;
        private string STRURL_SOF;
        private DateTime DTFECHAREGISTRO_SOF;
        private bool BITESTADO_SOF;
        private DateTime DTFECHA_LOG;
        private string STRUSER_LOG;
        private string STROBS1_SOF;
        private string STROBS2_SOF;
        private bool BITOBS1_SOF;
        private bool BITOBS2_SOF;
        private decimal DECOBS1_SOF;
        private decimal DECOBS2_SOF;
        private DateTime DTOBS1_SOF;
        private DateTime DTOBS2_SOF;
        private int NUMERR;
        private string MSG;
        private bool RESULTADO;
        ///////////////////// Generacion de propiedades/////////////////

        public string strCod_sof
        {
            get
            {
                return STRCOD_SOF;
            }
            set
            {
                STRCOD_SOF = value;
            }
        }

        public string strCod_Sede
        {
            get
            {
                return STRCOD_SEDE;
            }
            set
            {
                STRCOD_SEDE = value;
            }
        }

        public string strCod_Fac
        {
            get
            {
                return STRCOD_FAC;
            }
            set
            {
                STRCOD_FAC = value;
            }
        }

        public string strNombre_sof
        {
            get
            {
                return STRNOMBRE_SOF;
            }
            set
            {
                STRNOMBRE_SOF = value;
            }
        }

        public string strTipoLicencia_sof
        {
            get
            {
                return STRTIPOLICENCIA_SOF;
            }
            set
            {
                STRTIPOLICENCIA_SOF = value;
            }
        }

        public string strNombreLicencia_sof
        {
            get
            {
                return STRNOMBRELICENCIA_SOF;
            }
            set
            {
                STRNOMBRELICENCIA_SOF = value;
            }
        }

        public int intCantidad_sof
        {
            get
            {
                return INTCANTIDAD_SOF;
            }
            set
            {
                INTCANTIDAD_SOF = value;
            }
        }

        public decimal decCostoUnitario_sof
        {
            get
            {
                return DECCOSTOUNITARIO_SOF;
            }
            set
            {
                DECCOSTOUNITARIO_SOF = value;
            }
        }

        public decimal decCostoTotal_sof
        {
            get
            {
                return DECCOSTOTOTAL_SOF;
            }
            set
            {
                DECCOSTOTOTAL_SOF = value;
            }
        }

        public string strDescripcion_sof
        {
            get
            {
                return STRDESCRIPCION_SOF;
            }
            set
            {
                STRDESCRIPCION_SOF = value;
            }
        }

        public string strImagen_sof
        {
            get
            {
                return STRIMAGEN_SOF;
            }
            set
            {
                STRIMAGEN_SOF = value;
            }
        }

        public string strUrl_sof
        {
            get
            {
                return STRURL_SOF;
            }
            set
            {
                STRURL_SOF = value;
            }
        }

        public DateTime dtFechaRegistro_sof
        {
            get
            {
                return DTFECHAREGISTRO_SOF;
            }
            set
            {
                DTFECHAREGISTRO_SOF = value;
            }
        }

        public bool bitEstado_sof
        {
            get
            {
                return BITESTADO_SOF;
            }
            set
            {
                BITESTADO_SOF = value;
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

        public string strObs1_sof
        {
            get
            {
                return STROBS1_SOF;
            }
            set
            {
                STROBS1_SOF = value;
            }
        }

        public string strObs2_sof
        {
            get
            {
                return STROBS2_SOF;
            }
            set
            {
                STROBS2_SOF = value;
            }
        }

        public bool bitObs1_sof
        {
            get
            {
                return BITOBS1_SOF;
            }
            set
            {
                BITOBS1_SOF = value;
            }
        }

        public bool bitObs2_sof
        {
            get
            {
                return BITOBS2_SOF;
            }
            set
            {
                BITOBS2_SOF = value;
            }
        }

        public decimal decObs1_sof
        {
            get
            {
                return DECOBS1_SOF;
            }
            set
            {
                DECOBS1_SOF = value;
            }
        }

        public decimal decObs2_sof
        {
            get
            {
                return DECOBS2_SOF;
            }
            set
            {
                DECOBS2_SOF = value;
            }
        }

        public DateTime dtObs1_sof
        {
            get
            {
                return DTOBS1_SOF;
            }
            set
            {
                DTOBS1_SOF = value;
            }
        }


        public DateTime dtObs2_sof
        {
            get
            {
                return DTOBS2_SOF;
            }
            set
            {
                DTOBS2_SOF = value;
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
        public List<LAB_SOFTWARE> LoadLAB_SOFTWARE(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<LAB_SOFTWARE>();
            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
            {
                using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_SOFTWARE", myConnection))
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
                                LAB_SOFTWARE miClase = new LAB_SOFTWARE()
                                {
                                    strCod_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strcod_sof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strcod_sof"))),
                                    strCod_Sede = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strcod_Sede"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strcod_Sede"))),
                                    strCod_Fac = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strcod_Fac"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strcod_Fac"))),
                                    strNombre_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strNombre_sof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strNombre_sof"))),
                                    strTipoLicencia_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strTipoLicencia_sof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strTipoLicencia_sof"))),
                                    strNombreLicencia_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strNombreLicencia_sof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strNombreLicencia_sof"))),
                                    intCantidad_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("intCantidad_sof"))) == true ? 0 : Convert.ToInt32(reader1.GetValue(reader1.GetOrdinal("intCantidad_sof"))),
                                    decCostoUnitario_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decCostoUnitario_sof"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decCostoUnitario_sof"))),
                                    decCostoTotal_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decCostoTotal_sof"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decCostoTotal_sof"))),
                                    strDescripcion_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strDescripcion_sof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strDescripcion_sof"))),
                                    strImagen_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strImagen_sof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strImagen_sof"))),
                                    strUrl_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUrl_sof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUrl_sof"))),
                                    dtFechaRegistro_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_sof"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_sof"))),
                                    bitEstado_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitEstado_sof"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitEstado_sof"))),
                                    dtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    strUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strObs1_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_sof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_sof"))),
                                    strObs2_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_sof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_sof"))),
                                    bitObs1_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_sof"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_sof"))),
                                    bitObs2_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_sof"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_sof"))),
                                    decObs1_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_sof"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_sof"))),
                                    decObs2_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_sof"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_sof"))),
                                    dtObs1_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_sof"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_sof"))),
                                    dtObs2_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_sof"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_sof"))),
                                    numerr = 0,
                                    msg = "Datos extraidos satisfactoriamente...",
                                    resultado = true

                                };
                                listG.Add(miClase);
                            }
                            myConnection.Close();
                        }
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
        public int AddLAB_SOFTWARE(LAB_SOFTWARE miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_SOFTWARE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = miClass.strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = miClass.strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = miClass.strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRNOMBRE_SOF = new SqlParameter("@STRNOMBRE_SOF", SqlDbType.NVarChar);
            prmSTRNOMBRE_SOF.Value = miClass.strNombre_sof;
            myCommand.Parameters.Add(prmSTRNOMBRE_SOF);

            SqlParameter prmSTRTIPOLICENCIA_SOF = new SqlParameter("@STRTIPOLICENCIA_SOF", SqlDbType.NVarChar);
            prmSTRTIPOLICENCIA_SOF.Value = miClass.strTipoLicencia_sof;
            myCommand.Parameters.Add(prmSTRTIPOLICENCIA_SOF);

            SqlParameter prmSTRNOMBRELICENCIA_SOF = new SqlParameter("@STRNOMBRELICENCIA_SOF", SqlDbType.NVarChar);
            prmSTRNOMBRELICENCIA_SOF.Value = miClass.strNombreLicencia_sof;
            myCommand.Parameters.Add(prmSTRNOMBRELICENCIA_SOF);

            SqlParameter prmINTCANTIDAD_SOF = new SqlParameter("@INTCANTIDAD_SOF", SqlDbType.Int);
            prmINTCANTIDAD_SOF.Value = miClass.intCantidad_sof;
            myCommand.Parameters.Add(prmINTCANTIDAD_SOF);

            SqlParameter prmDECCOSTOUNITARIO_SOF = new SqlParameter("@DECCOSTOUNITARIO_SOF", SqlDbType.Decimal);
            prmDECCOSTOUNITARIO_SOF.Value = miClass.decCostoUnitario_sof;
            myCommand.Parameters.Add(prmDECCOSTOUNITARIO_SOF);

            SqlParameter prmDECCOSTOTOTAL_SOF = new SqlParameter("@DECCOSTOTOTAL_SOF", SqlDbType.Decimal);
            prmDECCOSTOTOTAL_SOF.Value = miClass.decCostoTotal_sof;
            myCommand.Parameters.Add(prmDECCOSTOTOTAL_SOF);

            SqlParameter prmSTRDESCRIPCION_SOF = new SqlParameter("@STRDESCRIPCION_SOF", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_SOF.Value = miClass.strDescripcion_sof;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_SOF);

            SqlParameter prmSTRIMAGEN_SOF = new SqlParameter("@STRIMAGEN_SOF", SqlDbType.NVarChar);
            prmSTRIMAGEN_SOF.Value = miClass.strImagen_sof;
            myCommand.Parameters.Add(prmSTRIMAGEN_SOF);

            SqlParameter prmSTRURL_SOF = new SqlParameter("@STRURL_SOF", SqlDbType.NVarChar);
            prmSTRURL_SOF.Value = miClass.strUrl_sof;
            myCommand.Parameters.Add(prmSTRURL_SOF);

            SqlParameter prmDTFECHAREGISTRO_SOF = new SqlParameter("@DTFECHAREGISTRO_SOF", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_SOF.Value = miClass.dtFechaRegistro_sof;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_SOF);

            SqlParameter prmBITESTADO_SOF = new SqlParameter("@BITESTADO_SOF", SqlDbType.Bit);
            prmBITESTADO_SOF.Value = miClass.bitEstado_sof;
            myCommand.Parameters.Add(prmBITESTADO_SOF);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_SOF = new SqlParameter("@STROBS1_SOF", SqlDbType.NVarChar);
            prmSTROBS1_SOF.Value = miClass.strObs1_sof;
            myCommand.Parameters.Add(prmSTROBS1_SOF);

            SqlParameter prmSTROBS2_SOF = new SqlParameter("@STROBS2_SOF", SqlDbType.NVarChar);
            prmSTROBS2_SOF.Value = miClass.strObs2_sof;
            myCommand.Parameters.Add(prmSTROBS2_SOF);

            SqlParameter prmBITOBS1_SOF = new SqlParameter("@BITOBS1_SOF", SqlDbType.Bit);
            prmBITOBS1_SOF.Value = miClass.bitObs1_sof;
            myCommand.Parameters.Add(prmBITOBS1_SOF);

            SqlParameter prmBITOBS2_SOF = new SqlParameter("@BITOBS2_SOF", SqlDbType.Bit);
            prmBITOBS2_SOF.Value = miClass.bitObs2_sof;
            myCommand.Parameters.Add(prmBITOBS2_SOF);

            SqlParameter prmDECOBS1_SOF = new SqlParameter("@DECOBS1_SOF", SqlDbType.Decimal);
            prmDECOBS1_SOF.Value = miClass.decObs1_sof;
            myCommand.Parameters.Add(prmDECOBS1_SOF);

            SqlParameter prmDECOBS2_SOF = new SqlParameter("@DECOBS2_SOF", SqlDbType.Decimal);
            prmDECOBS2_SOF.Value = miClass.decObs2_sof;
            myCommand.Parameters.Add(prmDECOBS2_SOF);

            SqlParameter prmDTOBS1_SOF = new SqlParameter("@DTOBS1_SOF", SqlDbType.DateTime);
            prmDTOBS1_SOF.Value = miClass.dtObs1_sof;
            myCommand.Parameters.Add(prmDTOBS1_SOF);

            SqlParameter prmDTOBS2_SOF = new SqlParameter("@DTOBS2_SOF", SqlDbType.DateTime);
            prmDTOBS2_SOF.Value = miClass.dtObs2_sof;
            myCommand.Parameters.Add(prmDTOBS2_SOF);

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
        public int AddLAB_SOFTWARE(
        string _strCod_sof,
        string _strCod_Sede,
        string _strCod_Fac,
        string _strNombre_sof,
        string _strTipoLicencia_sof,
        string _strNombreLicencia_sof,
        int _intCantidad_sof,
        decimal _decCostoUnitario_sof,
        decimal _decCostoTotal_sof,
        string _strDescripcion_sof,
        string _strImagen_sof,
        string _strUrl_sof,
        DateTime _dtFechaRegistro_sof,
        bool _bitEstado_sof,
        DateTime _dtFecha_log,
        string _strUser_log,
        string _strObs1_sof,
        string _strObs2_sof,
        bool _bitObs1_sof,
        bool _bitObs2_sof,
        decimal _decObs1_sof,
        decimal _decObs2_sof,
        DateTime _dtObs1_sof,
        DateTime _dtObs2_sof)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand(" SIGUTC_AddLAB_SOFTWARE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = _strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = _strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = _strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRNOMBRE_SOF = new SqlParameter("@STRNOMBRE_SOF", SqlDbType.NVarChar);
            prmSTRNOMBRE_SOF.Value = _strNombre_sof;
            myCommand.Parameters.Add(prmSTRNOMBRE_SOF);

            SqlParameter prmSTRTIPOLICENCIA_SOF = new SqlParameter("@STRTIPOLICENCIA_SOF", SqlDbType.NVarChar);
            prmSTRTIPOLICENCIA_SOF.Value = _strTipoLicencia_sof;
            myCommand.Parameters.Add(prmSTRTIPOLICENCIA_SOF);

            SqlParameter prmSTRNOMBRELICENCIA_SOF = new SqlParameter("@STRNOMBRELICENCIA_SOF", SqlDbType.NVarChar);
            prmSTRNOMBRELICENCIA_SOF.Value = _strNombreLicencia_sof;
            myCommand.Parameters.Add(prmSTRNOMBRELICENCIA_SOF);

            SqlParameter prmINTCANTIDAD_SOF = new SqlParameter("@INTCANTIDAD_SOF", SqlDbType.Int);
            prmINTCANTIDAD_SOF.Value = _intCantidad_sof;
            myCommand.Parameters.Add(prmINTCANTIDAD_SOF);

            SqlParameter prmDECCOSTOUNITARIO_SOF = new SqlParameter("@DECCOSTOUNITARIO_SOF", SqlDbType.Decimal);
            prmDECCOSTOUNITARIO_SOF.Value = _decCostoUnitario_sof;
            myCommand.Parameters.Add(prmDECCOSTOUNITARIO_SOF);

            SqlParameter prmDECCOSTOTOTAL_SOF = new SqlParameter("@DECCOSTOTOTAL_SOF", SqlDbType.Decimal);
            prmDECCOSTOTOTAL_SOF.Value = _decCostoTotal_sof;
            myCommand.Parameters.Add(prmDECCOSTOTOTAL_SOF);

            SqlParameter prmSTRDESCRIPCION_SOF = new SqlParameter("@STRDESCRIPCION_SOF", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_SOF.Value = _strDescripcion_sof;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_SOF);

            SqlParameter prmSTRIMAGEN_SOF = new SqlParameter("@STRIMAGEN_SOF", SqlDbType.NVarChar);
            prmSTRIMAGEN_SOF.Value = _strImagen_sof;
            myCommand.Parameters.Add(prmSTRIMAGEN_SOF);

            SqlParameter prmSTRURL_SOF = new SqlParameter("@STRURL_SOF", SqlDbType.NVarChar);
            prmSTRURL_SOF.Value = _strUrl_sof;
            myCommand.Parameters.Add(prmSTRURL_SOF);

            SqlParameter prmDTFECHAREGISTRO_SOF = new SqlParameter("@DTFECHAREGISTRO_SOF", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_SOF.Value = _dtFechaRegistro_sof;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_SOF);

            SqlParameter prmBITESTADO_SOF = new SqlParameter("@BITESTADO_SOF", SqlDbType.Bit);
            prmBITESTADO_SOF.Value = _bitEstado_sof;
            myCommand.Parameters.Add(prmBITESTADO_SOF);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_SOF = new SqlParameter("@STROBS1_SOF", SqlDbType.NVarChar);
            prmSTROBS1_SOF.Value = _strObs1_sof;
            myCommand.Parameters.Add(prmSTROBS1_SOF);

            SqlParameter prmSTROBS2_SOF = new SqlParameter("@STROBS2_SOF", SqlDbType.NVarChar);
            prmSTROBS2_SOF.Value = _strObs2_sof;
            myCommand.Parameters.Add(prmSTROBS2_SOF);

            SqlParameter prmBITOBS1_SOF = new SqlParameter("@BITOBS1_SOF", SqlDbType.Bit);
            prmBITOBS1_SOF.Value = _bitObs1_sof;
            myCommand.Parameters.Add(prmBITOBS1_SOF);

            SqlParameter prmBITOBS2_SOF = new SqlParameter("@BITOBS2_SOF", SqlDbType.Bit);
            prmBITOBS2_SOF.Value = _bitObs2_sof;
            myCommand.Parameters.Add(prmBITOBS2_SOF);

            SqlParameter prmDECOBS1_SOF = new SqlParameter("@DECOBS1_SOF", SqlDbType.Decimal);
            prmDECOBS1_SOF.Value = _decObs1_sof;
            myCommand.Parameters.Add(prmDECOBS1_SOF);

            SqlParameter prmDECOBS2_SOF = new SqlParameter("@DECOBS2_SOF", SqlDbType.Decimal);
            prmDECOBS2_SOF.Value = _decObs2_sof;
            myCommand.Parameters.Add(prmDECOBS2_SOF);

            SqlParameter prmDTOBS1_SOF = new SqlParameter("@DTOBS1_SOF", SqlDbType.DateTime);
            prmDTOBS1_SOF.Value = _dtObs1_sof;
            myCommand.Parameters.Add(prmDTOBS1_SOF);

            SqlParameter prmDTOBS2_SOF = new SqlParameter("@DTOBS2_SOF", SqlDbType.DateTime);
            prmDTOBS2_SOF.Value = _dtObs2_sof;
            myCommand.Parameters.Add(prmDTOBS2_SOF);

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
        public int UpdateLAB_SOFTWARE(LAB_SOFTWARE miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_SOFTWARE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = miClass.strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = miClass.strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = miClass.strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRNOMBRE_SOF = new SqlParameter("@STRNOMBRE_SOF", SqlDbType.NVarChar);
            prmSTRNOMBRE_SOF.Value = miClass.strNombre_sof;
            myCommand.Parameters.Add(prmSTRNOMBRE_SOF);

            SqlParameter prmSTRTIPOLICENCIA_SOF = new SqlParameter("@STRTIPOLICENCIA_SOF", SqlDbType.NVarChar);
            prmSTRTIPOLICENCIA_SOF.Value = miClass.strTipoLicencia_sof;
            myCommand.Parameters.Add(prmSTRTIPOLICENCIA_SOF);

            SqlParameter prmSTRNOMBRELICENCIA_SOF = new SqlParameter("@STRNOMBRELICENCIA_SOF", SqlDbType.NVarChar);
            prmSTRNOMBRELICENCIA_SOF.Value = miClass.strNombreLicencia_sof;
            myCommand.Parameters.Add(prmSTRNOMBRELICENCIA_SOF);

            SqlParameter prmINTCANTIDAD_SOF = new SqlParameter("@INTCANTIDAD_SOF", SqlDbType.Int);
            prmINTCANTIDAD_SOF.Value = miClass.intCantidad_sof;
            myCommand.Parameters.Add(prmINTCANTIDAD_SOF);

            SqlParameter prmDECCOSTOUNITARIO_SOF = new SqlParameter("@DECCOSTOUNITARIO_SOF", SqlDbType.Decimal);
            prmDECCOSTOUNITARIO_SOF.Value = miClass.decCostoUnitario_sof;
            myCommand.Parameters.Add(prmDECCOSTOUNITARIO_SOF);

            SqlParameter prmDECCOSTOTOTAL_SOF = new SqlParameter("@DECCOSTOTOTAL_SOF", SqlDbType.Decimal);
            prmDECCOSTOTOTAL_SOF.Value = miClass.decCostoTotal_sof;
            myCommand.Parameters.Add(prmDECCOSTOTOTAL_SOF);

            SqlParameter prmSTRDESCRIPCION_SOF = new SqlParameter("@STRDESCRIPCION_SOF", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_SOF.Value = miClass.strDescripcion_sof;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_SOF);

            SqlParameter prmSTRIMAGEN_SOF = new SqlParameter("@STRIMAGEN_SOF", SqlDbType.NVarChar);
            prmSTRIMAGEN_SOF.Value = miClass.strImagen_sof;
            myCommand.Parameters.Add(prmSTRIMAGEN_SOF);

            SqlParameter prmSTRURL_SOF = new SqlParameter("@STRURL_SOF", SqlDbType.NVarChar);
            prmSTRURL_SOF.Value = miClass.strUrl_sof;
            myCommand.Parameters.Add(prmSTRURL_SOF);

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
                intReturb = myCommand.ExecuteNonQuery(); //devuelve el número de registros afectados en la bd
                resultado = true;
                msg = "El registro se actualizó satisfactoriamente...";
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

        ///////////////// Método Update Sobrecargado /////////////////

        public int UpdateLAB_SOFTWARE(
            string _strCod_sof,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strNombre_sof,
            string _strTipoLicencia_sof,
            string _strNombreLicencia_sof,
            int _intCantidad_sof,
            decimal _decCostoUnitario_sof,
            decimal _decCostoTotal_sof,
            string _strDescripcion_sof,
            string _strImagen_sof,
            string _strUrl_sof,
            DateTime _dtFecha_log,
            string _strUser_log)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_SOFTWARE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = _strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = _strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = _strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRNOMBRE_SOF = new SqlParameter("@STRNOMBRE_SOF", SqlDbType.NVarChar);
            prmSTRNOMBRE_SOF.Value = _strNombre_sof;
            myCommand.Parameters.Add(prmSTRNOMBRE_SOF);

            SqlParameter prmSTRTIPOLICENCIA_SOF = new SqlParameter("@STRTIPOLICENCIA_SOF", SqlDbType.NVarChar);
            prmSTRTIPOLICENCIA_SOF.Value = _strTipoLicencia_sof;
            myCommand.Parameters.Add(prmSTRTIPOLICENCIA_SOF);

            SqlParameter prmSTRNOMBRELICENCIA_SOF = new SqlParameter("@STRNOMBRELICENCIA_SOF", SqlDbType.NVarChar);
            prmSTRNOMBRELICENCIA_SOF.Value = _strNombreLicencia_sof;
            myCommand.Parameters.Add(prmSTRNOMBRELICENCIA_SOF);

            SqlParameter prmINTCANTIDAD_SOF = new SqlParameter("@INTCANTIDAD_SOF", SqlDbType.Int);
            prmINTCANTIDAD_SOF.Value = _intCantidad_sof;
            myCommand.Parameters.Add(prmINTCANTIDAD_SOF);

            SqlParameter prmDECCOSTOUNITARIO_SOF = new SqlParameter("@DECCOSTOUNITARIO_SOF", SqlDbType.Decimal);
            prmDECCOSTOUNITARIO_SOF.Value = _decCostoUnitario_sof;
            myCommand.Parameters.Add(prmDECCOSTOUNITARIO_SOF);

            SqlParameter prmDECCOSTOTOTAL_SOF = new SqlParameter("@DECCOSTOTOTAL_SOF", SqlDbType.Decimal);
            prmDECCOSTOTOTAL_SOF.Value = _decCostoTotal_sof;
            myCommand.Parameters.Add(prmDECCOSTOTOTAL_SOF);

            SqlParameter prmSTRDESCRIPCION_SOF = new SqlParameter("@STRDESCRIPCION_SOF", SqlDbType.NVarChar);
            prmSTRDESCRIPCION_SOF.Value = _strDescripcion_sof;
            myCommand.Parameters.Add(prmSTRDESCRIPCION_SOF);

            SqlParameter prmSTRIMAGEN_SOF = new SqlParameter("@STRIMAGEN_SOF", SqlDbType.NVarChar);
            prmSTRIMAGEN_SOF.Value = _strImagen_sof;
            myCommand.Parameters.Add(prmSTRIMAGEN_SOF);

            SqlParameter prmSTRURL_SOF = new SqlParameter("@STRURL_SOF", SqlDbType.NVarChar);
            prmSTRURL_SOF.Value = _strUrl_sof;
            myCommand.Parameters.Add(prmSTRURL_SOF);


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
        public int DelLAB_SOFTWARE(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_DelLAB_SOFTWARE", myConnection);
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