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
    public partial class Frm_Hello : Form
    {
        public Frm_Hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameC = txtNameC.Text;
            string Name=txtName.Text;
            string Gender=txtGender.Text;
            string Zodiac=txtZodiac.Text;

            MessageBox.Show("Hello，我是"+NameC+"\n英文名字是"+Name+"\n性別是"+Gender+"\n星座是"+Zodiac+"\n很高興認識你!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string NameC = txtNameC.Text;
            string Name = txtName.Text;
            string Gender = txtGender.Text;
            string Zodiac = txtZodiac.Text;
            MessageBox.Show("Hi，我是" + NameC + "\n英文名字是" + Name + "\n性別是" + Gender + "\n星座是" + Zodiac + "\n很高興認識你!");
        }
    }
}
