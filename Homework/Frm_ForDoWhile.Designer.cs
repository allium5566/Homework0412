﻿namespace Homework
{
    partial class Frm_ForDoWhile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnevenodd = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(94, 23);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(107, 22);
            this.txtNum.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(17, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "輸入的數字為奇數或偶數?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(17, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "arr[]0711最大值最小值";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnevenodd
            // 
            this.btnevenodd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnevenodd.Location = new System.Drawing.Point(232, 23);
            this.btnevenodd.Name = "btnevenodd";
            this.btnevenodd.Size = new System.Drawing.Size(178, 29);
            this.btnevenodd.TabIndex = 4;
            this.btnevenodd.Text = "陣列arr[]0711統計奇偶數";
            this.btnevenodd.UseVisualStyleBackColor = true;
            this.btnevenodd.Click += new System.EventHandler(this.btnevenodd_Click);
            // 
            // btnsum
            // 
            this.btnsum.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsum.Location = new System.Drawing.Point(516, 54);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(163, 29);
            this.btnsum.TabIndex = 5;
            this.btnsum.Text = "SUM(陣列arr0711[])";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnmax
            // 
            this.btnmax.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmax.Location = new System.Drawing.Point(516, 100);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(163, 29);
            this.btnmax.TabIndex = 6;
            this.btnmax.Text = "Max(陣列arr0711[])";
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnmin
            // 
            this.btnmin.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnmin.Location = new System.Drawing.Point(516, 148);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(163, 29);
            this.btnmin.TabIndex = 7;
            this.btnmin.Text = "Min(陣列arr0711)";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(516, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 28);
            this.button7.TabIndex = 8;
            this.button7.Text = "swap[int,int]";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(16, 138);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(168, 59);
            this.button8.TabIndex = 9;
            this.button8.Text = "陣列arr0711_str[] xue\"C\"or\"c\" 的字樣有幾個";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button9.Location = new System.Drawing.Point(232, 72);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(192, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "arr0711_strr[] 最長的名字";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button10.Location = new System.Drawing.Point(112, 233);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 35);
            this.button10.TabIndex = 11;
            this.button10.Text = "清空結果欄";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button11.Location = new System.Drawing.Point(232, 115);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(245, 23);
            this.button11.TabIndex = 12;
            this.button11.Text = "[10,10]二維陣列-邊1,內0";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button12.Location = new System.Drawing.Point(232, 158);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(245, 23);
            this.button12.TabIndex = 13;
            this.button12.Text = "[10,10]二維陣列-邊0,內1";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button13.Location = new System.Drawing.Point(232, 201);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(147, 44);
            this.button13.TabIndex = 14;
            this.button13.Text = "[10,10]二維陣列 \r\n101010\r\n010101";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(27, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Result:";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labResult.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.ForeColor = System.Drawing.Color.IndianRed;
            this.labResult.Location = new System.Drawing.Point(109, 323);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(34, 17);
            this.labResult.TabIndex = 16;
            this.labResult.Text = "結果";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(707, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "rows:";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(763, 223);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(70, 22);
            this.txtRows.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "From:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(423, 229);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(50, 22);
            this.txtFrom.TabIndex = 20;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(423, 257);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(50, 22);
            this.txtTo.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "To:";
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(423, 285);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(50, 22);
            this.txtStep.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "Step:";
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(516, 224);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(75, 23);
            this.btnfor.TabIndex = 25;
            this.btnfor.Text = "for";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(516, 256);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(75, 23);
            this.btnwhile.TabIndex = 26;
            this.btnwhile.Text = "while";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndo
            // 
            this.btndo.Location = new System.Drawing.Point(516, 285);
            this.btndo.Name = "btndo";
            this.btndo.Size = new System.Drawing.Size(75, 23);
            this.btndo.TabIndex = 27;
            this.btndo.Text = "do";
            this.btndo.UseVisualStyleBackColor = true;
            this.btndo.Click += new System.EventHandler(this.btndo_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(699, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 27);
            this.button3.TabIndex = 28;
            this.button3.Text = "100的二進位";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(699, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 27);
            this.button4.TabIndex = 29;
            this.button4.Text = "樂透int[] 號碼不重複";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Maroon;
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(699, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 27);
            this.button5.TabIndex = 30;
            this.button5.Text = "直角聖誕樹";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Maroon;
            this.button6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(699, 148);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 27);
            this.button6.TabIndex = 31;
            this.button6.Text = "九九乘法表";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Frm_ForDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 517);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btndo);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btnevenodd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ForDoWhile";
            this.Text = "Frm_ForDoWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnevenodd;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}