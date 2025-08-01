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
            string _strcod_uso,
            string _strcod_reser,
            DateTime _dthorainicio_uso,
            string _strobservacion_uso,
            DateTime _dtfecharegistro_uso,
            bool _bitestado_uso,
            DateTime _dtfecha_log,
            string _struser_log,
            string _strobs1_uso,
            string _strobs2_uso,
            bool _bitobs1_uso,
            bool _bitobs2_uso,
            decimal _decobs1_uso,
            decimal _decobs2_uso,
            DateTime _dtobs1_uso,
            DateTime _dtobs2_uso
            )
        {
            strcod_uso = _strcod_uso;
            strcod_reser = _strcod_reser;
            dthorainicio_uso = _dthorainicio_uso;
            strobservacion_uso = _strobservacion_uso;
            dtfecharegistro_uso = _dtfecharegistro_uso;
            bitestado_uso = _bitestado_uso;
            dtfecha_log = _dtfecha_log;
            struser_log = _struser_log;
            strobs1_uso = _strobs1_uso;
            strobs2_uso = _strobs2_uso;
            bitobs1_uso = _bitobs1_uso;
            bitobs2_uso = _bitobs2_uso;
            decobs1_uso = _decobs1_uso;
            decobs2_uso = _decobs2_uso;
            dtobs1_uso = _dtobs1_uso;
            dtobs2_uso = _dtobs2_uso;

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
        private bool BITESTADO_USO;
        private DateTime DTFECHA_LOG;
        private string STRUSER_LOG;
        private string STROBS1_USO;
        private string STROBS2_USO;
        private bool BITOBS1_USO;
        private bool BITOBS2_USO;
        private decimal DECOBS1_USO;
        private decimal DECOBS2_USO;
        private DateTime DTOBS1_USO;
        private DateTime DTOBS2_USO;


        private int NUMERR;
        private string MSG;
        private bool RESULTADO;

        ///////////////////// Generacion de propiedades/////////////////
        public string strcod_uso
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

        public string strcod_reser
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

        public DateTime dthorainicio_uso
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

        public string strobservacion_uso
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

        public DateTime dtfecharegistro_uso
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

        public bool bitestado_uso
        {
            get
            {
                return BITESTADO_USO;
            }
            set
            {
                BITESTADO_USO = value;
            }
        }

        public DateTime dtfecha_log
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

        public string struser_log
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

        public string strobs1_uso
        {
            get
            {
                return STROBS1_USO;
            }
            set
            {
                STROBS1_USO = value;
            }
        }

        public string strobs2_uso
        {
            get
            {
                return STROBS2_USO;
            }
            set
            {
                STROBS2_USO = value;
            }
        }

        public bool bitobs1_uso
        {
            get
            {
                return BITOBS1_USO;
            }
            set
            {
                BITOBS1_USO = value;
            }
        }

        public bool bitobs2_uso
        {
            get
            {
                return BITOBS2_USO;
            }
            set
            {
                BITOBS2_USO = value;
            }
        }

        public decimal decobs1_uso
        {
            get
            {
                return DECOBS1_USO;
            }
            set
            {
                DECOBS1_USO = value;
            }
        }

        public decimal decobs2_uso
        {
            get
            {
                return DECOBS2_USO;
            }
            set
            {
                DECOBS2_USO = value;
            }
        }

        public DateTime dtobs1_uso
        {
            get
            {
                return DTOBS1_USO;
            }
            set
            {
                DTOBS1_USO = value;
            }
        }

        public DateTime dtobs2_uso
        {
            get
            {
                return DTOBS2_USO;
            }
            set
            {
                DTOBS2_USO = value;
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
                                    strcod_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_uso"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_uso"))),
                                    strcod_reser = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_reser"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_reser"))),
                                    dthorainicio_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtHoraInicio_uso"))) ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtHoraInicio_uso"))),
                                    strobservacion_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObservacion_uso"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObservacion_uso"))),
                                    dtfecharegistro_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_uso"))) ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_uso"))),
                                    bitestado_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitEstado_uso"))) ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitEstado_uso"))),
                                    dtfecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    struser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strobs1_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_uso"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_uso"))),
                                    strobs2_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_uso"))) ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_uso"))),
                                    bitobs1_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_uso"))) ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_uso"))),
                                    bitobs2_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_uso"))) ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_uso"))),
                                    decobs1_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_uso"))) ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_uso"))),
                                    decobs2_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_uso"))) ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_uso"))),
                                    dtobs1_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_uso"))) ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_uso"))),
                                    dtobs2_uso = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_uso"))) ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_uso"))),


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

            // Conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_USO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_USO = new SqlParameter("@STRCOD_USO", SqlDbType.NVarChar);
            prmSTRCOD_USO.Value = miClass.strcod_uso;
            myCommand.Parameters.Add(prmSTRCOD_USO);

            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = miClass.strcod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmDTHORAINICIO_USO = new SqlParameter("@DTHORAINICIO_USO", SqlDbType.DateTime);
            prmDTHORAINICIO_USO.Value = miClass.dthorainicio_uso;
            myCommand.Parameters.Add(prmDTHORAINICIO_USO);

            SqlParameter prmSTROBSERVACION_USO = new SqlParameter("@STROBSERVACION_USO", SqlDbType.NVarChar);
            prmSTROBSERVACION_USO.Value = miClass.strobservacion_uso;
            myCommand.Parameters.Add(prmSTROBSERVACION_USO);

            SqlParameter prmDTFECHAREGISTRO_USO = new SqlParameter("@DTFECHAREGISTRO_USO", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_USO.Value = miClass.dtfecharegistro_uso;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_USO);

            SqlParameter prmBITESTADO_USO = new SqlParameter("@BITESTADO_USO", SqlDbType.Bit);
            prmBITESTADO_USO.Value = miClass.bitestado_uso;
            myCommand.Parameters.Add(prmBITESTADO_USO);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtfecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.struser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_USO = new SqlParameter("@STROBS1_USO", SqlDbType.NVarChar);
            prmSTROBS1_USO.Value = miClass.strobs1_uso;
            myCommand.Parameters.Add(prmSTROBS1_USO);

            SqlParameter prmSTROBS2_USO = new SqlParameter("@STROBS2_USO", SqlDbType.NVarChar);
            prmSTROBS2_USO.Value = miClass.strobs2_uso;
            myCommand.Parameters.Add(prmSTROBS2_USO);

            SqlParameter prmBITOBS1_USO = new SqlParameter("@BITOBS1_USO", SqlDbType.Bit);
            prmBITOBS1_USO.Value = miClass.bitobs1_uso;
            myCommand.Parameters.Add(prmBITOBS1_USO);

            SqlParameter prmBITOBS2_USO = new SqlParameter("@BITOBS2_USO", SqlDbType.Bit);
            prmBITOBS2_USO.Value = miClass.bitobs2_uso;
            myCommand.Parameters.Add(prmBITOBS2_USO);

            SqlParameter prmDECOBS1_USO = new SqlParameter("@DECOBS1_USO", SqlDbType.Decimal);
            prmDECOBS1_USO.Value = miClass.decobs1_uso;
            myCommand.Parameters.Add(prmDECOBS1_USO);

            SqlParameter prmDECOBS2_USO = new SqlParameter("@DECOBS2_USO", SqlDbType.Decimal);
            prmDECOBS2_USO.Value = miClass.decobs2_uso;
            myCommand.Parameters.Add(prmDECOBS2_USO);

            SqlParameter prmDTOBS1_USO = new SqlParameter("@DTOBS1_USO", SqlDbType.DateTime);
            prmDTOBS1_USO.Value = miClass.dtobs1_uso;
            myCommand.Parameters.Add(prmDTOBS1_USO);

            SqlParameter prmDTOBS2_USO = new SqlParameter("@DTOBS2_USO", SqlDbType.DateTime);
            prmDTOBS2_USO.Value = miClass.dtobs2_uso;
            myCommand.Parameters.Add(prmDTOBS2_USO);


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
            string _strcod_uso,
            string _strcod_reser,
            DateTime _dthorainicio_uso,
            string _strobservacion_uso,
            DateTime _dtfecharegistro_uso,
            bool _bitestado_uso,
            DateTime _dtfecha_log,
            string _struser_log,
            string _strobs1_uso,
            string _strobs2_uso,
            bool _bitobs1_uso,
            bool _bitobs2_uso,
            decimal _decobs1_uso,
            decimal _decobs2_uso,
            DateTime _dtobs1_uso,
            DateTime _dtobs2_uso
            )
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_USO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSTRCOD_USO = new SqlParameter("@STRCOD_USO", SqlDbType.NVarChar);
            prmSTRCOD_USO.Value = _strcod_uso;
            myCommand.Parameters.Add(prmSTRCOD_USO);

            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = _strcod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmDTHORAINICIO_USO = new SqlParameter("@DTHORAINICIO_USO", SqlDbType.DateTime);
            prmDTHORAINICIO_USO.Value = _dthorainicio_uso;
            myCommand.Parameters.Add(prmDTHORAINICIO_USO);

            SqlParameter prmSTROBSERVACION_USO = new SqlParameter("@STROBSERVACION_USO", SqlDbType.NVarChar);
            prmSTROBSERVACION_USO.Value = _strobservacion_uso;
            myCommand.Parameters.Add(prmSTROBSERVACION_USO);

            SqlParameter prmDTFECHAREGISTRO_USO = new SqlParameter("@DTFECHAREGISTRO_USO", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_USO.Value = _dtfecharegistro_uso;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_USO);

            SqlParameter prmBITESTADO_USO = new SqlParameter("@BITESTADO_USO", SqlDbType.Bit);
            prmBITESTADO_USO.Value = _bitestado_uso;
            myCommand.Parameters.Add(prmBITESTADO_USO);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtfecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _struser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_USO = new SqlParameter("@STROBS1_USO", SqlDbType.NVarChar);
            prmSTROBS1_USO.Value = _strobs1_uso;
            myCommand.Parameters.Add(prmSTROBS1_USO);

            SqlParameter prmSTROBS2_USO = new SqlParameter("@STROBS2_USO", SqlDbType.NVarChar);
            prmSTROBS2_USO.Value = _strobs2_uso;
            myCommand.Parameters.Add(prmSTROBS2_USO);

            SqlParameter prmBITOBS1_USO = new SqlParameter("@BITOBS1_USO", SqlDbType.Bit);
            prmBITOBS1_USO.Value = _bitobs1_uso;
            myCommand.Parameters.Add(prmBITOBS1_USO);

            SqlParameter prmBITOBS2_USO = new SqlParameter("@BITOBS2_USO", SqlDbType.Bit);
            prmBITOBS2_USO.Value = _bitobs2_uso;
            myCommand.Parameters.Add(prmBITOBS2_USO);

            SqlParameter prmDECOBS1_USO = new SqlParameter("@DECOBS1_USO", SqlDbType.Decimal);
            prmDECOBS1_USO.Value = _decobs1_uso;
            myCommand.Parameters.Add(prmDECOBS1_USO);

            SqlParameter prmDECOBS2_USO = new SqlParameter("@DECOBS2_USO", SqlDbType.Decimal);
            prmDECOBS2_USO.Value = _decobs2_uso;
            myCommand.Parameters.Add(prmDECOBS2_USO);

            SqlParameter prmDTOBS1_USO = new SqlParameter("@DTOBS1_USO", SqlDbType.DateTime);
            prmDTOBS1_USO.Value = _dtobs1_uso;
            myCommand.Parameters.Add(prmDTOBS1_USO);

            SqlParameter prmDTOBS2_USO = new SqlParameter("@DTOBS2_USO", SqlDbType.DateTime);
            prmDTOBS2_USO.Value = _dtobs2_uso;
            myCommand.Parameters.Add(prmDTOBS2_USO);


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

        ///////////////// Método Update /////////////////
        public int UpdateLAB_USO(LAB_USO miClass)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_USO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSTRCOD_USO = new SqlParameter("@STRCOD_USO", SqlDbType.NVarChar);
            prmSTRCOD_USO.Value = miClass.strcod_uso;
            myCommand.Parameters.Add(prmSTRCOD_USO);

            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = miClass.strcod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmDTHORAINICIO_USO = new SqlParameter("@DTHORAINICIO_USO", SqlDbType.DateTime);
            prmDTHORAINICIO_USO.Value = miClass.dthorainicio_uso;
            myCommand.Parameters.Add(prmDTHORAINICIO_USO);

            SqlParameter prmSTROBSERVACION_USO = new SqlParameter("@STROBSERVACION_USO", SqlDbType.NVarChar);
            prmSTROBSERVACION_USO.Value = miClass.strobservacion_uso;
            myCommand.Parameters.Add(prmSTROBSERVACION_USO);

            SqlParameter prmDTFECHAREGISTRO_USO = new SqlParameter("@DTFECHAREGISTRO_USO", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_USO.Value = miClass.dtfecharegistro_uso;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_USO);

            SqlParameter prmBITESTADO_USO = new SqlParameter("@BITESTADO_USO", SqlDbType.Bit);
            prmBITESTADO_USO.Value = miClass.bitestado_uso;
            myCommand.Parameters.Add(prmBITESTADO_USO);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtfecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.struser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_USO = new SqlParameter("@STROBS1_USO", SqlDbType.NVarChar);
            prmSTROBS1_USO.Value = miClass.strobs1_uso;
            myCommand.Parameters.Add(prmSTROBS1_USO);

            SqlParameter prmSTROBS2_USO = new SqlParameter("@STROBS2_USO", SqlDbType.NVarChar);
            prmSTROBS2_USO.Value = miClass.strobs2_uso;
            myCommand.Parameters.Add(prmSTROBS2_USO);

            SqlParameter prmBITOBS1_USO = new SqlParameter("@BITOBS1_USO", SqlDbType.Bit);
            prmBITOBS1_USO.Value = miClass.bitobs1_uso;
            myCommand.Parameters.Add(prmBITOBS1_USO);

            SqlParameter prmBITOBS2_USO = new SqlParameter("@BITOBS2_USO", SqlDbType.Bit);
            prmBITOBS2_USO.Value = miClass.bitobs2_uso;
            myCommand.Parameters.Add(prmBITOBS2_USO);

            SqlParameter prmDECOBS1_USO = new SqlParameter("@DECOBS1_USO", SqlDbType.Decimal);
            prmDECOBS1_USO.Value = miClass.decobs1_uso;
            myCommand.Parameters.Add(prmDECOBS1_USO);

            SqlParameter prmDECOBS2_USO = new SqlParameter("@DECOBS2_USO", SqlDbType.Decimal);
            prmDECOBS2_USO.Value = miClass.decobs2_uso;
            myCommand.Parameters.Add(prmDECOBS2_USO);

            SqlParameter prmDTOBS1_USO = new SqlParameter("@DTOBS1_USO", SqlDbType.DateTime);
            prmDTOBS1_USO.Value = miClass.dtobs1_uso;
            myCommand.Parameters.Add(prmDTOBS1_USO);

            SqlParameter prmDTOBS2_USO = new SqlParameter("@DTOBS2_USO", SqlDbType.DateTime);
            prmDTOBS2_USO.Value = miClass.dtobs2_uso;
            myCommand.Parameters.Add(prmDTOBS2_USO);



            int intReturn = -1;
            try
            {
                myConnection.Open();
                intReturn = myCommand.ExecuteNonQuery(); // Devuelve el número de registros afectados en la bd
                resultado = true;
                msg = "Los datos se actualizaron satisfactoriamente...";
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
        public int UpdateLAB_USO(
            string _strcod_uso,
            string _strcod_reser,
            DateTime _dthorainicio_uso,
            string _strobservacion_uso,
            DateTime _dtfecharegistro_uso,
            bool _bitestado_uso,
            DateTime _dtfecha_log,
            string _struser_log,
            string _strobs1_uso,
            string _strobs2_uso,
            bool _bitobs1_uso,
            bool _bitobs2_uso,
            decimal _decobs1_uso,
            decimal _decobs2_uso,
            DateTime _dtobs1_uso,
            DateTime _dtobs2_uso
            )
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_USO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSTRCOD_USO = new SqlParameter("@STRCOD_USO", SqlDbType.NVarChar);
            prmSTRCOD_USO.Value = _strcod_uso;
            myCommand.Parameters.Add(prmSTRCOD_USO);

            SqlParameter prmSTRCOD_RESER = new SqlParameter("@STRCOD_RESER", SqlDbType.NVarChar);
            prmSTRCOD_RESER.Value = _strcod_reser;
            myCommand.Parameters.Add(prmSTRCOD_RESER);

            SqlParameter prmDTHORAINICIO_USO = new SqlParameter("@DTHORAINICIO_USO", SqlDbType.DateTime);
            prmDTHORAINICIO_USO.Value = _dthorainicio_uso;
            myCommand.Parameters.Add(prmDTHORAINICIO_USO);

            SqlParameter prmSTROBSERVACION_USO = new SqlParameter("@STROBSERVACION_USO", SqlDbType.NVarChar);
            prmSTROBSERVACION_USO.Value = _strobservacion_uso;
            myCommand.Parameters.Add(prmSTROBSERVACION_USO);

            SqlParameter prmDTFECHAREGISTRO_USO = new SqlParameter("@DTFECHAREGISTRO_USO", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_USO.Value = _dtfecharegistro_uso;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_USO);

            SqlParameter prmBITESTADO_USO = new SqlParameter("@BITESTADO_USO", SqlDbType.Bit);
            prmBITESTADO_USO.Value = _bitestado_uso;
            myCommand.Parameters.Add(prmBITESTADO_USO);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtfecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _struser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_USO = new SqlParameter("@STROBS1_USO", SqlDbType.NVarChar);
            prmSTROBS1_USO.Value = _strobs1_uso;
            myCommand.Parameters.Add(prmSTROBS1_USO);

            SqlParameter prmSTROBS2_USO = new SqlParameter("@STROBS2_USO", SqlDbType.NVarChar);
            prmSTROBS2_USO.Value = _strobs2_uso;
            myCommand.Parameters.Add(prmSTROBS2_USO);

            SqlParameter prmBITOBS1_USO = new SqlParameter("@BITOBS1_USO", SqlDbType.Bit);
            prmBITOBS1_USO.Value = _bitobs1_uso;
            myCommand.Parameters.Add(prmBITOBS1_USO);

            SqlParameter prmBITOBS2_USO = new SqlParameter("@BITOBS2_USO", SqlDbType.Bit);
            prmBITOBS2_USO.Value = _bitobs2_uso;
            myCommand.Parameters.Add(prmBITOBS2_USO);

            SqlParameter prmDECOBS1_USO = new SqlParameter("@DECOBS1_USO", SqlDbType.Decimal);
            prmDECOBS1_USO.Value = _decobs1_uso;
            myCommand.Parameters.Add(prmDECOBS1_USO);

            SqlParameter prmDECOBS2_USO = new SqlParameter("@DECOBS2_USO", SqlDbType.Decimal);
            prmDECOBS2_USO.Value = _decobs2_uso;
            myCommand.Parameters.Add(prmDECOBS2_USO);

            SqlParameter prmDTOBS1_USO = new SqlParameter("@DTOBS1_USO", SqlDbType.DateTime);
            prmDTOBS1_USO.Value = _dtobs1_uso;
            myCommand.Parameters.Add(prmDTOBS1_USO);

            SqlParameter prmDTOBS2_USO = new SqlParameter("@DTOBS2_USO", SqlDbType.DateTime);
            prmDTOBS2_USO.Value = _dtobs2_uso;
            myCommand.Parameters.Add(prmDTOBS2_USO);



            int intReturn = -1;
            try
            {
                myConnection.Open();
                intReturn = myCommand.ExecuteNonQuery(); // Devuelve el número de registros afectados en la bd
                resultado = true;
                msg = "Los datos se actualizaron satisfactoriamente...";
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
        public int DeleteLAB_USO(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_DeleteLAB_USO", myConnection);
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
                resultado = true;
                msg = "Los datos se eliminaron satisfactoriamente...";
            }
            catch (SqlException er)
            {
                if (er.Number == 547)
                {
                    msg = "Este registro no se puede eliminar porque está siendo utilizado por otro proceso...";
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