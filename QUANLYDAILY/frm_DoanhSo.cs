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
    public partial class frm_DoanhSo : Form
    {
        public frm_DoanhSo()
        {
            InitializeComponent();
        }
        SQL _DB = new SQL();
        int temprow;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reload_Click(object sender, EventArgs e)
        {
            frm_reload();
            /* Put month to combobox */
            string sql;
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();
            sql = "select DISTINCT Thang from DoanhSo";
            _DB.Excute(sql);
            Month.DataSource = _DB.kq;
            Month.DisplayMember = "Thang";
            Month.ValueMember = "Thang";

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }
        private void frm_reload()
        {
            string sql;
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();

                sql = "select DISTINCT ID_DaiLy,MONTH(NgayLapPhieu) as Thang from HoaDon";
                _DB.Excute(sql);
                DataTable kq_temp = _DB.kq;

                for (int i = 0; i < kq_temp.Rows.Count; i++)
                {
                    sql = "select Thang,DaiLy from DoanhSo where Thang = " + kq_temp.Rows[i][1] + " and DaiLy ='" + kq_temp.Rows[i][0] + "'";
                    _DB.Excute(sql);
                    if (_DB.kq.Rows.Count == 0)
                    {
                        sql = "insert into DoanhSo(Thang,DaiLy) values(" + kq_temp.Rows[i][1] + ",'" + kq_temp.Rows[i][0] + "')";
                        _DB.Excute(sql);
                    }
                }


                sql = "select Thang,DaiLy from DoanhSo";
                _DB.Excute(sql);
                kq_temp = _DB.kq;

                for (int i = 0; i < kq_temp.Rows.Count; i++)
                {
                    /* update SoPhieuXuat  */
                    sql = "select COUNT(Id) from HoaDon where MONTH(NgayLapPhieu) = " + kq_temp.Rows[i][0] + " and ID_DaiLy = '" + kq_temp.Rows[i][1] + "'";
                    _DB.Excute(sql);
                    sql = "update DoanhSo set SoPhieuXuat = " + _DB.kq.Rows[0][0] + " where Thang = " + kq_temp.Rows[i][0] + " and DaiLy = '" + kq_temp.Rows[i][1] + "'";
                    _DB.Excute(sql);

                    /* update TongTriGia */
                    sql = "select SUM(TongTien) from HoaDon where MONTH(NgayLapPhieu) = " + kq_temp.Rows[i][0] + " and ID_DaiLy = '" + kq_temp.Rows[i][1] + "'";
                    _DB.Excute(sql);
                    sql = "update DoanhSo set TongTriGia = " + _DB.kq.Rows[0][0] + " where Thang = " + kq_temp.Rows[i][0] + " and DaiLy = '" + kq_temp.Rows[i][1] + "'";
                    _DB.Excute(sql);
                }


                /* Put to datagrid */
                sql = "select * from DoanhSo where Thang =" + Month.GetItemText(Month.SelectedItem);
                _DB.Excute(sql);
                Datagrid_DoanhSo.DataSource = _DB.ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void frm_DoanhSo_Load(object sender, EventArgs e)
        {
            string sql;
            _DB.Connect();
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();

                sql = "select DISTINCT ID_DaiLy,MONTH(NgayLapPhieu) as Thang from HoaDon";
                _DB.Excute(sql);
                DataTable kq_temp = _DB.kq;

                for (int i = 0; i < kq_temp.Rows.Count; i ++)
                {
                    sql = "select Thang,DaiLy from DoanhSo where Thang = " + kq_temp.Rows[i][1] + " and DaiLy ='" + kq_temp.Rows[i][0] +"'";
                    _DB.Excute(sql);
                    if (_DB.kq.Rows.Count == 0)
                    {
                        sql = "insert into DoanhSo(Thang,DaiLy) values(" + kq_temp.Rows[i][1] + ",'" + kq_temp.Rows[i][0] + "')";
                        _DB.Excute(sql);
                    }
                }

                
                sql = "select Thang,DaiLy from DoanhSo";
                _DB.Excute(sql);
                kq_temp = _DB.kq;

                for (int i = 0; i < kq_temp.Rows.Count; i++)
                {
                    /* update SoPhieuXuat  */
                    sql = "select COUNT(Id) from HoaDon where MONTH(NgayLapPhieu) = "+ kq_temp.Rows[i][0] + " and ID_DaiLy = '"+ kq_temp.Rows[i][1] + "'";
                    _DB.Excute(sql);
                    sql = "update DoanhSo set SoPhieuXuat = " + _DB.kq.Rows[0][0] + " where Thang = " + kq_temp.Rows[i][0] + " and DaiLy = '" + kq_temp.Rows[i][1] + "'";
                    _DB.Excute(sql);

                    /* update TongTriGia */
                    sql = "select SUM(TongTien) from HoaDon where MONTH(NgayLapPhieu) = " + kq_temp.Rows[i][0] + " and ID_DaiLy = '" + kq_temp.Rows[i][1] + "'";
                    _DB.Excute(sql);
                    sql = "update DoanhSo set TongTriGia = " + _DB.kq.Rows[0][0] + " where Thang = " + kq_temp.Rows[i][0] + " and DaiLy = '" + kq_temp.Rows[i][1] + "'";
                    _DB.Excute(sql);
                }

                /* Put month to combobox */
                sql = "select DISTINCT Thang from DoanhSo";
                _DB.Excute(sql);
                Month.DataSource = _DB.kq;
                Month.DisplayMember = "Thang";
                Month.ValueMember = "Thang";

                /* Put to datagrid */
                sql = "select * from DoanhSo where Thang =" + Month.GetItemText(Month.SelectedItem);
                _DB.Excute(sql);
                Datagrid_DoanhSo.DataSource = _DB.ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            frm_reload();
        }
    }
}
