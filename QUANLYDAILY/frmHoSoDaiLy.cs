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
    public partial class frmHoSoDaiLy : Form
    {
        //public delegate void SendMessage(string Message);
        //public SendMessage Sender;
        public frmHoSoDaiLy()
        {
            InitializeComponent();
           // Tao con tro toi ham GetMessage
         //   Sender = new SendMessage(GetMessage);
        }
        //static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\QUANLYDAILY.mdf;Integrated Security=True;Connect Timeout=30";
        //static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Anh Khoa\\Documents\\Visual Studio 2015\\Projects\\QUANLYDAILY\\QUANLYDAILY\\QUANLYDAILY.mdf\";Integrated Security=True;Connect Timeout=30";
        //SqlConnection conn = new SqlConnection(connString);
        //static SqlDataAdapter da;
        SQL _DB = new SQL();
        int temprow;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string loai = comboBox1.SelectedItem.ToString();
            string ngay = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                _DB.conn.Open();
                string sql =
                    "insert into HoSoDaiLy(Id,Ten,DienThoai,DiaChi,LoaiDaiLy,NgayTiepNhan) values(" + ID.Text + ",'" + Ten.Text + "','" + Phone.Text + "','" + Address.Text + "','" + loai + "','" + ngay + "')";
                _DB.Excute(sql);
                MessageBox.Show("work");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string sql = "select * from HoSoDaiLy";
                _DB.Excute(sql);
                datagrid_HSDL.DataSource = _DB.ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
            _DB.conn.Close();
        }

        private void frmHoSoDaiLy_Load(object sender, EventArgs e)
        {
            _DB.Connect();
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                _DB.conn.Open();
                string sql = "select * from HoSoDaiLy";
                _DB.Excute(sql);
                datagrid_HSDL.DataSource = _DB.ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
            _DB.conn.Close();
            temprow = datagrid_HSDL.Rows.Count;
        }

        private void fix_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                _DB.conn.Open();
                
                for (int i = 0; i < datagrid_HSDL.Rows.Count - 1; i++)
                {
                    sql = "update HoSoDaiLy set Ten = N'" + datagrid_HSDL.Rows[i].Cells["Ten"].Value + "',DienThoai = '" + datagrid_HSDL.Rows[i].Cells["DienThoai"].Value + "',DiaChi = '" + datagrid_HSDL.Rows[i].Cells["DiaChi"].Value + "',LoaiDaiLy ='" + datagrid_HSDL.Rows[i].Cells["LoaiDaiLy"] .Value + "',NgayTiepNhan ='" + datagrid_HSDL.Rows[i].Cells["NgayTiepNhan"].Value + "' where Id =" + datagrid_HSDL.Rows[i].Cells["Id"].Value;
                    _DB.Excute(sql);
                }
                MessageBox.Show("work");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                sql = "select * from HoSoDaiLy";
                _DB.Excute(sql);
                datagrid_HSDL.DataSource = _DB.ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
            _DB.conn.Close();
            temprow = datagrid_HSDL.Rows.Count;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_DB.conn.State != ConnectionState.Open)
                _DB.conn.Open();
                string sql =
                    "delete from HoSoDaiLy where Id ='" + datagrid_HSDL.CurrentRow.Cells["Id"].Value +"'";
                _DB.Excute(sql);
                MessageBox.Show("work");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string sql = "select * from HoSoDaiLy";
                _DB.Excute(sql);
                datagrid_HSDL.DataSource = _DB.ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (_DB.conn.State != ConnectionState.Closed)
            _DB.conn.Close();
            temprow = datagrid_HSDL.Rows.Count;
        }

        private void datagrid_HSDL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void datagrid_HSDL_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            temprow = datagrid_HSDL.Rows.Count;
        }
    }
}
