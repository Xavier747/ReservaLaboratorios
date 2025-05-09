using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ClassLibraryLaboratorios
{
    public class LAB_RESPONSABLE
    {
        public LAB_RESPONSABLE()
        {
        }

        public LAB_RESPONSABLE(
            string _strCod_respo,
            string _strCod_lab,
            string _strCod_res,
            string _strTipo_respo,
            DateTime _dtFechaInicio_respo,
            bool _bitEstado_respo,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_respo,
            string _strObs2_respo,
            bool _bitObs1_respo,
            bool _bitObs2_respo,
            decimal _decObs1_respo,
            decimal _decObs2_respo,
            DateTime _dtObs1_respo,
            DateTime _dtObs2_respo
        )
        {
            strCod_respo = _strCod_respo;
            strCod_lab = _strCod_lab;
            strCod_res = _strCod_res;
            strTipo_respo = _strTipo_respo;
            dtFechaInicio_respo = _dtFechaInicio_respo;
            bitEstado_respo = _bitEstado_respo;
            dtFecha_log = _dtFecha_log;
            strUser_log = _strUser_log;
            strObs1_respo = _strObs1_respo;
            strObs2_respo = _strObs2_respo;
            bitObs1_respo = _bitObs1_respo;
            bitObs2_respo = _bitObs2_respo;
            decObs1_respo = _decObs1_respo;
            decObs2_respo = _decObs2_respo;
            dtObs1_respo = _dtObs1_respo;
            dtObs2_respo = _dtObs2_respo;
        }

        private string STRCOD_RESPO;
        private string STRCOD_LAB;
        private string STRCOD_RES;
        private string STRTIPO_RESPO;
        private DateTime DTFINICIO_RESPO;
        private bool BITESTADO_RESPO;
        private DateTime DTFECHA_LOG;
        private string STRUSER_LOG;
        private string STROBS1_RESPO;
        private string STROBS2_RESPO;
        private bool BITOBS1_RESPO;
        private bool BITOBS2_RESPO;
        private decimal DECOBS1_RESPO;
        private decimal DECOBS2_RESPO;
        private DateTime DTOBS1_RESPO;
        private DateTime DTOBS2_RESPO;
        private int NUMERR;
        private string MSG;
        private bool RESULTADO;

        public string strCod_respo
        {
            get
            {
                return STRCOD_RESPO;
            }
            set
            {
                STRCOD_RESPO = value;
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

        public string strCod_res
        {
            get
            {
                return STRCOD_RES;
            }
            set
            {
                STRCOD_RES = value;
            }
        }

        public string strTipo_respo
        {
            get
            {
                return STRTIPO_RESPO;
            }
            set
            {
                STRTIPO_RESPO = value;
            }
        }

        public DateTime dtFechaInicio_respo
        {
            get
            {
                return DTFINICIO_RESPO;
            }
            set
            {
                DTFINICIO_RESPO = value;
            }
        }

        public bool bitEstado_respo
        {
            get
            {
                return BITESTADO_RESPO;
            }
            set
            {
                BITESTADO_RESPO = value;
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

        public string strObs1_respo
        {
            get
            {
                return STROBS1_RESPO;
            }
            set
            {
                STROBS1_RESPO = value;
            }
        }

        public string strObs2_respo
        {
            get
            {
                return STROBS2_RESPO;
            }
            set
            {
                STROBS2_RESPO = value;
            }
        }

        public bool bitObs1_respo
        {
            get
            {
                return BITOBS1_RESPO;
            }
            set
            {
                BITOBS1_RESPO = value;
            }
        }

        public bool bitObs2_respo
        {
            get
            {
                return BITOBS2_RESPO;
            }
            set
            {
                BITOBS2_RESPO = value;
            }
        }

        public decimal decObs1_respo
        {
            get
            {
                return DECOBS1_RESPO;
            }
            set
            {
                DECOBS1_RESPO = value;
            }
        }

        public decimal decObs2_respo
        {
            get
            {
                return DECOBS2_RESPO;
            }
            set
            {
                DECOBS2_RESPO = value;
            }
        }

        public DateTime dtObs1_respo
        {
            get
            {
                return DTOBS1_RESPO;
            }
            set
            {
                DTOBS1_RESPO = value;
            }
        }

        public DateTime dtObs2_respo
        {
            get
            {
                return DTOBS2_RESPO;
            }
            set
            {
                DTOBS2_RESPO = value;
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
        public List<LAB_RESPONSABLE> LoadLAB_RESPONSABLE(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<LAB_RESPONSABLE>();
            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
            {
                using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_RESPONSABLE", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
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

                    try
                    {
                        myConnection.Open();
                        using (SqlDataReader reader1 = myCommand.ExecuteReader())
                        {
                            while (reader1.Read())
                            {
                                LAB_RESPONSABLE miClase = new LAB_RESPONSABLE()
                                {
                                    strCod_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_respo"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_respo"))),
                                    strCod_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))),
                                    strCod_res = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_res"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_res"))),
                                    strTipo_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strTipo_respo"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strTipo_respo"))),
                                    dtFechaInicio_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaInicio_respo"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaInicio_respo"))),
                                    bitEstado_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitEstado_respo"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitEstado_respo"))),
                                    dtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    strUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strObs1_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("Responsable"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("Responsable"))),
                                    strObs2_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("IMAGEN_ALU"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("IMAGEN_ALU"))),
                                    bitObs1_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_respo"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_respo"))),
                                    bitObs2_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_respo"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_respo"))),
                                    decObs1_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_respo"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_respo"))),
                                    decObs2_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_respo"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_respo"))),
                                    dtObs1_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_respo"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_respo"))),
                                    dtObs2_respo = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_respo"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_respo"))),
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
        public int AddLAB_RESPONSABLE(LAB_RESPONSABLE miClase)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_RESPONSABLE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESPO = new SqlParameter("@strCod_respo", SqlDbType.NVarChar);
            prmSTRCOD_RESPO.Value = miClase.strCod_respo;
            myCommand.Parameters.Add(prmSTRCOD_RESPO);

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@strCod_lab", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = miClase.strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmSTRCOD_RES = new SqlParameter("@strCod_res", SqlDbType.NVarChar);
            prmSTRCOD_RES.Value = miClase.strCod_res;
            myCommand.Parameters.Add(prmSTRCOD_RES);

            SqlParameter prmSTRTIPO_RESPO = new SqlParameter("@strTipo_respo", SqlDbType.NVarChar);
            prmSTRTIPO_RESPO.Value = miClase.strTipo_respo;
            myCommand.Parameters.Add(prmSTRTIPO_RESPO);

            SqlParameter prmDTFECHA_INICIO_RESPO = new SqlParameter("@dtFechaInicio_respo", SqlDbType.DateTime);
            prmDTFECHA_INICIO_RESPO.Value = miClase.dtFechaInicio_respo;
            myCommand.Parameters.Add(prmDTFECHA_INICIO_RESPO);

            SqlParameter prmBITESTADO_RESPO = new SqlParameter("@bitEstado_respo", SqlDbType.Bit);
            prmBITESTADO_RESPO.Value = miClase.bitEstado_respo;
            myCommand.Parameters.Add(prmBITESTADO_RESPO);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@dtFecha_log", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClase.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@strUser_log", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClase.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESPO = new SqlParameter("@strObs1_respo", SqlDbType.NVarChar);
            prmSTROBS1_RESPO.Value = miClase.strObs1_respo;
            myCommand.Parameters.Add(prmSTROBS1_RESPO);

            SqlParameter prmSTROBS2_RESPO = new SqlParameter("@strObs2_respo", SqlDbType.NVarChar);
            prmSTROBS2_RESPO.Value = miClase.strObs2_respo;
            myCommand.Parameters.Add(prmSTROBS2_RESPO);

            SqlParameter prmBITOBS1_RESPO = new SqlParameter("@bitObs1_respo", SqlDbType.Bit);
            prmBITOBS1_RESPO.Value = miClase.bitObs1_respo;
            myCommand.Parameters.Add(prmBITOBS1_RESPO);

            SqlParameter prmBITOBS2_RESPO = new SqlParameter("@bitObs2_respo", SqlDbType.Bit);
            prmBITOBS2_RESPO.Value = miClase.bitObs2_respo;
            myCommand.Parameters.Add(prmBITOBS2_RESPO);

            SqlParameter prmDECOBS1_RESPO = new SqlParameter("@decObs1_respo", SqlDbType.Decimal);
            prmDECOBS1_RESPO.Value = miClase.decObs1_respo;
            myCommand.Parameters.Add(prmDECOBS1_RESPO);

            SqlParameter prmDECOBS2_RESPO = new SqlParameter("@decObs2_respo", SqlDbType.Decimal);
            prmDECOBS2_RESPO.Value = miClase.decObs2_respo;
            myCommand.Parameters.Add(prmDECOBS2_RESPO);

            SqlParameter prmDTOBS1_RESPO = new SqlParameter("@dtObs1_respo", SqlDbType.DateTime);
            prmDTOBS1_RESPO.Value = miClase.dtObs1_respo;
            myCommand.Parameters.Add(prmDTOBS1_RESPO);

            SqlParameter prmDTOBS2_RESPO = new SqlParameter("@dtObs2_respo", SqlDbType.DateTime);
            prmDTOBS2_RESPO.Value = miClase.dtObs2_respo;
            myCommand.Parameters.Add(prmDTOBS2_RESPO);

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

        public int AddLAB_RESPONSABLE(
            string _strCod_respo,
            string _strCod_lab,
            string _strCod_res,
            string _strTipo_respo,
            DateTime _dtFechaInicio_respo,
            bool _bitEstado_respo,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_respo,
            string _strObs2_respo,
            bool _bitObs1_respo,
            bool _bitObs2_respo,
            decimal _decObs1_respo,
            decimal _decObs2_respo,
            DateTime _dtObs1_respo,
            DateTime _dtObs2_respo
        )
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_RESPONSABLE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESPO = new SqlParameter("@strCod_respo", SqlDbType.NVarChar);
            prmSTRCOD_RESPO.Value = _strCod_respo;
            myCommand.Parameters.Add(prmSTRCOD_RESPO);

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@strCod_lab", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = _strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmSTRCOD_RES = new SqlParameter("@strCod_res", SqlDbType.NVarChar);
            prmSTRCOD_RES.Value = _strCod_res;
            myCommand.Parameters.Add(prmSTRCOD_RES);

            SqlParameter prmSTRTIPO_RESPO = new SqlParameter("@strTipo_respo", SqlDbType.NVarChar);
            prmSTRTIPO_RESPO.Value = _strTipo_respo;
            myCommand.Parameters.Add(prmSTRTIPO_RESPO);

            SqlParameter prmDTFECHA_INICIO_RESPO = new SqlParameter("@dtFechaInicio_respo", SqlDbType.DateTime);
            prmDTFECHA_INICIO_RESPO.Value = _dtFechaInicio_respo;
            myCommand.Parameters.Add(prmDTFECHA_INICIO_RESPO);

            SqlParameter prmBITESTADO_RESPO = new SqlParameter("@bitEstado_respo", SqlDbType.Bit);
            prmBITESTADO_RESPO.Value = _bitEstado_respo;
            myCommand.Parameters.Add(prmBITESTADO_RESPO);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@dtFecha_log", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@strUser_log", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESPO = new SqlParameter("@strObs1_respo", SqlDbType.NVarChar);
            prmSTROBS1_RESPO.Value = _strObs1_respo;
            myCommand.Parameters.Add(prmSTROBS1_RESPO);

            SqlParameter prmSTROBS2_RESPO = new SqlParameter("@strObs2_respo", SqlDbType.NVarChar);
            prmSTROBS2_RESPO.Value = _strObs2_respo;
            myCommand.Parameters.Add(prmSTROBS2_RESPO);

            SqlParameter prmBITOBS1_RESPO = new SqlParameter("@bitObs1_respo", SqlDbType.Bit);
            prmBITOBS1_RESPO.Value = _bitObs1_respo;
            myCommand.Parameters.Add(prmBITOBS1_RESPO);

            SqlParameter prmBITOBS2_RESPO = new SqlParameter("@bitObs2_respo", SqlDbType.Bit);
            prmBITOBS2_RESPO.Value = _bitObs2_respo;
            myCommand.Parameters.Add(prmBITOBS2_RESPO);

            SqlParameter prmDECOBS1_RESPO = new SqlParameter("@decObs1_respo", SqlDbType.Decimal);
            prmDECOBS1_RESPO.Value = _decObs1_respo;
            myCommand.Parameters.Add(prmDECOBS1_RESPO);

            SqlParameter prmDECOBS2_RESPO = new SqlParameter("@decObs2_respo", SqlDbType.Decimal);
            prmDECOBS2_RESPO.Value = _decObs2_respo;
            myCommand.Parameters.Add(prmDECOBS2_RESPO);

            SqlParameter prmDTOBS1_RESPO = new SqlParameter("@dtObs1_respo", SqlDbType.DateTime);
            prmDTOBS1_RESPO.Value = _dtObs1_respo;
            myCommand.Parameters.Add(prmDTOBS1_RESPO);

            SqlParameter prmDTOBS2_RESPO = new SqlParameter("@dtObs2_respo", SqlDbType.DateTime);
            prmDTOBS2_RESPO.Value = _dtObs2_respo;
            myCommand.Parameters.Add(prmDTOBS2_RESPO);

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
        public int UpdateLAB_RESPONSABLE(LAB_RESPONSABLE miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_RESPONSABLE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESPO = new SqlParameter("@strCod_respo", SqlDbType.NVarChar);
            prmSTRCOD_RESPO.Value = miClass.strCod_respo;
            myCommand.Parameters.Add(prmSTRCOD_RESPO);

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@strCod_lab", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = miClass.strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmSTRCOD_RES = new SqlParameter("@strCod_res", SqlDbType.NVarChar);
            prmSTRCOD_RES.Value = miClass.strCod_res;
            myCommand.Parameters.Add(prmSTRCOD_RES);

            SqlParameter prmSTRTIPO_RESPO = new SqlParameter("@strTipo_respo", SqlDbType.NVarChar);
            prmSTRTIPO_RESPO.Value = miClass.strTipo_respo;
            myCommand.Parameters.Add(prmSTRTIPO_RESPO);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@dtFecha_log", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@strUser_log", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);


            int intReturb = -1;

            try
            {
                myConnection.Open();
                intReturb = myCommand.ExecuteNonQuery(); //devuelve el número de registros afectados en la bd
                if (intReturb == 0)
                {
                    resultado = false;
                    msg = "No se realizaron cambios en la base de datos...";
                }
                else
                {
                    resultado = true;
                    msg = "Los datos se actualizaron satisfactoriamente...";
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

        ///////////////// Método Update SobreCargado /////////////////
        public int UpdateLAB_RESPONSABLE(
            string _strCod_respo,
            string _strCod_lab,
            string _strCod_res,
            string _strTipo_respo,
            DateTime _dtFecha_log,
            string _strUser_log
        )
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_RESPONSABLE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESPO = new SqlParameter("@strCod_respo", SqlDbType.NVarChar);
            prmSTRCOD_RESPO.Value = _strCod_respo;
            myCommand.Parameters.Add(prmSTRCOD_RESPO);

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@strCod_lab", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = _strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmSTRCOD_RES = new SqlParameter("@strCod_res", SqlDbType.NVarChar);
            prmSTRCOD_RES.Value = _strCod_res;
            myCommand.Parameters.Add(prmSTRCOD_RES);

            SqlParameter prmSTRTIPO_RESPO = new SqlParameter("@strTipo_respo", SqlDbType.NVarChar);
            prmSTRTIPO_RESPO.Value = _strTipo_respo;
            myCommand.Parameters.Add(prmSTRTIPO_RESPO);



            SqlParameter prmDTFECHA_LOG = new SqlParameter("@dtFecha_log", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@strUser_log", SqlDbType.NVarChar);
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
                    msg = "No se realizaron cambios en la base de datos...";
                }
                else
                {
                    resultado = true;
                    msg = "Los datos se actualizaron satisfactoriamente...";
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

    }
}
