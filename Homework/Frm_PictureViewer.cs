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
    public partial class Frm_PictureViewer : Form
    {
        public Frm_PictureViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pictureBox"></param>
        void PicShow(PictureBox pictureBox)//統一設定圖片點開的執行方法
        {
            PicShow picShow = new PicShow();
            picShow.Show();

            PictureBox pb = new PictureBox();
            pb.Image = new Bitmap(pictureBox.Image);
            pb.Dock = DockStyle.Fill;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            picShow.Controls.Add(pb);

            // 設定新的視窗的大小和顯示方式
            picShow.ClientSize = pb.Size;
            picShow.FormBorderStyle = FormBorderStyle.Sizable;
            picShow.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            PicShow(pb);
        }       
    }

}
