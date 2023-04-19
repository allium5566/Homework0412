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
    public partial class Bar_POS : Form
    {
        public Bar_POS()
        {
            InitializeComponent();
        }

        int tequilaCount = 0;
        int j = 0;
        int beerCount = 0;
        public void Order( )
        {

            
            if (beerCount > 0)
            {
                string beer = "";
                beer += $"啤酒×{beerCount}共{180 * beerCount}元";
                labList.Text = beer;
            }

        }
        private void btnBeer_Click(object sender, EventArgs e)
        {
            ++beerCount;
             Order();


        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            string order = "";
            //tequila += $"龍舌蘭×{i} 共{180 * (i++)}元";

          Order();
            
            
            //int tequilapay = 180 * (i++);
            
        }

        private void btnWhiskey_Click(object sender, EventArgs e)
        {
            //string whiskey = "";
            ///*whiskey += $"威士忌×{j} 共{35*/0 * (j++)}元";
            //labList.Text= whiskey;
            ////int whiskeypay = 350 * (i++);
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            //string wine = "";
            //wine += $"紅酒×{i} 共{320 * (i++)}元";
            //int winepay = 320 * (i++);
        }
        
        
    }
}
