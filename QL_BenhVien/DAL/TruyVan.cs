using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class TruyVan
    {
        QLBVDataContext qlbv = new QLBVDataContext();
        private static string GetConnectionString()
        {
            return Properties.Settings.Default.QL_BENHVIENConnectionString;
        }
        public static DataTable GetData(string tableName)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM {tableName}";

            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public List<TOATHUOC> loadToaThuoc()
        {
            return qlbv.TOATHUOCs.Select(tt => tt).ToList<TOATHUOC>();
        }

        public List<THUOC> loadThuoc()
        {
            return qlbv.THUOCs.Select(t => t).ToList<THUOC>();
        }

        public List<BENH> loadBenh()
        {
            return qlbv.BENHs.Select(b => b).ToList<BENH>();
        }
    }
}
