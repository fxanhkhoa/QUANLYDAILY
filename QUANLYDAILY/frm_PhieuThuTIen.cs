using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYDAILY
{
    public partial class frm_PhieuThuTIen : Form
    {
        public frm_PhieuThuTIen()
        {
            InitializeComponent();
        }
        SQL _DB = new SQL();
        int temprow;
       

        private void frm_PhieuThuTIen_Load(object sender, EventArgs e)
        {
            string sql;
            _DB.Connect();
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
                // Update No
                sql = "select ID_DaiLy,SUM(No) from HangXuat group by ID_DaiLy";
                _DB.Excute(sql);
                DataTable kq_temp = new DataTable();
                kq_temp = _DB.kq;
                int temp_count = _DB.kq.Rows.Count;
                for (int i = 0; i < temp_count; i++)
                {
                    sql = "update HoSoDaiLy set No=" + kq_temp.Rows[i][1] + "where Id ='" + kq_temp.Rows[i][0] + "'";
                    _DB.Excute(sql);
                }

          
                // Show data
                sql = "select ID_DaiLy,DiaChi,Email,DienThoai,NgayThuTien,No from PhieuThuTien,HoSoDaiLy where ID_DaiLy = Id";
                _DB.Excute(sql);
                PTT_datagrid.DataSource = _DB.ds.Tables[0];
                PTT_datagrid.Columns["No"].ReadOnly = true;
                PTT_datagrid.Columns["No"].DefaultCellStyle.BackColor = Color.Gray;
                PTT_datagrid.Columns["DiaChi"].ReadOnly = true;
                PTT_datagrid.Columns["DiaChi"].DefaultCellStyle.BackColor = Color.Gray;
                PTT_datagrid.Columns["DienThoai"].ReadOnly = true;
                PTT_datagrid.Columns["DienThoai"].DefaultCellStyle.BackColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
            temprow = PTT_datagrid.Rows.Count;
        }
        private void reload()
        {
            string sql;
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
                // Update No
                sql = "select ID_DaiLy,SUM(No) from HangXuat group by ID_DaiLy";
                _DB.Excute(sql);
                DataTable kq_temp = new DataTable();
                kq_temp = _DB.kq;
                int temp_count = _DB.kq.Rows.Count;
                for (int i = 0; i < temp_count; i++)
                {
                    sql = "update HoSoDaiLy set No=" + kq_temp.Rows[i][1] + "where Id ='" + kq_temp.Rows[i][0] + "'";
                    _DB.Excute(sql);
                }


                // Show data
                sql = "select ID_DaiLy,DiaChi,Email,DienThoai,NgayThuTien,No from PhieuThuTien,HoSoDaiLy where ID_DaiLy = Id";
                _DB.Excute(sql);
                PTT_datagrid.DataSource = _DB.ds.Tables[0];
                PTT_datagrid.Columns["No"].ReadOnly = true;
                PTT_datagrid.Columns["No"].DefaultCellStyle.BackColor = Color.Gray;
                PTT_datagrid.Columns["DiaChi"].ReadOnly = true;
                PTT_datagrid.Columns["DiaChi"].DefaultCellStyle.BackColor = Color.Gray;
                PTT_datagrid.Columns["DienThoai"].ReadOnly = true;
                PTT_datagrid.Columns["DienThoai"].DefaultCellStyle.BackColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
            temprow = PTT_datagrid.Rows.Count;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();

                if (temprow == 2) temprow = 1;
                for (int i = temprow - 1; i < PTT_datagrid.Rows.Count ; i++)
                {
                    sql = "insert into PhieuThuTien(Email,NgayThuTien,ID_DaiLy) values('"+PTT_datagrid.Rows[i].Cells["Email"].Value +"','"+ PTT_datagrid.Rows[i].Cells["NgayThuTien"].Value + "','" + PTT_datagrid.Rows[i].Cells["ID_DaiLy"].Value +"')";
                    _DB.Excute(sql);
                }
                MessageBox.Show("Thành Công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
            reload();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();
                sql = "delete from PhieuThuTien where ID_DaiLy='" + PTT_datagrid.CurrentRow.Cells["ID_DaiLy"].Value + "'";
                _DB.Excute(sql);
                MessageBox.Show("Thành Công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
            reload();
        }

        private void fix_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
                for (int i = 0; i < PTT_datagrid.Rows.Count - 1; i++)
                {
                    sql = "update PhieuThuTien set Email ='"+PTT_datagrid.Rows[i].Cells["Email"].Value + "', NgayThuTien ='" + PTT_datagrid.Rows[i].Cells["NgayThuTien"].Value + "' where ID_DaiLy ='" + PTT_datagrid.Rows[i].Cells["ID_DaiLy"].Value + "'";
                    _DB.Excute(sql);
                }
                MessageBox.Show("Thành Công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
            reload();
        }
    }
}
