using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class XuLyDangNhap
    {
        private UserDAL userDAL = new UserDAL();
        public XuLyDangNhap() { }

        public int Check_Config()
        {
            return userDAL.Check_Config(Properties.Settings.Default.conStr);
        }

        public LoginResult Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from TAIKHOAN where TENTAIKHOAN = '" + pUser + "' and MATKHAU = N'" + pPass + "'", Properties.Settings.Default.conStr);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return LoginResult.Invalid;
            }
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return LoginResult.Disabled;
            }
            return LoginResult.Success;
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
