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
    public partial class Frm_ForDoWhile : Form
    {
        public Frm_ForDoWhile()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
            private void button12_Click(object sender, EventArgs e)
            {

            }

            private void button13_Click(object sender, EventArgs e)
            {

            }

            




            

            private void button2_Click(object sender, EventArgs e)
            {
                int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
                int max = arr0711.Max();
                int min = arr0711.Min();
                labResult.Text = $"int 陣列 arr0711[1,5,6,8,7,97,54,887,65,578]\n最大值為 {max}\n最小值為 {min}";

            }

            private void btnevenodd_Click(object sender, EventArgs e)
            {
                int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
                int oddcount = 0;
                int evencount = 0;
                for (int i = 0; i < arr0711.Length; i++)
                {
                    if (arr0711[i] % 2 == 0)
                    {
                        evencount++;
                    }
                    else {
                        oddcount++;
                    }

                }
                labResult.Text = $"int 陣列 arr0711[1,5,6,8,7,97,54,887,65,578]\n奇數共{oddcount}個\n偶數共{evencount}個";
            }

            private void button4_Click(object sender, EventArgs e)
            {
                int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
                int sumarr0711 = arr0711.Sum();
                labResult.Text = $"int 陣列 arr0711[1,5,6,8,7,97,54,887,65,578]\n加總為{sumarr0711}";
            }

            private void btnmax_Click(object sender, EventArgs e)
            {
                int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
                int maxarr0711 = arr0711.Max();
                labResult.Text = $"int 陣列 arr0711[1,5,6,8,7,97,54,887,65,578]\n最大值為{maxarr0711}";
            }

            private void btnmin_Click(object sender, EventArgs e)
            {
                int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
                int minarr0711 = arr0711.Min();
                labResult.Text = $"int 陣列 arr0711[1,5,6,8,7,97,54,887,65,578]\n最小值為{minarr0711}";
            }
        private void button10_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txtNum.Text, out num))//如果tryparse結果為數字，則輸出數字
            {
                if (num % 2 == 0)
                {
                    labResult.Text = $"輸入的數{txtNum.Text} 為偶數";
                }
                else
                {
                    labResult.Text = $"輸入的數{txtNum.Text} 為奇數";
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int sum = 0; 
            //int numFrom = int.Parse(txtFrom.Text);
            //int numTo = int.Parse(txtTo.Text);
            //int numStep = int.Parse(txtStep.Text);
            if (!int.TryParse(txtFrom.Text, out int numFrom) || !int.TryParse(txtTo.Text, out int numTo) ||
                 !int.TryParse(txtStep.Text, out int numStep))
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            for (int i = numFrom; i <= numTo; i += numStep)
                {
                    sum += i;
                }

                labResult.Text = $"{numFrom}到{numTo}相隔{numStep - 1} \n加總為 {sum.ToString()}";
           
            
            

            

            
        
            }
        }
    }

       
    

