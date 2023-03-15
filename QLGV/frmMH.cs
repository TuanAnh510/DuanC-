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
    public partial class frmMH : DevExpress.XtraEditors.XtraForm
    {
        public frmMH()
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
            btnTinhTC.Enabled = !kt;
            btnThoat.Enabled = kt;
            cboMaHocPhan.Enabled = !kt;
            txtMaMon.Enabled = !kt;
            txtTenMon.Enabled = !kt;
            cboChiLT.Enabled = !kt;
            txtTongSoLT.Enabled = !kt;
            cboChiTH.Enabled = !kt;
            txtTongSoTH.Enabled = !kt;
            txtTong.Enabled = !kt;
            //dtNgayBatDau.Enabled = !kt;
            //dtNgayKetThuc.Enabled = !kt;
        }
        void reset()
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtTongSoLT.Clear();
            txtTongSoTH.Clear();
            txtTong.Clear();
        }
        public void suatieude()
        {
            dtgv.Columns[0].HeaderText = "Mã học phần ";
            dtgv.Columns[1].HeaderText = "Mã môn";
            dtgv.Columns[2].HeaderText = "Tên môn";
            dtgv.Columns[3].HeaderText = "Số chỉ LT";
            dtgv.Columns[4].HeaderText = "Tống số chỉ LT";
            dtgv.Columns[5].HeaderText = "Số chỉ TH";
            dtgv.Columns[6].HeaderText = "Tổng số chỉ TH";
            dtgv.Columns[7].HeaderText = "Tổng số chỉ";
        }

        private void frmMH_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dtgv, "select * from tb_MON");
            cls.loadcombobox(cboMaHocPhan, "select * from tb_HOCPHAN", 0);
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
            string delete = "delete from tb_MON where MaMon=N'" + txtMaMon.Text + "'";
            if (MessageBox.Show("Bạn có muốn môn học này không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dtgv, "select * from tb_MON");
                MessageBox.Show("Xóa thành công dữ liệu " + txtMaMon.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtMaMon.Enabled = false;
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

                    string insert = "insert into tb_MON values(N'" + cboMaHocPhan.Text + "',N'" + txtMaMon.Text + "',N'" + txtTenMon.Text + "',N'" + cboChiLT.Text + "',N'" + txtTongSoLT.Text + "',N'" + cboChiTH.Text + "',N'" + txtTongSoTH.Text + "',N'" + txtTong.Text + "')";
                    if (cls.kttrungkhoa(txtMaMon.Text, "select * from tb_MON") == true)
                        MessageBox.Show("Mã học vị này đã tồn tại. Bạn có thể thử tên khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (txtMaMon.Text == "" || txtTenMon.Text == "" || txtTongSoLT.Text == "" || txtTongSoTH.Text == "" || txtTong.Text == "")
                    {
                        MessageBox.Show("Bạn vui lòng nhập đủ thông tin!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        cls.thucthiketnoi(insert);
                        MessageBox.Show("Chúc mừng bạn đã thêm thành công môn mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls.loaddatagridview(dtgv, "select * from tb_MON");
                        //this.Close();
                        reset();
                    }
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đầu vào không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reset();
                }
               
            }
            else
            {
                try
                {
                    string update = "update tb_MON set MaHK=N'" + cboMaHocPhan.Text + "',TenMon=N'" + txtTenMon.Text + "',SoChiLT=N'" + cboChiLT.Text + "',TongSoLT=N'" + txtTongSoLT.Text + "',SoChiTH=N'" + cboChiTH.Text + "',TongSoTH=N'" + txtTongSoTH.Text + "',TongTC=N'" + txtTong.Text + "' where MaMon=N'" + txtMaMon.Text + "'";
                    cls.thucthiketnoi(update);
                    cls.loaddatagridview(dtgv, "select * from tb_MON");
                    MessageBox.Show("Sửa thành công dữ liệu " + txtMaMon.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đầu vào không đúng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reset();
                }
            }
        }
        private void btnTinhTC_Click(object sender, EventArgs e)
        {
            if(txtTongSoLT.Text == "" && txtTongSoTH.Text == "")
            {
                MessageBox.Show("Khong duoc bo trong tổng số LT và TH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (txtTongSoLT.Text == "")
            {

                MessageBox.Show("Khong duoc bo trong tổng số LT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txtTongSoTH.Text == "")
            {
                MessageBox.Show("Khong duoc bo trong tổng số TH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int lythuyet = Convert.ToInt32(cboChiLT.Text);
                int thuchanh = Convert.ToInt32(cboChiTH.Text);
                float tong = lythuyet + thuchanh;
                txtTong.Text = tong.ToString();
            }
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                cboMaHocPhan.Text = dtgv.Rows[hang].Cells[0].Value.ToString();
                txtMaMon.Text = dtgv.Rows[hang].Cells[1].Value.ToString();
                txtTenMon.Text = dtgv.Rows[hang].Cells[2].Value.ToString();
                cboChiLT.Text = dtgv.Rows[hang].Cells[3].Value.ToString();
                txtTongSoLT.Text = dtgv.Rows[hang].Cells[4].Value.ToString();
                cboChiTH.Text = dtgv.Rows[hang].Cells[5].Value.ToString();
                txtTongSoTH.Text = dtgv.Rows[hang].Cells[6].Value.ToString();
                txtTong.Text = dtgv.Rows[hang].Cells[7].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cboChiLT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChiLT.Text == "0")
            {
                txtTongSoLT.Text = "0";
            }
            else if (cboChiLT.Text == "1")
            {
                txtTongSoLT.Text = "15";
            }
            else if (cboChiLT.Text == "2")
            {
                txtTongSoLT.Text = "30";
            }
            else if (cboChiLT.Text == "3")
            {
                txtTongSoLT.Text = "45";
            }
            else if (cboChiLT.Text == "4")
            {
                txtTongSoLT.Text = "60";
            }
        }

        private void cboChiTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChiTH.Text == "0")
            {
                txtTongSoTH.Text = "0";
            }
            else if (cboChiTH.Text == "1")
            {
                txtTongSoTH.Text = "30";
            }
            else if (cboChiTH.Text == "2")
            {
                txtTongSoTH.Text = "60";
            }
            else if (cboChiTH.Text == "3")
            {
                txtTongSoTH.Text = "90";
            }
            else if (cboChiTH.Text == "4")
            {
                txtTongSoTH.Text = "120";
            }

        }

        private void txtMaMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 8 || e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void txtTenMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar); // hàm chạy chữ, số , dấu cách bỏ kí tự đặc biệt
        }
    }
}