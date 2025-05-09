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
    public class LAB_MOTIVO_RESERVAS
    {
        public LAB_MOTIVO_RESERVAS() { }

        public LAB_MOTIVO_RESERVAS(
            string _strCod_motRes,
            string _strNombre_motRes,
            DateTime _dtFechaRegistro_motRes,
            bool _bitEstado_motRes,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_lab,
            string _strObs2_lab,
            bool _bitObs1_lab,
            bool _bitObs2_lab,
            decimal _decObs1_lab,
            decimal _decObs2_lab,
            DateTime _dtObs1_lab,
            DateTime _dtObs2_lab)
        {
            strCod_motRes = _strCod_motRes;
            strNombre_motRes = _strNombre_motRes;
            dtFechaRegistro_motRes = _dtFechaRegistro_motRes;
            bitEstado_motRes = _bitEstado_motRes;
            dtFecha_log = _dtFecha_log;
            strUser_log = _strUser_log;
            strObs1_lab = _strObs1_lab;
            strObs2_lab = _strObs2_lab;
            bitObs1_lab = _bitObs1_lab;
            bitObs2_lab = _bitObs2_lab;
            decObs1_lab = _decObs1_lab;
            decObs2_lab = _decObs2_lab;
            dtObs1_lab = _dtObs1_lab;
            dtObs2_lab = _dtObs2_lab;

            NUMERR = 0;
            MSG = string.Empty;
            RESULTADO = false;
        }

        // Campos privados
        private string STRCOD_MOTRES;
        private string STRNOMBRE_MOTRES;
        private DateTime DTFECHAREGISTRO_MOTRES;
        private bool BITESTADO_MOTRES;
        private DateTime DTFECCHA_LOG;
        private string STRUSER_LOG;
        private string STROBS1_LAB;
        private string STROBS2_LAB;
        private bool BITOBS1_LAB;
        private bool BITOBS2_LAB;
        private decimal DECOBS1_LAB;
        private decimal DECOBS2_LAB;
        private DateTime DTOBS1_LAB;
        private DateTime DTOBS2_LAB;
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

        public string strCod_motRes
        {
            get
            {
                return STRCOD_MOTRES;
            }
            set
            {
                STRCOD_MOTRES = value;
            }
        }

        public string strNombre_motRes
        {
            get
            {
                return STRNOMBRE_MOTRES;
            }
            set
            {
                STRNOMBRE_MOTRES = value;
            }
        }

        public DateTime dtFechaRegistro_motRes
        {
            get
            {
                return DTFECHAREGISTRO_MOTRES;
            }
            set
            {
                DTFECHAREGISTRO_MOTRES = value;
            }
        }

        public bool bitEstado_motRes
        {
            get
            {
                return BITESTADO_MOTRES;
            }
            set
            {
                BITESTADO_MOTRES = value;
            }
        }

        public DateTime dtFecha_log
        {
            get
            {
                return DTFECCHA_LOG;
            }
            set
            {
                DTFECCHA_LOG = value;
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

        public string strObs1_lab
        {
            get
            {
                return STROBS1_LAB;
            }
            set
            {
                STROBS1_LAB = value;
            }
        }

        public string strObs2_lab
        {
            get
            {
                return STROBS2_LAB;
            }
            set
            {
                STROBS2_LAB = value;
            }
        }

        public bool bitObs1_lab
        {
            get
            {
                return BITOBS1_LAB;
            }
            set
            {
                BITOBS1_LAB = value;
            }
        }

        public bool bitObs2_lab
        {
            get
            {
                return BITOBS2_LAB;
            }
            set
            {
                BITOBS2_LAB = value;
            }
        }

        public decimal decObs1_lab
        {
            get
            {
                return DECOBS1_LAB;
            }
            set
            {
                DECOBS1_LAB = value;
            }
        }

        public decimal decObs2_lab
        {
            get
            {
                return DECOBS2_LAB;
            }
            set
            {
                DECOBS2_LAB = value;
            }
        }

        public DateTime dtObs1_lab
        {
            get
            {
                return DTOBS1_LAB;
            }
            set
            {
                DTOBS1_LAB = value;
            }
        }

        public DateTime dtObs2_lab
        {
            get
            {
                return DTOBS2_LAB;
            }
            set
            {
                DTOBS2_LAB = value;
            }
        }


        ///////////////// Método Get /////////////////

        public List<LAB_MOTIVO_RESERVAS> LoadLAB_MOTIVO_RESERVAS(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<LAB_MOTIVO_RESERVAS>();
            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
            {
                using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_MOTIVO_RESERVAS", myConnection))
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
                                LAB_MOTIVO_RESERVAS miClase = new LAB_MOTIVO_RESERVAS()
                                {
                                    strCod_motRes = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_motRes"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_motRes"))),
                                    strNombre_motRes = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strNombre_motRes"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strNombre_motRes"))),
                                    dtFechaRegistro_motRes = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_motRes"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_motRes"))),
                                    bitEstado_motRes = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitEstado_motRes"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitEstado_motRes"))),
                                    dtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    strUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strObs1_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_lab"))),
                                    strObs2_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_lab"))),
                                    bitObs1_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_lab"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_lab"))),
                                    bitObs2_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_lab"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_lab"))),
                                    decObs1_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_lab"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_lab"))),
                                    decObs2_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_lab"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_lab"))),
                                    dtObs1_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_lab"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_lab"))),
                                    dtObs2_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_lab"))) == true ? DateTime.Now : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_lab"))),
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


        public int AddLAB_MOTIVO_RESERVAS(LAB_MOTIVO_RESERVAS miClass)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_MOTIVO_RESERVAS", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSTRCOD_MOTRES = new SqlParameter("@STRCOD_MOTRES", SqlDbType.NVarChar);
            prmSTRCOD_MOTRES.Value = miClass.strCod_motRes;
            myCommand.Parameters.Add(prmSTRCOD_MOTRES);

            SqlParameter prmSTRNOMBRE_MOTRES = new SqlParameter("@STRNOMBRE_MOTRES", SqlDbType.NVarChar);
            prmSTRNOMBRE_MOTRES.Value = miClass.strNombre_motRes;
            myCommand.Parameters.Add(prmSTRNOMBRE_MOTRES);

            SqlParameter prmDTFECHAREGISTRO_MOTRES = new SqlParameter("@DTFECHAREGISTRO_MOTRES", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_MOTRES.Value = miClass.dtFechaRegistro_motRes;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_MOTRES);

            SqlParameter prmBITESTADO_MOTRES = new SqlParameter("@BITESTADO_MOTRES", SqlDbType.Bit);
            prmBITESTADO_MOTRES.Value = miClass.bitEstado_motRes;
            myCommand.Parameters.Add(prmBITESTADO_MOTRES);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_LAB = new SqlParameter("@STROBS1_LAB", SqlDbType.NVarChar);
            prmSTROBS1_LAB.Value = miClass.strObs1_lab;
            myCommand.Parameters.Add(prmSTROBS1_LAB);

            SqlParameter prmSTROBS2_LAB = new SqlParameter("@STROBS2_LAB", SqlDbType.NVarChar);
            prmSTROBS2_LAB.Value = miClass.strObs2_lab;
            myCommand.Parameters.Add(prmSTROBS2_LAB);

            SqlParameter prmBITOBS1_LAB = new SqlParameter("@BITOBS1_LAB", SqlDbType.Bit);
            prmBITOBS1_LAB.Value = miClass.bitObs1_lab;
            myCommand.Parameters.Add(prmBITOBS1_LAB);

            SqlParameter prmBITOBS2_LAB = new SqlParameter("@BITOBS2_LAB", SqlDbType.Bit);
            prmBITOBS2_LAB.Value = miClass.bitObs2_lab;
            myCommand.Parameters.Add(prmBITOBS2_LAB);

            SqlParameter prmDECOBS1_LAB = new SqlParameter("@DECOBS1_LAB", SqlDbType.Decimal);
            prmDECOBS1_LAB.Value = miClass.decObs1_lab;
            myCommand.Parameters.Add(prmDECOBS1_LAB);

            SqlParameter prmDECOBS2_LAB = new SqlParameter("@DECOBS2_LAB", SqlDbType.Decimal);
            prmDECOBS2_LAB.Value = miClass.decObs2_lab;
            myCommand.Parameters.Add(prmDECOBS2_LAB);

            SqlParameter prmDTOBS1_LAB = new SqlParameter("@DTOBS1_LAB", SqlDbType.DateTime);
            prmDTOBS1_LAB.Value = miClass.dtObs1_lab;
            myCommand.Parameters.Add(prmDTOBS1_LAB);

            SqlParameter prmDTOBS2_LAB = new SqlParameter("@DTOBS2_LAB", SqlDbType.DateTime);
            prmDTOBS2_LAB.Value = miClass.dtObs2_lab;
            myCommand.Parameters.Add(prmDTOBS2_LAB);

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

        ///////////////// Método Add SobreCargado /////////////////
        public int AddLAB_MOTIVO_RESERVAS(
              string _strCod_motRes,
              string _strNombre_motRes,
              DateTime _dtFechaRegistro_motRes,
              bool _bitEstado_motRes,
              DateTime _dtFecha_log,
              string _strUser_log,
              string _strObs1_lab,
              string _strObs2_lab,
              bool _bitObs1_lab,
              bool _bitObs2_lab,
              decimal _decObs1_lab,
              decimal _decObs2_lab,
              DateTime _dtObs1_lab,
              DateTime _dtObs2_lab)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_MOTIVO_RESERVAS", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSTRCOD_MOTRES = new SqlParameter("@STRCOD_MOTRES", SqlDbType.NVarChar);
            prmSTRCOD_MOTRES.Value = _strCod_motRes;
            myCommand.Parameters.Add(prmSTRCOD_MOTRES);

            SqlParameter prmSTRNOMBRE_MOTRES = new SqlParameter("@STRNOMBRE_MOTRES", SqlDbType.NVarChar);
            prmSTRNOMBRE_MOTRES.Value = _strNombre_motRes;
            myCommand.Parameters.Add(prmSTRNOMBRE_MOTRES);

            SqlParameter prmDTFECHAREGISTRO_MOTRES = new SqlParameter("@DTFECHAREGISTRO_MOTRES", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_MOTRES.Value = _dtFechaRegistro_motRes;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_MOTRES);

            SqlParameter prmBITESTADO_MOTRES = new SqlParameter("@BITESTADO_MOTRES", SqlDbType.Bit);
            prmBITESTADO_MOTRES.Value = _bitEstado_motRes;
            myCommand.Parameters.Add(prmBITESTADO_MOTRES);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_LAB = new SqlParameter("@STROBS1_LAB", SqlDbType.NVarChar);
            prmSTROBS1_LAB.Value = _strObs1_lab;
            myCommand.Parameters.Add(prmSTROBS1_LAB);

            SqlParameter prmSTROBS2_LAB = new SqlParameter("@STROBS2_LAB", SqlDbType.NVarChar);
            prmSTROBS2_LAB.Value = _strObs2_lab;
            myCommand.Parameters.Add(prmSTROBS2_LAB);

            SqlParameter prmBITOBS1_LAB = new SqlParameter("@BITOBS1_LAB", SqlDbType.Bit);
            prmBITOBS1_LAB.Value = _bitObs1_lab;
            myCommand.Parameters.Add(prmBITOBS1_LAB);

            SqlParameter prmBITOBS2_LAB = new SqlParameter("@BITOBS2_LAB", SqlDbType.Bit);
            prmBITOBS2_LAB.Value = _bitObs2_lab;
            myCommand.Parameters.Add(prmBITOBS2_LAB);

            SqlParameter prmDECOBS1_LAB = new SqlParameter("@DECOBS1_LAB", SqlDbType.Decimal);
            prmDECOBS1_LAB.Value = _decObs1_lab;
            myCommand.Parameters.Add(prmDECOBS1_LAB);

            SqlParameter prmDECOBS2_LAB = new SqlParameter("@DECOBS2_LAB", SqlDbType.Decimal);
            prmDECOBS2_LAB.Value = _decObs2_lab;
            myCommand.Parameters.Add(prmDECOBS2_LAB);

            SqlParameter prmDTOBS1_LAB = new SqlParameter("@DTOBS1_LAB", SqlDbType.DateTime);
            prmDTOBS1_LAB.Value = _dtObs1_lab;
            myCommand.Parameters.Add(prmDTOBS1_LAB);

            SqlParameter prmDTOBS2_LAB = new SqlParameter("@DTOBS2_LAB", SqlDbType.DateTime);
            prmDTOBS2_LAB.Value = _dtObs2_lab;
            myCommand.Parameters.Add(prmDTOBS2_LAB);

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
        public int UpdateLAB_MOTIVO_RESERVAS(LAB_MOTIVO_RESERVAS miClass)
        {
            // Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            // Conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_MOTIVO_RESERVAS", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_MOTRES = new SqlParameter("@STRCOD_MOTRES", SqlDbType.NVarChar);
            prmSTRCOD_MOTRES.Value = miClass.strCod_motRes;
            myCommand.Parameters.Add(prmSTRCOD_MOTRES);

            SqlParameter prmSTRNOMBRE_MOTRES = new SqlParameter("@STRNOMBRE_MOTRES", SqlDbType.NVarChar);
            prmSTRNOMBRE_MOTRES.Value = miClass.strNombre_motRes;
            myCommand.Parameters.Add(prmSTRNOMBRE_MOTRES);

            SqlParameter prmDTFECHAREGISTRO_MOTRES = new SqlParameter("@DTFECHAREGISTRO_MOTRES", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_MOTRES.Value = miClass.dtFechaRegistro_motRes;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_MOTRES);

            SqlParameter prmBITESTADO_MOTRES = new SqlParameter("@BITESTADO_MOTRES", SqlDbType.Bit);
            prmBITESTADO_MOTRES.Value = miClass.bitEstado_motRes;
            myCommand.Parameters.Add(prmBITESTADO_MOTRES);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = miClass.dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = miClass.strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_LAB = new SqlParameter("@STROBS1_LAB", SqlDbType.NVarChar);
            prmSTROBS1_LAB.Value = miClass.strObs1_lab;
            myCommand.Parameters.Add(prmSTROBS1_LAB);

            SqlParameter prmSTROBS2_LAB = new SqlParameter("@STROBS2_LAB", SqlDbType.NVarChar);
            prmSTROBS2_LAB.Value = miClass.strObs2_lab;
            myCommand.Parameters.Add(prmSTROBS2_LAB);

            SqlParameter prmBITOBS1_LAB = new SqlParameter("@BITOBS1_LAB", SqlDbType.Bit);
            prmBITOBS1_LAB.Value = miClass.bitObs1_lab;
            myCommand.Parameters.Add(prmBITOBS1_LAB);

            SqlParameter prmBITOBS2_LAB = new SqlParameter("@BITOBS2_LAB", SqlDbType.Bit);
            prmBITOBS2_LAB.Value = miClass.bitObs2_lab;
            myCommand.Parameters.Add(prmBITOBS2_LAB);

            SqlParameter prmDECOBS1_LAB = new SqlParameter("@DECOBS1_LAB", SqlDbType.Decimal);
            prmDECOBS1_LAB.Value = miClass.decObs1_lab;
            myCommand.Parameters.Add(prmDECOBS1_LAB);

            SqlParameter prmDECOBS2_LAB = new SqlParameter("@DECOBS2_LAB", SqlDbType.Decimal);
            prmDECOBS2_LAB.Value = miClass.decObs2_lab;
            myCommand.Parameters.Add(prmDECOBS2_LAB);

            SqlParameter prmDTOBS1_LAB = new SqlParameter("@DTOBS1_LAB", SqlDbType.DateTime);
            prmDTOBS1_LAB.Value = miClass.dtObs1_lab;
            myCommand.Parameters.Add(prmDTOBS1_LAB);

            SqlParameter prmDTOBS2_LAB = new SqlParameter("@DTOBS2_LAB", SqlDbType.DateTime);
            prmDTOBS2_LAB.Value = miClass.dtObs2_lab;
            myCommand.Parameters.Add(prmDTOBS2_LAB);

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
        /// 
        public int UpdateLAB_MOTIVO_RESERVAS(
            string _strCod_motRes,
            string _strNombre_motRes,
            DateTime _dtFechaRegistro_motRes,
            bool _bitEstado_motRes,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_lab,
            string _strObs2_lab,
            bool _bitObs1_lab,
            bool _bitObs2_lab,
            decimal _decObs1_lab,
            decimal _decObs2_lab,
            DateTime _dtObs1_lab,
            DateTime _dtObs2_lab)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_MOTIVO_RESERVAS", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSTRCOD_MOTRES = new SqlParameter("@STRCOD_MOTRES", SqlDbType.NVarChar);
            prmSTRCOD_MOTRES.Value = _strCod_motRes;
            myCommand.Parameters.Add(prmSTRCOD_MOTRES);

            SqlParameter prmSTRNOMBRE_MOTRES = new SqlParameter("@STRNOMBRE_MOTRES", SqlDbType.NVarChar);
            prmSTRNOMBRE_MOTRES.Value = _strNombre_motRes;
            myCommand.Parameters.Add(prmSTRNOMBRE_MOTRES);

            SqlParameter prmDTFECHAREGISTRO_MOTRES = new SqlParameter("@DTFECHAREGISTRO_MOTRES", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_MOTRES.Value = _dtFechaRegistro_motRes;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_MOTRES);

            SqlParameter prmBITESTADO_MOTRES = new SqlParameter("@BITESTADO_MOTRES", SqlDbType.Bit);
            prmBITESTADO_MOTRES.Value = _bitEstado_motRes;
            myCommand.Parameters.Add(prmBITESTADO_MOTRES);

            SqlParameter prmDTFECHA_LOG = new SqlParameter("@DTFECHA_LOG", SqlDbType.DateTime);
            prmDTFECHA_LOG.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDTFECHA_LOG);

            SqlParameter prmSTRUSER_LOG = new SqlParameter("@STRUSER_LOG", SqlDbType.NVarChar);
            prmSTRUSER_LOG.Value = _strUser_log;
            myCommand.Parameters.Add(prmSTRUSER_LOG);

            SqlParameter prmSTROBS1_LAB = new SqlParameter("@STROBS1_LAB", SqlDbType.NVarChar);
            prmSTROBS1_LAB.Value = _strObs1_lab;
            myCommand.Parameters.Add(prmSTROBS1_LAB);

            SqlParameter prmSTROBS2_LAB = new SqlParameter("@STROBS2_LAB", SqlDbType.NVarChar);
            prmSTROBS2_LAB.Value = _strObs2_lab;
            myCommand.Parameters.Add(prmSTROBS2_LAB);

            SqlParameter prmBITOBS1_LAB = new SqlParameter("@BITOBS1_LAB", SqlDbType.Bit);
            prmBITOBS1_LAB.Value = _bitObs1_lab;
            myCommand.Parameters.Add(prmBITOBS1_LAB);

            SqlParameter prmBITOBS2_LAB = new SqlParameter("@BITOBS2_LAB", SqlDbType.Bit);
            prmBITOBS2_LAB.Value = _bitObs2_lab;
            myCommand.Parameters.Add(prmBITOBS2_LAB);

            SqlParameter prmDECOBS1_LAB = new SqlParameter("@DECOBS1_LAB", SqlDbType.Decimal);
            prmDECOBS1_LAB.Value = _decObs1_lab;
            myCommand.Parameters.Add(prmDECOBS1_LAB);

            SqlParameter prmDECOBS2_LAB = new SqlParameter("@DECOBS2_LAB", SqlDbType.Decimal);
            prmDECOBS2_LAB.Value = _decObs2_lab;
            myCommand.Parameters.Add(prmDECOBS2_LAB);

            SqlParameter prmDTOBS1_LAB = new SqlParameter("@DTOBS1_LAB", SqlDbType.DateTime);
            prmDTOBS1_LAB.Value = _dtObs1_lab;
            myCommand.Parameters.Add(prmDTOBS1_LAB);

            SqlParameter prmDTOBS2_LAB = new SqlParameter("@DTOBS2_LAB", SqlDbType.DateTime);
            prmDTOBS2_LAB.Value = _dtObs2_lab;
            myCommand.Parameters.Add(prmDTOBS2_LAB);

            int intReturn = -1;

            try
            {
                myConnection.Open();
                intReturn = myCommand.ExecuteNonQuery();
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
        public int DelLAB_MOTIVO_RESERVAS(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            // Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            // Conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_DelLAB_MOTIVO_RESERVAS", myConnection);
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










