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
    public class LAB_EXCLUSIVO
    {
        public LAB_EXCLUSIVO()
        {
        }

        public LAB_EXCLUSIVO(
            string _strCod_labEx,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_Car,
            string _strCod_lab,
            DateTime _dtFechaRegistro_labEx,
            bool _bitEstado_labEx,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_labEx,
            string _strObs2_labEx,
            bool _bitObs1_labEx,
            bool _bitObs2_labEx,
            decimal _decObs1_labEx,
            decimal _decObs2_labEx,
            DateTime _dtObs1_labEx,
            DateTime _dtObs2_labEx)
        {
            strCod_labEx = _strCod_labEx;
            strCod_Sede = _strCod_Sede;
            strCod_Fac = _strCod_Fac;
            strCod_Car = _strCod_Car;
            strCod_lab = _strCod_lab;
            dtFechaRegistro_labEx = _dtFechaRegistro_labEx;
            bitEstado_labEx = _bitEstado_labEx;
            dtFecha_log = _dtFecha_log;
            strUser_log = _strUser_log;
            strObs1_labEx = _strObs1_labEx;
            strObs2_labEx = _strObs2_labEx;
            bitObs1_labEx = _bitObs1_labEx;
            bitObs2_labEx = _bitObs2_labEx;
            decObs1_labEx = _decObs1_labEx;
            decObs2_labEx = _decObs2_labEx;
            dtObs1_labEx = _dtObs1_labEx;
            dtObs2_labEx = _dtObs2_labEx;


            numerr = 0;
            msg = string.Empty;
            resultado = false;
        }

        private string strCod_labEx;
        private string strCod_Sede;
        private string strCod_Fac;
        private string strCod_Car;
        private string strCod_lab;
        private DateTime dtFechaRegistro_labEx;
        private bool bitEstado_labEx;
        private DateTime dtFecha_log;
        private string strUser_log;
        private string strObs1_labEx;
        private string strObs2_labEx;
        private bool bitObs1_labEx;
        private bool bitObs2_labEx;
        private decimal decObs1_labEx;
        private decimal decObs2_labEx;
        private DateTime dtObs1_labEx;
        private DateTime dtObs2_labEx;
        private int NUMERR;
        private string MSG;
        private bool RESULTADO;


        ///////////////////// Generacion de propiedades/////////////////

        public string StrCod_labEx
        {
            get
            {
                return strCod_labEx;
            }
            set
            {
                strCod_labEx = value;
            }

        }

       
        public string StrCod_Sede
        {
            get
            {
                return strCod_Sede;
            }
            set
            {
                strCod_Sede = value;
            }
        }
        public string StrCod_Fac
        {
            get
            {
                return strCod_Fac;
            }
            set
            {
                strCod_Fac = value;
            }
        }
        public string StrCod_Car
        {
            get
            {
                return strCod_Car;
            }
            set
            {
                strCod_Car = value;
            }
        }
        public string StrCod_lab
        {
            get
            {
                return strCod_lab;
            }
            set
            {
                strCod_lab = value;
            }
        }
        public DateTime DtFechaRegistro_labEx
        {
            get
            {
                return dtFechaRegistro_labEx;
            }
            set
            {
                dtFechaRegistro_labEx = value;
            }
        }
        public bool BitEstado_labEx
        {
            get
            {
                return bitEstado_labEx;
            }
            set
            {
                bitEstado_labEx = value;
            }
        }
        public DateTime DtFecha_log
        {
            get
            {
                return dtFecha_log;
            }
            set
            {
                dtFecha_log = value;
            }
        }
        public string StrUser_log
        {
            get
            {
                return strUser_log;
            }
            set
            {
                strUser_log = value;
            }
        }
        public string StrObs1_labEx
        {
            get
            {
                return strObs1_labEx;
            }
            set
            {
                strObs1_labEx = value;
            }
        }
        public string StrObs2_labEx
        {
            get
            {
                return strObs2_labEx;
            }
            set
            {
                strObs2_labEx = value;
            }
        }
        public bool BitObs1_labEx
        {
            get
            {
                return bitObs1_labEx;
            }
            set
            {
                bitObs1_labEx = value;
            }
        }
        public bool BitObs2_labEx
        {
            get
            {
                return bitObs2_labEx;
            }
            set
            {
                bitObs2_labEx = value;
            }
        }
        public decimal DecObs1_labEx
        {
            get
            {
                return decObs1_labEx;
            }
            set
            {
                decObs1_labEx = value;
            }
        }
        public decimal DecObs2_labEx
        {
            get
            {
                return decObs2_labEx;
            }
            set
            {
                decObs2_labEx = value;
            }
        }
        public DateTime DtObs1_labEx
        {
            get
            {
                return dtObs1_labEx;
            }
            set
            {
                dtObs1_labEx = value;
            }
        }
        public DateTime DtObs2_labEx
        {
            get
            {
                return dtObs2_labEx;
            }
            set
            {
                dtObs2_labEx = value;
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
            public List<LAB_EXCLUSIVO> LoadLAB_EXCLUSIVO(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
            {
                var listG = new List<LAB_EXCLUSIVO>();
                using (SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]))
                {
                    using (SqlCommand myCommand = new SqlCommand("SIGUTC_GetLAB_EXCLUSIVO", myConnection))
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
                                    LAB_EXCLUSIVO labExclusivo = new LAB_EXCLUSIVO
                                    {
                                        StrCod_labEx = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_labEx"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_labEx"))),
                                        StrCod_Sede = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Sede"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Sede"))),
                                        StrCod_Fac = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Fac"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Fac"))),
                                        StrCod_Car = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_Car"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_Car"))),
                                        StrCod_lab = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strCod_lab"))),
                                        DtFechaRegistro_labEx = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_labEx"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFechaRegistro_labEx"))),
                                        BitEstado_labEx = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitEstado_labEx"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitEstado_labEx"))),
                                        DtFecha_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtFecha_log"))),
                                        StrUser_log = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strUser_log"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strUser_log"))),
                                        StrObs1_labEx = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs1_labEx"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs1_labEx"))),
                                        StrObs2_labEx = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("strObs2_labEx"))) == true ? string.Empty : Convert.ToString(reader1.GetValue(reader1.GetOrdinal("strObs2_labEx"))),
                                        BitObs1_labEx = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs1_labEx"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs1_labEx"))),
                                        BitObs2_labEx = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("bitObs2_labEx"))) == true ? false : Convert.ToBoolean(reader1.GetValue(reader1.GetOrdinal("bitObs2_labEx"))),
                                        DecObs1_labEx = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs1_labEx"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs1_labEx"))),
                                        DecObs2_labEx = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("decObs2_labEx"))) == true ? 0 : Convert.ToDecimal(reader1.GetValue(reader1.GetOrdinal("decObs2_labEx"))),
                                        DtObs1_labEx = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs1_labEx"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs1_labEx"))),
                                        DtObs2_labEx = Convert.IsDBNull(reader1.GetValue(reader1.GetOrdinal("dtObs2_labEx"))) == true ? DateTime.MinValue : Convert.ToDateTime(reader1.GetValue(reader1.GetOrdinal("dtObs2_labEx"))),
                                        numerr = 0,
                                        msg = "Datos extraidos satisfactoriamente...",
                                        resultado = true
                                    };
                                    listG.Add(labExclusivo);
                                }
                            }
                            myConnection.Close();
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    }
                }
                return listG;
            }
            ///////////////// Método Add /////////////////


            public int AddLAB_EXCLUSIVO(LAB_EXCLUSIVO miClass)
        {
            //Conexion a bd
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_EXCLUSIVO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmStrCod_labEx = new SqlParameter("@strCod_labEx", SqlDbType.NVarChar);
            prmStrCod_labEx.Value = miClass.StrCod_labEx;
            myCommand.Parameters.Add(prmStrCod_labEx);

            SqlParameter prmStrCod_Sede = new SqlParameter("@strCod_Sede", SqlDbType.NVarChar);
            prmStrCod_Sede.Value = miClass.StrCod_Sede;
            myCommand.Parameters.Add(prmStrCod_Sede);

            SqlParameter prmStrCod_Fac = new SqlParameter("@strCod_Fac", SqlDbType.NVarChar);
            prmStrCod_Fac.Value = miClass.StrCod_Fac;
            myCommand.Parameters.Add(prmStrCod_Fac);

            SqlParameter prmStrCod_Car = new SqlParameter("@strCod_Car", SqlDbType.NVarChar);
            prmStrCod_Car.Value = miClass.StrCod_Car;
            myCommand.Parameters.Add(prmStrCod_Car);

            SqlParameter prmStrCod_lab = new SqlParameter("@strCod_lab", SqlDbType.NVarChar);
            prmStrCod_lab.Value = miClass.StrCod_lab;
            myCommand.Parameters.Add(prmStrCod_lab);

            SqlParameter prmDtFechaRegistro_labEx = new SqlParameter("@dtFechaRegistro_labEx", SqlDbType.DateTime);
            prmDtFechaRegistro_labEx.Value = miClass.DtFechaRegistro_labEx;
            myCommand.Parameters.Add(prmDtFechaRegistro_labEx);

            SqlParameter prmBitEstado_labEx = new SqlParameter("@bitEstado_labEx", SqlDbType.Bit);
            prmBitEstado_labEx.Value = miClass.BitEstado_labEx;
            myCommand.Parameters.Add(prmBitEstado_labEx);

            SqlParameter prmDtFecha_log = new SqlParameter("@dtFecha_log", SqlDbType.DateTime);
            prmDtFecha_log.Value = miClass.DtFecha_log;
            myCommand.Parameters.Add(prmDtFecha_log);

            SqlParameter prmStrUser_log = new SqlParameter("@strUser_log", SqlDbType.NVarChar);
            prmStrUser_log.Value = miClass.StrUser_log;
            myCommand.Parameters.Add(prmStrUser_log);

            SqlParameter prmStrObs1_labEx = new SqlParameter("@strObs1_labEx", SqlDbType.NVarChar);
            prmStrObs1_labEx.Value = miClass.StrObs1_labEx;
            myCommand.Parameters.Add(prmStrObs1_labEx);

            SqlParameter prmStrObs2_labEx = new SqlParameter("@strObs2_labEx", SqlDbType.NVarChar);
            prmStrObs2_labEx.Value = miClass.StrObs2_labEx;
            myCommand.Parameters.Add(prmStrObs2_labEx);

            SqlParameter prmBitObs1_labEx = new SqlParameter("@bitObs1_labEx", SqlDbType.Bit);
            prmBitObs1_labEx.Value = miClass.BitObs1_labEx;
            myCommand.Parameters.Add(prmBitObs1_labEx);

            SqlParameter prmBitObs2_labEx = new SqlParameter("@bitObs2_labEx", SqlDbType.Bit);
            prmBitObs2_labEx.Value = miClass.BitObs2_labEx;
            myCommand.Parameters.Add(prmBitObs2_labEx);

            SqlParameter prmDecObs1_labEx = new SqlParameter("@decObs1_labEx", SqlDbType.Decimal);
            prmDecObs1_labEx.Value = miClass.DecObs1_labEx;
            myCommand.Parameters.Add(prmDecObs1_labEx);

            SqlParameter prmDecObs2_labEx = new SqlParameter("@decObs2_labEx", SqlDbType.Decimal);
            prmDecObs2_labEx.Value = miClass.DecObs2_labEx;
            myCommand.Parameters.Add(prmDecObs2_labEx);

            SqlParameter prmDtObs1_labEx = new SqlParameter("@dtObs1_labEx", SqlDbType.DateTime);
            prmDtObs1_labEx.Value = miClass.DtObs1_labEx;
            myCommand.Parameters.Add(prmDtObs1_labEx);

            SqlParameter prmDtObs2_labEx = new SqlParameter("@dtObs2_labEx", SqlDbType.DateTime);
            prmDtObs2_labEx.Value = miClass.DtObs2_labEx;
            myCommand.Parameters.Add(prmDtObs2_labEx);

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

        public int AddLAB_EXCLUSIVO(
            string _strCod_labEx,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_Car,
            string _strCod_lab,
            DateTime _dtFechaRegistro_labEx,
            bool _bitEstado_labEx,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_labEx,
            string _strObs2_labEx,
            bool _bitObs1_labEx,
            bool _bitObs2_labEx,
            decimal _decObs1_labEx,
            decimal _decObs2_labEx,
            DateTime _dtObs1_labEx,
            DateTime _dtObs2_labEx)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_AddLAB_EXCLUSIVO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmStrCod_labEx = new SqlParameter("@strCod_labEx", SqlDbType.NVarChar);
            prmStrCod_labEx.Value = _strCod_labEx;
            myCommand.Parameters.Add(prmStrCod_labEx);

            SqlParameter prmStrCod_Sede = new SqlParameter("@strCod_Sede", SqlDbType.NVarChar);
            prmStrCod_Sede.Value = _strCod_Sede;
            myCommand.Parameters.Add(prmStrCod_Sede);

            SqlParameter prmStrCod_Fac = new SqlParameter("@strCod_Fac", SqlDbType.NVarChar);
            prmStrCod_Fac.Value = _strCod_Fac;
            myCommand.Parameters.Add(prmStrCod_Fac);

            SqlParameter prmStrCod_Car = new SqlParameter("@strCod_Car", SqlDbType.NVarChar);
            prmStrCod_Car.Value = _strCod_Car;
            myCommand.Parameters.Add(prmStrCod_Car);

            SqlParameter prmStrCod_lab = new SqlParameter("@strCod_lab", SqlDbType.NVarChar);
            prmStrCod_lab.Value = _strCod_lab;
            myCommand.Parameters.Add(prmStrCod_lab);

            SqlParameter prmDtFechaRegistro_labEx = new SqlParameter("@dtFechaRegistro_labEx", SqlDbType.DateTime);
            prmDtFechaRegistro_labEx.Value = _dtFechaRegistro_labEx;
            myCommand.Parameters.Add(prmDtFechaRegistro_labEx);

            SqlParameter prmBitEstado_labEx = new SqlParameter("@bitEstado_labEx", SqlDbType.Bit);
            prmBitEstado_labEx.Value = _bitEstado_labEx;
            myCommand.Parameters.Add(prmBitEstado_labEx);

            SqlParameter prmDtFecha_log = new SqlParameter("@dtFecha_log", SqlDbType.DateTime);
            prmDtFecha_log.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDtFecha_log);

            SqlParameter prmStrUser_log = new SqlParameter("@strUser_log", SqlDbType.NVarChar);
            prmStrUser_log.Value = _strUser_log;
            myCommand.Parameters.Add(prmStrUser_log);

            SqlParameter prmStrObs1_labEx = new SqlParameter("@strObs1_labEx", SqlDbType.NVarChar);
            prmStrObs1_labEx.Value = _strObs1_labEx;
            myCommand.Parameters.Add(prmStrObs1_labEx);

            SqlParameter prmStrObs2_labEx = new SqlParameter("@strObs2_labEx", SqlDbType.NVarChar);
            prmStrObs2_labEx.Value = _strObs2_labEx;
            myCommand.Parameters.Add(prmStrObs2_labEx);

            SqlParameter prmBitObs1_labEx = new SqlParameter("@bitObs1_labEx", SqlDbType.Bit);
            prmBitObs1_labEx.Value = _bitObs1_labEx;
            myCommand.Parameters.Add(prmBitObs1_labEx);

            SqlParameter prmBitObs2_labEx = new SqlParameter("@bitObs2_labEx", SqlDbType.Bit);
            prmBitObs2_labEx.Value = _bitObs2_labEx;
            myCommand.Parameters.Add(prmBitObs2_labEx);

            SqlParameter prmDecObs1_labEx = new SqlParameter("@decObs1_labEx", SqlDbType.Decimal);
            prmDecObs1_labEx.Value = _decObs1_labEx;
            myCommand.Parameters.Add(prmDecObs1_labEx);

            SqlParameter prmDecObs2_labEx = new SqlParameter("@decObs2_labEx", SqlDbType.Decimal);
            prmDecObs2_labEx.Value = _decObs2_labEx;
            myCommand.Parameters.Add(prmDecObs2_labEx);

            SqlParameter prmDtObs1_labEx = new SqlParameter("@dtObs1_labEx", SqlDbType.DateTime);
            prmDtObs1_labEx.Value = _dtObs1_labEx;
            myCommand.Parameters.Add(prmDtObs1_labEx);

            SqlParameter prmDtObs2_labEx = new SqlParameter("@dtObs2_labEx", SqlDbType.DateTime);
            prmDtObs2_labEx.Value = _dtObs2_labEx;
            myCommand.Parameters.Add(prmDtObs2_labEx);

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

        public int UpdateLAB_EXCLUSIVO(LAB_EXCLUSIVO miClass)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_EXCLUSIVO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmStrCod_labEx = new SqlParameter("@strCod_labEx", SqlDbType.NVarChar);
            prmStrCod_labEx.Value = miClass.StrCod_labEx;
            myCommand.Parameters.Add(prmStrCod_labEx);

            SqlParameter prmStrCod_Sede = new SqlParameter("@strCod_Sede", SqlDbType.NVarChar);
            prmStrCod_Sede.Value = miClass.StrCod_Sede;
            myCommand.Parameters.Add(prmStrCod_Sede);

            SqlParameter prmStrCod_Fac = new SqlParameter("@strCod_Fac", SqlDbType.NVarChar);
            prmStrCod_Fac.Value = miClass.StrCod_Fac;
            myCommand.Parameters.Add(prmStrCod_Fac);

            SqlParameter prmStrCod_Car = new SqlParameter("@strCod_Car", SqlDbType.NVarChar);
            prmStrCod_Car.Value = miClass.StrCod_Car;
            myCommand.Parameters.Add(prmStrCod_Car);

            SqlParameter prmStrCod_lab = new SqlParameter("@strCod_lab", SqlDbType.NVarChar);
            prmStrCod_lab.Value = miClass.StrCod_lab;
            myCommand.Parameters.Add(prmStrCod_lab);

            SqlParameter prmDtFechaRegistro_labEx = new SqlParameter("@dtFechaRegistro_labEx", SqlDbType.DateTime);
            prmDtFechaRegistro_labEx.Value = miClass.DtFechaRegistro_labEx;
            myCommand.Parameters.Add(prmDtFechaRegistro_labEx);

            SqlParameter prmBitEstado_labEx = new SqlParameter("@bitEstado_labEx", SqlDbType.Bit);
            prmBitEstado_labEx.Value = miClass.BitEstado_labEx;
            myCommand.Parameters.Add(prmBitEstado_labEx);

            SqlParameter prmDtFecha_log = new SqlParameter("@dtFecha_log", SqlDbType.DateTime);
            prmDtFecha_log.Value = miClass.DtFecha_log;
            myCommand.Parameters.Add(prmDtFecha_log);

            SqlParameter prmStrUser_log = new SqlParameter("@strUser_log", SqlDbType.NVarChar);
            prmStrUser_log.Value = miClass.StrUser_log;
            myCommand.Parameters.Add(prmStrUser_log);

            SqlParameter prmStrObs1_labEx = new SqlParameter("@strObs1_labEx", SqlDbType.NVarChar);
            prmStrObs1_labEx.Value = miClass.StrObs1_labEx;
            myCommand.Parameters.Add(prmStrObs1_labEx);

            SqlParameter prmStrObs2_labEx = new SqlParameter("@strObs2_labEx", SqlDbType.NVarChar);
            prmStrObs2_labEx.Value = miClass.StrObs2_labEx;
            myCommand.Parameters.Add(prmStrObs2_labEx);

            SqlParameter prmBitObs1_labEx = new SqlParameter("@bitObs1_labEx", SqlDbType.Bit);
            prmBitObs1_labEx.Value = miClass.BitObs1_labEx;
            myCommand.Parameters.Add(prmBitObs1_labEx);

            SqlParameter prmBitObs2_labEx = new SqlParameter("@bitObs2_labEx", SqlDbType.Bit);
            prmBitObs2_labEx.Value = miClass.BitObs2_labEx;
            myCommand.Parameters.Add(prmBitObs2_labEx);

            SqlParameter prmDecObs1_labEx = new SqlParameter("@decObs1_labEx", SqlDbType.Decimal);
            prmDecObs1_labEx.Value = miClass.DecObs1_labEx;
            myCommand.Parameters.Add(prmDecObs1_labEx);

            SqlParameter prmDecObs2_labEx = new SqlParameter("@decObs2_labEx", SqlDbType.Decimal);
            prmDecObs2_labEx.Value = miClass.DecObs2_labEx;
            myCommand.Parameters.Add(prmDecObs2_labEx);

            SqlParameter prmDtObs1_labEx = new SqlParameter("@dtObs1_labEx", SqlDbType.DateTime);
            prmDtObs1_labEx.Value = miClass.DtObs1_labEx;
            myCommand.Parameters.Add(prmDtObs1_labEx);

            SqlParameter prmDtObs2_labEx = new SqlParameter("@dtObs2_labEx", SqlDbType.DateTime);
            prmDtObs2_labEx.Value = miClass.DtObs2_labEx;
            myCommand.Parameters.Add(prmDtObs2_labEx);

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

        ///////////////// Método Update SobreCargado  /////////////////

        public int UpdateLAB_EXCLUSIVO(
            string _strCod_labEx,
            string _strCod_Sede,
            string _strCod_Fac,
            string _strCod_Car,
            string _strCod_lab,
            DateTime _dtFechaRegistro_labEx,
            bool _bitEstado_labEx,
            DateTime _dtFecha_log,
            string _strUser_log,
            string _strObs1_labEx,
            string _strObs2_labEx,
            bool _bitObs1_labEx,
            bool _bitObs2_labEx,
            decimal _decObs1_labEx,
            decimal _decObs2_labEx,
            DateTime _dtObs1_labEx,
            DateTime _dtObs2_labEx)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);
            SqlCommand myCommand = new SqlCommand("SIGUTC_UpdateLAB_EXCLUSIVO", myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter prmStrCod_labEx = new SqlParameter("@strCod_labEx", SqlDbType.NVarChar);
            prmStrCod_labEx.Value = _strCod_labEx;
            myCommand.Parameters.Add(prmStrCod_labEx);

            SqlParameter prmStrCod_Sede = new SqlParameter("@strCod_Sede", SqlDbType.NVarChar);
            prmStrCod_Sede.Value = _strCod_Sede;
            myCommand.Parameters.Add(prmStrCod_Sede);

            SqlParameter prmStrCod_Fac = new SqlParameter("@strCod_Fac", SqlDbType.NVarChar);
            prmStrCod_Fac.Value = _strCod_Fac;
            myCommand.Parameters.Add(prmStrCod_Fac);

            SqlParameter prmStrCod_Car = new SqlParameter("@strCod_Car", SqlDbType.NVarChar);
            prmStrCod_Car.Value = _strCod_Car;
            myCommand.Parameters.Add(prmStrCod_Car);

            SqlParameter prmStrCod_lab = new SqlParameter("@strCod_lab", SqlDbType.NVarChar);
            prmStrCod_lab.Value = _strCod_lab;
            myCommand.Parameters.Add(prmStrCod_lab);

            SqlParameter prmDtFechaRegistro_labEx = new SqlParameter("@dtFechaRegistro_labEx", SqlDbType.DateTime);
            prmDtFechaRegistro_labEx.Value = _dtFechaRegistro_labEx;
            myCommand.Parameters.Add(prmDtFechaRegistro_labEx);

            SqlParameter prmBitEstado_labEx = new SqlParameter("@bitEstado_labEx", SqlDbType.Bit);
            prmBitEstado_labEx.Value = _bitEstado_labEx;
            myCommand.Parameters.Add(prmBitEstado_labEx);

            SqlParameter prmDtFecha_log = new SqlParameter("@dtFecha_log", SqlDbType.DateTime);
            prmDtFecha_log.Value = _dtFecha_log;
            myCommand.Parameters.Add(prmDtFecha_log);

            SqlParameter prmStrUser_log = new SqlParameter("@strUser_log", SqlDbType.NVarChar);
            prmStrUser_log.Value = _strUser_log;
            myCommand.Parameters.Add(prmStrUser_log);

            SqlParameter prmStrObs1_labEx = new SqlParameter("@strObs1_labEx", SqlDbType.NVarChar);
            prmStrObs1_labEx.Value = _strObs1_labEx;
            myCommand.Parameters.Add(prmStrObs1_labEx);

            SqlParameter prmStrObs2_labEx = new SqlParameter("@strObs2_labEx", SqlDbType.NVarChar);
            prmStrObs2_labEx.Value = _strObs2_labEx;
            myCommand.Parameters.Add(prmStrObs2_labEx);

            SqlParameter prmBitObs1_labEx = new SqlParameter("@bitObs1_labEx", SqlDbType.Bit);
            prmBitObs1_labEx.Value = _bitObs1_labEx;
            myCommand.Parameters.Add(prmBitObs1_labEx);

            SqlParameter prmBitObs2_labEx = new SqlParameter("@bitObs2_labEx", SqlDbType.Bit);
            prmBitObs2_labEx.Value = _bitObs2_labEx;
            myCommand.Parameters.Add(prmBitObs2_labEx);

            SqlParameter prmDecObs1_labEx = new SqlParameter("@decObs1_labEx", SqlDbType.Decimal);
            prmDecObs1_labEx.Value = _decObs1_labEx;
            myCommand.Parameters.Add(prmDecObs1_labEx);

            SqlParameter prmDecObs2_labEx = new SqlParameter("@decObs2_labEx", SqlDbType.Decimal);
            prmDecObs2_labEx.Value = _decObs2_labEx;
            myCommand.Parameters.Add(prmDecObs2_labEx);

            SqlParameter prmDtObs1_labEx = new SqlParameter("@dtObs1_labEx", SqlDbType.DateTime);
            prmDtObs1_labEx.Value = _dtObs1_labEx;
            myCommand.Parameters.Add(prmDtObs1_labEx);

            SqlParameter prmDtObs2_labEx = new SqlParameter("@dtObs2_labEx", SqlDbType.DateTime);
            prmDtObs2_labEx.Value = _dtObs2_labEx;
            myCommand.Parameters.Add(prmDtObs2_labEx);

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

        public int DelLAB_EXCLUSIVO(string comodin, string filtro1, string filtro2, string filtro3, string filtro4)
        {
            SqlConnection myConnection = new SqlConnection(WebConfigurationManager.AppSettings["conexionBddProductos"]);

            SqlCommand myCommand = new SqlCommand("SIGUTC_DelLAB_EXCLUSIVO", myConnection);
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
                intReturn = myCommand.ExecuteNonQuery();
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





