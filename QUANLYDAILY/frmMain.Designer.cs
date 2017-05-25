namespace QUANLYDAILY
{
    partial class frmMain
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
            this.HS_radio = new System.Windows.Forms.RadioButton();
            this.PXH_radio = new System.Windows.Forms.RadioButton();
            this.DS_DaiLy = new System.Windows.Forms.RadioButton();
            this.Phieuthu = new System.Windows.Forms.RadioButton();
            this.DoanhSo_radio = new System.Windows.Forms.RadioButton();
            this.CongNo_radio = new System.Windows.Forms.RadioButton();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HS_radio
            // 
            this.HS_radio.AutoSize = true;
            this.HS_radio.Location = new System.Drawing.Point(565, 12);
            this.HS_radio.Name = "HS_radio";
            this.HS_radio.Size = new System.Drawing.Size(88, 17);
            this.HS_radio.TabIndex = 0;
            this.HS_radio.Text = "Hồ Sơ Đại Lý";
            this.HS_radio.UseVisualStyleBackColor = true;
            this.HS_radio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PXH_radio
            // 
            this.PXH_radio.AutoSize = true;
            this.PXH_radio.Location = new System.Drawing.Point(565, 35);
            this.PXH_radio.Name = "PXH_radio";
            this.PXH_radio.Size = new System.Drawing.Size(106, 17);
            this.PXH_radio.TabIndex = 2;
            this.PXH_radio.Text = "Phiếu Xuất Hàng";
            this.PXH_radio.UseVisualStyleBackColor = true;
            this.PXH_radio.CheckedChanged += new System.EventHandler(this.PXH_radio_CheckedChanged);
            // 
            // DS_DaiLy
            // 
            this.DS_DaiLy.AutoSize = true;
            this.DS_DaiLy.Location = new System.Drawing.Point(565, 58);
            this.DS_DaiLy.Name = "DS_DaiLy";
            this.DS_DaiLy.Size = new System.Drawing.Size(73, 17);
            this.DS_DaiLy.TabIndex = 4;
            this.DS_DaiLy.Text = "DS Đại Lý";
            this.DS_DaiLy.UseVisualStyleBackColor = true;
            this.DS_DaiLy.CheckedChanged += new System.EventHandler(this.DS_DaiLy_CheckedChanged);
            // 
            // Phieuthu
            // 
            this.Phieuthu.AutoSize = true;
            this.Phieuthu.Location = new System.Drawing.Point(565, 81);
            this.Phieuthu.Name = "Phieuthu";
            this.Phieuthu.Size = new System.Drawing.Size(74, 17);
            this.Phieuthu.TabIndex = 6;
            this.Phieuthu.Text = "Phiếu Thu";
            this.Phieuthu.UseVisualStyleBackColor = true;
            this.Phieuthu.CheckedChanged += new System.EventHandler(this.Phieuthu_CheckedChanged);
            // 
            // DoanhSo_radio
            // 
            this.DoanhSo_radio.AutoSize = true;
            this.DoanhSo_radio.Location = new System.Drawing.Point(565, 104);
            this.DoanhSo_radio.Name = "DoanhSo_radio";
            this.DoanhSo_radio.Size = new System.Drawing.Size(73, 17);
            this.DoanhSo_radio.TabIndex = 8;
            this.DoanhSo_radio.Text = "Doanh Số";
            this.DoanhSo_radio.UseVisualStyleBackColor = true;
            this.DoanhSo_radio.CheckedChanged += new System.EventHandler(this.DoanhSo_radio_CheckedChanged);
            // 
            // CongNo_radio
            // 
            this.CongNo_radio.AutoSize = true;
            this.CongNo_radio.Location = new System.Drawing.Point(565, 127);
            this.CongNo_radio.Name = "CongNo_radio";
            this.CongNo_radio.Size = new System.Drawing.Size(67, 17);
            this.CongNo_radio.TabIndex = 9;
            this.CongNo_radio.Text = "Công Nợ";
            this.CongNo_radio.UseVisualStyleBackColor = true;
            this.CongNo_radio.CheckedChanged += new System.EventHandler(this.CongNo_radio_CheckedChanged);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(198, 113);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(214, 20);
            this.user.TabIndex = 11;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(198, 165);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(214, 20);
            this.pass.TabIndex = 12;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(198, 210);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 13;
            this.login.Text = "Đăng Nhập";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(337, 210);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.CongNo_radio);
            this.Controls.Add(this.DoanhSo_radio);
            this.Controls.Add(this.Phieuthu);
            this.Controls.Add(this.DS_DaiLy);
            this.Controls.Add(this.PXH_radio);
            this.Controls.Add(this.HS_radio);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton HS_radio;
        private System.Windows.Forms.RadioButton PXH_radio;
        private System.Windows.Forms.RadioButton DS_DaiLy;
        private System.Windows.Forms.RadioButton Phieuthu;
        private System.Windows.Forms.RadioButton DoanhSo_radio;
        private System.Windows.Forms.RadioButton CongNo_radio;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

