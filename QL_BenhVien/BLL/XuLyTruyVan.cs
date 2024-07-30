using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class XuLyTruyVan
    {
        public static DataTable GetTableData(string tableName)
        {
            return TruyVan.GetData(tableName);
        }
    }
}
