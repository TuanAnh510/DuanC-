using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLGV
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        int i;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-3NFIFOLQ;Initial Catalog=QLGV;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * From tb_TAIKHOAN1 where TAIKHOAN='" + txtTaiKhoan.Text + "' and MATKHAU='" + txtMatKhau.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (i < 4)
            {

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    Mainfrm frmMain = new Mainfrm(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    frmMain.Show();
                }
                else
                {
                    i++;
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập sai quá nhiều lần!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Hệ thống sẽ tự động thoát", "Nghi vấn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult ldr = MessageBox.Show("Bạn có muốn thoát đăng nhập hay không ^^", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            {
                if (ldr == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 8 || e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }
    }
}