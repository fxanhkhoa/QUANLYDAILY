namespace QUANLYDAILY
{
    partial class frm_DSDaiLy
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
            this.DS_DL_datagrid = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS_DL_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Các Đại Lý";
            // 
            // DS_DL_datagrid
            // 
            this.DS_DL_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DS_DL_datagrid.Location = new System.Drawing.Point(12, 45);
            this.DS_DL_datagrid.Name = "DS_DL_datagrid";
            this.DS_DL_datagrid.Size = new System.Drawing.Size(496, 150);
            this.DS_DL_datagrid.TabIndex = 1;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(212, 217);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "Cập Nhật";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // frm_DSDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(520, 354);
            this.Controls.Add(this.update);
            this.Controls.Add(this.DS_DL_datagrid);
            this.Controls.Add(this.label1);
            this.Name = "frm_DSDaiLy";
            this.Text = "frm_DSDaiLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_DSDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_DL_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DS_DL_datagrid;
        private System.Windows.Forms.Button update;
    }
}