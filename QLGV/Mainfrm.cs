using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }
        string laytaikhoan;
        string LayTenDangNhap = "", MatKhau = "", Quyen = "", TenThat = "";

        private void mntDangXuat_Click(object sender, EventArgs e)
        {
            
            DialogResult ldr = MessageBox.Show("Bạn thực sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ldr == DialogResult.OK)
            {
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
                this.Close();
            }
        }

        private void mntDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau(lb_taikhoan.Text);
            frm.Show();
        }

        private void mntQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mntKhoa_Click_1(object sender, EventArgs e)
        {
            frmKhoa frm = new frmKhoa();
            frm.Show();
        }

        private void mnthv_Click(object sender, EventArgs e)
        {
            frmHocVi frm = new frmHocVi();
            frm.Show();
        }
        private void mntdt_Click(object sender, EventArgs e)
        {
            frmDaoTao frm = new frmDaoTao();
            frm.Show();
        }

        private void mntGV_Click(object sender, EventArgs e)
        {
            frmGV frm = new frmGV();
            frm.Show();
        }

        private void mntG_Click(object sender, EventArgs e)
        {

        }

        private void mntMh_Click(object sender, EventArgs e)
        {
            frmMH frm = new frmMH();
            frm.Show();
        }

        private void mntHp_Click(object sender, EventArgs e)
        {
            frmHocKy frm = new frmHocKy();
            frm.Show();
        }

        private void mntTTGV_Click(object sender, EventArgs e)
        {
            frmTimkiem frm = new frmTimkiem();
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnthh_Click_1(object sender, EventArgs e)
        {
            frmHocHam frm = new frmHocHam();
            frm.Show();
        }

        private void mntMail_Click(object sender, EventArgs e)
        {
            Mail frm = new Mail();
            frm.Show();
        }

        private void mntTK_Click(object sender, EventArgs e)
        {
            thongkeGV frm = new thongkeGV();
            frm.Show();
        }

        private void mntPm_Click(object sender, EventArgs e)
        {
            Thongtin frm = new Thongtin();
            frm.Show();
        }

        private void mntTH_Click(object sender, EventArgs e)
        {
            TongHop frm = new TongHop();
            frm.Show();
        }

        private void mntGD_Click(object sender, EventArgs e)
        {
            TonghopGD frm = new TonghopGD();
            frm.Show();
        }

        private void mntDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
        }
        private void Mainfrm_Load(object sender, EventArgs e)
        {
            mntDangNhap.Enabled = true;
            mntQuanLyTaiKhoan.Enabled = false;
            mntDanhMuc.Enabled = false;
            mntDoiMatKhau.Enabled = false;
            mntDangXuat.Enabled = false;
            mntTimkiem.Enabled = false;
            mntThongke.Enabled = false;
            mntTrogiup.Enabled = true;
            

            if (Quyen == "admin")
            {
                MessageBox.Show("Xin chào " + lb_taikhoan.Text + " với quyền " + lb_quyen.Text + "", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mntDangNhap.Enabled = false;
                mntQuanLyTaiKhoan.Enabled = true;
                mntDoiMatKhau.Enabled = true;
                mntDanhMuc.Enabled = true;
                mntDangXuat.Enabled = true;
                mntTimkiem.Enabled = true;
                mntThongke.Enabled = true;
                mntTrogiup.Enabled = true;
                mntMail.Enabled = true;
            }
            else if (Quyen == "user")
            {
                MessageBox.Show("Xin chào " + lb_taikhoan.Text + " với quyền " + lb_quyen.Text + "", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mntDangNhap.Enabled = false;
                mntDanhMuc.Enabled = false;
                mntQuanLyTaiKhoan.Enabled = false;
                //bt_timkiem.Enabled = true;
                mntDoiMatKhau.Enabled = true;
                mntDangXuat.Enabled = true;
                mntTimkiem.Enabled = true;
                mntThongke.Enabled = false;
                mntTrogiup.Enabled = true;

            }
        }

        public Mainfrm(string TenDangNhap, string MatKhau, string Quyen, string TenThat)
        {
            InitializeComponent();
            lb_taikhoan.Text = TenDangNhap;
            lb_quyen.Text = Quyen;
            this.LayTenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;
            this.TenThat = TenThat;
        }


    }
}
