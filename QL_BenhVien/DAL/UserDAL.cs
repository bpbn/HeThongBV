using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        public UserDAL() { }

        public int Check_Config(string conStr)
        {
            if (Properties.Settings.Default.conStr == string.Empty)
                return 1;
            SqlConnection _Sqlconn = new SqlConnection(conStr);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
        }

        public DataTable GetUser(string username, string password, string conStr)
        {
            using (SqlDataAdapter daUser = new SqlDataAdapter("SELECT * FROM TAIKHOAN WHERE TENTAIKHOAN = @username AND MATKHAU = @password", conStr))
            {
                daUser.SelectCommand.Parameters.AddWithValue("@username", username);
                daUser.SelectCommand.Parameters.AddWithValue("@password", password);

                DataTable dt = new DataTable();
                daUser.Fill(dt);
                return dt;
            }
        }

        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source = " + pServer + "; Initial Catalog = master; User ID = " + pUser + "; pwd = " + pPass + "");
            da.Fill(dt);
            return dt;
        }

        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            Properties.Settings.Default.conStr = "Data Source=" + pServer + ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";Password = " + pPass + "";
            Properties.Settings.Default.Save();
        }
    }
}
