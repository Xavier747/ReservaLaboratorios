using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace ClassLibraryLaboratorios
{
    public class LAB_RESERVAD
    {
        public LAB_RESERVAD()
        {
        }

        public LAB_RESERVAD(
            string _strCod_reserd,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_sof,
            string _strCod_reserc,
            string _strNombre_reserd,
            DateTime _dtRegistro_reserd,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_reserd,
            string _strObs2_reserd,
            bool _bitObs1_reserd,
            bool _bitObs2_reserd,
            decimal _decObs1_reserd,
            decimal _decObs2_reserd,
            DateTime _dtObs1_reserd,
            DateTime _dtObs2_reserd
        )
        {
            strCod_reserd = _strCod_reserd;
            strCod_Sede = _strCod_Sede;
            strCod_Fac = _strCod_Fac;
            strCod_sof = _strCod_sof;
            strCod_reserc = _strCod_reserc;
            strNombre_reserd = _strNombre_reserd;
            dtRegistro_reserd = _dtRegistro_reserd;
            dtFecha_log = _dtFecha_log;
            strUser_log = _strUser_log;
            strObs1_reserd = _strObs1_reserd;
            strObs2_reserd = _strObs2_reserd;
            bitObs1_reserd = _bitObs1_reserd;
            bitObs2_reserd = _bitObs2_reserd;
            decObs1_reserd = _decObs1_reserd;
            decObs2_reserd = _decObs2_reserd;
            dtObs1_reserd = _dtObs1_reserd;
            dtObs2_reserd = _dtObs2_reserd;
        }

        private string STRCOD_RESERD;
        private string STRCOD_SOF;
        private string STRCOD_SEDE;
        private string STRCOD_FAC;
        private string STRCOD_RESERC;
        private string STRNOMBRE_RESERD;
        private DateTime DTREGISTRO_RESERD;
        private DateTime DTFECHA_LOG;
        private string STRUSER_LOG;
        private string STROBS1_RESERD;
        private string STROBS2_RESERD;
        private bool BITOBS1_RESERD;
        private bool BITOBS2_RESERD;
        private decimal DECOBS1_RESERD;
        private decimal DECOBS2_RESERD;
        private DateTime DTOBS1_RESERD;
        private DateTime DTOBS2_RESERD;


        private int NUMERR;
        private string MSG;
        private bool RESULTADO;

        ///////////////////// Generacion de propiedades/////////////////
        public string strCod_reserd
        {
            get
            {
                return STRCOD_RESERD;
            }
            set
            {
                STRCOD_RESERD = value;
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

        public string strNombre_reserd
        {
            get
            {
                return STRNOMBRE_RESERD;
            }
            set
            {
                STRNOMBRE_RESERD = value;
            }
        }

        public DateTime dtRegistro_reserd
        {
            get
            {
                return DTREGISTRO_RESERD;
            }
            set
            {
                DTREGISTRO_RESERD = value;
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

        public string strObs1_reserd
        {
            get
            {
                return STROBS1_RESERD;
            }
            set
            {
                STROBS1_RESERD = value;
            }
        }

        public string strObs2_reserd
        {
            get
            {
                return STROBS2_RESERD;
            }
            set
            {
                STROBS2_RESERD = value;
            }
        }

        public bool bitObs1_reserd
        {
            get
            {
                return BITOBS1_RESERD;
            }
            set
            {
                BITOBS1_RESERD = value;
            }
        }

        public bool bitObs2_reserd
        {
            get
            {
                return BITOBS2_RESERD;
            }
            set
            {
                BITOBS2_RESERD = value;
            }
        }

        public decimal decObs1_reserd
        {
            get
            {
                return DECOBS1_RESERD;
            }
            set
            {
                DECOBS1_RESERD = value;
            }
        }

        public decimal decObs2_reserd
        {
            get
            {
                return DECOBS2_RESERD;
            }
            set
            {
                DECOBS2_RESERD = value;
            }
        }

        public DateTime dtObs1_reserd
        {
            get
            {
                return DTOBS1_RESERD;
            }
            set
            {
                DTOBS1_RESERD = value;
            }
        }

        public DateTime dtObs2_reserd
        {
            get
            {
                return DTOBS2_RESERD;
            }
            set
            {
                DTOBS2_RESERD = value;
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

        public List<LAB_RESERVAD> LoadLAB_RESERVAD(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<LAB_RESERVAD>();

            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
            {
                using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_RESERVAD", myConnection))
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
                                LAB_RESERVAD miClase = new LAB_RESERVAD()
                                {
                                    strCod_reserd = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_reserd"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_reserd"))),
                                    strCod_sof = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_sof"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_sof"))),
                                    strCod_Sede = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Sede"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Sede"))),
                                    strCod_Fac = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Fac"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Fac"))),
                                    strCod_reserc = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_reserc"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_reserc"))),
                                    strNombre_reserd = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strNombre_reserd"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strNombre_reserd"))),
                                    dtRegistro_reserd = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtRegistro_reserd"))) ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtRegistro_reserd"))),
                                    dtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    strUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strObs1_reserd = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_reserd"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_reserd"))),
                                    strObs2_reserd = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_reserd"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_reserd"))),
                                    bitObs1_reserd = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_reserd"))) ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_reserd"))),
                                    bitObs2_reserd = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_reserd"))) ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_reserd"))),
                                    decObs1_reserd = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_reserd"))) ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_reserd"))),
                                    decObs2_reserd = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_reserd"))) ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_reserd"))),
                                    dtObs1_reserd = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_reserd"))) ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_reserd"))),
                                    dtObs2_reserd = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_reserd"))) ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_reserd"))),

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
        public int AddLAB_RESERVAD(LAB_RESERVAD miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_RESERVAD", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESERD = new SqlParameter("@STRCOD_RESERD", SqlDbType.NVarChar);
            prmSTRCOD_RESERD.Value = miClass.strCod_reserd;
            myCommand.Parameters.Add(prmSTRCOD_RESERD);

            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = miClass.strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = miClass.strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = miClass.strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRCOD_RESERC = new SqlParameter("@STRCOD_RESERC", SqlDbType.NVarChar);
            prmSTRCOD_RESERC.Value = miClass.strCod_reserc;
            myCommand.Parameters.Add(prmSTRCOD_RESERC);

            SqlParameter prmSTRNOMBRE_RESERD = new SqlParameter("@STRNOMBRE_RESERD", SqlDbType.NVarChar);
            prmSTRNOMBRE_RESERD.Value = miClass.strNombre_reserd;
            myCommand.Parameters.Add(prmSTRNOMBRE_RESERD);

            SqlParameter prmDTREGISTRO_RESERD = new SqlParameter("@DTREGISTRO_RESERD", SqlDbType.DateTime);
            prmDTREGISTRO_RESERD.Value = miClass.dtRegistro_reserd;
            myCommand.Parameters.Add(prmDTREGISTRO_RESERD);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESERD = new SqlParameter("@STROBS1_RESERD", SqlDbType.NVarChar);
            prmSTROBS1_RESERD.Value = miClass.strObs1_reserd;
            myCommand.Parameters.Add(prmSTROBS1_RESERD);

            SqlParameter prmSTROBS2_RESERD = new SqlParameter("@STROBS2_RESERD", SqlDbType.NVarChar);
            prmSTROBS2_RESERD.Value = miClass.strObs2_reserd;
            myCommand.Parameters.Add(prmSTROBS2_RESERD);

            SqlParameter prmBITOBS1_RESERD = new SqlParameter("@BITOBS1_RESERD", SqlDbType.Bit);
            prmBITOBS1_RESERD.Value = miClass.bitObs1_reserd;
            myCommand.Parameters.Add(prmBITOBS1_RESERD);

            SqlParameter prmBITOBS2_RESERD = new SqlParameter("@BITOBS2_RESERD", SqlDbType.Bit);
            prmBITOBS2_RESERD.Value = miClass.bitObs2_reserd;
            myCommand.Parameters.Add(prmBITOBS2_RESERD);

            SqlParameter prmDECOBS1_RESERD = new SqlParameter("@DECOBS1_RESERD", SqlDbType.Decimal);
            prmDECOBS1_RESERD.Value = miClass.decObs1_reserd;
            myCommand.Parameters.Add(prmDECOBS1_RESERD);

            SqlParameter prmDECOBS2_RESERD = new SqlParameter("@DECOBS2_RESERD", SqlDbType.Decimal);
            prmDECOBS2_RESERD.Value = miClass.decObs2_reserd;
            myCommand.Parameters.Add(prmDECOBS2_RESERD);

            SqlParameter prmDTOBS1_RESERD = new SqlParameter("@DTOBS1_RESERD", SqlDbType.DateTime);
            prmDTOBS1_RESERD.Value = miClass.dtObs1_reserd;
            myCommand.Parameters.Add(prmDTOBS1_RESERD);

            SqlParameter prmDTOBS2_RESERD = new SqlParameter("@DTOBS2_RESERD", SqlDbType.DateTime);
            prmDTOBS2_RESERD.Value = miClass.dtObs2_reserd;
            myCommand.Parameters.Add(prmDTOBS2_RESERD);

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
        public int AddLAB_RESERVAD(
            string _strCod_reserd,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_sof,
            string _strCod_reserc,
            string _strNombre_reserd,
            DateTime _dtRegistro_reserd,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_reserd,
            string _strObs2_reserd,
            bool _bitObs1_reserd,
            bool _bitObs2_reserd,
            decimal _decObs1_reserd,
            decimal _decObs2_reserd,
            DateTime _dtObs1_reserd,
            DateTime _dtObs2_reserd
        )
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_RESERVAD", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            //Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_RESERD = new SqlParameter("@STRCOD_RESERD", SqlDbType.NVarChar);
            prmSTRCOD_RESERD.Value = _strCod_reserd;
            myCommand.Parameters.Add(prmSTRCOD_RESERD);

            SqlParameter prmSTRCOD_SOF = new SqlParameter("@STRCOD_SOF", SqlDbType.NVarChar);
            prmSTRCOD_SOF.Value = _strCod_sof;
            myCommand.Parameters.Add(prmSTRCOD_SOF);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = _strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = _strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRCOD_RESERC = new SqlParameter("@STRCOD_RESERC", SqlDbType.NVarChar);
            prmSTRCOD_RESERC.Value = _strCod_reserc;
            myCommand.Parameters.Add(prmSTRCOD_RESERC);

            SqlParameter prmSTRNOMBRE_RESERD = new SqlParameter("@STRNOMBRE_RESERD", SqlDbType.NVarChar);
            prmSTRNOMBRE_RESERD.Value = _strNombre_reserd;
            myCommand.Parameters.Add(prmSTRNOMBRE_RESERD);

            SqlParameter prmDTREGISTRO_RESERD = new SqlParameter("@DTREGISTRO_RESERD", SqlDbType.DateTime);
            prmDTREGISTRO_RESERD.Value = _dtRegistro_reserd;
            myCommand.Parameters.Add(prmDTREGISTRO_RESERD);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_RESERD = new SqlParameter("@STROBS1_RESERD", SqlDbType.NVarChar);
            prmSTROBS1_RESERD.Value = _strObs1_reserd;
            myCommand.Parameters.Add(prmSTROBS1_RESERD);

            SqlParameter prmSTROBS2_RESERD = new SqlParameter("@STROBS2_RESERD", SqlDbType.NVarChar);
            prmSTROBS2_RESERD.Value = _strObs2_reserd;
            myCommand.Parameters.Add(prmSTROBS2_RESERD);

            SqlParameter prmBITOBS1_RESERD = new SqlParameter("@BITOBS1_RESERD", SqlDbType.Bit);
            prmBITOBS1_RESERD.Value = _bitObs1_reserd;
            myCommand.Parameters.Add(prmBITOBS1_RESERD);

            SqlParameter prmBITOBS2_RESERD = new SqlParameter("@BITOBS2_RESERD", SqlDbType.Bit);
            prmBITOBS2_RESERD.Value = _bitObs2_reserd;
            myCommand.Parameters.Add(prmBITOBS2_RESERD);

            SqlParameter prmDECOBS1_RESERD = new SqlParameter("@DECOBS1_RESERD", SqlDbType.Decimal);
            prmDECOBS1_RESERD.Value = _decObs1_reserd;
            myCommand.Parameters.Add(prmDECOBS1_RESERD);

            SqlParameter prmDECOBS2_RESERD = new SqlParameter("@DECOBS2_RESERD", SqlDbType.Decimal);
            prmDECOBS2_RESERD.Value = _decObs2_reserd;
            myCommand.Parameters.Add(prmDECOBS2_RESERD);

            SqlParameter prmDTOBS1_RESERD = new SqlParameter("@DTOBS1_RESERD", SqlDbType.DateTime);
            prmDTOBS1_RESERD.Value = _dtObs1_reserd;
            myCommand.Parameters.Add(prmDTOBS1_RESERD);

            SqlParameter prmDTOBS2_RESERD = new SqlParameter("@DTOBS2_RESERD", SqlDbType.DateTime);
            prmDTOBS2_RESERD.Value = _dtObs2_reserd;
            myCommand.Parameters.Add(prmDTOBS2_RESERD);

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

        public int DelLAB_RESERVAD(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            //conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_DelLAB_RESERVAD", myConnection);
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