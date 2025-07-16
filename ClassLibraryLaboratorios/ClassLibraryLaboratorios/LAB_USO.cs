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
    public class LAB_USO
    {
        public LAB_USO() { }

        public LAB_USO(
            string _strCod_uso,
            string _strCod_reser,
            DateTime _dtHoraInicio_uso,
            string _strObservacion_uso,
            DateTime _dtFechaRegistro_uso,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_exter,
            string _strObs2_exter,
            bool _bitObs1_exter,
            bool _bitObs2_exter,
            decimal _decObs1_exter,
            decimal _decObs2_exter,
            DateTime _dtObs1_exter,
            DateTime _dtObs2_exter)
        {
            strCod_uso = _strCod_uso;
            strCod_reser = _strCod_reser;
            dtHoraInicio_uso = _dtHoraInicio_uso;
            strObservacion_uso = _strObservacion_uso;
            dtFechaRegistro_uso = _dtFechaRegistro_uso;
            dtFecha_log = _dtFecha_log;
            strUser_log = _strUser_log;
            strObs1_exter = _strObs1_exter;
            strObs2_exter = _strObs2_exter;
            bitObs1_exter = _bitObs1_exter;
            bitObs2_exter = _bitObs2_exter;
            decObs1_exter = _decObs1_exter;
            decObs2_exter = _decObs2_exter;
            dtObs1_exter = _dtObs1_exter;
            dtObs2_exter = _dtObs2_exter;

            numerr = 0;
            msg = string.Empty;
            resultado = false;
        }

        // Campos privados
        private string STRCOD_USO;
        private string STRCOD_RESER;
        private DateTime DTHORAINICIO_USO;
        private string STROBERVACION_USO;
        private DateTime DTFECHAREGISTRO_USO;
        private DateTime DTFECHA_LOG;
        private string STRUSER_LOG;
        private string STROBS1_EXTER;
        private string STROBS2_EXTER;
        private bool BITOBS1_EXTER;
        private bool BITOBS2_EXTER;
        private decimal DECOBS1_EXTER;
        private decimal DECOBS2_EXTER;
        private DateTime DTOBS1_EXTER;
        private DateTime DTOBS2_EXTER;

        private int NUMERR;
        private string MSG;
        private bool RESULTADO;

        ///////////////////// Generacion de propiedades/////////////////
        public string strCod_uso
        {
            get
            {
                return STRCOD_USO;
            }
            set
            {
                STRCOD_USO = value;
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

        public DateTime dtHoraInicio_uso
        {
            get
            {
                return DTHORAINICIO_USO;
            }
            set
            {
                DTHORAINICIO_USO = value;
            }
        }

        public string strObservacion_uso
        {
            get
            {
                return STROBERVACION_USO;
            }
            set
            {
                STROBERVACION_USO = value;
            }
        }

        public DateTime dtFechaRegistro_uso
        {
            get
            {
                return DTFECHAREGISTRO_USO;
            }
            set
            {
                DTFECHAREGISTRO_USO = value;
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

        public string strObs1_exter
        {
            get
            {
                return STROBS1_EXTER;
            }
            set
            {
                STROBS1_EXTER = value;
            }
        }

        public string strObs2_exter
        {
            get
            {
                return STROBS2_EXTER;
            }
            set
            {
                STROBS2_EXTER = value;
            }
        }

        public bool bitObs1_exter
        {
            get
            {
                return BITOBS1_EXTER;
            }
            set
            {
                BITOBS1_EXTER = value;
            }
        }

        public bool bitObs2_exter
        {
            get
            {
                return BITOBS2_EXTER;
            }
            set
            {
                BITOBS2_EXTER = value;
            }
        }

        public decimal decObs1_exter
        {
            get
            {
                return DECOBS1_EXTER;
            }
            set
            {
                DECOBS1_EXTER = value;
            }
        }

        public decimal decObs2_exter
        {
            get
            {
                return DECOBS2_EXTER;
            }
            set
            {
                DECOBS2_EXTER = value;
            }
        }

        public DateTime dtObs1_exter
        {
            get
            {
                return DTOBS1_EXTER;
            }
            set
            {
                DTOBS1_EXTER = value;
            }
        }

        public DateTime dtObs2_exter
        {
            get
            {
                return DTOBS2_EXTER;
            }
            set
            {
                DTOBS2_EXTER = value;
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
        public List<LAB_USO> LoadLAB_USO(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<LAB_USO>();
            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
            {
                using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_USO", myConnection))
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
                                LAB_USO miClase = new LAB_USO()
                                {
                                    strCod_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_uso"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_uso"))),
                                    strCod_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_reser"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_reser"))),
                                    dtHoraInicio_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtHoraInicio_uso"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtHoraInicio_uso"))),
                                    strObservacion_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObservacion_uso"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObservacion_uso"))),
                                    dtFechaRegistro_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_uso"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_uso"))),
                                    dtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    strUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strObs1_exter = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_exter"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_exter"))),
                                    strObs2_exter = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_exter"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_exter"))),
                                    bitObs1_exter = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_exter"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_exter"))),
                                    bitObs2_exter = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_exter"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_exter"))),
                                    decObs1_exter = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_exter"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_exter"))),
                                    decObs2_exter = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_exter"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_exter"))),
                                    dtObs1_exter = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_exter"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_exter"))),
                                    dtObs2_exter = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_exter"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_exter"))),


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
        public int AddLAB_USO(LAB_USO miClass)
        {
            // Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["db_conexion"])

            // Conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_USO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_USO = new SqlParameter("@STRCOD_USO", SqlDbType.NVarChar);
            prmSTRCOD_USO.Value = miClass.strCod_uso;
            myCommand.Parameters.Add(prmSTRCOD_USO);

            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = miClass.strCod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmDTHORAINICIO_USO = new SqlParameter("@DTHORAINICIO_USO", SqlDbType.DateTime);
            prmDTHORAINICIO_USO.Value = miClass.dtHoraInicio_uso;
            myCommand.Parameters.Add(prmDTHORAINICIO_USO);

            SqlParameter prmSTROBERVACION_USO = new SqlParameter("@STROBERVACION_USO", SqlDbType.NVarChar);
            prmSTROBERVACION_USO.Value = miClass.strObservacion_uso;
            myCommand.Parameters.Add(prmSTROBERVACION_USO);

            SqlParameter prmDTFECHAREGISTRO_USO = new SqlParameter("@DTFECHAREGISTRO_USO", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_USO.Value = miClass.dtFechaRegistro_uso;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_USO);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_EXTER = new SqlParameter("@STROBS1_EXTER", SqlDbType.NVarChar);
            prmSTROBS1_EXTER.Value = miClass.strObs1_exter;
            myCommand.Parameters.Add(prmSTROBS1_EXTER);

            SqlParameter prmSTROBS2_EXTER = new SqlParameter("@STROBS2_EXTER", SqlDbType.NVarChar);
            prmSTROBS2_EXTER.Value = miClass.strObs2_exter;
            myCommand.Parameters.Add(prmSTROBS2_EXTER);

            SqlParameter prmBITOBS1_EXTER = new SqlParameter("@BITOBS1_EXTER", SqlDbType.Bit);
            prmBITOBS1_EXTER.Value = miClass.bitObs1_exter;
            myCommand.Parameters.Add(prmBITOBS1_EXTER);

            SqlParameter prmBITOBS2_EXTER = new SqlParameter("@BITOBS2_EXTER", SqlDbType.Bit);
            prmBITOBS2_EXTER.Value = miClass.bitObs2_exter;
            myCommand.Parameters.Add(prmBITOBS2_EXTER);

            SqlParameter prmDECOBS1_EXTER = new SqlParameter("@DECOBS1_EXTER", SqlDbType.Decimal);
            prmDECOBS1_EXTER.Value = miClass.decObs1_exter;
            myCommand.Parameters.Add(prmDECOBS1_EXTER);

            SqlParameter prmDECOBS2_EXTER = new SqlParameter("@DECOBS2_EXTER", SqlDbType.Decimal);
            prmDECOBS2_EXTER.Value = miClass.decObs2_exter;
            myCommand.Parameters.Add(prmDECOBS2_EXTER);

            SqlParameter prmDTOBS1_EXTER = new SqlParameter("@DTOBS1_EXTER", SqlDbType.DateTime);
            prmDTOBS1_EXTER.Value = miClass.dtObs1_exter;
            myCommand.Parameters.Add(prmDTOBS1_EXTER);

            SqlParameter prmDTOBS2_EXTER = new SqlParameter("@DTOBS2_EXTER", SqlDbType.DateTime);
            prmDTOBS2_EXTER.Value = miClass.dtObs2_exter;
            myCommand.Parameters.Add(prmDTOBS2_EXTER);

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

        public int AddLAB_USO(
            string _strCod_uso,
            string _strCod_reser,
            DateTime _dtHoraInicio_uso,
            string _strObservacion_uso,
            DateTime _dtFechaRegistro_uso,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_exter,
            string _strObs2_exter,
            bool _bitObs1_exter,
            bool _bitObs2_exter,
            decimal _decObs1_exter,
            decimal _decObs2_exter,
            DateTime _dtObs1_exter,
            DateTime _dtObs2_exter)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            //SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["db_conexion"])

            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_USO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSTRCOD_USO = new SqlParameter("@STRCOD_USO", SqlDbType.NVarChar);
            prmSTRCOD_USO.Value = _strCod_uso;
            myCommand.Parameters.Add(prmSTRCOD_USO);

            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = _strCod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmDTHORAINICIO_USO = new SqlParameter("@DTHORAINICIO_USO", SqlDbType.DateTime);
            prmDTHORAINICIO_USO.Value = _dtHoraInicio_uso;
            myCommand.Parameters.Add(prmDTHORAINICIO_USO);

            SqlParameter prmSTROBERVACION_USO = new SqlParameter("@STROBERVACION_USO", SqlDbType.NVarChar);
            prmSTROBERVACION_USO.Value = _strObservacion_uso;
            myCommand.Parameters.Add(prmSTROBERVACION_USO);

            SqlParameter prmDTFECHAREGISTRO_USO = new SqlParameter("@DTFECHAREGISTRO_USO", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_USO.Value = _dtFechaRegistro_uso;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_USO);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_EXTER = new SqlParameter("@STROBS1_EXTER", SqlDbType.NVarChar);
            prmSTROBS1_EXTER.Value = _strObs1_exter;
            myCommand.Parameters.Add(prmSTROBS1_EXTER);

            SqlParameter prmSTROBS2_EXTER = new SqlParameter("@STROBS2_EXTER", SqlDbType.NVarChar);
            prmSTROBS2_EXTER.Value = _strObs2_exter;
            myCommand.Parameters.Add(prmSTROBS2_EXTER);

            SqlParameter prmBITOBS1_EXTER = new SqlParameter("@BITOBS1_EXTER", SqlDbType.Bit);
            prmBITOBS1_EXTER.Value = _bitObs1_exter;
            myCommand.Parameters.Add(prmBITOBS1_EXTER);

            SqlParameter prmBITOBS2_EXTER = new SqlParameter("@BITOBS2_EXTER", SqlDbType.Bit);
            prmBITOBS2_EXTER.Value = _bitObs2_exter;
            myCommand.Parameters.Add(prmBITOBS2_EXTER);

            SqlParameter prmDECOBS1_EXTER = new SqlParameter("@DECOBS1_EXTER", SqlDbType.Decimal);
            prmDECOBS1_EXTER.Value = _decObs1_exter;
            myCommand.Parameters.Add(prmDECOBS1_EXTER);

            SqlParameter prmDECOBS2_EXTER = new SqlParameter("@DECOBS2_EXTER", SqlDbType.Decimal);
            prmDECOBS2_EXTER.Value = _decObs2_exter;
            myCommand.Parameters.Add(prmDECOBS2_EXTER);

            SqlParameter prmDTOBS1_EXTER = new SqlParameter("@DTOBS1_EXTER", SqlDbType.DateTime);
            prmDTOBS1_EXTER.Value = _dtObs1_exter;
            myCommand.Parameters.Add(prmDTOBS1_EXTER);

            SqlParameter prmDTOBS2_EXTER = new SqlParameter("@DTOBS2_EXTER", SqlDbType.DateTime);
            prmDTOBS2_EXTER.Value = _dtObs2_exter;
            myCommand.Parameters.Add(prmDTOBS2_EXTER);

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
    }
}