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
    public class LAB_RESERSOFTWARE
    {
        public LAB_RESERSOFTWARE()
        {

        }

        public LAB_RESERSOFTWARE(
            string _strCod_resof,
            string _strCod_sof,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_reser,
            string _strNombre_resof,
            DateTime _dtRegistro_resof,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_resof,
            string _strObs2_resof,
            bool _bitObs1_resof,
            bool _bitObs2_resof,
            decimal _decObs1_resof,
            decimal _decObs2_resof,
            DateTime _dtObs1_resof,
            DateTime _dtObs2_resof
            )
        {
            strCod_resof = _strCod_resof;
            strCod_sof = _strCod_sof;
            strCod_Sede = _strCod_Sede;
            strCod_Fac = _strCod_Fac;
            strCod_reser = _strCod_reser;
            strNombre_resof = _strNombre_resof;
            dtRegistro_resof = _dtRegistro_resof;
            dtFecha_log = _dtFecha_log;
            strUser_log = _strUser_log;
            strObs1_resof = _strObs1_resof;
            strObs2_resof = _strObs2_resof;
            bitObs1_resof = _bitObs1_resof;
            bitObs2_resof = _bitObs2_resof;
            decObs1_resof = _decObs1_resof;
            decObs2_resof = _decObs2_resof;
            dtObs1_resof = _dtObs1_resof;
            dtObs2_resof = _dtObs2_resof;
        }

        private string STRCOD_RESOF;
        private string STRCOD_SOF;
        private string STRCOD_SEDE;
        private string STRCOD_FAC;
        private string STRCOD_RESER;
        private string STRNOMBRE_RESOF;
        private DateTime DTREGISTRO_RESOF;
        private DateTime DTFECHA_LOG;
        private string STRUSER_LOG;
        private string STROBS1_RESOF;
        private string STROBS2_RESOF;
        private bool BITOBS1_RESOF;
        private bool BITOBS2_RESOF;
        private decimal DECOBS1_RESOF;
        private decimal DECOBS2_RESOF;
        private DateTime DTOBS1_RESOF;
        private DateTime DTOBS2_RESOF;
        private int NUMERR;
        private string MSG;
        private bool RESULTADO;

        ///////////////////// Generacion de propiedades/////////////////
        public string strCod_resof
        {
            get
            {
                return STRCOD_RESOF;
            }
            set
            {
                STRCOD_RESOF = value;
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

        public string strNombre_resof
        {
            get
            {
                return STRNOMBRE_RESOF;
            }
            set
            {
                STRNOMBRE_RESOF = value;
            }
        }

        public DateTime dtRegistro_resof
        {
            get
            {
                return DTREGISTRO_RESOF;
            }
            set
            {
                DTREGISTRO_RESOF = value;
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

        public string strObs1_resof
        {
            get
            {
                return STROBS1_RESOF;
            }
            set
            {
                STROBS1_RESOF = value;
            }
        }

        public string strObs2_resof
        {
            get
            {
                return STROBS2_RESOF;
            }
            set
            {
                STROBS2_RESOF = value;
            }
        }

        public bool bitObs1_resof
        {
            get
            {
                return BITOBS1_RESOF;
            }
            set
            {
                BITOBS1_RESOF = value;
            }
        }

        public bool bitObs2_resof
        {
            get
            {
                return BITOBS2_RESOF;
            }
            set
            {
                BITOBS2_RESOF = value;
            }
        }

        public decimal decObs1_resof
        {
            get
            {
                return DECOBS1_RESOF;
            }
            set
            {
                DECOBS1_RESOF = value;
            }
        }

        public decimal decObs2_resof
        {
            get
            {
                return DECOBS2_RESOF;
            }
            set
            {
                DECOBS2_RESOF = value;
            }
        }

        public DateTime dtObs1_resof
        {
            get
            {
                return DTOBS1_RESOF;
            }
            set
            {
                DTOBS1_RESOF = value;
            }
        }

        public DateTime dtObs2_resof
        {
            get
            {
                return DTOBS2_RESOF;
            }
            set
            {
                DTOBS2_RESOF = value;
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

        public List<LAB_RESERSOFTWARE> LoadLAB_RESERSOFTWARE(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<LAB_RESERSOFTWARE>();

            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
            {
                using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_RESERSOFTWARE", myConnection))
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
                                LAB_RESERSOFTWARE miClase = new LAB_RESERSOFTWARE()
                                {
                                    strCod_resof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_resof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_resof"))),
                                    strCod_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_sof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_sof"))),
                                    strCod_Sede = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Sede"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Sede"))),
                                    strCod_Fac = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Fac"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Fac"))),
                                    strCod_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_reser"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_reser"))),
                                    strNombre_resof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strNombre_resof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strNombre_resof"))),
                                    dtRegistro_resof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtRegistro_resof"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtRegistro_resof"))),
                                    dtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    strUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strObs1_resof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_resof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_resof"))),
                                    strObs2_resof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_resof"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_resof"))),
                                    bitObs1_resof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_resof"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_resof"))),
                                    bitObs2_resof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_resof"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_resof"))),
                                    decObs1_resof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_resof"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_resof"))),
                                    decObs2_resof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_resof"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_resof"))),
                                    dtObs1_resof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_resof"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_resof"))),
                                    dtObs2_resof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_resof"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_resof"))),

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

        public int AddLAB_RESERSOFTWARE(LAB_RESERSOFTWARE miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_RESERSOFTWARE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESOF = new SqlParameter("@STRCOD_RESOF", SqlDbType.NVarChar);
            prmSTRCOD_RESOF.Value = miClass.strCod_resof;
            myCommand.Parameters.Add(prmSTRCOD_RESOF);

            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = miClass.strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = miClass.strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = miClass.strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = miClass.strCod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmSTRNOMBRE_RESOF = new SqlParameter("@STRNOMBRE_RESOF", SqlDbType.NVarChar);
            prmSTRNOMBRE_RESOF.Value = miClass.strNombre_resof;
            myCommand.Parameters.Add(prmSTRNOMBRE_RESOF);

            SqlParameter prmDTREGISTRO_RESOF = new SqlParameter("@DTREGISTRO_RESOF", SqlDbType.DateTime);
            prmDTREGISTRO_RESOF.Value = miClass.dtRegistro_resof;
            myCommand.Parameters.Add(prmDTREGISTRO_RESOF);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESOF = new SqlParameter("@STROBS1_RESOF", SqlDbType.NVarChar);
            prmSTROBS1_RESOF.Value = miClass.strObs1_resof;
            myCommand.Parameters.Add(prmSTROBS1_RESOF);

            SqlParameter prmSTROBS2_RESOF = new SqlParameter("@STROBS2_RESOF", SqlDbType.NVarChar);
            prmSTROBS2_RESOF.Value = miClass.strObs2_resof;
            myCommand.Parameters.Add(prmSTROBS2_RESOF);

            SqlParameter prmBITOBS1_RESOF = new SqlParameter("@BITOBS1_RESOF", SqlDbType.Bit);
            prmBITOBS1_RESOF.Value = miClass.bitObs1_resof;
            myCommand.Parameters.Add(prmBITOBS1_RESOF);

            SqlParameter prmBITOBS2_RESOF = new SqlParameter("@BITOBS2_RESOF", SqlDbType.Bit);
            prmBITOBS2_RESOF.Value = miClass.bitObs2_resof;
            myCommand.Parameters.Add(prmBITOBS2_RESOF);

            SqlParameter prmDECOBS1_RESOF = new SqlParameter("@DECOBS1_RESOF", SqlDbType.Decimal);
            prmDECOBS1_RESOF.Value = miClass.decObs1_resof;
            myCommand.Parameters.Add(prmDECOBS1_RESOF);

            SqlParameter prmDECOBS2_RESOF = new SqlParameter("@DECOBS2_RESOF", SqlDbType.Decimal);
            prmDECOBS2_RESOF.Value = miClass.decObs2_resof;
            myCommand.Parameters.Add(prmDECOBS2_RESOF);

            SqlParameter prmDTOBS1_RESOF = new SqlParameter("@DTOBS1_RESOF", SqlDbType.DateTime);
            prmDTOBS1_RESOF.Value = miClass.dtObs1_resof;
            myCommand.Parameters.Add(prmDTOBS1_RESOF);

            SqlParameter prmDTOBS2_RESOF = new SqlParameter("@DTOBS2_RESOF", SqlDbType.DateTime);
            prmDTOBS2_RESOF.Value = miClass.dtObs2_resof;
            myCommand.Parameters.Add(prmDTOBS2_RESOF);
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
        public int AddLAB_RESERSOFTWARE(
            string _strCod_resof,
            string _strCod_sof,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_reser,
            string _strNombre_resof,
            DateTime _dtRegistro_resof,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_resof,
            string _strObs2_resof,
            bool _bitObs1_resof,
            bool _bitObs2_resof,
            decimal _decObs1_resof,
            decimal _decObs2_resof,
            DateTime _dtObs1_resof,
            DateTime _dtObs2_resof
        )
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_RESERSOFTWARE", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESOF = new SqlParameter("@STRCOD_RESOF", SqlDbType.NVarChar);
            prmSTRCOD_RESOF.Value = _strCod_resof;
            myCommand.Parameters.Add(prmSTRCOD_RESOF);

            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = _strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = _strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = _strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = _strCod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmSTRNOMBRE_RESOF = new SqlParameter("@STRNOMBRE_RESOF", SqlDbType.NVarChar);
            prmSTRNOMBRE_RESOF.Value = _strNombre_resof;
            myCommand.Parameters.Add(prmSTRNOMBRE_RESOF);

            SqlParameter prmDTREGISTRO_RESOF = new SqlParameter("@DTREGISTRO_RESOF", SqlDbType.DateTime);
            prmDTREGISTRO_RESOF.Value = _dtRegistro_resof;
            myCommand.Parameters.Add(prmDTREGISTRO_RESOF);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESOF = new SqlParameter("@STROBS1_RESOF", SqlDbType.NVarChar);
            prmSTROBS1_RESOF.Value = _strObs1_resof;
            myCommand.Parameters.Add(prmSTROBS1_RESOF);

            SqlParameter prmSTROBS2_RESOF = new SqlParameter("@STROBS2_RESOF", SqlDbType.NVarChar);
            prmSTROBS2_RESOF.Value = _strObs2_resof;
            myCommand.Parameters.Add(prmSTROBS2_RESOF);

            SqlParameter prmBITOBS1_RESOF = new SqlParameter("@BITOBS1_RESOF", SqlDbType.Bit);
            prmBITOBS1_RESOF.Value = _bitObs1_resof;
            myCommand.Parameters.Add(prmBITOBS1_RESOF);

            SqlParameter prmBITOBS2_RESOF = new SqlParameter("@BITOBS2_RESOF", SqlDbType.Bit);
            prmBITOBS2_RESOF.Value = _bitObs2_resof;
            myCommand.Parameters.Add(prmBITOBS2_RESOF);

            SqlParameter prmDECOBS1_RESOF = new SqlParameter("@DECOBS1_RESOF", SqlDbType.Decimal);
            prmDECOBS1_RESOF.Value = _decObs1_resof;
            myCommand.Parameters.Add(prmDECOBS1_RESOF);

            SqlParameter prmDECOBS2_RESOF = new SqlParameter("@DECOBS2_RESOF", SqlDbType.Decimal);
            prmDECOBS2_RESOF.Value = _decObs2_resof;
            myCommand.Parameters.Add(prmDECOBS2_RESOF);

            SqlParameter prmDTOBS1_RESOF = new SqlParameter("@DTOBS1_RESOF", SqlDbType.DateTime);
            prmDTOBS1_RESOF.Value = _dtObs1_resof;
            myCommand.Parameters.Add(prmDTOBS1_RESOF);

            SqlParameter prmDTOBS2_RESOF = new SqlParameter("@DTOBS2_RESOF", SqlDbType.DateTime);
            prmDTOBS2_RESOF.Value = _dtObs2_resof;
            myCommand.Parameters.Add(prmDTOBS2_RESOF);

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

        ///////////////// Método Delete /////////////////
        public int DelLAB_RESERSOFTWARE(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_DelLAB_RESERSOFTWARE", myConnection);
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