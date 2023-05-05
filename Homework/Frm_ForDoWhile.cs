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

        private void btnwhile_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFrom.Text, out int numFrom) || !int.TryParse(txtTo.Text, out int numTo) ||
                !int.TryParse(txtStep.Text, out int numStep))
            {
                MessageBox.Show("請輸入數字");
                return;
            }

            int sum =numFrom;
            int i = 0;
            
            while (numFrom+(i++ *numStep)<numTo)
            { 
                sum += numFrom +( i * numStep);
            }
            labResult.Text = $"{numFrom}到{numTo}相隔{numStep - 1} \n加總為 {sum.ToString()}";
        }

        private void btndo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFrom.Text, out int numFrom) || !int.TryParse(txtTo.Text, out int numTo) ||
              !int.TryParse(txtStep.Text, out int numStep))
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            int i = 0;
            int sum =numFrom;
            do
            {
                sum += numFrom + (i * numStep);
            } while ((numFrom + i++) < numTo);
        }

        private void button6_Click(object sender, EventArgs e)//九九乘法表
        {
            string result = "";
            for(int i = 1; i < 10; i++)
            {
                for(int j = 2; j < 10; j++)
                { 
                    result += $" {j}×{i}＝{ (i*j).ToString("00")} | ";
                }
                result +=  "\n";
            }
              labResult.Text="九九乘法表\n"+ result ;
        }

        private void button5_Click(object sender, EventArgs e)//christmastree
        {
            string result = "";
            if (!int.TryParse(txtRows.Text,out int rows))
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            for(int i = 1; i <= rows; i++)
            {
                for(int j=1;j<=i; j++)//*的數量(當i=3 ,j跑123
                {
                    result += "＊";
                }
                result += "\n";
            }
            labResult.Text=result;

        }

        private void button4_Click_1(object sender, EventArgs e)//樂透開獎
        {
            int[] lottery = new int[49];
           for(int i = 0; i <lottery.Length; i++)
            {
                lottery[i] = i+1;
            }
            int[] open = new int[6];
            Random random = new Random();

            for (int i = 0; i < open.Length; i++)
            {
                int index = random.Next(lottery.Length - i);//chat說的丟進來。但這到底是啥
                open[i] = lottery[index];
                lottery[index] = lottery[lottery.Length - i - 1];
            }
            string result = "";
            foreach(int i in open)
            {
                result += $"{i} ";
                labResult.Text =$"樂透號碼\n [ {result} ]";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 100;
            string binary=Convert.ToString(num, 2);
            labResult.Text = binary;
        }
    }
    }

       
    

