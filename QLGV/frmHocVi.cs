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
    public partial class frmHocVi : DevExpress.XtraEditors.XtraForm
    {
        public frmHocVi()
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
            txtMaHocVi.Enabled = !kt;
            txtTenHocVi.Enabled = !kt;
            txtMoTa.Enabled = !kt;
            //dtNgayBatDau.Enabled = !kt;
            //dtNgayKetThuc.Enabled = !kt;
        }
        void reset()
        {
            txtMaHocVi.Clear();
            txtTenHocVi.Clear();
            txtMoTa.Clear();
        }
        public void suatieude()
        {
            dtgv.Columns[0].HeaderText = "Mã học vị";
            dtgv.Columns[1].HeaderText = "Tên học vị";
            dtgv.Columns[2].HeaderText = "Mô tả";
        }
        private void frmHocVi_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dtgv, "select * from tb_HOCVI");
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
            string delete = "delete from tb_HOCVI where MaHocVi=N'" + txtMaHocVi.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa học vị này không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dtgv, "select * from tb_HOCVI");
                MessageBox.Show("Xóa thành công dữ liệu " + txtMaHocVi.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtMaHocVi.Enabled = false;
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

                    string insert = "insert into tb_HOCVI values(N'" + txtMaHocVi.Text + "',N'" + txtTenHocVi.Text + "',N'" + txtMoTa.Text + "')";
                    if (cls.kttrungkhoa(txtMaHocVi.Text, "select * from tb_HOCVI") == true)
                        MessageBox.Show("Mã học vị này đã tồn tại. Bạn có thể thử tên khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (txtMaHocVi.Text == "" || txtTenHocVi.Text == "")
                    {
                        MessageBox.Show("Bạn vui lòng nhập đủ thông tin!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txtMaHocVi.Text.Length < 2 || txtMaHocVi.Text.Length > 20)
                    {
                        MessageBox.Show("Mã học vị phải lớn hơn 1 và nhỏ hơn 20 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cls.thucthiketnoi(insert);
                        MessageBox.Show("Chúc mừng bạn đã thêm thành công học vị mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls.loaddatagridview(dtgv, "select * from tb_HOCVI");
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
                    string update = "update tb_HOCVI set TenHocVi=N'" + txtTenHocVi.Text + "',MoTa=N'" + txtMoTa.Text + "' where MaHocVi='" + txtMaHocVi.Text + "'";
                    if (cls.kttrungkhoa(txtMaHocVi.Text, "select * from tb_HOCVI") == true)
                        MessageBox.Show("Mã học vị này đã tồn tại. Bạn có thể thử tên khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (txtMaHocVi.Text == "" || txtTenHocVi.Text == "")
                    {
                        MessageBox.Show("Bạn vui lòng nhập đủ thông tin!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txtMaHocVi.Text.Length < 2 || txtMaHocVi.Text.Length > 20)
                    {
                        MessageBox.Show("Mã học hàm phải lớn hơn 1 và nhỏ hơn 20 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    else
                    {
                        cls.thucthiketnoi(update);
                        cls.loaddatagridview(dtgv, "select * from tb_HOCVI");
                        MessageBox.Show("Sửa thành công dữ liệu học vị " + txtMaHocVi.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                txtMaHocVi.Text = dtgv.Rows[hang].Cells[0].Value.ToString();
                txtTenHocVi.Text = dtgv.Rows[hang].Cells[1].Value.ToString();
                txtMoTa.Text = dtgv.Rows[hang].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void txtMaHocVi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 8 || e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void txtTenHocVi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }
    }
}