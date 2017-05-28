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
using System.IO;

namespace QUANLYDAILY
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frmHoSoDaiLy HS ;
        PhieuXuatHang PXH ;
        frm_DSDaiLy DS;
        frm_PhieuThuTIen ptt;
        frm_DoanhSo DoS;
        frm_CongNo CN;
        frmQuiDinh QD;
        //static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\QUANLYDAILY.mdf;Integrated Security=True;Connect Timeout=30";
        //SqlConnection conn = new SqlConnection(connString);
        private void frmMain_Load(object sender, EventArgs e)
        {
            PXH_radio.Checked = false;
            HS_radio.Checked = false;
            DoanhSo_radio.Checked = false;
            radio_QD.Checked = false;

            HS_radio.Enabled = false;
            PXH_radio.Enabled = false;
            DS_DaiLy.Enabled = false;
            Phieuthu.Enabled = false;
            DoanhSo_radio.Enabled = false;
            CongNo_radio.Enabled = false;
            radio_QD.Enabled = false;

            try
            {
                //string path = Directory.GetCurrentDirectory();
                //MessageBox.Show("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\" " + path + "\\QUANLIDAILY.mdf \";Integrated Security=True;Connect Timeout=30");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //if (conn.State == System.Data.ConnectionState.Open)
            {
            //    MessageBox.Show("Connect successfully!");
            }
            //else
            {
             //   MessageBox.Show("Connect failed!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            /* disable all other button*/
            //PXH_radio.Checked = false;


            //HS_radio.Checked = true;
            HS = new frmHoSoDaiLy();
            HS.MdiParent = this;
            if (Application.OpenForms.OfType<PhieuXuatHang>().Any())
            {
                PXH.Hide();
            }
            HS.Show();
        }

        private void PXH_radio_CheckedChanged(object sender, EventArgs e)
        {
            //PXH_radio.Checked = true;
            //HS_radio.Checked = false;
            PXH = new PhieuXuatHang();
            PXH.MdiParent = this;
            if (Application.OpenForms.OfType<frmHoSoDaiLy>().Any())  HS.Hide();
            PXH.Show();
        }

        private void DS_DaiLy_CheckedChanged(object sender, EventArgs e)
        {
            DS = new frm_DSDaiLy();
            DS.MdiParent = this;
            DS.Show();
        }

        private void Phieuthu_CheckedChanged(object sender, EventArgs e)
        {
            ptt = new frm_PhieuThuTIen();
            ptt.MdiParent = this;
            ptt.Show();
        }

        private void DoanhSo_radio_CheckedChanged(object sender, EventArgs e)
        {
            DoS = new frm_DoanhSo();
            DoS.MdiParent = this;
            DoS.Show();
        }

        private void CongNo_radio_CheckedChanged(object sender, EventArgs e)
        {
            CN = new frm_CongNo();
            CN.MdiParent = this;
            CN.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (user.Text == "user")
                if (pass.Text == "user")
                {
                    HS_radio.Enabled = true;
                    PXH_radio.Enabled = true;
                    DS_DaiLy.Enabled = true;
                    Phieuthu.Enabled = true;
                    DoanhSo_radio.Enabled = true;
                    CongNo_radio.Enabled = true;
                    radio_QD.Enabled = true;
                    MessageBox.Show("Thành Công!");

                    label1.Visible = false;
                    label2.Visible = false;
                    user.Visible = false;
                    pass.Visible = false;
                    login.Visible = false;
                    Reset.Visible = false;
                }
            else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập!");
                }
        }

        private void radio_QD_CheckedChanged(object sender, EventArgs e)
        {
            QD = new frmQuiDinh();
            QD.MdiParent = this;
            QD.Show();
        }
    }
}
