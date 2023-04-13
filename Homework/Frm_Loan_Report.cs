using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Frm_Loan_Report : Form
    {
        public Frm_Loan_Report()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 讀取靜態變量的值
            string LA = Loan.loanAmount.ToString();

            // 將值顯示在label控件中
            labLoanAmount.Text = LA;
        }




    }
}
