namespace QUANLYDAILY
{
    partial class PhieuXuatHang
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
            this.PXH_datagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_list = new System.Windows.Forms.ListBox();
            this.TenDaiLy = new System.Windows.Forms.Label();
            this.NgayLapPhieu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.HD_Add = new System.Windows.Forms.TextBox();
            this.DaiLy_combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.re_load = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.thua_no = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PXH_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PXH_datagrid
            // 
            this.PXH_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PXH_datagrid.Location = new System.Drawing.Point(12, 36);
            this.PXH_datagrid.Name = "PXH_datagrid";
            this.PXH_datagrid.Size = new System.Drawing.Size(496, 170);
            this.PXH_datagrid.TabIndex = 0;
            this.PXH_datagrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PXH_datagrid_RowsAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phiếu Xuất Hàng";
            // 
            // ID_list
            // 
            this.ID_list.FormattingEnabled = true;
            this.ID_list.Location = new System.Drawing.Point(12, 255);
            this.ID_list.MultiColumn = true;
            this.ID_list.Name = "ID_list";
            this.ID_list.Size = new System.Drawing.Size(89, 69);
            this.ID_list.TabIndex = 3;
            this.ID_list.SelectedIndexChanged += new System.EventHandler(this.ID_list_SelectedIndexChanged);
            this.ID_list.SelectedValueChanged += new System.EventHandler(this.ID_list_SelectedValueChanged);
            // 
            // TenDaiLy
            // 
            this.TenDaiLy.AutoSize = true;
            this.TenDaiLy.Location = new System.Drawing.Point(101, 365);
            this.TenDaiLy.Name = "TenDaiLy";
            this.TenDaiLy.Size = new System.Drawing.Size(35, 13);
            this.TenDaiLy.TabIndex = 4;
            this.TenDaiLy.Text = "label2";
            // 
            // NgayLapPhieu
            // 
            this.NgayLapPhieu.AutoSize = true;
            this.NgayLapPhieu.Location = new System.Drawing.Point(101, 336);
            this.NgayLapPhieu.Name = "NgayLapPhieu";
            this.NgayLapPhieu.Size = new System.Drawing.Size(35, 13);
            this.NgayLapPhieu.TabIndex = 5;
            this.NgayLapPhieu.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày Xuất Phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đại Lý:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã Hóa Đơn";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(399, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Thêm Hóa Đơn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tên Hóa Đơn";
            // 
            // HD_Add
            // 
            this.HD_Add.Location = new System.Drawing.Point(372, 232);
            this.HD_Add.Name = "HD_Add";
            this.HD_Add.Size = new System.Drawing.Size(100, 20);
            this.HD_Add.TabIndex = 16;
            // 
            // DaiLy_combo
            // 
            this.DaiLy_combo.FormattingEnabled = true;
            this.DaiLy_combo.Location = new System.Drawing.Point(372, 257);
            this.DaiLy_combo.Name = "DaiLy_combo";
            this.DaiLy_combo.Size = new System.Drawing.Size(121, 21);
            this.DaiLy_combo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Đại Lý";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(372, 290);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ngày Lập Phiếu";
            // 
            // re_load
            // 
            this.re_load.Location = new System.Drawing.Point(433, 12);
            this.re_load.Name = "re_load";
            this.re_load.Size = new System.Drawing.Size(75, 23);
            this.re_load.TabIndex = 21;
            this.re_load.Text = "Reload";
            this.re_load.UseVisualStyleBackColor = true;
            this.re_load.Click += new System.EventHandler(this.re_load_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(369, 351);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(52, 13);
            this.Total.TabIndex = 22;
            this.Total.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tổng Tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Số tiền trả";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Còn";
            // 
            // thua_no
            // 
            this.thua_no.AutoSize = true;
            this.thua_no.Location = new System.Drawing.Point(369, 411);
            this.thua_no.Name = "thua_no";
            this.thua_no.Size = new System.Drawing.Size(41, 13);
            this.thua_no.TabIndex = 27;
            this.thua_no.Text = "label11";
            // 
            // PhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(520, 433);
            this.Controls.Add(this.thua_no);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.re_load);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DaiLy_combo);
            this.Controls.Add(this.HD_Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NgayLapPhieu);
            this.Controls.Add(this.TenDaiLy);
            this.Controls.Add(this.ID_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PXH_datagrid);
            this.Name = "PhieuXuatHang";
            this.Text = "PhieuXuatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PhieuXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PXH_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PXH_datagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ID_list;
        private System.Windows.Forms.Label TenDaiLy;
        private System.Windows.Forms.Label NgayLapPhieu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HD_Add;
        private System.Windows.Forms.ComboBox DaiLy_combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button re_load;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label thua_no;
    }
}