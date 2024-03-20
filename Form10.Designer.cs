namespace Lab1
{
    partial class Form10
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
            this.labelNhapMon = new System.Windows.Forms.Label();
            this.textBoxNhapMon = new System.Windows.Forms.TextBox();
            this.textBoxMenu = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonTimMon = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.labelMonAn = new System.Windows.Forms.Label();
            this.textBoxMonAn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNhapMon
            // 
            this.labelNhapMon.AutoSize = true;
            this.labelNhapMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapMon.Location = new System.Drawing.Point(12, 42);
            this.labelNhapMon.Name = "labelNhapMon";
            this.labelNhapMon.Size = new System.Drawing.Size(120, 20);
            this.labelNhapMon.TabIndex = 0;
            this.labelNhapMon.Text = "Nhập Món Ăn :";
            // 
            // textBoxNhapMon
            // 
            this.textBoxNhapMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapMon.Location = new System.Drawing.Point(138, 29);
            this.textBoxNhapMon.Multiline = true;
            this.textBoxNhapMon.Name = "textBoxNhapMon";
            this.textBoxNhapMon.Size = new System.Drawing.Size(210, 43);
            this.textBoxNhapMon.TabIndex = 1;
            // 
            // textBoxMenu
            // 
            this.textBoxMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMenu.Location = new System.Drawing.Point(371, 29);
            this.textBoxMenu.Multiline = true;
            this.textBoxMenu.Name = "textBoxMenu";
            this.textBoxMenu.ReadOnly = true;
            this.textBoxMenu.Size = new System.Drawing.Size(400, 217);
            this.textBoxMenu.TabIndex = 2;
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(229, 93);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(119, 45);
            this.buttonThem.TabIndex = 3;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonTimMon
            // 
            this.buttonTimMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimMon.Location = new System.Drawing.Point(305, 270);
            this.buttonTimMon.Name = "buttonTimMon";
            this.buttonTimMon.Size = new System.Drawing.Size(132, 37);
            this.buttonTimMon.TabIndex = 4;
            this.buttonTimMon.Text = "Tìm Món Ăn";
            this.buttonTimMon.UseVisualStyleBackColor = true;
            this.buttonTimMon.Click += new System.EventHandler(this.buttonTimMon_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(43, 270);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(132, 37);
            this.buttonXoa.TabIndex = 5;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(578, 270);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(132, 37);
            this.buttonThoat.TabIndex = 6;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // labelMonAn
            // 
            this.labelMonAn.AutoSize = true;
            this.labelMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonAn.Location = new System.Drawing.Point(285, 351);
            this.labelMonAn.Name = "labelMonAn";
            this.labelMonAn.Size = new System.Drawing.Size(175, 20);
            this.labelMonAn.TabIndex = 7;
            this.labelMonAn.Text = "Món Ăn Hôm Nay Là: ";
            // 
            // textBoxMonAn
            // 
            this.textBoxMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonAn.Location = new System.Drawing.Point(203, 383);
            this.textBoxMonAn.Multiline = true;
            this.textBoxMonAn.Name = "textBoxMonAn";
            this.textBoxMonAn.ReadOnly = true;
            this.textBoxMonAn.Size = new System.Drawing.Size(338, 35);
            this.textBoxMonAn.TabIndex = 8;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMonAn);
            this.Controls.Add(this.labelMonAn);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonTimMon);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxMenu);
            this.Controls.Add(this.textBoxNhapMon);
            this.Controls.Add(this.labelNhapMon);
            this.Name = "Form10";
            this.Text = "Bài 8";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNhapMon;
        private System.Windows.Forms.TextBox textBoxNhapMon;
        private System.Windows.Forms.TextBox textBoxMenu;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonTimMon;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label labelMonAn;
        private System.Windows.Forms.TextBox textBoxMonAn;
    }
}