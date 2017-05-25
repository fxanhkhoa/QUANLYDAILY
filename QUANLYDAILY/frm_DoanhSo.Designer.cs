namespace QUANLYDAILY
{
    partial class frm_DoanhSo
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
            this.Month = new System.Windows.Forms.ComboBox();
            this.Datagrid_DoanhSo = new System.Windows.Forms.DataGridView();
            this.reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_DoanhSo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Doanh Số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(76, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Month
            // 
            this.Month.FormattingEnabled = true;
            this.Month.Location = new System.Drawing.Point(159, 45);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(121, 21);
            this.Month.TabIndex = 2;
            this.Month.SelectedIndexChanged += new System.EventHandler(this.Month_SelectedIndexChanged);
            // 
            // Datagrid_DoanhSo
            // 
            this.Datagrid_DoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_DoanhSo.Location = new System.Drawing.Point(12, 87);
            this.Datagrid_DoanhSo.Name = "Datagrid_DoanhSo";
            this.Datagrid_DoanhSo.Size = new System.Drawing.Size(496, 150);
            this.Datagrid_DoanhSo.TabIndex = 3;
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(12, 257);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(75, 23);
            this.reload.TabIndex = 4;
            this.reload.Text = "Reload";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // frm_DoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 354);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.Datagrid_DoanhSo);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DoanhSo";
            this.Text = "frm_DoanhSo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_DoanhSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_DoanhSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.DataGridView Datagrid_DoanhSo;
        private System.Windows.Forms.Button reload;
    }
}