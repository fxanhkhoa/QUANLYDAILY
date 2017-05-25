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
    public partial class frm_DSDaiLy : Form
    {
        public frm_DSDaiLy()
        {
            InitializeComponent();
        }
        SQL _DB = new SQL();

        private void frm_DSDaiLy_Load(object sender, EventArgs e)
        {
            string sql;
            _DB.Connect();
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
                sql = "select Id,Ten,LoaiDaiLy,DiaChi,No from HoSoDaiLy";
                _DB.Excute(sql);
                DS_DL_datagrid.DataSource = _DB.ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void reload()
        {
            string sql;
            _DB.Connect();
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
                sql = "select Id,Ten,LoaiDaiLy,DiaChi,No from HoSoDaiLy";
                _DB.Excute(sql);
                DS_DL_datagrid.DataSource = _DB.ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
                sql = "select ID_DaiLy,SUM(No) from HangXuat group by ID_DaiLy";
                _DB.Excute(sql);
                DataTable kq_temp = new DataTable();
                kq_temp = _DB.kq;
                int temp_count = _DB.kq.Rows.Count;
                for (int i = 0; i < temp_count; i++)
                {
                    sql = "update HoSoDaiLy set No=" + kq_temp.Rows[i][1] + "where Id ='"+ kq_temp.Rows[i][0]+"'";
                    _DB.Excute(sql);
                }
                MessageBox.Show("Update thành công!");
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
