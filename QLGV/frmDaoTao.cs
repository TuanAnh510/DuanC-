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
    public partial class frmDaoTao : DevExpress.XtraEditors.XtraForm
    {
        public frmDaoTao()
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
            txtMaDT.Enabled = !kt;
            txtTenTruong.Enabled = !kt;
            txtThanhPho.Enabled = !kt;
            txtQuocGia.Enabled = !kt;
            //dtNgayBatDau.Enabled = !kt;
            //dtNgayKetThuc.Enabled = !kt;
        }
        void reset()
        {
            txtMaDT.Clear();
            txtTenTruong.Clear();
            txtThanhPho.Clear();
            txtQuocGia.Clear();
        }
        public void suatieude()
        {
            dtgv.Columns[0].HeaderText = "Mã trường";
            dtgv.Columns[1].HeaderText = "Tên trường";
            dtgv.Columns[2].HeaderText = "Thành phố";
            dtgv.Columns[3].HeaderText = "Quốc gia";
        }
        private void frmDaoTao_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dtgv, "select * from tb_NOIDAOTAO");
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
            string delete = "delete from tb_NOIDAOTAO where MaTruong=N'" + txtMaDT.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa nơi đào tạo này không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dtgv, "select * from tb_NOIDAOTAO");
                MessageBox.Show("Xóa thành công nơi đào tạo " + txtMaDT.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtMaDT.Enabled = false;
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

                    string insert = "insert into tb_NOIDAOTAO values(N'" + txtMaDT.Text + "',N'" + txtTenTruong.Text + "',N'" + txtThanhPho.Text + "',N'" + txtQuocGia.Text + "')";
                    if (cls.kttrungkhoa(txtMaDT.Text, "select * from tb_NOIDAOTAO") == true)
                        MessageBox.Show("Mã nơi đào tạo này đã tồn tại. Bạn có thể thử tên khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (txtMaDT.Text == "" || txtTenTruong.Text == "" || txtThanhPho.Text == "" || txtQuocGia.Text=="")
                    {
                        MessageBox.Show("Bạn vui lòng nhập đủ thông tin!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txtMaDT.Text.Length < 2 || txtMaDT.Text.Length > 10)
                    {
                        MessageBox.Show("Mã đào tạo mới phải trong khoản từ 2 đến 10 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cls.thucthiketnoi(insert);
                        MessageBox.Show("Chúc mừng bạn đã thêm thành công nơi đào tạo mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls.loaddatagridview(dtgv, "select * from tb_NOIDAOTAO");
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
                    string update = "update tb_NOIDAOTAO set TenTruong=N'" + txtTenTruong.Text + "',ThanhPho=N'" + txtThanhPho.Text + "',QuocGia=N'" + txtQuocGia.Text + "' where MaTruong='" + txtMaDT.Text + "'";
                    cls.thucthiketnoi(update);
                    cls.loaddatagridview(dtgv, "select * from tb_NOIDAOTAO");
                    MessageBox.Show("Sửa thành công dữ liệu nơi đào tạo  " + txtMaDT.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
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
                txtMaDT.Text = dtgv.Rows[hang].Cells[0].Value.ToString();
                txtTenTruong.Text = dtgv.Rows[hang].Cells[1].Value.ToString();
                txtThanhPho.Text = dtgv.Rows[hang].Cells[3].Value.ToString();
                txtQuocGia.Text = dtgv.Rows[hang].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void txtMaDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 8 || e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void txtTenTruong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtThanhPho_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtQuocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }
    }
}