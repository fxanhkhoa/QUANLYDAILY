namespace QUANLYDAILY
{
    partial class frm_PhieuThuTIen
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
            this.PTT_datagrid = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.fix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PTT_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Thu Tiền";
            // 
            // PTT_datagrid
            // 
            this.PTT_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PTT_datagrid.Location = new System.Drawing.Point(12, 47);
            this.PTT_datagrid.Name = "PTT_datagrid";
            this.PTT_datagrid.Size = new System.Drawing.Size(496, 150);
            this.PTT_datagrid.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(52, 215);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(360, 215);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // fix
            // 
            this.fix.Location = new System.Drawing.Point(209, 215);
            this.fix.Name = "fix";
            this.fix.Size = new System.Drawing.Size(75, 23);
            this.fix.TabIndex = 5;
            this.fix.Text = "Sửa";
            this.fix.UseVisualStyleBackColor = true;
            this.fix.Click += new System.EventHandler(this.fix_Click);
            // 
            // frm_PhieuThuTIen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(520, 354);
            this.Controls.Add(this.fix);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.PTT_datagrid);
            this.Controls.Add(this.label1);
            this.Name = "frm_PhieuThuTIen";
            this.Text = "frm_PhieuThuTIen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_PhieuThuTIen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PTT_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PTT_datagrid;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button fix;
    }
}