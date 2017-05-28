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
    public partial class frmQuiDinh : Form
    {
        public frmQuiDinh()
        {
            InitializeComponent();
        }
        SQL _DB = new SQL();
        string sql;

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
                sql = "update QuiDinh1 set SoLuong = " + SL_loai.Text + "where Id = 'LoaiDL'";
                _DB.Excute(sql);
                sql = "update QuiDinh1 set SoLuong = " + SL_toida.Text + "where Id = 'SoDL'";
                _DB.Excute(sql);
                sql = "update QuiDinh1 set SoLuong = " + SL_mathang.Text + "where Id = 'SoMatHang'";
                _DB.Excute(sql);
                sql = "update QuiDinh1 set SoLuong = " + SL_donvi.Text + "where Id = 'SoDonVi'";
                _DB.Excute(sql);
                MessageBox.Show("Thành Công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void frmQuiDinh_Load(object sender, EventArgs e)
        {
            try
            {
                _DB.Connect();
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
                sql = "select * from Quidinh1";
                _DB.Excute(sql);
                SL_loai.Text = _DB.kq.Rows[0][1].ToString();
                SL_toida.Text = _DB.kq.Rows[1][1].ToString();
                SL_mathang.Text = _DB.kq.Rows[3][1].ToString();
                SL_donvi.Text = _DB.kq.Rows[2][1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }
    }
}
