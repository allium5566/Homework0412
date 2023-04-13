using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Frm_Student_StructForm : Form
    {
        public Frm_Student_StructForm()
        {
            InitializeComponent();
        }
        Grade grade = new Grade();
        private void button1_Click(object sender, EventArgs e)
        {
            

            grade.Name = txtName.Text;
            grade.Chinese=int.Parse(txtChinese.Text) ;
            grade.English=int.Parse(txtEnglish.Text) ;
            grade.Math=int.Parse(txtMath.Text) ;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labShow.Text=$"姓名:{grade.Name}\n國文:{grade.Chinese}分\n" +
                $"英文:{grade.English}分\n數學:{grade.Math}分";
        }
    }
}
