using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
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
        string order = "";
        int totalpay = 0;

        //void Order(string menu,int price,int quantity)
        //{
        //    if (quantity > 0)
        //    {
        //        order = $"{menu}×{quantity} 共{price * quantity}元";
        //        labList.Text=order;
        //        Totalpay();
        //    }
        //    else { }

        //}
        Dictionary<string, int> drinkCounts = new Dictionary<string, int>();

        void Order(string menu, int price, int quantity)
        {
            if (quantity > 0)
            {
                int total = price * quantity;
                order = $"{menu} × {quantity} 共 {total} 元";
                drinkCounts[menu] = quantity;  // 將訂購數量保存到字典中
                labList.Text = string.Join("\n", drinkCounts.Select(kv => $"{kv.Key} × {kv.Value} 共 {kv.Value * price} 元"));
                Totalpay();
            }
            else { }
        }





        private void btnBeer_Click(object sender, EventArgs e)
        {
            ++beerCount;
            Order("啤酒",120,beerCount);
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            ++tequilaCount;
            Order("龍舌蘭", 180, tequilaCount);
        }

        private void btnWhiskey_Click(object sender, EventArgs e)
        {
            ++whiskeyCount;
            Order("威士忌",350,whiskeyCount);
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            ++wineCount;
            Order("紅酒",320,wineCount);

            
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            labList.Text = "尚未點餐";
            labAmount.Text= "NT$ 0";
            
        }
        void  Totalpay()
        {
            
            totalpay = 120 * beerCount + 180 * tequilaCount + 350 * whiskeyCount + 320 * wineCount;
            labAmount.Text=$"NT$ {totalpay}";
            
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額NT${totalpay} ");
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額NT${totalpay*0.9} ");
        }
    }
}
