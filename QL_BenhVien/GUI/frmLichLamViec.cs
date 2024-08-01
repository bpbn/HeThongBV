using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThietKeControl;

namespace GUI
{
    public partial class frmLichLamViec : Form
    {
        int year, month;
        public frmLichLamViec()
        {
            InitializeComponent();
        }

        private void frmLichLamViec_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            year = now.Year;
            month = now.Month;
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;


            for(int i=1;i < dayOfTheWeek; i++)
            {
                uc_Blank ucBlank = new uc_Blank();
                pnLich.Controls.Add(ucBlank);
            }    
            for (int i = 1; i <= days; i++)
            {
                uc_Days ucDay = new uc_Days();
                ucDay.days(i);
                pnLich.Controls.Add(ucDay);
            }

            lbMonthYear.Text = "Tháng " + month.ToString() + " Năm " + year.ToString();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            pnLich.Controls.Clear();
            month--;
            if (month < 1)
            {
                year--;
                month = 12;
            }
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                uc_Blank ucBlank = new uc_Blank();
                pnLich.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                uc_Days ucDay = new uc_Days();
                ucDay.days(i);
                pnLich.Controls.Add(ucDay);
            }

            lbMonthYear.Text = "Tháng " + month.ToString() + " Năm " + year.ToString();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            pnLich.Controls.Clear();
            month++;
            if(month > 12)
            {
                year++;
                month = 1;
            }
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                uc_Blank ucBlank = new uc_Blank();
                pnLich.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                uc_Days ucDay = new uc_Days();
                ucDay.days(i);
                pnLich.Controls.Add(ucDay);
            }

            lbMonthYear.Text = "Tháng " + month.ToString() + " Năm " + year.ToString();
        }
    }
}
