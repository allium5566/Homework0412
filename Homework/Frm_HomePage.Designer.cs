using System.Windows.Forms;

namespace Homework
{
    partial class Frm_HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void showSplitContainer()
        {
            SplitContainer splitContainer1 = new SplitContainer();
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Location = new System.Drawing.Point(74, 20);
            splitContainer1.Name = "DemoSplitContainer";
            splitContainer1.Size = new System.Drawing.Size(212, 435);
            splitContainer1.TabIndex = 0;
            splitContainer1.Orientation = Orientation.Horizontal;
            this.Controls.Add(splitContainer1);

        }

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button button1;
        private Button button2;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button15;
    }
}