using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Sql
{
     public class SqlSet
    {       
        public SqlSet(string constr)
        {
            SqlConnTools.Connstr = constr;
            Conn = SqlConnTools.Baglanti;
            Cmd = new SqlCommand { Connection = Conn, CommandTimeout = 0 };
            switch (Conn.State)
            {
                case ConnectionState.Broken:
                    Conn.Close();
                    Conn.Open();
                    break;
                case ConnectionState.Closed:
                    Conn.Open();
                    break;
                case ConnectionState.Connecting:
                case ConnectionState.Executing:
                case ConnectionState.Fetching:
                case ConnectionState.Open:
                    break;
            }


            Da = new SqlDataAdapter { SelectCommand = Cmd };
            Dt = new DataTable();



            


        }
        #region property



        SqlConnection conn;

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        SqlCommand cmd;

        public SqlCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }
        SqlDataAdapter da;

        public SqlDataAdapter Da
        {
            get { return da; }
            set { da = value; }
        }
        DataTable dt;

        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        private DataSet dtset;

        public DataSet Dtset
        {
            get { return dtset; }
            set { dtset = value; }
        }
        private List<object> myList;

        public List<object> _myList
        {
            get { return myList; }
            set { myList = value; }
        }
        private XmlReadMode XmlRead;

        public XmlReadMode _XmlRead
        {
            get { return XmlRead; }
            set { XmlRead = value; }
        }
        private XmlWriteMode XmlWrite;

        public XmlWriteMode _XmlWrite
        {
            get { return XmlWrite; }
            set { XmlWrite = value; }
        }
         
        
        #endregion
        public class SqlConnTools
        {
            public static string Connstr { get; set; }
            static SqlConnection _con;

            public static SqlConnection Baglanti
            {
                get
                {
                    if (_con == null)
                    {
                        _con = new SqlConnection(Connstr);
                        _con.Open();
                    }
                    else
                    {
                        switch (_con.State)
                        {
                            case ConnectionState.Broken:
                                _con.Close();
                                _con.Open();
                                break;
                            case ConnectionState.Closed:
                                _con.Open();
                                break;
                            case ConnectionState.Connecting:
                            case ConnectionState.Executing:
                            case ConnectionState.Fetching:
                            case ConnectionState.Open:
                                break;
                        }
                    }

                    return _con;
                }
            }
        }
    
    }
}
