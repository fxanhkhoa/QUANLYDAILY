using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYDAILY
{
    public partial class PhieuXuatHang : Form
    {
        public PhieuXuatHang()
        {
            InitializeComponent();
        }
        //static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Anh Khoa\\Documents\\Visual Studio 2015\\Projects\\QUANLYDAILY\\QUANLYDAILY\\QUANLYDAILY.mdf\";Integrated Security=True;Connect Timeout=30";
        //SqlConnection conn = new SqlConnection(connString);
        int temprow, addornot = 0;
        SQL _DB = new SQL();

        private void PhieuXuatHang_Load(object sender, EventArgs e)
        {
            //textBox1.Text = "select DISTINCT STT,MatHang,DonViTinh,SoLuong,DonGia,ThanhTien from PhieuXuatHang where ID = 'A001' and STT != 0";
            //SQL _DB = new SQL();
            
            _DB.Connect();
            try
            {
                _DB.Open();
                string sql = "select DISTINCT Id from HoaDon";
                _DB.Excute(sql);
                ID_list.DataSource = _DB.kq;
                ID_list.DisplayMember = "Id";
                ID_list.ValueMember = "Id";

                string temp = ID_list.GetItemText(ID_list.SelectedItem);
                if (_DB.conn.State == ConnectionState.Closed)
                    _DB.Open();

                //sql = "select DISTINCT STT,MatHang,DonViTinh,SoLuong,DonGia,ThanhTien from PhieuXuatHang where ID = '" + temp + "' and STT != 0";
                sql = "select STT,ID_MatHang,DonViTinh,SoLuong,ThanhTien from HangXuat,MatHang where ID_HoaDon ='" + temp + "' and ID_MatHang = Id order by STT ASC";
                _DB.Excute(sql);
                PXH_datagrid.DataSource = _DB.ds.Tables[0];
                //PXH_datagrid.Columns["ID_MatHang"].ReadOnly = true;
                //PXH_datagrid.Columns["ID_MatHang"].DefaultCellStyle.BackColor = Color.Gray;


                sql = "select ID_DaiLy from HoaDon where Id ='" + temp + "'";
                _DB.Excute(sql);
                TenDaiLy.Text =  _DB.kq.Rows[0][0].ToString();

                sql = "select NgayLapPhieu from HoaDon where Id ='" + temp + "'";
                _DB.Excute(sql);
                NgayLapPhieu.Text = _DB.kq.Rows[0][0].ToString();

                sql = "select Id from HoSoDaiLy";
                _DB.Excute(sql);
                DaiLy_combo.DataSource = _DB.kq;
                DaiLy_combo.DisplayMember = "Id";
                DaiLy_combo.ValueMember = "Id";

                sql = "select SUM(ThanhTien) from HangXuat where ID_HoaDon ='" + ID_list.GetItemText(ID_list.SelectedItem) + "'";
                _DB.Excute(sql);
                Total.Text = _DB.kq.Rows[0][0].ToString();

                // update tong tien
                sql = "update HoaDon set TongTien =" + _DB.kq.Rows[0][0] + " where Id ='" + ID_list.GetItemText(ID_list.SelectedItem) + "'";
                _DB.Excute(sql);
                //

                sql = "select No from HangXuat where ID_HoaDon ='" + ID_list.GetItemText(ID_list.SelectedItem) + "'";
                _DB.Excute(sql);
                thua_no.Text = _DB.kq.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            temprow = PXH_datagrid.Rows.Count;
            //textBox1.Text = temprow.ToString();
            _DB.Close();
        }
        void reload()
        {
            //SQL _DB1 = new SQL();
            //_DB1.Connect();
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();
                string sql = "select DISTINCT Id from HoaDon";
                _DB.Excute(sql);
                ID_list.DataSource = _DB.kq;
                ID_list.DisplayMember = "ID";
                ID_list.ValueMember = "ID";

                string temp = ID_list.GetItemText(ID_list.SelectedItem);

                if (_DB.conn.State == ConnectionState.Closed)
                _DB.Open();
                sql = "select STT,ID_MatHang,DonViTinh,SoLuong,ThanhTien from HangXuat,MatHang where ID_HoaDon ='" + temp + "' and ID_MatHang = Id order by STT ASC";
                _DB.Excute(sql);
                PXH_datagrid.DataSource = _DB.ds.Tables[0];
                //PXH_datagrid.Columns["ID_MatHang"].ReadOnly = true;
                //PXH_datagrid.Columns["ID_MatHang"].DefaultCellStyle.BackColor = Color.Gray;


                sql = "select ID_DaiLy from HoaDon where Id ='" + temp + "'";
                _DB.Excute(sql);
                TenDaiLy.Text = _DB.kq.Rows[0][0].ToString();

                sql = "select NgayLapPhieu from HoaDon where Id ='" + temp + "'";
                _DB.Excute(sql);
                NgayLapPhieu.Text = _DB.kq.Rows[0][0].ToString();

                sql = "select SUM(ThanhTien) from HangXuat where ID_HoaDon ='" + ID_list.GetItemText(ID_list.SelectedItem) + "'";
                _DB.Excute(sql);
                Total.Text = _DB.kq.Rows[0][0].ToString();

                // update tong tien
                sql = "update HoaDon set TongTien =" + _DB.kq.Rows[0][0] + " where Id ='" + ID_list.GetItemText(ID_list.SelectedItem) + "'";
                _DB.Excute(sql);
                //

                sql = "select No from HangXuat where ID_HoaDon ='" + ID_list.GetItemText(ID_list.SelectedItem) + "'";
                _DB.Excute(sql);
                thua_no.Text = _DB.kq.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
            _DB.Close();
            temprow = PXH_datagrid.Rows.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i = 1;
            //textBox1.Text = "insert into PhieuXuatHang(ID,MatHang,DonViTinh,SoLuong,DonGia,ThanhTien,DaiLy,NgayLapPhieu,STT) values('" + ID_list.GetItemText(ID_list.SelectedItem) + "','" + PXH_datagrid.Rows[i].Cells["MatHang"].Value + "','" + PXH_datagrid.Rows[i].Cells["DonViTinh"].Value + "'," + PXH_datagrid.Rows[i].Cells["SoLuong"].Value + "," + PXH_datagrid.Rows[i].Cells["DonGia"].Value + "," + PXH_datagrid.Rows[i].Cells["ThanhTien"].Value + ",'" + TenDaiLy.Text + "','" + NgayLapPhieu.Text + "'," + PXH_datagrid.Rows[i].Cells["STT"].Value + ")";
            string sql;
            try
            {
                //if (addornot == 1)
                {
                    if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
                    if (temprow == 2) temprow = 1;
                    for (int i = temprow - 1; i < PXH_datagrid.Rows.Count - 1; i++)
                    {
                        //sql = "insert into PhieuXuatHang(ID,MatHang,DonViTinh,SoLuong,DonGia,ThanhTien,DaiLy,NgayLapPhieu,STT) values('" + ID_list.GetItemText(ID_list.SelectedItem) + "','" + PXH_datagrid.Rows[i].Cells["MatHang"].Value + "','" + PXH_datagrid.Rows[i].Cells["DonViTinh"].Value + "'," + PXH_datagrid.Rows[i].Cells["SoLuong"].Value + "," + PXH_datagrid.Rows[i].Cells["DonGia"].Value + "," + PXH_datagrid.Rows[i].Cells["ThanhTien"].Value + ",'" + TenDaiLy.Text + "','" + NgayLapPhieu.Text + "'," + PXH_datagrid.Rows[i].Cells["STT"].Value + ")";
                        sql = "insert into HangXuat(ID_MatHang,SoLuong,ThanhTien,ID_HoaDon,STT) values('" + PXH_datagrid.Rows[i].Cells["ID_MatHang"].Value + "'," + PXH_datagrid.Rows[i].Cells["SoLuong"].Value + "," + PXH_datagrid.Rows[i].Cells["ThanhTien"].Value + ",'" + ID_list.GetItemText(ID_list.SelectedItem) + "'," + PXH_datagrid.Rows[i].Cells["STT"].Value + ")";
                        _DB.Excute(sql);
                    }
                    MessageBox.Show("Thành Công");
                    //int j = temprow - 1;
                    //textBox2.Text = "insert into PhieuXuatHang(ID,MatHang,DonViTinh,SoLuong,DonGia,ThanhTien,DaiLy,NgayLapPhieu,STT) values('" + ID_list.GetItemText(ID_list.SelectedItem) + "','" + PXH_datagrid.Rows[j].Cells["MatHang"].Value + "','" + PXH_datagrid.Rows[j].Cells["DonViTinh"].Value + "'," + PXH_datagrid.Rows[j].Cells["SoLuong"].Value + "," + PXH_datagrid.Rows[j].Cells["DonGia"].Value + "," + PXH_datagrid.Rows[j].Cells["ThanhTien"].Value + ",'" + TenDaiLy.Text + "','" + NgayLapPhieu.Text + "'," + PXH_datagrid.Rows[j].Cells["STT"].Value + ")";
                }
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Close();
                //addornot = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
            _DB.Close();

            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            //if (_DB.conn.State == ConnectionState.Open) return;
            try
            {
                //if (addornot == 1)
                {
                    _DB.Open();
                    for (int i = 0; i < PXH_datagrid.Rows.Count - 1; i++)
                    {
                        sql =
                        "update HangXuat set SoLuong =" + PXH_datagrid.Rows[i].Cells["SoLuong"].Value + ", ThanhTien=" + PXH_datagrid.Rows[i].Cells["ThanhTien"].Value + ", STT= " + PXH_datagrid.Rows[i].Cells["STT"].Value + " where ID_HoaDon ='" + ID_list.GetItemText(ID_list.SelectedItem) + "' and ID_MatHang ='" + PXH_datagrid.Rows[i].Cells["ID_MatHang"].Value +"'";
                        _DB.Excute(sql);
                    }
                    MessageBox.Show("Thành Công");
                    //int j = temprow - 1;
                    //textBox2.Text = "update HangXuat,MatHang set ID_MatHang = '" + PXH_datagrid.Rows[j].Cells["ID_MatHang"].Value + "', DonViTinh = '" + PXH_datagrid.Rows[j].Cells["DonViTinh"].Value + "', SoLuong =" + PXH_datagrid.Rows[j].Cells["SoLuong"].Value + ", ThanhTien=" + PXH_datagrid.Rows[j].Cells["ThanhTien"].Value + ", STT= " + PXH_datagrid.Rows[j].Cells["STT"].Value + "where ID_HoaDon ='" + ID_list.GetItemText(ID_list.SelectedItem) + "'";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _DB.Close();
            reload();
         }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "insert into PhieuXuatHang(ID,MatHang,DonViTinh,SoLuong,DonGia,ThanhTien,DaiLy,NgayLapPhieu,STT) values('" + ID_list.GetItemText(ID_list.SelectedItem) + "','" + PXH_datagrid.Rows[i].Cells["MatHang"].Value + "','" + PXH_datagrid.Rows[i].Cells["DonViTinh"].Value + "'," + PXH_datagrid.Rows[i].Cells["SoLuong"].Value + "," + PXH_datagrid.Rows[i].Cells["DonGia"].Value + "," + PXH_datagrid.Rows[i].Cells["ThanhTien"].Value + ",'" + TenDaiLy.Text + "','" + NgayLapPhieu.Text + "'," + PXH_datagrid.Rows[i].Cells["STT"].Value + ")";
            //textBox2.Text = "delete from PhieuXuatHang where ID = '" + ID_list.GetItemText(ID_list.SelectedItem) + "'";
            string sql;
            //SQL _DB = new SQL();
            try
            {
                _DB.Open();
                sql = "delete from HangXuat where ID_MatHang = '" + PXH_datagrid.CurrentRow.Cells["ID_MatHang"].Value + "'";
                _DB.Excute(sql);
                MessageBox.Show("Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _DB.Close();
            reload();
        }

        private void ID_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox1.Text = ID_list.GetItemText(ID_list.SelectedItem);
            //textBox1.Text = PXH_datagrid.Rows.Count.ToString();
            if (_DB.conn.State == ConnectionState.Open) return;
            try
            {
                if (_DB.conn.State != ConnectionState.Open) _DB.Open();

                string sql;
                string temp = ID_list.GetItemText(ID_list.SelectedItem);

                //conn.Open();
                //sql = "select DISTINCT STT,MatHang,DonViTinh,SoLuong,DonGia,ThanhTien from PhieuXuatHang where ID = '" + temp + "' and STT != 0";
                sql = "select STT,ID_MatHang,DonViTinh,SoLuong,ThanhTien from HangXuat,MatHang where ID_HoaDon ='" + temp + "' and ID_MatHang = Id order by STT ASC";
                _DB.Excute(sql);
                PXH_datagrid.DataSource = _DB.ds.Tables[0];
                //PXH_datagrid.Columns["ID_MatHang"].ReadOnly = true;
                //PXH_datagrid.Columns["ID_MatHang"].DefaultCellStyle.BackColor = Color.Gray;

                sql = "select ID_DaiLy from HoaDon where Id ='" + temp + "'";
                _DB.Excute(sql);
                TenDaiLy.Text = _DB.kq.Rows[0][0].ToString();

                sql = "select NgayLapPhieu from HoaDon where Id ='" + temp + "'";
                _DB.Excute(sql);
                NgayLapPhieu.Text = _DB.kq.Rows[0][0].ToString();

                sql = "select SUM(ThanhTien) from HangXuat where ID_HoaDon ='" + ID_list.GetItemText(ID_list.SelectedItem) + "'" ;
                _DB.Excute(sql);
                Total.Text = _DB.kq.Rows[0][0].ToString();

                // update tong tien
                sql = "update HoaDon set TongTien =" + _DB.kq.Rows[0][0] + " where Id ='" + ID_list.GetItemText(ID_list.SelectedItem) + "'";
                _DB.Excute(sql);
                //

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //textBox1.Text = PXH_datagrid.Rows.Count.ToString();
            }
            temprow = PXH_datagrid.Rows.Count;
            if (_DB.conn.State != ConnectionState.Closed) _DB.Close();
        }

        private void ID_list_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql;
            string ngay = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            //SQL _DB = new SQL();
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();
                //sql = "select * from PhieuXuatHang where ID='" + HD_Add.Text + "'";
                //_DB.Excute(sql);
                //sql = "insert into PhieuXuatHang(ID,MatHang,DonViTinh,SoLuong,DonGia,ThanhTien,DaiLy,NgayLapPhieu,STT) values('"+ HD_Add.Text + "','x','Cai',0,0,0,'1','01/01/2001',0)";
                sql = "insert into Hoadon(Id,NgayLapPhieu,ID_DaiLy) values('" + HD_Add.Text + "','" + ngay + "','" + DaiLy_combo.GetItemText(DaiLy_combo.SelectedItem) + "')";
                _DB.Excute(sql);
                MessageBox.Show("Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
            _DB.Close();
            reload();
        }

        private void re_load_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                UInt16 tong = Convert.ToUInt16(Total.Text);
                UInt16 dua = Convert.ToUInt16(textBox1.Text);
                thua_no.Text = (dua - tong).ToString();
                if ((dua - tong) < 0)
                {
                    if (_DB.conn.State != ConnectionState.Open)
                        _DB.Open();
                    string sql = "update HangXuat set No =" + (dua - tong).ToString() + " where ID_HoaDon ='" + ID_list.GetItemText(ID_list.SelectedItem) + "'";
                    _DB.Excute(sql);
                    if (_DB.conn.State != ConnectionState.Closed)
                        _DB.Close();
                }
                else
                {
                    if (_DB.conn.State != ConnectionState.Open)
                        _DB.Open();
                    string sql = "update HangXuat set No = 0 where ID_HoaDon ='" + ID_list.GetItemText(ID_list.SelectedItem) + "'";
                    _DB.Excute(sql);
                    if (_DB.conn.State != ConnectionState.Closed)
                        _DB.Close();
                }
                reload();
            }
        }

        private void PXH_datagrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            addornot = 1;
            temprow = PXH_datagrid.Rows.Count;
        }
    }
}
