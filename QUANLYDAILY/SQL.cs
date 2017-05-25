using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QUANLYDAILY
{
    public class SQL
    {
        public string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Anh Khoa\\Documents\\Visual Studio 2015\\Projects\\QUANLYDAILY\\QUANLYDAILY\\QUANLYDAILY.mdf\";Integrated Security=True;Connect Timeout=30";
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable kq;
        public DataSet ds;

        public void Connect()
        {
            conn = new SqlConnection(conn_string);
        }
        public void Open()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Close()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Excute(string sql)
        {

            try {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.CommandType = CommandType.Text;
                da = new SqlDataAdapter(cmd);
                kq = new DataTable();
                ds = new DataSet();
                da.Fill(kq);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
