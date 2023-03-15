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
    public partial class frmGV : DevExpress.XtraEditors.XtraForm
    {
        public frmGV()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        public void load_dtgv()
        {
            clss_kn ketnoi = new clss_kn();
            if (ketnoi.kn())
            {
                SqlConnection conn = new SqlConnection();
                conn = ketnoi.conn;
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "select * from tb_GV1";


                SqlDataReader data = com.ExecuteReader();
                DataTable tb_nhanvien = new DataTable();
                tb_nhanvien.Load(data);
                dtgv.DataSource = tb_nhanvien;
            }
            else
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void load_khoa()
        {
            clss_kn ketnoi = new clss_kn();
            if (ketnoi.kn())
            {
                SqlConnection conn = new SqlConnection();
                conn = ketnoi.conn;
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "select * from tb_KHOA";
                SqlDataReader data = com.ExecuteReader();
                DataTable tb_chucvu = new DataTable();
                tb_chucvu.Load(data);
                cboMaKhoa.DataSource = tb_chucvu;
                cboMaKhoa.DisplayMember = "MaKhoa";
                cboMaKhoa.ValueMember = "MaKhoa";
            }
            else
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void load_hocvi()
        {
            clss_kn ketnoi = new clss_kn();
            if (ketnoi.kn())
            {
                SqlConnection conn = new SqlConnection();
                conn = ketnoi.conn;
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "select * from tb_HOCVI";
                SqlDataReader data = com.ExecuteReader();
                DataTable tb_chucvu = new DataTable();
                tb_chucvu.Load(data);
                cboMaHocVi.DataSource = tb_chucvu;
                cboMaHocVi.DisplayMember = "MaHocVi";
                cboMaHocVi.ValueMember = "MaHocVi";
            }
            else
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void load_hocham()
        {
            clss_kn ketnoi = new clss_kn();
            if (ketnoi.kn())
            {
                SqlConnection conn = new SqlConnection();
                conn = ketnoi.conn;
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "select * from tb_HOCHAM";
                SqlDataReader data = com.ExecuteReader();
                DataTable tb_chucvu = new DataTable();
                tb_chucvu.Load(data);
                cboMaHocHam.DataSource = tb_chucvu;
                cboMaHocHam.DisplayMember = "MaHocHam";
                cboMaHocHam.ValueMember = "MaHocHam";
            }
            else
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void load_truong()
        {
            clss_kn ketnoi = new clss_kn();
            if (ketnoi.kn())
            {
                SqlConnection conn = new SqlConnection();
                conn = ketnoi.conn;
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "select * from tb_NOIDAOTAO";
                SqlDataReader data = com.ExecuteReader();
                DataTable tb_chucvu = new DataTable();
                tb_chucvu.Load(data);
                cboMaTruong.DataSource = tb_chucvu;
                cboMaTruong.DisplayMember = "MaTruong";
                cboMaTruong.ValueMember = "MaTruong";
            }
            else
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void load_Mon()
        {
            clss_kn ketnoi = new clss_kn();
            if (ketnoi.kn())
            {
                SqlConnection conn = new SqlConnection();
                conn = ketnoi.conn;
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "select * from tb_MON";
                SqlDataReader data = com.ExecuteReader();
                DataTable tb_chucvu = new DataTable();
                tb_chucvu.Load(data);
                cboMaMon.DataSource = tb_chucvu;
                cboMaMon.DisplayMember = "MaMon";
                cboMaMon.ValueMember = "MaMon";
            }
            else
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void load_HK()
        {
            clss_kn ketnoi = new clss_kn();
            if (ketnoi.kn())
            {
                SqlConnection conn = new SqlConnection();
                conn = ketnoi.conn;
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "select * from tb_HOCPHAN";
                SqlDataReader data = com.ExecuteReader();
                DataTable tb_chucvu = new DataTable();
                tb_chucvu.Load(data);
                cboMaHK.DataSource = tb_chucvu;
                cboMaHK.DisplayMember = "MaHK";
                cboMaHK.ValueMember = "MaHK";
            }
            else
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK);
            }
        }
        bool _them;
        void _showHide(bool kt)
        {
            btnHuy.Enabled = !kt;
            btnLuu.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnThoat.Enabled = kt;
            cboMaKhoa.Enabled = !kt;
            txtTenKhoa.Enabled = !kt;
            txtMaGV.Enabled = !kt;
            txtHoTen.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
            cboGioiTinh.Enabled = !kt;
            txtQueQuan.Enabled = !kt;
            dtNgayBatDau.Enabled = !kt;
            cboMaHocVi.Enabled = !kt;
            tbTenHocVi.Enabled = !kt;
            dtNgayBDHH.Enabled = !kt;
            cboMaHocHam.Enabled = !kt;
            txtTenHocHam.Enabled = !kt;
            dtNgayBDHV.Enabled = !kt;
            cboLoaiGV.Enabled = !kt;
            cboMaTruong.Enabled = !kt;
            txtTenTruong.Enabled = !kt;
            cboMaHK.Enabled = !kt;
            cboMaMon.Enabled = !kt;
            txtLCB.Enabled = !kt;
            txtSNL.Enabled = !kt;
            txtPC.Enabled = !kt;
            btnTT.Enabled = !kt;
        }
        void reset()
        {
            cboMaKhoa.Text = string.Empty;
            txtTenKhoa.Text = string.Empty;
            txtMaGV.Clear();
            txtHoTen.Clear();
            cboGioiTinh.Text = string.Empty;
            txtQueQuan.Clear();
            cboMaHocVi.Text = string.Empty;
            tbTenHocVi.Clear();
            cboMaHocHam.Text = string.Empty;
            txtTenHocHam.Clear();
            cboMaTruong.Text = string.Empty;
            txtTenTruong.Clear();
            cboLoaiGV.Text = string.Empty;
            txtLCB.Clear();
            txtSNL.Clear();
            txtPC.Clear();
            txtTT.Clear();
        }
        public void suatieude()
        {
            dtgv.Columns[0].HeaderText = "Mã giáo viên";
            dtgv.Columns[1].HeaderText = "Tên giáo viên";
            dtgv.Columns[2].HeaderText = "Mã Khoa";
            dtgv.Columns[3].HeaderText = "Tên Khoa";
            dtgv.Columns[4].HeaderText = "Ngày sinh";
            dtgv.Columns[5].HeaderText = "Giới tính";
            dtgv.Columns[6].HeaderText = "Quê quán";
            dtgv.Columns[7].HeaderText = "Ngày bắt đầu làm việc";
            dtgv.Columns[8].HeaderText = "Mã học vị";
            dtgv.Columns[9].HeaderText = "Tên học vị";
            dtgv.Columns[10].HeaderText = "Năm đạt học vị";
            dtgv.Columns[11].HeaderText = "Mã học hàm";
            dtgv.Columns[12].HeaderText = "Tên học hàm";
            dtgv.Columns[13].HeaderText = "Năm đạt học hàm";
            dtgv.Columns[14].HeaderText = "Loại giáo viên";
            dtgv.Columns[15].HeaderText = "Mã trường";
            dtgv.Columns[16].HeaderText = "Tên trường";
            dtgv.Columns[17].HeaderText = "Mã học kì";
            dtgv.Columns[18].HeaderText = "Mã môn";
            dtgv.Columns[19].HeaderText = "Tên môn";
            dtgv.Columns[20].HeaderText = "Tổng số lí thuyết";
            dtgv.Columns[21].HeaderText = "Tổng số thực hành";
            dtgv.Columns[22].HeaderText = "Lương cơ bản";
            dtgv.Columns[23].HeaderText = "Số ngày làm";
            dtgv.Columns[24].HeaderText = "Phụ cấp";
            dtgv.Columns[25].HeaderText = "Tổng lương";

        }
        private void frmGV_Load(object sender, EventArgs e)
        {
            load_dtgv();
            load_khoa();
            load_hocvi();
            load_hocham();
            load_truong();
            load_Mon();
            load_HK();
            _them = false;
            _showHide(true);
            suatieude();
        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txtTenKhoa, "select * from tb_KHOA where MAKHOA='" + cboMaKhoa.Text + "'", 1);
        }

        private void cboMaHocVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(tbTenHocVi, "select * from tb_HOCVI where MaHocVi='" + cboMaHocVi.Text + "'", 1);
        }

        private void cboMaHocHam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txtTenHocHam, "select * from tb_HOCHAM where MaHocHam='" + cboMaHocHam.Text + "'", 1);
        }

        private void cboMaTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txtTenTruong, "select * from tb_NOIDAOTAO where MaTruong='" + cboMaTruong.Text + "'", 1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true; //Khi nhấn mới thêm
            _showHide(false);
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
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from tb_GV1 where MaGV=N'" + txtMaGV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa giáo viên này không", "Xóa dữ liệu ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dtgv, "select * from tb_GV1");
                MessageBox.Show("Xóa thành công giáo viên " + txtHoTen.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtMaGV.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void SaveData()
        {
            if (_them)
            {
                clss_kn ketnoi = new clss_kn();
                
                if (ketnoi.kn())
                {
                    if (txtMaGV.Text == "" || txtHoTen.Text == "" || txtQueQuan.Text == "" || txtLCB.Text == "" || txtPC.Text == "" || txtTT.Text == "")
                    {
                        MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin khi thêm thông tin mới!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (txtSNL.Text.Trim() != string.Empty)
                    {
                        int ngaylam = Convert.ToInt32(txtSNL.Text);
                        if (ngaylam < 1 || ngaylam > 31)
                        {
                            MessageBox.Show("Chỉ nhập được từ 1 đến 31 ngày !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được bỏ trống dữ liệu !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    int lcb = Convert.ToInt32(txtLCB.Text);
                    if (cls.kttrungkhoa(txtMaGV.Text, "select * from tb_GV1") == true)
                    {
                        MessageBox.Show("Mã giáo viên này đã tồn tại. Bạn vui lòng nhập lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (lcb < 200)
                    {
                        MessageBox.Show("Lương cơ bản thấp nhất là 200.000Đ 1 ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //       else if (ngaylam < 1 || ngaylam > 31)
                    //       {
                    //           MessageBox.Show("chỉ nhập được từ 1 đến 31 ngày ! ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //       }
                    else
                    {
                        SqlConnection conn = new SqlConnection();
                        conn = ketnoi.conn;
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "insert tb_GV1 values (@MaGV,@HoTen,@MaKhoa,@TenKhoa,@NgaySinh,@GioiTinh,@QueQuan,@NgayBatDau,@MaHocVi,@TenHocVi,@NgayBDHV,@MaHocHam,@TenHocHam,@NgayBDHH,@LoaiGV,@MaTruong,@TenTruong,@MaHK,@MaMon,@TenMon,@TongSoLT,@TongSoTH,@LuongCB,@SoNgayLam,@PhuCap,@TongLuong)";
                        cmd.Parameters.AddWithValue("@MaGV", txtMaGV.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@MaKhoa", cboMaKhoa.Text);
                        cmd.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);
                        cmd.Parameters.AddWithValue("@NgayBatDau", dtNgayBatDau.Value);
                        cmd.Parameters.AddWithValue("@MaHocVi", cboMaHocVi.Text);
                        cmd.Parameters.AddWithValue("@TenHocVi", tbTenHocVi.Text);
                        cmd.Parameters.AddWithValue("@NgayBDHV", dtNgayBDHV.Value);
                        cmd.Parameters.AddWithValue("@MaHocHam", cboMaHocHam.Text);
                        cmd.Parameters.AddWithValue("@TenHocHam", txtTenHocHam.Text);
                        cmd.Parameters.AddWithValue("@NgayBDHH", dtNgayBDHH.Value);
                        cmd.Parameters.AddWithValue("@LoaiGV", cboLoaiGV.Text);
                        cmd.Parameters.AddWithValue("@MaTruong", cboMaTruong.Text);
                        cmd.Parameters.AddWithValue("@TenTruong", txtTenTruong.Text);
                        cmd.Parameters.AddWithValue("@MaHK", cboMaHK.Text);
                        cmd.Parameters.AddWithValue("@MaMon", cboMaMon.Text);
                        cmd.Parameters.AddWithValue("@TenMon", txtTenMon.Text);
                        cmd.Parameters.AddWithValue("@TongSoLT", txtChiLT.Text);
                        cmd.Parameters.AddWithValue("@TongSoTH", txtChiTH.Text);
                        cmd.Parameters.AddWithValue("@LuongCB", txtLCB.Text);
                        cmd.Parameters.AddWithValue("@SoNgayLam", txtSNL.Text);
                        cmd.Parameters.AddWithValue("@PhuCap", txtPC.Text);
                        cmd.Parameters.AddWithValue("@TongLuong", txtTT.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Chúc mừng bạn đã thêm thành công giáo viên mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_dtgv();
                    }

                }
                else
                {
                    MessageBox.Show("Dữ liệu đã nhập còn sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                clss_kn ketnoi = new clss_kn();
                int lcb = Convert.ToInt32(txtLCB.Text);
                if (txtSNL.Text.Trim() != string.Empty)
                {
                    int ngaylam = Convert.ToInt32(txtSNL.Text);
                    if (ngaylam < 1 || ngaylam > 31)
                    {
                        MessageBox.Show("Chỉ nhập được từ 1 đến 31 ngày !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (txtSNL.Text == "")
                {
                    MessageBox.Show("không đươc bỏ trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (lcb < 200)
                {
                    MessageBox.Show("Lương cơ bản thấp nhất là 200.000Đ 1 ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else if (ketnoi.kn())
                {
                    SqlConnection conn = new SqlConnection();
                    conn = ketnoi.conn;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE tb_GV1 set HoTen = @Hoten, MaKhoa = @MaKhoa,TenKhoa = @TenKhoa,NgaySinh = @NgaySinh,GioiTinh = @GioiTinh,QueQuan = @QueQuan,NgayBatDau = @NgayBatDau,MaHocVi = @MaHocVi,TenHocVi = @TenHocVi,NgayBDHV = @NgayBDHV,MaHocHam = @MaHocHam,TenHocHam = @TenHocHam,NgayBDHH = @NgayBDHH,LoaiGV = @LoaiGV,MaTruong = @MaTruong,TenTruong=@TenTruong,MaHK=@MaHK,MaMon=@MaMon,TenMon=@TenMon,TongSoLT=@TongSoLT,TongSoTH=@TongSoTH, LuongCB=@LuongCB , SoNgayLam=@SoNgayLam, PhuCap=@PhuCap, TongLuong=@TongLuong where MaGV=@MaGV";
                    cmd.Parameters.AddWithValue("@MaGV", txtMaGV.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@MaKhoa", cboMaKhoa.Text);
                    cmd.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);
                    cmd.Parameters.AddWithValue("@NgayBatDau", dtNgayBatDau.Value);
                    cmd.Parameters.AddWithValue("@MaHocVi", cboMaHocVi.Text);
                    cmd.Parameters.AddWithValue("@TenHocVi", tbTenHocVi.Text);
                    cmd.Parameters.AddWithValue("@NgayBDHV", dtNgayBDHV.Value);
                    cmd.Parameters.AddWithValue("@MaHocHam", cboMaHocHam.Text);
                    cmd.Parameters.AddWithValue("@TenHocHam", txtTenHocHam.Text);
                    cmd.Parameters.AddWithValue("@NgayBDHH", dtNgayBDHH.Value);
                    cmd.Parameters.AddWithValue("@LoaiGV", cboLoaiGV.Text);
                    cmd.Parameters.AddWithValue("@MaTruong", cboMaTruong.Text);
                    cmd.Parameters.AddWithValue("@TenTruong", txtTenTruong.Text);
                    cmd.Parameters.AddWithValue("@MaHK", cboMaHK.Text);
                    cmd.Parameters.AddWithValue("@MaMon", cboMaMon.Text);
                    cmd.Parameters.AddWithValue("@TenMon", txtTenMon.Text);
                    cmd.Parameters.AddWithValue("@TongSoLT", txtChiLT.Text);
                    cmd.Parameters.AddWithValue("@TongSoTH", txtChiTH.Text);
                    cmd.Parameters.AddWithValue("@LuongCB", txtLCB.Text);
                    cmd.Parameters.AddWithValue("@SoNgayLam", txtSNL.Text);
                    cmd.Parameters.AddWithValue("@PhuCap", txtPC.Text);
                    cmd.Parameters.AddWithValue("@TongLuong", txtTT.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công dữ liệu giáo viên" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_dtgv();
                }
               
                else
                {
                    MessageBox.Show("Dữ liệu đã nhập còn sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaGV.Text = dtgv.Rows[hang].Cells[0].Value.ToString();
                txtHoTen.Text = dtgv.Rows[hang].Cells[1].Value.ToString();
                cboMaKhoa.Text = dtgv.Rows[hang].Cells[2].Value.ToString();
                txtTenKhoa.Text = dtgv.Rows[hang].Cells[3].Value.ToString();
                dtNgaySinh.Text = dtgv.Rows[hang].Cells[4].Value.ToString();
                cboGioiTinh.Text = dtgv.Rows[hang].Cells[5].Value.ToString();
                txtQueQuan.Text = dtgv.Rows[hang].Cells[6].Value.ToString();
                dtNgayBatDau.Text = dtgv.Rows[hang].Cells[7].Value.ToString();
                cboMaHocVi.Text = dtgv.Rows[hang].Cells[8].Value.ToString();
                tbTenHocVi.Text = dtgv.Rows[hang].Cells[9].Value.ToString();
                dtNgayBDHV.Text = dtgv.Rows[hang].Cells[10].Value.ToString();
                cboMaHocHam.Text = dtgv.Rows[hang].Cells[11].Value.ToString();
                txtTenHocHam.Text = dtgv.Rows[hang].Cells[12].Value.ToString();
                dtNgayBDHH.Text = dtgv.Rows[hang].Cells[13].Value.ToString();
                cboLoaiGV.Text = dtgv.Rows[hang].Cells[14].Value.ToString();
                cboMaTruong.Text = dtgv.Rows[hang].Cells[15].Value.ToString();
                txtTenTruong.Text = dtgv.Rows[hang].Cells[16].Value.ToString();
                cboMaHK.Text = dtgv.Rows[hang].Cells[17].Value.ToString();
                cboMaMon.Text = dtgv.Rows[hang].Cells[18].Value.ToString();
                txtTenMon.Text = dtgv.Rows[hang].Cells[19].Value.ToString();
                txtChiLT.Text = dtgv.Rows[hang].Cells[20].Value.ToString();
                txtChiTH.Text = dtgv.Rows[hang].Cells[21].Value.ToString();
                txtLCB.Text = dtgv.Rows[hang].Cells[22].Value.ToString();
                txtSNL.Text = dtgv.Rows[hang].Cells[23].Value.ToString();
                txtPC.Text = dtgv.Rows[hang].Cells[24].Value.ToString();
                txtTT.Text = dtgv.Rows[hang].Cells[25].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cboMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(txtTenMon, "select * from tb_MON where MaMon='" + cboMaMon.Text + "'", 2);
            cls.loadtextboxchiso(txtChiLT, "select * from tb_MON where MaMon='" + cboMaMon.Text + "'", 4);
            cls.loadtextboxchiso(txtChiTH, "select * from tb_MON where MaMon='" + cboMaMon.Text + "'", 6);
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            
            float Luong = 0;
            if (txtSNL.Text=="")
            {

                MessageBox.Show("Khong duoc bo trong so ngay lam", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }else if (txtLCB.Text == "")
            {
                MessageBox.Show("Khong duoc bo trong luong co ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPC.Text.Trim()==string.Empty)
            {
                int nl = Convert.ToInt32(txtSNL.Text);
                int lcb = Convert.ToInt32(txtLCB.Text);
                
                Luong = nl * lcb;
            }
            else
            {
                int nl = Convert.ToInt32(txtSNL.Text);
                int lcb = Convert.ToInt32(txtLCB.Text);
                int pc = Convert.ToInt32(txtPC.Text);
                Luong = nl * lcb + pc;
            }
           
            txtTT.Text = Luong.ToString();
        }

        private void txtMaGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 8 || e.KeyChar != 13))
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtQueQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtLCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSNL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}