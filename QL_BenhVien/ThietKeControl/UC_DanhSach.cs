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
        public event EventHandler<DataRow> RowSelected;

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

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện SelectionChanged tại đây
            var selectedRow = GetSelectedRow();
            if (selectedRow != null)
            {
                RowSelected?.Invoke(this, selectedRow);
            }
        }

        public DataRow GetSelectedRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var dataTable = (DataTable)dataGridView1.DataSource;
                return dataTable.Rows[selectedRow.Index];
            }
            return null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
