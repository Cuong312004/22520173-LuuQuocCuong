namespace Lab1
{
    partial class Form7
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.comboBoxTinhToan = new System.Windows.Forms.ComboBox();
            this.buttonTinh = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.textBoxKQ = new System.Windows.Forms.TextBox();
            this.labelKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(94, 45);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(52, 16);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Nhập A";
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(431, 45);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(52, 16);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "Nhập B";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(152, 42);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(119, 22);
            this.textBoxA.TabIndex = 2;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(489, 42);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 3;
            // 
            // comboBoxTinhToan
            // 
            this.comboBoxTinhToan.FormattingEnabled = true;
            this.comboBoxTinhToan.Items.AddRange(new object[] {
            "Bảng Cửu Chương",
            "Tính toán giá trị"});
            this.comboBoxTinhToan.Location = new System.Drawing.Point(280, 97);
            this.comboBoxTinhToan.Name = "comboBoxTinhToan";
            this.comboBoxTinhToan.Size = new System.Drawing.Size(139, 24);
            this.comboBoxTinhToan.TabIndex = 4;
            // 
            // buttonTinh
            // 
            this.buttonTinh.Location = new System.Drawing.Point(38, 172);
            this.buttonTinh.Name = "buttonTinh";
            this.buttonTinh.Size = new System.Drawing.Size(139, 43);
            this.buttonTinh.TabIndex = 5;
            this.buttonTinh.Text = "Tính các giá trị";
            this.buttonTinh.UseVisualStyleBackColor = true;
            this.buttonTinh.Click += new System.EventHandler(this.buttonTinh_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(280, 172);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(139, 42);
            this.buttonXoa.TabIndex = 6;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(518, 173);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(139, 42);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // textBoxKQ
            // 
            this.textBoxKQ.Location = new System.Drawing.Point(38, 301);
            this.textBoxKQ.Multiline = true;
            this.textBoxKQ.Name = "textBoxKQ";
            this.textBoxKQ.ReadOnly = true;
            this.textBoxKQ.Size = new System.Drawing.Size(703, 240);
            this.textBoxKQ.TabIndex = 8;
            // 
            // labelKQ
            // 
            this.labelKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKQ.Location = new System.Drawing.Point(34, 266);
            this.labelKQ.Name = "labelKQ";
            this.labelKQ.Size = new System.Drawing.Size(87, 22);
            this.labelKQ.TabIndex = 9;
            this.labelKQ.Text = "Kết Quả : ";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.labelKQ);
            this.Controls.Add(this.textBoxKQ);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonTinh);
            this.Controls.Add(this.comboBoxTinhToan);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Name = "Form7";
            this.Text = "Bài 5";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.ComboBox comboBoxTinhToan;
        private System.Windows.Forms.Button buttonTinh;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TextBox textBoxKQ;
        private System.Windows.Forms.Label labelKQ;
    }
}