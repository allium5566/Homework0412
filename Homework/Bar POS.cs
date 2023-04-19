using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Bar_POS : Form
    {
        public Bar_POS()
        {
            InitializeComponent();
        }
        int beerCount = 0;
        int tequilaCount = 0;
        int whiskeyCount = 0;
        int wineCount = 0;
      
        int totalpay = 0;

        void Order(string menu, int price, int quantity)
        {
            Totalpay();
            labList.Text = "";
            if (beerCount > 0)
            {
                
                string order = "";
                order = $"啤酒×{beerCount} 共{120 * beerCount}元" + Environment.NewLine;
                labList.Text += order;
               
            }
            

           
            if (tequilaCount > 0)
            {
                
                string order = "";
                order = $"龍舌蘭×{tequilaCount} 共{180 * tequilaCount}元"+ Environment.NewLine;
                labList.Text += order;
                
            }
            if (whiskeyCount > 0)
            {

                string order = "";
                order = $"威士忌×{tequilaCount} 共{350 * whiskeyCount}元" + Environment.NewLine;
                labList.Text += order;

            }
            if (wineCount > 0)
            {

                string order = "";
                order = $"紅酒×{tequilaCount} 共{320 * wineCount}元" + Environment.NewLine;
                labList.Text += order;

            }

        }

        


            private void btnBeer_Click_1(object sender, EventArgs e)
        {
            ++beerCount;
            Order("啤酒", 120, beerCount);
        }


        private void btnTequila_Click(object sender, EventArgs e)
        { 
            ++tequilaCount;
            Order("龍舌蘭", 180, tequilaCount);
        }

            
             private void btnWhiskey_Click(object sender, EventArgs e)
        {
            ++whiskeyCount;
            Order("威士忌", 350, whiskeyCount);
        }
        private void btnWine_Click(object sender, EventArgs e)
        {
            ++wineCount;
            Order("紅酒",320, wineCount);

        }


            private void btnDelete_Click(object sender, EventArgs e)
            {
                labList.Text = "尚未點餐";
                labAmount.Text = "NT$ 0";

            }
            void Totalpay()
        {
            totalpay = 120 * beerCount + 180 * tequilaCount + 350 * whiskeyCount + 320 * wineCount;
            labAmount.Text = $"NT$ {totalpay}";
        }

        
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            beerCount = 0;
            tequilaCount = 0;
            whiskeyCount = 0;
            wineCount = 0;
          
            totalpay = 0;
            labAmount.Text = "NT$ 0";
            labList.Text = "尚未點餐";
        }

        private void btnCash_Click_1(object sender, EventArgs e)
        {
            if (totalpay > 0)
            {
                MessageBox.Show($"總金額:NT$ {totalpay}");
            }
            else
            {
                MessageBox.Show("尚未點餐");
            }
        }

        private void btnCard_Click_1(object sender, EventArgs e)
        {
            if (totalpay > 0)
            {
                MessageBox.Show($"總金額:NT$ {totalpay*0.9}");
            }
            else
            {
                MessageBox.Show("尚未點餐");
            }
        }
    }
    }

       
    

