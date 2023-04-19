namespace Homework
{
    partial class Frm_Student_StructForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labShow2 = new System.Windows.Forms.Label();
            this.labShow = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(94, 22);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "0";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(71, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(71, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "國文:";
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(166, 128);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(94, 22);
            this.txtChinese.TabIndex = 2;
            this.txtChinese.Text = "0";
            this.txtChinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(71, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "英文:";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(166, 188);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(94, 22);
            this.txtEnglish.TabIndex = 4;
            this.txtEnglish.Text = "0";
            this.txtEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(71, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "數學:";
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(166, 248);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(94, 22);
            this.txtMath.TabIndex = 6;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "儲存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "顯示儲存內容";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labShow2);
            this.groupBox1.Controls.Add(this.labShow);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(421, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 328);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // labShow2
            // 
            this.labShow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow2.Location = new System.Drawing.Point(10, 176);
            this.labShow2.Name = "labShow2";
            this.labShow2.Size = new System.Drawing.Size(227, 136);
            this.labShow2.TabIndex = 1;
            // 
            // labShow
            // 
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Location = new System.Drawing.Point(10, 28);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(227, 136);
            this.labShow.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(531, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 38);
            this.button3.TabIndex = 11;
            this.button3.Text = "最高分/最低分科目";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Frm_Student_StructForm";
            this.Text = "Frm_Student_StructForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labShow2;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Button button3;
    }
}