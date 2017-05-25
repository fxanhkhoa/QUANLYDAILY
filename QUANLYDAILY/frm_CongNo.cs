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
    public partial class frm_CongNo : Form
    {
        public frm_CongNo()
        {
            InitializeComponent();
        }
        SQL _DB = new SQL();
        int temprow;

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            frm_reload();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            frm_reload();
            //Show Combobox
            /* Put month to combobox */
            string sql;
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();
            sql = "select DISTINCT Thang from CongNo";
            _DB.Excute(sql);
            month.DataSource = _DB.kq;
            month.DisplayMember = "Thang";
            month.ValueMember = "Thang";
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void frm_CongNo_Load(object sender, EventArgs e)
        {
            string sql;
            _DB.Connect();
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();

                // update Thang, DaiLy to CongNo
                sql = "select DISTINCT ID_DaiLy,MONTH(NgayLapPhieu) as Thang from HoaDon";
                _DB.Excute(sql);
                DataTable kq_temp = _DB.kq;

                for (int i = 0; i < kq_temp.Rows.Count; i++)
                {
                    sql = "select Thang,DaiLy from CongNo where Thang = " + kq_temp.Rows[i][1] + " and DaiLy ='" + kq_temp.Rows[i][0] + "'";
                    _DB.Excute(sql);
                    if (_DB.kq.Rows.Count == 0)
                    {
                        sql = "insert into CongNo(Thang,DaiLy,PhatSinh) values(" + kq_temp.Rows[i][1] + ",'" + kq_temp.Rows[i][0] + "', 0)";
                        _DB.Excute(sql);
                    }
                }

                //update No Dau
                sql = "select Thang,DaiLy from CongNo";
                _DB.Excute(sql);
                kq_temp = _DB.kq;

                for (int i = 0; i < kq_temp.Rows.Count; i++)
                {
                    sql = "select SUM(DISTINCT No) from HangXuat where ID_DaiLy = '" + kq_temp.Rows[i][1] + "' and  ID_HoaDon in (select ID_HoaDon from HoaDon where MONTH(NgayLapPhieu) = "+ kq_temp.Rows[i][0] +")";
                    _DB.Excute(sql);
                    
                    if (_DB.kq.Rows[0][0] != DBNull.Value)
                    {
                        DataTable kq_new = _DB.kq;

                        sql = "select PhatSinh from CongNo where Thang = " + kq_temp.Rows[i][0] + " and DaiLy = '" + kq_temp.Rows[i][1] + "'";
                        _DB.Excute(sql);

                        string NoCuoi = (Convert.ToInt16(kq_new.Rows[0][0]) - Convert.ToInt16(_DB.kq.Rows[0][0])).ToString();

                        sql = "update CongNo set NoDau = " + kq_new.Rows[0][0] + " , NoCuoi = " + NoCuoi + " where Thang = " + kq_temp.Rows[i][0] + " and DaiLy = '" + kq_temp.Rows[i][1] + "'";
                        _DB.Excute(sql);
                    }
                }

                //Show Combobox
                /* Put month to combobox */
                _DB.kq.Clear();

                sql = "select DISTINCT Thang from CongNo";
                _DB.Excute(sql);
                month.DataSource = _DB.kq;
                month.DisplayMember = "Thang";
                month.ValueMember = "Thang";

                // Show Data
                sql = "select DaiLy,NoDau,PhatSinh,NoCuoi from CongNo where Thang = " + month.GetItemText(month.SelectedItem);
                _DB.Excute(sql);
                CongNo_Datagrid.DataSource = _DB.ds.Tables[0];

                //disable fields
                CongNo_Datagrid.Columns["DaiLy"].ReadOnly = true;
                CongNo_Datagrid.Columns["DaiLy"].DefaultCellStyle.BackColor = Color.Gray;
                CongNo_Datagrid.Columns["NoCuoi"].ReadOnly = true;
                CongNo_Datagrid.Columns["NoCuoi"].DefaultCellStyle.BackColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                // update Thang, DaiLy to CongNo
                sql = "select DISTINCT ID_DaiLy,MONTH(NgayLapPhieu) as Thang from HoaDon";
                _DB.Excute(sql);
                DataTable kq_temp = _DB.kq;

                for (int i = 0; i < kq_temp.Rows.Count; i++)
                {
                    sql = "select Thang,DaiLy from CongNo where Thang = " + kq_temp.Rows[i][1] + " and DaiLy ='" + kq_temp.Rows[i][0] + "'";
                    _DB.Excute(sql);
                    if (_DB.kq.Rows.Count == 0)
                    {
                        sql = "insert into CongNo(Thang,DaiLy,PhatSinh) values(" + kq_temp.Rows[i][1] + ",'" + kq_temp.Rows[i][0] + "', 0)";
                        _DB.Excute(sql);
                    }
                }

                //update No Dau
                sql = "select Thang,DaiLy from CongNo";
                _DB.Excute(sql);
                kq_temp = _DB.kq;

                for (int i = 0; i < kq_temp.Rows.Count; i++)
                {
                    sql = "select SUM(DISTINCT No) from HangXuat where ID_DaiLy = '" + kq_temp.Rows[i][1] + "' and  ID_HoaDon in (select ID_HoaDon from HoaDon where MONTH(NgayLapPhieu) = " + kq_temp.Rows[i][0] + ")";
                    _DB.Excute(sql);

                    if (_DB.kq.Rows[0][0] != DBNull.Value)
                    {
                        DataTable kq_new = _DB.kq;

                        sql = "select PhatSinh from CongNo where Thang = " + kq_temp.Rows[i][0] + " and DaiLy = '" + kq_temp.Rows[i][1] + "'";
                        _DB.Excute(sql);

                        string NoCuoi = (Convert.ToInt16(kq_new.Rows[0][0]) - Convert.ToInt16(_DB.kq.Rows[0][0])).ToString();

                        sql = "update CongNo set NoDau = " + kq_new.Rows[0][0] + " , NoCuoi = " + NoCuoi + " where Thang = " + kq_temp.Rows[i][0] + " and DaiLy = '" + kq_temp.Rows[i][1] + "'";
                        _DB.Excute(sql);
                    }
                }

                // Show Data
                sql = "select DaiLy,NoDau,PhatSinh,NoCuoi from CongNo where Thang = " + month.GetItemText(month.SelectedItem);
                _DB.Excute(sql);
                CongNo_Datagrid.DataSource = _DB.ds.Tables[0];

                //disable fields
                CongNo_Datagrid.Columns["DaiLy"].ReadOnly = true;
                CongNo_Datagrid.Columns["DaiLy"].DefaultCellStyle.BackColor = Color.Gray;
                CongNo_Datagrid.Columns["NoCuoi"].ReadOnly = true;
                CongNo_Datagrid.Columns["NoCuoi"].DefaultCellStyle.BackColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
                for (int i = 0; i < CongNo_Datagrid.Rows.Count - 1; i++)
                {
                    sql = "update CongNo set PhatSinh = " + CongNo_Datagrid.Rows[i].Cells["PhatSinh"].Value + " where Thang = " + month.GetItemText(month.SelectedItem);
                    _DB.Excute(sql);
                }
                frm_reload();
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
