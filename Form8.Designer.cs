namespace Lab1
{
    partial class Form8
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDMY = new System.Windows.Forms.Label();
            this.buttonXem = new System.Windows.Forms.Button();
            this.textBoxCHĐ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(276, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // labelDMY
            // 
            this.labelDMY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDMY.Location = new System.Drawing.Point(104, 76);
            this.labelDMY.Name = "labelDMY";
            this.labelDMY.Size = new System.Drawing.Size(166, 43);
            this.labelDMY.TabIndex = 1;
            this.labelDMY.Text = "Chọn DD/MM/YY :";
            // 
            // buttonXem
            // 
            this.buttonXem.Location = new System.Drawing.Point(276, 149);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(259, 39);
            this.buttonXem.TabIndex = 2;
            this.buttonXem.Text = "Xem Cung Hoàng Đạo Của Bạn";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // textBoxCHĐ
            // 
            this.textBoxCHĐ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxCHĐ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCHĐ.Location = new System.Drawing.Point(276, 240);
            this.textBoxCHĐ.Multiline = true;
            this.textBoxCHĐ.Name = "textBoxCHĐ";
            this.textBoxCHĐ.ReadOnly = true;
            this.textBoxCHĐ.Size = new System.Drawing.Size(269, 56);
            this.textBoxCHĐ.TabIndex = 3;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCHĐ);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.labelDMY);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form8";
            this.Text = "Bài 6";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDMY;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.TextBox textBoxCHĐ;
    }
}