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

        Bar bar = new Bar();
        int i = 1;
        
        private void btnBeer_Click(object sender, EventArgs e)
        { 
            
            string beer = "";
            beer += $"啤酒×{i} 共{120 *( i++)}元";
           
           
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            string tequila = "";
            tequila += $"龍舌蘭×{i} 共{180 * (i++)}元";
            int tequilapay = 180 * (i++);
        }

        private void btnWhiskey_Click(object sender, EventArgs e)
        {
            string whiskey = "";
            whiskey += $"威士忌×{i} 共{350 * (i++)}元";
            int whiskeypay = 350 * (i++);
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            string wine = "";
            wine += $"紅酒×{i} 共{320 * (i++)}元";
            int winepay = 320 * (i++);
        }
        
    }
}
