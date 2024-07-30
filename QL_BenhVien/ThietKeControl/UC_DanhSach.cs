using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControl
{
    public partial class UC_DanhSach : UserControl
    {
        public UC_DanhSach()
        {
            InitializeComponent();
        }

        private void UC_DanhSach_Load(object sender, EventArgs e)
        {
            
        }

        public void SetDataSource(DataTable dataSource)
        {
            dataGridView1.DataSource = dataSource;
        }
    }
}
