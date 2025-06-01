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
    public class LAB_LABORATORIOS
    {
        public LAB_LABORATORIOS() { }

        public LAB_LABORATORIOS(
            string _strCod_lab,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_tipoLab,
            string _strCod_areac,
            string _strNombre_lab,
            int _intNumeroEquipos_lab,
            string _strUbicacion_lab,
            string _strFotografia1_lab,
            string _strFotografia2_lab,
            DateTime _dtFechaRegistro_lab,
            bool _bitEstado_lab,
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
            strCod_lab = _strCod_lab;
            strCod_Sede = _strCod_Sede;
            strCod_Fac = _strCod_Fac;
            strCod_tipoLab = _strCod_tipoLab;
            strCod_areac = _strCod_areac;
            strNombre_lab = _strNombre_lab;
            intNumeroEquipos_lab = _intNumeroEquipos_lab;
            strUbicacion_lab = _strUbicacion_lab;
            strFotografia1_lab = _strFotografia1_lab;
            strFotografia2_lab = _strFotografia2_lab;
            dtFechaRegistro_lab = _dtFechaRegistro_lab;
            bitEstado_lab = _bitEstado_lab;
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
        private string STRCOD_LAB;
        private string STRCOD_SEDE;
        private string STRCOD_FAC;
        private string STRCOD_TIPOLAB;
        private string STRCOD_AREAC;
        private string STRNOMBRE_LAB;
        private int INTNUMEROEQUIPOS_LAB;
        private string STRUBICACION_LAB;
        private string STRFOTOGRAFIA1_LAB;
        private string STRFOTOGRAFIA2_LAB;
        private DateTime DTFECHAREGISTRO_LAB;
        private bool BITESTADO_LAB;
        private DateTime DTFECHA_LOG;
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

        public string strCod_areac
        {
            get
            {
                return STRCOD_AREAC;
            }
            set
            {
                STRCOD_AREAC = value;
            }
        }

        public string strNombre_lab
        {
            get
            {
                return STRNOMBRE_LAB;
            }
            set
            {
                STRNOMBRE_LAB = value;
            }
        }

        public int intNumeroEquipos_lab
        {
            get
            {
                return INTNUMEROEQUIPOS_LAB;
            }
            set
            {
                INTNUMEROEQUIPOS_LAB = value;
            }
        }

        public string strUbicacion_lab
        {
            get
            {
                return STRUBICACION_LAB;
            }
            set
            {
                STRUBICACION_LAB = value;
            }
        }

        public string strFotografia1_lab
        {
            get
            {
                return STRFOTOGRAFIA1_LAB;
            }
            set
            {
                STRFOTOGRAFIA1_LAB = value;
            }
        }

        public string strFotografia2_lab
        {
            get
            {
                return STRFOTOGRAFIA2_LAB;
            }
            set
            {
                STRFOTOGRAFIA2_LAB = value;
            }
        }

        public DateTime dtFechaRegistro_lab
        {
            get
            {
                return DTFECHAREGISTRO_LAB;
            }
            set
            {
                DTFECHAREGISTRO_LAB = value;
            }
        }

        public bool bitEstado_lab
        {
            get
            {
                return BITESTADO_LAB;
            }
            set
            {
                BITESTADO_LAB = value;
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
        public List<LAB_LABORATORIOS> LoadLAB_LABORATORIOS(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            var listG = new List<LAB_LABORATORIOS>();
            using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
            {
                using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_LABORATORIOS", myConnection))
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
                                LAB_LABORATORIOS miClase = new LAB_LABORATORIOS()
                                {
                                    strCod_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))),
                                    strCod_Sede = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Sede"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Sede"))),
                                    strCod_Fac = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Fac"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Fac"))),
                                    strCod_tipoLab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_tipoLab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_tipoLab"))),
                                    strCod_areac = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_areac"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_areac"))),
                                    strNombre_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strNombre_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strNombre_lab"))),
                                    intNumeroEquipos_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("intNumeroEquipos_lab"))) == true ? 0 : Convert.ToInt32(reader1.GetValue(reader1.GetOrdinal("intNumeroEquipos_lab"))),
                                    strUbicacion_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUbicacion_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUbicacion_lab"))),
                                    strFotografia1_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strFotografia1_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strFotografia1_lab"))),
                                    strFotografia2_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strFotografia2_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strFotografia2_lab"))),
                                    dtFechaRegistro_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_lab"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_lab"))),
                                    bitEstado_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitEstado_lab"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitEstado_lab"))),
                                    dtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                    strUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                    strObs1_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_lab"))),
                                    strObs2_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_lab"))),
                                    bitObs1_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_lab"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_lab"))),
                                    bitObs2_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_lab"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_lab"))),
                                    decObs1_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_lab"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_lab"))),
                                    decObs2_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_lab"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_lab"))),
                                    dtObs1_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_lab"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_lab"))),
                                    dtObs2_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_lab"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_lab"))),

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


        public int AddLAB_LABORATORIOS(LAB_LABORATORIOS miClass)
        {
            // Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            // Conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_LABORATORIOS", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_LAB = new SqlParameter("@STRCOD_LAB", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = miClass.strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = miClass.strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = miClass.strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRCOD_TIPOLAB = new SqlParameter("@STRCOD_TIPOLAB", SqlDbType.NVarChar);
            prmSTRCOD_TIPOLAB.Value = miClass.strCod_tipoLab;
            myCommand.Parameters.Add(prmSTRCOD_TIPOLAB);

            SqlParameter prmSTRCOD_AREAC = new SqlParameter("@STRCOD_AREAC", SqlDbType.NVarChar);
            prmSTRCOD_AREAC.Value = miClass.strCod_areac;
            myCommand.Parameters.Add(prmSTRCOD_AREAC);

            SqlParameter prmSTRNOMBRE_LAB = new SqlParameter("@STRNOMBRE_LAB", SqlDbType.NVarChar);
            prmSTRNOMBRE_LAB.Value = miClass.strNombre_lab;
            myCommand.Parameters.Add(prmSTRNOMBRE_LAB);

            SqlParameter prmINTNUMEROEQUIPOS_LAB = new SqlParameter("@INTNUMEROEQUIPOS_LAB", SqlDbType.Int);
            prmINTNUMEROEQUIPOS_LAB.Value = miClass.intNumeroEquipos_lab;
            myCommand.Parameters.Add(prmINTNUMEROEQUIPOS_LAB);

            SqlParameter prmSTRUBICACION_LAB = new SqlParameter("@STRUBICACION_LAB", SqlDbType.NVarChar);
            prmSTRUBICACION_LAB.Value = miClass.strUbicacion_lab;
            myCommand.Parameters.Add(prmSTRUBICACION_LAB);

            SqlParameter prmSTRFOTOGRAFIA1_LAB = new SqlParameter("@STRFOTOGRAFIA1_LAB", SqlDbType.NVarChar);
            prmSTRFOTOGRAFIA1_LAB.Value = miClass.strFotografia1_lab;
            myCommand.Parameters.Add(prmSTRFOTOGRAFIA1_LAB);

            SqlParameter prmSTRFOTOGRAFIA2_LAB = new SqlParameter("@STRFOTOGRAFIA2_LAB", SqlDbType.NVarChar);
            prmSTRFOTOGRAFIA2_LAB.Value = miClass.strFotografia2_lab;
            myCommand.Parameters.Add(prmSTRFOTOGRAFIA2_LAB);

            SqlParameter prmDTFECHAREGISTRO_LAB = new SqlParameter("@DTFECHAREGISTRO_LAB", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_LAB.Value = miClass.dtFechaRegistro_lab;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_LAB);

            SqlParameter prmBITESTADO_LAB = new SqlParameter("@BITESTADO_LAB", SqlDbType.Bit);
            prmBITESTADO_LAB.Value = miClass.bitEstado_lab;
            myCommand.Parameters.Add(prmBITESTADO_LAB);

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
        public int AddLAB_LABORATORIOS(
            string _strCod_lab,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_tipoLab,
            string _strCod_areac,
            string _strNombre_lab,
            int _intNumeroEquipos_lab,
            string _strUbicacion_lab,
            string _strFotografia1_lab,
            string _strFotografia2_lab,
            DateTime _dtFechaRegistro_lab,
            bool _bitEstado_lab,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_lab,
            string _strObs2_lab,
            bool _bitObs1_lab,
            bool _bitObs2_lab,
            decimal _decObs1_lab,
            decimal _decObs2_lab,
            DateTime _dtObs1_lab,
            DateTime _dtObs2_lab
            )
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_LABORATORIOS", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@STRCOD_LAB", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = _strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmSTRCOD_SEDE = new SqlParameter("@STRCOD_SEDE", SqlDbType.NVarChar);
            prmSTRCOD_SEDE.Value = _strCod_Sede;
            myCommand.Parameters.Add(prmSTRCOD_SEDE);

            SqlParameter prmSTRCOD_FAC = new SqlParameter("@STRCOD_FAC", SqlDbType.NVarChar);
            prmSTRCOD_FAC.Value = _strCod_Fac;
            myCommand.Parameters.Add(prmSTRCOD_FAC);

            SqlParameter prmSTRCOD_TIPOLAB = new SqlParameter("@STRCOD_TIPOLAB", SqlDbType.NVarChar);
            prmSTRCOD_TIPOLAB.Value = _strCod_tipoLab;
            myCommand.Parameters.Add(prmSTRCOD_TIPOLAB);

            SqlParameter prmSTRCOD_AREAC = new SqlParameter("@STRCOD_AREAC", SqlDbType.NVarChar);
            prmSTRCOD_AREAC.Value = _strCod_areac;
            myCommand.Parameters.Add(prmSTRCOD_AREAC);

            SqlParameter prmSTRNOMBRE_LAB = new SqlParameter("@STRNOMBRE_LAB", SqlDbType.NVarChar);
            prmSTRNOMBRE_LAB.Value = _strNombre_lab;
            myCommand.Parameters.Add(prmSTRNOMBRE_LAB);

            SqlParameter prmINTNUMEROEQUIPOS_LAB = new SqlParameter("@INTNUMEROEQUIPOS_LAB", SqlDbType.Int);
            prmINTNUMEROEQUIPOS_LAB.Value = _intNumeroEquipos_lab;
            myCommand.Parameters.Add(prmINTNUMEROEQUIPOS_LAB);

            SqlParameter prmSTRUBICACION_LAB = new SqlParameter("@STRUBICACION_LAB", SqlDbType.NVarChar);
            prmSTRUBICACION_LAB.Value = _strUbicacion_lab;
            myCommand.Parameters.Add(prmSTRUBICACION_LAB);
            SqlParameter prmSTRFOTOGRAFIA1_LAB = new SqlParameter("@STRFOTOGRAFIA1_LAB", SqlDbType.NVarChar);
            prmSTRFOTOGRAFIA1_LAB.Value = _strFotografia1_lab;
            myCommand.Parameters.Add(prmSTRFOTOGRAFIA1_LAB);

            SqlParameter prmSTRFOTOGRAFIA2_LAB = new SqlParameter("@STRFOTOGRAFIA2_LAB", SqlDbType.NVarChar);
            prmSTRFOTOGRAFIA2_LAB.Value = _strFotografia2_lab;
            myCommand.Parameters.Add(prmSTRFOTOGRAFIA2_LAB);

            SqlParameter prmDTFECHAREGISTRO_LAB = new SqlParameter("@DTFECHAREGISTRO_LAB", SqlDbType.DateTime);
            prmDTFECHAREGISTRO_LAB.Value = _dtFechaRegistro_lab;
            myCommand.Parameters.Add(prmDTFECHAREGISTRO_LAB);

            SqlParameter prmBITESTADO_LAB = new SqlParameter("@BITESTADO_LAB", SqlDbType.Bit);
            prmBITESTADO_LAB.Value = _bitEstado_lab;
            myCommand.Parameters.Add(prmBITESTADO_LAB);

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
        public int UpdateLAB_LABORATORIOS(LAB_LABORATORIOS miClass)
        {
            // Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            // Conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_LABORATORIOS", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Creacion de parametros que se envian al SP
            SqlParameter prmSTRCOD_LAB = new SqlParameter("@STRCOD_LAB", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = miClass.strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmSTRCOD_TIPOLAB = new SqlParameter("@STRCOD_TIPOLAB", SqlDbType.NVarChar);
            prmSTRCOD_TIPOLAB.Value = miClass.strCod_tipoLab;
            myCommand.Parameters.Add(prmSTRCOD_TIPOLAB);

            SqlParameter prmSTRCOD_AREAC = new SqlParameter("@STRCOD_AREAC", SqlDbType.NVarChar);
            prmSTRCOD_AREAC.Value = miClass.strCod_areac;
            myCommand.Parameters.Add(prmSTRCOD_AREAC);

            SqlParameter prmSTRNOMBRE_LAB = new SqlParameter("@STRNOMBRE_LAB", SqlDbType.NVarChar);
            prmSTRNOMBRE_LAB.Value = miClass.strNombre_lab;
            myCommand.Parameters.Add(prmSTRNOMBRE_LAB);

            SqlParameter prmINTNUMEROEQUIPOS_LAB = new SqlParameter("@INTNUMEROEQUIPOS_LAB", SqlDbType.Int);
            prmINTNUMEROEQUIPOS_LAB.Value = miClass.intNumeroEquipos_lab;
            myCommand.Parameters.Add(prmINTNUMEROEQUIPOS_LAB);

            SqlParameter prmSTRUBICACION_LAB = new SqlParameter("@STRUBICACION_LAB", SqlDbType.NVarChar);
            prmSTRUBICACION_LAB.Value = miClass.strUbicacion_lab;
            myCommand.Parameters.Add(prmSTRUBICACION_LAB);

            SqlParameter prmSTRFOTOGRAFIA1_LAB = new SqlParameter("@STRFOTOGRAFIA1_LAB", SqlDbType.NVarChar);
            prmSTRFOTOGRAFIA1_LAB.Value = miClass.strFotografia1_lab;
            myCommand.Parameters.Add(prmSTRFOTOGRAFIA1_LAB);

            SqlParameter prmSTRFOTOGRAFIA2_LAB = new SqlParameter("@STRFOTOGRAFIA2_LAB", SqlDbType.NVarChar);
            prmSTRFOTOGRAFIA2_LAB.Value = miClass.strFotografia2_lab;
            myCommand.Parameters.Add(prmSTRFOTOGRAFIA2_LAB);

            SqlParameter prmBITESTADO_LAB = new SqlParameter("@BITESTADO_LAB", SqlDbType.Bit);
            prmBITESTADO_LAB.Value = miClass.bitEstado_lab;
            myCommand.Parameters.Add(prmBITESTADO_LAB);

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


        ///////////////// Método Update SobreCargado  /////////////////
        public int UpdateLAB_LABORATORIOS(
            string _strCod_lab,
            string _strCod_tipoLab,
            string _strCod_areac,
            string _strNombre_lab,
            int _intNumeroEquipos_lab,
            string _strUbicacion_lab,
            string _strFotografia1_lab,
            string _strFotografia2_lab,
            bool _bitEstado_lab,
            DateTime _dtFecha_log,
            string _strUser_log)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_LABORATORIOS", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSTRCOD_LAB = new SqlParameter("@STRCOD_LAB", SqlDbType.NVarChar);
            prmSTRCOD_LAB.Value = _strCod_lab;
            myCommand.Parameters.Add(prmSTRCOD_LAB);

            SqlParameter prmSTRCOD_TIPOLAB = new SqlParameter("@STRCOD_TIPOLAB", SqlDbType.NVarChar);
            prmSTRCOD_TIPOLAB.Value = _strCod_tipoLab;
            myCommand.Parameters.Add(prmSTRCOD_TIPOLAB);

            SqlParameter prmSTRCOD_AREAC = new SqlParameter("@STRCOD_AREAC", SqlDbType.NVarChar);
            prmSTRCOD_AREAC.Value = _strCod_areac;
            myCommand.Parameters.Add(prmSTRCOD_AREAC);

            SqlParameter prmSTRNOMBRE_LAB = new SqlParameter("@STRNOMBRE_LAB", SqlDbType.NVarChar);
            prmSTRNOMBRE_LAB.Value = _strNombre_lab;
            myCommand.Parameters.Add(prmSTRNOMBRE_LAB);

            SqlParameter prmINTNUMEROEQUIPOS_LAB = new SqlParameter("@INTNUMEROEQUIPOS_LAB", SqlDbType.Int);
            prmINTNUMEROEQUIPOS_LAB.Value = _intNumeroEquipos_lab;
            myCommand.Parameters.Add(prmINTNUMEROEQUIPOS_LAB);

            SqlParameter prmSTRUBICACION_LAB = new SqlParameter("@STRUBICACION_LAB", SqlDbType.NVarChar);
            prmSTRUBICACION_LAB.Value = _strUbicacion_lab;
            myCommand.Parameters.Add(prmSTRUBICACION_LAB);

            SqlParameter prmSTRFOTOGRAFIA1_LAB = new SqlParameter("@STRFOTOGRAFIA1_LAB", SqlDbType.NVarChar);
            prmSTRFOTOGRAFIA1_LAB.Value = _strFotografia1_lab;
            myCommand.Parameters.Add(prmSTRFOTOGRAFIA1_LAB);

            SqlParameter prmSTRFOTOGRAFIA2_LAB = new SqlParameter("@STRFOTOGRAFIA2_LAB", SqlDbType.NVarChar);
            prmSTRFOTOGRAFIA2_LAB.Value = _strFotografia2_lab;
            myCommand.Parameters.Add(prmSTRFOTOGRAFIA2_LAB);

            SqlParameter prmBITESTADO_LAB = new SqlParameter("@BITESTADO_LAB", SqlDbType.Bit);
            prmBITESTADO_LAB.Value = _bitEstado_lab;
            myCommand.Parameters.Add(prmBITESTADO_LAB);

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
        public int DelLAB_LABORATORIOS(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            // Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            // Conexion SP
            SqlCommand myCommand = new SqlCommand("SIGUTC_DelLAB_LABORATORIOS", myConnection);
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