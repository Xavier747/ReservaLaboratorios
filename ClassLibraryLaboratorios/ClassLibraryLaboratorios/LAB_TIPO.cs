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
    public class LAB_TIPO
    {
        public LAB_TIPO()
        {

        }

        public LAB_TIPO(
            string _strCod_tipoLab,
            string _strNombre_tipoLab,
            DateTime _dtFechaRegistro_tipoLab,
            bool _bitEstado_tipoLab,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_tipoLab,
            string _strObs2_tipoLab,
            bool _bitObs1_tipoLab,
            bool _bitObs2_tipoLab,
            decimal _decObs1_tipoLab,
            decimal _decObs2_tipoLab,
            DateTime _dtObs1_tipoLab,
            DateTime _dtObs2_tipoLab
        )
        {
            strCod_tipoLab = _strCod_tipoLab;
            strNombre_tipoLab = _strNombre_tipoLab;
            dtFechaRegistro_tipoLab = _dtFechaRegistro_tipoLab;
            bitEstado_tipoLab = _bitEstado_tipoLab;
            dtFecha_log = _dtFecha_log;
            strUser_log = _strUser_log;
            strObs1_tipoLab = _strObs1_tipoLab;
            strObs2_tipoLab = _strObs2_tipoLab;
            bitObs1_tipoLab = _bitObs1_tipoLab;
            bitObs2_tipoLab = _bitObs2_tipoLab;
            decObs1_tipoLab = _decObs1_tipoLab;
            decObs2_tipoLab = _decObs2_tipoLab;
            dtObs1_tipoLab = _dtObs1_tipoLab;
            dtObs2_tipoLab = _dtObs2_tipoLab;

            numerr = 0;
            msg = string.Empty;
            resultado = false;
        }

        private string STRCOD_TIPOLAB;
        private string STRNOMBRE_TIPOLAB;
        private DateTime DTFECHAREGISTRO_TIPOLAB;
        private bool BITESTADO_TIPOLAB;
        private DateTime DTFECHA_LOG;
        private string STRUSER_LOG;
        private string STROBS1_TIPOLAB;
        private string STROBS2_TIPOLAB;
        private bool BITOBS1_TIPOLAB;
        private bool BITOBS2_TIPOLAB;
        private decimal DECOBS1_TIPOLAB;
        private decimal DECOBS2_TIPOLAB;
        private DateTime DTOBS1_TIPOLAB;
        private DateTime DTOBS2_TIPOLAB;
        private int NUMERR;
        private string MSG;
        private bool RESULTADO;
        ///////////////////// Generacion de propiedades/////////////////

        public string strCod_tipoLab
        {
            get
            {
                return STRCOD_TIPOLAB;
            }
            set
            {
                STRCOD_TIPOLAB = value;
            }
        }

        public string strNombre_tipoLab
        {
            get
            {
                return STRNOMBRE_TIPOLAB;
            }
            set
            {
                STRNOMBRE_TIPOLAB = value;
            }
        }

        public DateTime dtFechaRegistro_tipoLab
        {
            get
            {
                return DTFECHAREGISTRO_TIPOLAB;
            }
            set
            {
                DTFECHAREGISTRO_TIPOLAB = value;
            }
        }

        public bool bitEstado_tipoLab
        {
            get
            {
                return BITESTADO_TIPOLAB;
            }
            set
            {
                BITESTADO_TIPOLAB = value;
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

        public string strObs1_tipoLab
        {
            get
            {
                return STROBS1_TIPOLAB;
            }
            set
            {
                STROBS1_TIPOLAB = value;
            }
        }

        public string strObs2_tipoLab
        {
            get
            {
                return STROBS2_TIPOLAB;
            }
            set
            {
                STROBS2_TIPOLAB = value;
            }
        }

        public bool bitObs1_tipoLab
        {
            get
            {
                return BITOBS1_TIPOLAB;
            }
            set
            {
                BITOBS1_TIPOLAB = value;
            }
        }

        public bool bitObs2_tipoLab
        {
            get
            {
                return BITOBS2_TIPOLAB;
            }
            set
            {
                BITOBS2_TIPOLAB = value;
            }
        }

        public decimal decObs1_tipoLab
        {
            get
            {
                return DECOBS1_TIPOLAB;
            }
            set
            {
                DECOBS1_TIPOLAB = value;
            }
        }

        public decimal decObs2_tipoLab
        {
            get
            {
                return DECOBS2_TIPOLAB;
            }
            set
            {
                DECOBS2_TIPOLAB = value;
            }
        }

        public DateTime dtObs1_tipoLab
        {
            get
            {
                return DTOBS1_TIPOLAB;
            }
            set
            {
                DTOBS1_TIPOLAB = value;
            }
        }

        public DateTime dtObs2_tipoLab
        {
            get
            {
                return DTOBS2_TIPOLAB;
            }
            set
            {
                DTOBS2_TIPOLAB = value;
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

        public List<LAB_TIPO> LoadLAB_TIPO(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<LAB_TIPO>();

            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
            {
                using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_TIPO", myConnection))
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
                                LAB_TIPO miClase = new LAB_TIPO()
                                {
                                    strCod_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_tipoLab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_tipoLab"))),
                                    strNombre_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strNombre_tipoLab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strNombre_tipoLab"))),
                                    dtFechaRegistro_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_tipoLab"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_tipoLab"))),
                                    bitEstado_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitEstado_tipoLab"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitEstado_tipoLab"))),
                                    dtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    strUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strObs1_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_tipoLab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_tipoLab"))),
                                    strObs2_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_tipoLab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_tipoLab"))),
                                    bitObs1_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_tipoLab"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_tipoLab"))),
                                    bitObs2_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_tipoLab"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_tipoLab"))),
                                    decObs1_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_tipoLab"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_tipoLab"))),
                                    decObs2_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_tipoLab"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_tipoLab"))),
                                    dtObs1_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_tipoLab"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_tipoLab"))),
                                    dtObs2_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_tipoLab"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_tipoLab"))),
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

        public int AddLAB_TIPO(LAB_TIPO miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_TIPO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_TIPOLAB = new SqlParameter("@strCod_tipoLab", SqlDbType.NVarChar);
            prmSTRCOD_TIPOLAB.Value = miClass.strCod_tipoLab;
            myCommand.Parameters.Add(prmSTRCOD_TIPOLAB);

            SqlParameter prmSTRNOMBRE_TIPOLAB = new SqlParameter("@strNombre_tipoLab", SqlDbType.NVarChar);
            prmSTRNOMBRE_TIPOLAB.Value = miClass.strNombre_tipoLab;
            myCommand.Parameters.Add(prmSTRNOMBRE_TIPOLAB);

            SqlParameter prmDTFECHAREGISTRO_TIPOLAB = new SqlParameter("@dtFechaRegistro_tipoLab", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_TIPOLAB.Value = miClass.dtFechaRegistro_tipoLab;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_TIPOLAB);

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
        public int AddLAB_TIPO(
            string _strCod_tipoLab,
            string _strNombre_tipoLab,
            DateTime _dtFechaRegistro_tipoLab,
            bool _bitEstado_tipoLab,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_tipoLab,
            string _strObs2_tipoLab,
            bool _bitObs1_tipoLab,
            bool _bitObs2_tipoLab,
            decimal _decObs1_tipoLab,
            decimal _decObs2_tipoLab,
            DateTime _dtObs1_tipoLab,
            DateTime _dtObs2_tipoLab
        )
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_TIPO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_TIPOLAB = new SqlParameter("@strCod_tipoLab", SqlDbType.NVarChar);
            prmSTRCOD_TIPOLAB.Value = _strCod_tipoLab;
            myCommand.Parameters.Add(prmSTRCOD_TIPOLAB);

            SqlParameter prmSTRNOMBRE_TIPOLAB = new SqlParameter("@strNombre_tipoLab", SqlDbType.NVarChar);
            prmSTRNOMBRE_TIPOLAB.Value = _strNombre_tipoLab;
            myCommand.Parameters.Add(prmSTRNOMBRE_TIPOLAB);

            SqlParameter prmDTFECHAREGISTRO_TIPOLAB = new SqlParameter("@dtFechaRegistro_tipoLab", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_TIPOLAB.Value = _dtFechaRegistro_tipoLab;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_TIPOLAB);

            SqlParameter prmBITESTADO_TIPOLAB = new SqlParameter("@bitEstado_tipoLab", SqlDbType.Bit);
            prmBITESTADO_TIPOLAB.Value = _bitEstado_tipoLab;
            myCommand.Parameters.Add(prmBITESTADO_TIPOLAB);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@dtFecha_log", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@strUser_log", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_TIPOLAB = new SqlParameter("@strObs1_tipoLab", SqlDbType.NVarChar);
            prmSTROBS1_TIPOLAB.Value = _strObs1_tipoLab;
            myCommand.Parameters.Add(prmSTROBS1_TIPOLAB);

            SqlParameter prmSTROBS2_TIPOLAB = new SqlParameter("@strObs2_tipoLab", SqlDbType.NVarChar);
            prmSTROBS2_TIPOLAB.Value = _strObs2_tipoLab;
            myCommand.Parameters.Add(prmSTROBS2_TIPOLAB);

            SqlParameter prmBITOBS1_TIPOLAB = new SqlParameter("@bitObs1_tipoLab", SqlDbType.Bit);
            prmBITOBS1_TIPOLAB.Value = _bitObs1_tipoLab;
            myCommand.Parameters.Add(prmBITOBS1_TIPOLAB);

            SqlParameter prmBITOBS2_TIPOLAB = new SqlParameter("@bitObs2_tipoLab", SqlDbType.Bit);
            prmBITOBS2_TIPOLAB.Value = _bitObs2_tipoLab;
            myCommand.Parameters.Add(prmBITOBS2_TIPOLAB);

            SqlParameter prmDECOBS1_TIPOLAB = new SqlParameter("@decObs1_tipoLab", SqlDbType.Decimal);
            prmDECOBS1_TIPOLAB.Value = _decObs1_tipoLab;
            myCommand.Parameters.Add(prmDECOBS1_TIPOLAB);

            SqlParameter prmDECOBS2_TIPOLAB = new SqlParameter("@decObs2_tipoLab", SqlDbType.Decimal);
            prmDECOBS2_TIPOLAB.Value = _decObs2_tipoLab;
            myCommand.Parameters.Add(prmDECOBS2_TIPOLAB);

            SqlParameter prmDTOBS1_TIPOLAB = new SqlParameter("@dtObs1_tipoLab", SqlDbType.DateTime);
            prmDTOBS1_TIPOLAB.Value = _dtObs1_tipoLab;
            myCommand.Parameters.Add(prmDTOBS1_TIPOLAB);

            SqlParameter prmDTOBS2_TIPOLAB = new SqlParameter("@dtObs2_tipoLab", SqlDbType.DateTime);
            prmDTOBS2_TIPOLAB.Value = _dtObs2_tipoLab;
            myCommand.Parameters.Add(prmDTOBS2_TIPOLAB);

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

        public int UpdateLAB_TIPO(LAB_TIPO miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_TIPO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_TIPOLAB = new SqlParameter("@strCod_tipoLab", SqlDbType.NVarChar);
            prmSTRCOD_TIPOLAB.Value = miClass.strCod_tipoLab;
            myCommand.Parameters.Add(prmSTRCOD_TIPOLAB);

            SqlParameter prmSTRNOMBRE_TIPOLAB = new SqlParameter("@strNombre_tipoLab", SqlDbType.NVarChar);
            prmSTRNOMBRE_TIPOLAB.Value = miClass.strNombre_tipoLab;
            myCommand.Parameters.Add(prmSTRNOMBRE_TIPOLAB);

            SqlParameter prmDTFECHAREGISTRO_TIPOLAB = new SqlParameter("@dtFechaRegistro_tipoLab", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_TIPOLAB.Value = miClass.dtFechaRegistro_tipoLab;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_TIPOLAB);

            SqlParameter prmBITESTADO_TIPOLAB = new SqlParameter("@bitEstado_tipoLab", SqlDbType.Bit);
            prmBITESTADO_TIPOLAB.Value = miClass.bitEstado_tipoLab;
            myCommand.Parameters.Add(prmBITESTADO_TIPOLAB);

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
        public int UpdateLAB_TIPO(
            string _strCod_tipoLab,
            string _strNombre_tipoLab,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_tipoLab,
            string _strObs2_tipoLab,
            bool _bitObs1_tipoLab,
            bool _bitObs2_tipoLab,
            decimal _decObs1_tipoLab,
            decimal _decObs2_tipoLab,
            DateTime _dtObs1_tipoLab,
            DateTime _dtObs2_tipoLab
        )
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_TIPO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_TIPOLAB = new SqlParameter("@strCod_tipoLab", SqlDbType.NVarChar);
            prmSTRCOD_TIPOLAB.Value = _strCod_tipoLab;
            myCommand.Parameters.Add(prmSTRCOD_TIPOLAB);

            SqlParameter prmSTRNOMBRE_TIPOLAB = new SqlParameter("@strNombre_tipoLab", SqlDbType.NVarChar);
            prmSTRNOMBRE_TIPOLAB.Value = _strNombre_tipoLab;
            myCommand.Parameters.Add(prmSTRNOMBRE_TIPOLAB);

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

        ///////////////// Método Delete /////////////////

        public int DelPOSG_INSCRIPCION(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_DelLAB_TIPO", myConnection);
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
                    msg = "Los datos se eliminaron satisfactoriamente...";
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
