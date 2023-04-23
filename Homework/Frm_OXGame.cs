using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Frm_OXGame : Form
    {
        public Frm_OXGame()
        {
            InitializeComponent();
        }
     
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button mouseEnter = sender as Button;
            if (mouseEnter != null)
            {
                mouseEnter.FlatAppearance.BorderColor = Color.Red;
            }
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button mouseLeave = sender as Button;
            if (mouseLeave !=null)
            {
                mouseLeave.FlatAppearance.BorderColor = Color.RoyalBlue;
            }
        }

        int buttomClick = 0;
        private void button_MouseClick(object sender, EventArgs e)
        {
             buttomClick++;
         
            Button clickedButton = sender as Button;
            if(buttomClick%2==1)
            {
                clickedButton.Text = "X";
            }else if (buttomClick % 2 == 0)
            {
                clickedButton.Text = "O";
            }
            
            if (clickedButton != null  )
            {
                clickedButton.Enabled = false;
            }

        }
        
        private void button10_Click(object sender, EventArgs e)    //RESET
        {
            buttomClick = 0;
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = true;
                    //Button button = (Button)control;
                    // 在這裡對選中的 Button 進行操作
                    control.Text = "";
                }
            }

        }

        private void button11_Click(object sender, EventArgs e) //關閉程式
        {
            Application.Exit();
        }

       
    }
}
