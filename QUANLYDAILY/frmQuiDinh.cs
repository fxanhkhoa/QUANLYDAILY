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
                sql = "update QuiDinh1 set ";
                MessageBox.Show("Thành Công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmQuiDinh_Load(object sender, EventArgs e)
        {
            try
            {
                _DB.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
