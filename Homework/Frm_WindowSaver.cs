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
        private int prevX, prevY;//初始滑鼠位置
        private int xSpeed = 20;  // 水平方向速度
        private int ySpeed = 20;  // 垂直方向速度

        public Frm_WindowSaver()
        {
            InitializeComponent();
            prevX = Cursor.Position.X;
            prevY = Cursor.Position.Y;
            Timer timer1 = new Timer();
            timer1.Interval = 50;
            timer1.Tick += new EventHandler(Timer_Tick);
            timer1.Start();
        }
        /// <summary>
        /// 滑鼠位置與初始值不同就關閉程式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            int curX = Cursor.Position.X;
            int curY = Cursor.Position.Y;
            if (curX != prevX || curY != prevY)
            {
                Close();
            }
            prevX = curX;
            prevY = curY;

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            x += xSpeed;
            y += ySpeed;
            pictureBox1.Location = new Point(x, y);
            if (x < 0 || x > (this.ClientSize.Width - pictureBox1.Width))
            {
                xSpeed = -xSpeed;
            }

            // 碰到上下邊界，垂直方向速度反向
            if (y < 0 || y > (this.ClientSize.Height - pictureBox1.Height))
            {
                ySpeed = -ySpeed;
            }
        }
        
    }
}
