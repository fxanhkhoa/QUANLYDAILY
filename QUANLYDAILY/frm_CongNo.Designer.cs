namespace QUANLYDAILY
{
    partial class frm_CongNo
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
            this.month = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CongNo_Datagrid = new System.Windows.Forms.DataGridView();
            this.Reload = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CongNo_Datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Công Nợ Đại Lý";
            // 
            // month
            // 
            this.month.FormattingEnabled = true;
            this.month.Location = new System.Drawing.Point(190, 53);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(121, 21);
            this.month.TabIndex = 1;
            this.month.SelectedIndexChanged += new System.EventHandler(this.month_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(116, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng";
            // 
            // CongNo_Datagrid
            // 
            this.CongNo_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CongNo_Datagrid.Location = new System.Drawing.Point(12, 93);
            this.CongNo_Datagrid.Name = "CongNo_Datagrid";
            this.CongNo_Datagrid.Size = new System.Drawing.Size(496, 150);
            this.CongNo_Datagrid.TabIndex = 3;
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(12, 265);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(75, 23);
            this.Reload.TabIndex = 4;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(119, 265);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // frm_CongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 354);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.CongNo_Datagrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label1);
            this.Name = "frm_CongNo";
            this.Text = "frm_CongNo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_CongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CongNo_Datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CongNo_Datagrid;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button Update;
    }
}