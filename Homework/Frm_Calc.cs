using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework
{
    public partial class Frm_Calc : Form
    {
        public Frm_Calc()
        {
            InitializeComponent();
        }
        double num1 = 0;
        double num2 = 0;
        private void button1_Click(object sender, EventArgs e)//plus
        {
            if (!Double.TryParse(txtNum1.Text, out double num1) || !Double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("請輸入數字！");
                return; //有回傳值要加return
            }
            {
                double result = num1 + num2;
                labAns.Text = result.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)//minus
        {
            if (!Double.TryParse(txtNum1.Text, out double num1) || !Double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("請輸入數字！");
                return; //有回傳值要加return
            }
            {
                double result = num1 - num2;
                labAns.Text = result.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e) //multiply
        {
            if (!Double.TryParse(txtNum1.Text, out double num1) || !Double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("請輸入數字！");
                return; //有回傳值要加return
            }
            {
                double result = num1 * num2;
                labAns.Text = result.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNum1.Text, out double num1) || !Double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("請輸入數字！");
                return; //有回傳值要加return
            }
            {
                //if (num2 == 0&&num1==0)
                //{
                //    MessageBox.Show("分子分母不可同時為0");
                //}
                double result = num1 /num2;
                labAns.Text = result.ToString();
            }
        }
    }
}
        
    

