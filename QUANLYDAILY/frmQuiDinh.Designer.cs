namespace QUANLYDAILY
{
    partial class frmQuiDinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SL_loai = new System.Windows.Forms.TextBox();
            this.SL_toida = new System.Windows.Forms.TextBox();
            this.SL_mathang = new System.Windows.Forms.TextBox();
            this.SL_donvi = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Lượng Loại ĐL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số ĐL Tối Đa Trong Quận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng Mặt Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng Đơn Vị Tính";
            // 
            // SL_loai
            // 
            this.SL_loai.Location = new System.Drawing.Point(215, 46);
            this.SL_loai.Name = "SL_loai";
            this.SL_loai.Size = new System.Drawing.Size(100, 20);
            this.SL_loai.TabIndex = 4;
            // 
            // SL_toida
            // 
            this.SL_toida.Location = new System.Drawing.Point(215, 84);
            this.SL_toida.Name = "SL_toida";
            this.SL_toida.Size = new System.Drawing.Size(100, 20);
            this.SL_toida.TabIndex = 5;
            // 
            // SL_mathang
            // 
            this.SL_mathang.Location = new System.Drawing.Point(215, 125);
            this.SL_mathang.Name = "SL_mathang";
            this.SL_mathang.Size = new System.Drawing.Size(100, 20);
            this.SL_mathang.TabIndex = 6;
            // 
            // SL_donvi
            // 
            this.SL_donvi.Location = new System.Drawing.Point(215, 163);
            this.SL_donvi.Name = "SL_donvi";
            this.SL_donvi.Size = new System.Drawing.Size(100, 20);
            this.SL_donvi.TabIndex = 7;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(397, 46);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // frmQuiDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 354);
            this.Controls.Add(this.update);
            this.Controls.Add(this.SL_donvi);
            this.Controls.Add(this.SL_mathang);
            this.Controls.Add(this.SL_toida);
            this.Controls.Add(this.SL_loai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQuiDinh";
            this.Text = "frmQuiDinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SL_loai;
        private System.Windows.Forms.TextBox SL_toida;
        private System.Windows.Forms.TextBox SL_mathang;
        private System.Windows.Forms.TextBox SL_donvi;
        private System.Windows.Forms.Button update;
    }
}