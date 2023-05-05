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
            grade.Math = int.Parse(txtMath.Text);

            //Grade[] studentGrades =
            //{
            //    new Grade{ 
            //        Name = txtName.Text, 
            //        Chinese=grade.Chinese, 
            //        English=grade.English, 
            //        Math=grade.Math
            //    }
            //};

        }

        private void button2_Click(object sender, EventArgs e)
        {
            labShow.Text=$"姓名:{grade.Name}\n國文:{grade.Chinese}分\n" +
                $"英文:{grade.English}分\n數學:{grade.Math}分";
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            int[] gradenum = { grade.Chinese, grade.English , grade.Math };
            string[] subjectName = { "國文", "英文", "數學" };

            int max=gradenum.Max(); 
            int min=gradenum.Min() ;
            int maxIndex = Array.IndexOf(gradenum, max);
            int minIndex = Array.IndexOf(gradenum, min);

            labShow2.Text = $"最高分科目為{subjectName[maxIndex]} {max}分\n最低分科目為{subjectName[minIndex]} {min}分";


        }
    }
}
