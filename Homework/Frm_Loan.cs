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
    public partial class Frm_Loan : Form
    {
        public Frm_Loan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 讀取輸入的貸款金額、年限、年利率、頭期款
            double loanAmount = double.Parse(textBox1.Text);
            int years = int.Parse(textBox2.Text);
            double annualRate = double.Parse(textBox3.Text) / 100;
            double downPayment = double.Parse(textBox4.Text);

            // 計算月利率、總期數、月付額(PMT)
            double monthlyRate = annualRate / 12;
            int months = years * 12;
            double principal = loanAmount - downPayment;
            double monthlyPayment = principal * monthlyRate * Math.Pow(1 + monthlyRate, months) / (Math.Pow(1 + monthlyRate, months) - 1);

            // 顯示月付額(PMT)
            MessageBox.Show("月付額(PMT)：" + monthlyPayment.ToString("#0"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double loanAmount = double.Parse(textBox1.Text);
            int years = int.Parse(textBox2.Text);
            double annualRate = double.Parse(textBox3.Text) / 100;
            double downPayment = double.Parse(textBox4.Text);

            double monthlyRate = annualRate / 12;
            int months = years * 12;
            double principal = loanAmount - downPayment;
            double monthlyPayment = principal * monthlyRate * Math.Pow(1 + monthlyRate, months) / (Math.Pow(1 + monthlyRate, months) - 1);
            double totalAmount = 12 * years * monthlyPayment;

            MessageBox.Show("總付款:" + totalAmount.ToString("#0"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Loan_Report frm_Loan_Report = new Frm_Loan_Report();
            frm_Loan_Report.Show();
        }
        
    
    }

}

