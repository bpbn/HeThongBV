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
    public partial class uc_Days : UserControl
    {
        public uc_Days()
        {
            InitializeComponent();
        }

        public void days(int numday)
        {
            lbDays.Text = numday.ToString();
        }
    }
}
