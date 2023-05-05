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
    public partial class Frm_Alarm : Form
    {
        public Frm_Alarm()
        {
            InitializeComponent();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString();
        }

        private void Frm_Alarm_Load(object sender, EventArgs e)
        {

        }
    }
}
