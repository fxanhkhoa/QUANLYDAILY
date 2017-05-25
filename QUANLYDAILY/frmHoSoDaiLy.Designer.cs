namespace QUANLYDAILY
{
    partial class frmHoSoDaiLy
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
            this.Ten = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Dicstrict = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.datagrid_HSDL = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fix = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_HSDL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỒ SƠ ĐẠI LÝ";
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(114, 50);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(100, 20);
            this.Ten.TabIndex = 1;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(114, 85);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(100, 20);
            this.Phone.TabIndex = 2;
            // 
            // Dicstrict
            // 
            this.Dicstrict.Location = new System.Drawing.Point(114, 122);
            this.Dicstrict.Name = "Dicstrict";
            this.Dicstrict.Size = new System.Drawing.Size(100, 20);
            this.Dicstrict.TabIndex = 3;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(331, 85);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 20);
            this.Address.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Loại Đại Lý";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày tiếp nhận";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(66, 187);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 13;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(259, 187);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // datagrid_HSDL
            // 
            this.datagrid_HSDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_HSDL.Location = new System.Drawing.Point(12, 216);
            this.datagrid_HSDL.Name = "datagrid_HSDL";
            this.datagrid_HSDL.Size = new System.Drawing.Size(496, 137);
            this.datagrid_HSDL.TabIndex = 16;
            this.datagrid_HSDL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_HSDL_CellContentClick);
            this.datagrid_HSDL.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.datagrid_HSDL_RowsAdded);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(331, 122);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // fix
            // 
            this.fix.Location = new System.Drawing.Point(163, 187);
            this.fix.Name = "fix";
            this.fix.Size = new System.Drawing.Size(75, 23);
            this.fix.TabIndex = 20;
            this.fix.Text = "Sửa";
            this.fix.UseVisualStyleBackColor = true;
            this.fix.Click += new System.EventHandler(this.fix_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(331, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // frmHoSoDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(520, 354);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fix);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.datagrid_HSDL);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Dicstrict);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.label1);
            this.Name = "frmHoSoDaiLy";
            this.Text = "frmHoSoDaiLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHoSoDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_HSDL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ten;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Dicstrict;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView datagrid_HSDL;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button fix;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}