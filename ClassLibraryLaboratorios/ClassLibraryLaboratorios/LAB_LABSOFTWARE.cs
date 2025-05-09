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
    public class LAB_LABSOFTWARE
    {
        public LAB_LABSOFTWARE() { }

        public LAB_LABSOFTWARE(
            string _strCod_labSoft,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_sof,
            string _strCod_lab,
            DateTime _dtFechaRegistro_labSoft,
            bool _bitEstado_labSoft,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_labSoft,
            string _strObs2_labSoft,
            bool _bitObs1_labSoft,
            bool _bitObs2_labSoft,
            decimal _decObs1_labSoft,
            decimal _decObs2_labSoft,
            DateTime _dtObs1_labSoft,
            DateTime _dtObs2_labSoft)
        {
            strCod_labSoft = _strCod_labSoft;
            strCod_Sede = _strCod_Sede;
            strCod_Fac = _strCod_Fac;
            strCod_sof = _strCod_sof;
            strCod_lab = _strCod_lab;
            dtFechaRegistro_labSoft = _dtFechaRegistro_labSoft;
            bitEstado_labSoft = _bitEstado_labSoft;
            dtFecha_log = _dtFecha_log;
            strUser_log = _strUser_log;
            strObs1_labSoft = _strObs1_labSoft;
            strObs2_labSoft = _strObs2_labSoft;
            bitObs1_labSoft = _bitObs1_labSoft;
            bitObs2_labSoft = _bitObs2_labSoft;
            decObs1_labSoft = _decObs1_labSoft;
            decObs2_labSoft = _decObs2_labSoft;
            dtObs1_labSoft = _dtObs1_labSoft;
            dtObs2_labSoft = _dtObs2_labSoft;

            NUMERR = 0;
            MSG = string.Empty;
            RESULTADO = false;
        }

        // Campos privados
        private string STRCOD_LABSOFT;
        private string STRCOD_SEDE;
        private string STRCOD_FAC;
        private string STRCOD_SOF;
        private string STRCOD_LAB;
        private DateTime DTFECHAREGISTRO_LABSOFT;
        private bool BITESTADO_LABSOFT;
        private DateTime DTFECHA_LOG;
        private string STRUSER_LOG;
        private string STROBS1_LABSOFT;
        private string STROBS2_LABSOFT;
        private bool BITOBS1_LABSOFT;
        private bool BITOBS2_LABSOFT;
        private decimal DECOBS1_LABSOFT;
        private decimal DECOBS2_LABSOFT;
        private DateTime DTOBS1_LABSOFT;
        private DateTime DTOBS2_LABSOFT;
        private int NUMERR;
        private string MSG;
        private bool RESULTADO;

        ///////////////////// Generacion de propiedades/////////////////
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

        public string strCod_labSoft
        {
            get
            {
                return STRCOD_LABSOFT;
            }
            set
            {
                STRCOD_LABSOFT = value;
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

        public DateTime dtFechaRegistro_labSoft
        {
            get
            {
                return DTFECHAREGISTRO_LABSOFT;
            }
            set
            {
                DTFECHAREGISTRO_LABSOFT = value;
            }
        }

        public bool bitEstado_labSoft
        {
            get
            {
                return BITESTADO_LABSOFT;
            }
            set
            {
                BITESTADO_LABSOFT = value;
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

        public string strObs1_labSoft
        {
            get
            {
                return STROBS1_LABSOFT;
            }
            set
            {
                STROBS1_LABSOFT = value;
            }
        }

        public string strObs2_labSoft
        {
            get
            {
                return STROBS2_LABSOFT;
            }
            set
            {
                STROBS2_LABSOFT = value;
            }
        }

        public bool bitObs1_labSoft
        {
            get
            {
                return BITOBS1_LABSOFT;
            }
            set
            {
                BITOBS1_LABSOFT = value;
            }
        }

        public bool bitObs2_labSoft
        {
            get
            {
                return BITOBS2_LABSOFT;
            }
            set
            {
                BITOBS2_LABSOFT = value;
            }
        }

        public decimal decObs1_labSoft
        {
            get
            {
                return DECOBS1_LABSOFT;
            }
            set
            {
                DECOBS1_LABSOFT = value;
            }
        }

        public decimal decObs2_labSoft
        {
            get
            {
                return DECOBS2_LABSOFT;
            }
            set
            {
                DECOBS2_LABSOFT = value;
            }
        }

        public DateTime dtObs1_labSoft
        {
            get
            {
                return DTOBS1_LABSOFT;
            }
            set
            {
                DTOBS1_LABSOFT = value;
            }
        }

        public DateTime dtObs2_labSoft
        {
            get
            {
                return DTOBS2_LABSOFT;
            }
            set
            {
                DTOBS2_LABSOFT = value;
            }
        }

        ///////////////// Método Get /////////////////

        public List<LAB_LABSOFTWARE> LoadLAB_LABSOFTWARE(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<LAB_LABSOFTWARE>();
            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
            {
                using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_LABSOFTWARE", myConnection))
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
                                LAB_LABSOFTWARE miClase = new LAB_LABSOFTWARE()
                                {
                                    strCod_labSoft = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_LabSoft"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_LabSoft"))),
                                    strCod_Sede = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Sede"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Sede"))),
                                    strCod_Fac = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Fac"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Fac"))),
                                    strCod_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_sof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_sof"))),
                                    strCod_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))),
                                    dtFechaRegistro_labSoft = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_labSoft"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_labSoft"))),
                                    bitEstado_labSoft = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitEstado_labSoft"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitEstado_labSoft"))),
                                    dtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    strUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strObs1_labSoft = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_labSoft"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_labSoft"))),
                                    strObs2_labSoft = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_labSoft"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_labSoft"))),
                                    bitObs1_labSoft = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_labSoft"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_labSoft"))),
                                    bitObs2_labSoft = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_labSoft"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_labSoft"))),
                                    decObs1_labSoft = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_labSoft"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_labSoft"))),
                                    decObs2_labSoft = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_labSoft"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_labSoft"))),
                                    dtObs1_labSoft = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_labSoft"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_labSoft"))),
                                    dtObs2_labSoft = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_labSoft"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_labSoft"))),
                                    numerr = 0,
                                    msg = "Datos extraídos satisfactoriamente...",
                                    resultado = true,
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

        public int AddLAB_LABSOFTWARE(LAB_LABSOFTWARE miClass)
        {
            // Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            // Conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_LABSOFTWARE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_LABSOFT = new SqlParameter("@STRCOD_LABSOFT", SqlDbType.NVarChar);
            prmSTRCOD_LABSOFT.Value = miClass.strCod_labSoft;
            myCommand.Parameters.Add(prmSTRCOD_LABSOFT);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = miClass.strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = miClass.strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = miClass.strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@STRCOD_LAB", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = miClass.strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmDTFECHAREGISTRO_LABSOFT = new SqlParameter("@DTFECHAREGISTRO_LABSOFT", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_LABSOFT.Value = miClass.dtFechaRegistro_labSoft;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_LABSOFT);

            SqlParameter prmBITESTADO_LABSOFT = new SqlParameter("@BITESTADO_LABSOFT", SqlDbType.Bit);
            prmBITESTADO_LABSOFT.Value = miClass.bitEstado_labSoft;
            myCommand.Parameters.Add(prmBITESTADO_LABSOFT);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_LABSOFT = new SqlParameter("@STROBS1_LABSOFT", SqlDbType.NVarChar);
            prmSTROBS1_LABSOFT.Value = miClass.strObs1_labSoft;
            myCommand.Parameters.Add(prmSTROBS1_LABSOFT);

            SqlParameter prmSTROBS2_LABSOFT = new SqlParameter("@STROBS2_LABSOFT", SqlDbType.NVarChar);
            prmSTROBS2_LABSOFT.Value = miClass.strObs2_labSoft;
            myCommand.Parameters.Add(prmSTROBS2_LABSOFT);

            SqlParameter prmBITOBS1_LABSOFT = new SqlParameter("@BITOBS1_LABSOFT", SqlDbType.Bit);
            prmBITOBS1_LABSOFT.Value = miClass.bitObs1_labSoft;
            myCommand.Parameters.Add(prmBITOBS1_LABSOFT);

            SqlParameter prmBITOBS2_LABSOFT = new SqlParameter("@BITOBS2_LABSOFT", SqlDbType.Bit);
            prmBITOBS2_LABSOFT.Value = miClass.bitObs2_labSoft;
            myCommand.Parameters.Add(prmBITOBS2_LABSOFT);

            SqlParameter prmDECOBS1_LABSOFT = new SqlParameter("@DECOBS1_LABSOFT", SqlDbType.Decimal);
            prmDECOBS1_LABSOFT.Value = miClass.decObs1_labSoft;
            myCommand.Parameters.Add(prmDECOBS1_LABSOFT);

            SqlParameter prmDECOBS2_LABSOFT = new SqlParameter("@DECOBS2_LABSOFT", SqlDbType.Decimal);
            prmDECOBS2_LABSOFT.Value = miClass.decObs2_labSoft;
            myCommand.Parameters.Add(prmDECOBS2_LABSOFT);

            SqlParameter prmDTOBS1_LABSOFT = new SqlParameter("@DTOBS1_LABSOFT", SqlDbType.DateTime);
            prmDTOBS1_LABSOFT.Value = miClass.dtObs1_labSoft;
            myCommand.Parameters.Add(prmDTOBS1_LABSOFT);

            SqlParameter prmDTOBS2_LABSOFT = new SqlParameter("@DTOBS2_LABSOFT", SqlDbType.DateTime);
            prmDTOBS2_LABSOFT.Value = miClass.dtObs2_labSoft;
            myCommand.Parameters.Add(prmDTOBS2_LABSOFT);

            int intReturn = -1;
            try
            {
                myConnection.Open();
                intReturn = myCommand.ExecuteNonQuery(); // Devuelve el número de registros afectados en la bd
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
            return intReturn;
        }

        ///////////////// Método Add SobreCargado /////////////////

        public int AddLAB_LABSOFTWARE(
            string _strCod_labSoft,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_sof,
            string _strCod_lab,
            DateTime _dtFechaRegistro_labSoft,
            bool _bitEstado_labSoft,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_labSoft,
            string _strObs2_labSoft,
            bool _bitObs1_labSoft,
            bool _bitObs2_labSoft,
            decimal _decObs1_labSoft,
            decimal _decObs2_labSoft,
            DateTime _dtObs1_labSoft,
            DateTime _dtObs2_labSoft)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_LABSOFTWARE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSTRCOD_LABSOFT = new SqlParameter("@STRCOD_LABSOFT", SqlDbType.NVarChar);
            prmSTRCOD_LABSOFT.Value = _strCod_labSoft;
            myCommand.Parameters.Add(prmSTRCOD_LABSOFT);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = _strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = _strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = _strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@STRCOD_LAB", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = _strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmDTFECHAREGISTRO_LABSOFT = new SqlParameter("@DTFECHAREGISTRO_LABSOFT", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_LABSOFT.Value = _dtFechaRegistro_labSoft;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_LABSOFT);

            SqlParameter prmBITESTADO_LABSOFT = new SqlParameter("@BITESTADO_LABSOFT", SqlDbType.Bit);
            prmBITESTADO_LABSOFT.Value = _bitEstado_labSoft;
            myCommand.Parameters.Add(prmBITESTADO_LABSOFT);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_LABSOFT = new SqlParameter("@STROBS1_LABSOFT", SqlDbType.NVarChar);
            prmSTROBS1_LABSOFT.Value = _strObs1_labSoft;
            myCommand.Parameters.Add(prmSTROBS1_LABSOFT);

            SqlParameter prmSTROBS2_LABSOFT = new SqlParameter("@STROBS2_LABSOFT", SqlDbType.NVarChar);
            prmSTROBS2_LABSOFT.Value = _strObs2_labSoft;
            myCommand.Parameters.Add(prmSTROBS2_LABSOFT);

            SqlParameter prmBITOBS1_LABSOFT = new SqlParameter("@BITOBS1_LABSOFT", SqlDbType.Bit);
            prmBITOBS1_LABSOFT.Value = _bitObs1_labSoft;
            myCommand.Parameters.Add(prmBITOBS1_LABSOFT);

            SqlParameter prmBITOBS2_LABSOFT = new SqlParameter("@BITOBS2_LABSOFT", SqlDbType.Bit);
            prmBITOBS2_LABSOFT.Value = _bitObs2_labSoft;
            myCommand.Parameters.Add(prmBITOBS2_LABSOFT);

            SqlParameter prmDECOBS1_LABSOFT = new SqlParameter("@DECOBS1_LABSOFT", SqlDbType.Decimal);
            prmDECOBS1_LABSOFT.Value = _decObs1_labSoft;
            myCommand.Parameters.Add(prmDECOBS1_LABSOFT);

            SqlParameter prmDECOBS2_LABSOFT = new SqlParameter("@DECOBS2_LABSOFT", SqlDbType.Decimal);
            prmDECOBS2_LABSOFT.Value = _decObs2_labSoft;
            myCommand.Parameters.Add(prmDECOBS2_LABSOFT);

            SqlParameter prmDTOBS1_LABSOFT = new SqlParameter("@DTOBS1_LABSOFT", SqlDbType.DateTime);
            prmDTOBS1_LABSOFT.Value = _dtObs1_labSoft;
            myCommand.Parameters.Add(prmDTOBS1_LABSOFT);

            SqlParameter prmDTOBS2_LABSOFT = new SqlParameter("@DTOBS2_LABSOFT", SqlDbType.DateTime);
            prmDTOBS2_LABSOFT.Value = _dtObs2_labSoft;
            myCommand.Parameters.Add(prmDTOBS2_LABSOFT);

            int intReturn = -1;

            try
            {
                myConnection.Open();
                intReturn = myCommand.ExecuteNonQuery();
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
            return intReturn;
        }

        ///////////////// Método Update /////////////////

        public int UpdateLAB_LABSOFTWARE(LAB_LABSOFTWARE miClass)
        {
            // Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            // Conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_LABSOFTWARE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_LABSOFT = new SqlParameter("@STRCOD_LABSOFT", SqlDbType.NVarChar);
            prmSTRCOD_LABSOFT.Value = miClass.strCod_labSoft;
            myCommand.Parameters.Add(prmSTRCOD_LABSOFT);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = miClass.strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = miClass.strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = miClass.strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@STRCOD_LAB", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = miClass.strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            int intReturn = -1;
            try
            {
                myConnection.Open();
                intReturn = myCommand.ExecuteNonQuery(); // Devuelve el número de registros afectados en la bd
                if (intReturn == 0)
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
            return intReturn;
        }

        ///////////////// Método Update SobreCargado /////////////////

        public int UpdateLAB_LABSOFTWARE(
            string _strCod_labSoft,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_sof,
            string _strCod_lab,
            DateTime _dtFecha_log,
            string _strUser_log)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_LABSOFTWARE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSTRCOD_LABSOFT = new SqlParameter("@STRCOD_LABSOFT", SqlDbType.NVarChar);
            prmSTRCOD_LABSOFT.Value = _strCod_labSoft;
            myCommand.Parameters.Add(prmSTRCOD_LABSOFT);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = _strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = _strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = _strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@STRCOD_LAB", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = _strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            int intReturn = -1;

            try
            {
                myConnection.Open();
                intReturn = myCommand.ExecuteNonQuery(); // Devuelve el número de registros afectados en la bd
                if (intReturn == 0)
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
            return intReturn;
        }

        ///////////////// Método Delete /////////////////

        public int DelLAB_LABSOFTWARE(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            // Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            // Conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_DelLAB_LABSOFTWARE", myConnection);
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

            int intReturn = -1;
            try
            {
                myConnection.Open();
                intReturn = myCommand.ExecuteNonQuery(); // Devuelve el número de registros afectados en la bd
                if (intReturn == 0)
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
            return intReturn;
        }
    }
}