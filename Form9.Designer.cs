namespace Lab1
{
    partial class Form9
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
            this.labelNhap = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonHoten = new System.Windows.Forms.Button();
            this.buttonDiem = new System.Windows.Forms.Button();
            this.buttonĐTB = new System.Windows.Forms.Button();
            this.buttonMaxMin = new System.Windows.Forms.Button();
            this.buttondaukhong = new System.Windows.Forms.Button();
            this.buttonXepLoai = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNhap
            // 
            this.labelNhap.AutoSize = true;
            this.labelNhap.Location = new System.Drawing.Point(24, 27);
            this.labelNhap.Name = "labelNhap";
            this.labelNhap.Size = new System.Drawing.Size(49, 16);
            this.labelNhap.TabIndex = 0;
            this.labelNhap.Text = "Nhập : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(643, 42);
            this.textBox1.TabIndex = 1;
            // 
            // buttonHoten
            // 
            this.buttonHoten.Location = new System.Drawing.Point(12, 109);
            this.buttonHoten.Name = "buttonHoten";
            this.buttonHoten.Size = new System.Drawing.Size(106, 47);
            this.buttonHoten.TabIndex = 2;
            this.buttonHoten.Text = "Họ và Tên";
            this.buttonHoten.UseVisualStyleBackColor = true;
            this.buttonHoten.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDiem
            // 
            this.buttonDiem.Location = new System.Drawing.Point(152, 109);
            this.buttonDiem.Name = "buttonDiem";
            this.buttonDiem.Size = new System.Drawing.Size(106, 47);
            this.buttonDiem.TabIndex = 3;
            this.buttonDiem.Text = "Điểm";
            this.buttonDiem.UseVisualStyleBackColor = true;
            this.buttonDiem.Click += new System.EventHandler(this.buttonDiem_Click);
            // 
            // buttonĐTB
            // 
            this.buttonĐTB.Location = new System.Drawing.Point(283, 109);
            this.buttonĐTB.Name = "buttonĐTB";
            this.buttonĐTB.Size = new System.Drawing.Size(106, 47);
            this.buttonĐTB.TabIndex = 4;
            this.buttonĐTB.Text = "Điểm Trung Bình";
            this.buttonĐTB.UseVisualStyleBackColor = true;
            this.buttonĐTB.Click += new System.EventHandler(this.buttonĐTB_Click);
            // 
            // buttonMaxMin
            // 
            this.buttonMaxMin.Location = new System.Drawing.Point(417, 109);
            this.buttonMaxMin.Name = "buttonMaxMin";
            this.buttonMaxMin.Size = new System.Drawing.Size(106, 47);
            this.buttonMaxMin.TabIndex = 5;
            this.buttonMaxMin.Text = "Max/Min";
            this.buttonMaxMin.UseVisualStyleBackColor = true;
            this.buttonMaxMin.Click += new System.EventHandler(this.buttonMaxMin_Click);
            // 
            // buttondaukhong
            // 
            this.buttondaukhong.Location = new System.Drawing.Point(546, 109);
            this.buttondaukhong.Name = "buttondaukhong";
            this.buttondaukhong.Size = new System.Drawing.Size(106, 47);
            this.buttondaukhong.TabIndex = 6;
            this.buttondaukhong.Text = "Số Môn Đậu Và Rớt";
            this.buttondaukhong.UseVisualStyleBackColor = true;
            this.buttondaukhong.Click += new System.EventHandler(this.buttondaukhong_Click);
            // 
            // buttonXepLoai
            // 
            this.buttonXepLoai.Location = new System.Drawing.Point(682, 109);
            this.buttonXepLoai.Name = "buttonXepLoai";
            this.buttonXepLoai.Size = new System.Drawing.Size(106, 47);
            this.buttonXepLoai.TabIndex = 7;
            this.buttonXepLoai.Text = "Xếp Loại";
            this.buttonXepLoai.UseVisualStyleBackColor = true;
            this.buttonXepLoai.Click += new System.EventHandler(this.buttonXepLoai_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(27, 249);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(744, 377);
            this.textBox2.TabIndex = 8;
            // 
            // labelKQ
            // 
            this.labelKQ.AutoSize = true;
            this.labelKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKQ.Location = new System.Drawing.Point(23, 215);
            this.labelKQ.Name = "labelKQ";
            this.labelKQ.Size = new System.Drawing.Size(80, 20);
            this.labelKQ.TabIndex = 9;
            this.labelKQ.Text = "Kết Quả :";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.labelKQ);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonXepLoai);
            this.Controls.Add(this.buttondaukhong);
            this.Controls.Add(this.buttonMaxMin);
            this.Controls.Add(this.buttonĐTB);
            this.Controls.Add(this.buttonDiem);
            this.Controls.Add(this.buttonHoten);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNhap);
            this.Name = "Form9";
            this.Text = "Bài 7";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNhap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonHoten;
        private System.Windows.Forms.Button buttonDiem;
        private System.Windows.Forms.Button buttonĐTB;
        private System.Windows.Forms.Button buttonMaxMin;
        private System.Windows.Forms.Button buttondaukhong;
        private System.Windows.Forms.Button buttonXepLoai;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelKQ;
    }
}