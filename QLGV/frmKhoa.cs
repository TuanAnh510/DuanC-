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

namespace QLGV
{
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        bool _them;
        void _showHide(bool kt)
        {
            btnHuy.Enabled = !kt;
            btnLuu.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnThoat.Enabled = kt;
            txtMaKhoa.Enabled = !kt;
            txtTenKhoa.Enabled = !kt;
            txtMoTa.Enabled = !kt;
            //dtNgayBatDau.Enabled = !kt;
            //dtNgayKetThuc.Enabled = !kt;
        }
        void reset()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtMoTa.Clear();
        }
        public void suatieude()
        {
            dtgv.Columns[0].HeaderText = "Mã khoa";
            dtgv.Columns[1].HeaderText = "Tên khoa";
            dtgv.Columns[2].HeaderText = "Mô tả";
        }
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dtgv, "select * from tb_KHOA");
            suatieude();
            _them = false;
            _showHide(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true; //Khi nhấn mới thêm
            _showHide(false);
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from tb_KHOA where MAKHOA=N'" + txtMaKhoa.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa khoa này không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dtgv, "select * from tb_KHOA");
                MessageBox.Show("Xóa thành công dữ liệu " + txtMaKhoa.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            else
                MessageBox.Show("Xóa không thành công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _showHide(false);
            _them = false;
            txtMaKhoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveData();
            _them = false;
            _showHide(true);
            reset();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _showHide(true);
            _them = false;
            reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                try
                {

                    string insert = "insert into tb_KHOA values(N'" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "',N'" + txtMoTa.Text + "')";
                    if (cls.kttrungkhoa(txtMaKhoa.Text, "select * from tb_KHOA") == true)
                        MessageBox.Show("Khoa này đã tồn tại. Bạn có thể thử tên khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "")
                    {
                        MessageBox.Show("Bạn vui lòng nhập đủ thông tin!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txtMaKhoa.Text.Length < 2 )
                    {
                        MessageBox.Show("Mã khoa phải lớn hơn 2 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtTenKhoa.Text.Length < 2)
                    {
                        MessageBox.Show("Tên khoa phải lớn hơn 2 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cls.thucthiketnoi(insert);
                        MessageBox.Show("Chúc mừng bạn đã thêm thành công khoa mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls.loaddatagridview(dtgv, "select * from tb_KHOA");
                        //this.Close();
                        reset();
                    }
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đầu vào không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //reset();
                }
            }
            else
            {
                try
                {
                    string update = "update tb_KHOA set TENKHOA=N'" + txtTenKhoa.Text + "',MOTA=N'" + txtMoTa.Text + "' where MAKHOA='" + txtMaKhoa.Text + "'";
                  
                    if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "")
                    {
                        MessageBox.Show("Bạn vui lòng nhập đủ thông tin!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txtMaKhoa.Text.Length < 2)
                    {
                        MessageBox.Show("Mã khoa phải lớn hơn 2 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtTenKhoa.Text.Length < 2)
                    {
                        MessageBox.Show("Tên khoa phải lớn hơn 2 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cls.thucthiketnoi(update);
                        cls.loaddatagridview(dtgv, "select * from tb_KHOA");
                        MessageBox.Show("Sửa thành công dữ liệu khoa " + txtMaKhoa.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đầu vào không đúng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reset();
                }
            }
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaKhoa.Text = dtgv.Rows[hang].Cells[0].Value.ToString();
                txtTenKhoa.Text = dtgv.Rows[hang].Cells[1].Value.ToString();
                txtMoTa.Text = dtgv.Rows[hang].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void txtMaKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTenKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}