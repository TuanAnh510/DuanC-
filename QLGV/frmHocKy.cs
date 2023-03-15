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
    public partial class frmHocKy : DevExpress.XtraEditors.XtraForm
    {
        public frmHocKy()
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
            btnXoa.Enabled = kt;
            btnThoat.Enabled = kt;
            cboLoaiHK.Enabled = !kt;
            cboNam.Enabled = !kt;
            txtMaHP.Enabled = !kt;
            txtTenHP.Enabled = !kt;
            //dtNgayBatDau.Enabled = !kt;
            //dtNgayKetThuc.Enabled = !kt;
        }
        void reset()
        {
            txtMaHP.Clear();
            txtTenHP.Clear();
        }
        public void suatieude()
        {
            dtgv.Columns[0].HeaderText = "Mã hoc ky";
            dtgv.Columns[1].HeaderText = "Tên học ky";
        }
        private void frmHocKy_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dtgv, "select * from tb_HOCPHAN");
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
             string delete = "delete from tb_HOCPHAN where MaHK=N'" + txtMaHP.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa học kỳ này không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dtgv, "select * from tb_HOCPHAN");
                MessageBox.Show("Xóa thành công dữ liệu " + txtMaHP.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            else
                MessageBox.Show("Xóa không thành công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            reset();
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

                    string insert = "insert into tb_HOCPHAN values(N'" + txtMaHP.Text + "',N'" + txtTenHP.Text + "')";
                    if (cls.kttrungkhoa(txtMaHP.Text, "select * from tb_HOCPHAN") == true)
                        MessageBox.Show("Học kỳ này đã tồn tại. Bạn có thể thử lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (txtMaHP.Text == "" || txtTenHP.Text == "")
                    {
                        MessageBox.Show("Bạn vui lòng nhập đủ thông tin!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        cls.thucthiketnoi(insert);
                        MessageBox.Show("Chúc mừng bạn đã thêm thành công học kỳ mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cls.loaddatagridview(dtgv, "select * from tb_HOCPHAN");
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
          
        }
        private void cboLoaiHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaHP.Text = cboLoaiHK.Text.ToString() + cboNam.Text.ToString();
            if (cboLoaiHK.Text == "HK1")
            {
                txtTenHP.Text = "Hoc ky 1/" + cboNam.Text.ToString();
            }
            else if (cboLoaiHK.Text == "HK2")
            {
                txtTenHP.Text = "Hoc ky 2/" + cboNam.Text.ToString();
            }
            else if (cboLoaiHK.Text == "HKH")
            {
                txtTenHP.Text = "Hoc ky he/" + cboNam.Text.ToString();
            }
            else if (cboLoaiHK.Text == "HKP")
            {
                txtTenHP.Text = "Hoc ky phu/" + cboNam.Text.ToString();
            }
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaHP.Text = cboLoaiHK.Text.ToString() + cboNam.Text.ToString();
            if (cboLoaiHK.Text == "HK1")
            {
                txtTenHP.Text = "Hoc ky 1/" + cboNam.Text.ToString();
            }
            else if (cboLoaiHK.Text == "HK2")
            {
                txtTenHP.Text = "Hoc ky 2/" + cboNam.Text.ToString();
            }
            else if (cboLoaiHK.Text == "HKH")
            {
                txtTenHP.Text = "Hoc ky he/" + cboNam.Text.ToString();
            }
            else if (cboLoaiHK.Text == "HKP")
            {
                txtTenHP.Text = "Hoc ky phu/" + cboNam.Text.ToString();
            }
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;  
                txtMaHP.Text = dtgv.Rows[hang].Cells[0].Value.ToString();
                txtTenHP.Text = dtgv.Rows[hang].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}