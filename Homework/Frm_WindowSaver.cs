using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Homework
{
    public partial class Frm_WindowSaver : Form
    {
       
        
        public Frm_WindowSaver()
        {
            InitializeComponent();
        
        }private int xVelocity = 10;
        private int yVelocity = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 檢查圖片是否碰到了螢幕邊界，如果碰到了就反彈
            if (pictureBox1.Location.X < 0 || pictureBox1.Location.X + pictureBox1.Width > ClientSize.Width)
            {
                xVelocity = -xVelocity;
            }
            if (pictureBox1.Location.Y < 0 || pictureBox1.Location.Y + pictureBox1.Height > ClientSize.Height)
            {
                yVelocity = -yVelocity;
            }

            // 更新圖片位置
            pictureBox1.Location = new Point(pictureBox1.Location.X + xVelocity, pictureBox1.Location.Y + yVelocity);
        }
        

        private void Frm_WindowSaver_MouseMove(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
