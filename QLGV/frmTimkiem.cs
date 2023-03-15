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
    public partial class frmTimkiem : DevExpress.XtraEditors.XtraForm
    {
        public frmTimkiem()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        public SqlConnection cn = new SqlConnection();
        public void Ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = "Data Source=LAPTOP-3NFIFOLQ;Initial Catalog=QLGV;Integrated Security=True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }

        //Phương thức truy vấn để xem dữ liệu
        public DataTable XemDL(string sql)
        {
            Ketnoi();

            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;

            Ngatketnoi();
        }

        //Phương thức truy vấn dữ liệu: Insert, Update, Delete
        public SqlCommand ThucThiDl(string sql)
        {
            Ketnoi();

            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();

            return cm;

            Ngatketnoi();
        }
       

        private void frmTimkiem_Load(object sender, EventArgs e)
        {
            cls.loaddatagridview(dtgv, "select * from tb_GV1");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void txtMaGV_TextChanged(object sender, EventArgs e)
        {
            dtgv.DataSource = XemDL("select * from tb_GV1 where MaGV like '%" + txtMaGV.Text.Trim() + "%'");
            
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            dtgv.DataSource = XemDL($"select * from tb_GV1 where HoTen like N'%{txtHoTen.Text.ToString().Trim()}%'"); 
        }

        private void txtTenHocVi_TextChanged(object sender, EventArgs e)
        {
            dtgv.DataSource = XemDL($"select * from tb_GV1 where TenHocVi like N'%{txtTenHocVi.Text.ToString().Trim()}%'");
        }

        private void txtTenHocHam_TextChanged(object sender, EventArgs e)
        {
            dtgv.DataSource = XemDL($"select * from tb_GV1 where TenHocHam like N'{txtTenHocHam.Text.ToString().Trim()}'");
        }
        private void txtTenKhoa_TextChanged(object sender, EventArgs e)
        {
            dtgv.DataSource = XemDL($"select * from tb_GV1 where TenKhoa like N'%{txtTenKhoa.Text.ToString().Trim()}%'");
        }

        private void txtLoaiGV_TextChanged(object sender, EventArgs e)
        {
            dtgv.DataSource = XemDL($"select * from tb_GV1 where LoaiGV like N'%{txtLoaiGV.Text.ToString().Trim()}%'");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtHoTen.Clear();
            txtTenHocVi.Clear();
            txtTenHocHam.Clear();
            txtTenKhoa.Clear();
            txtLoaiGV.Clear();
            cls.loaddatagridview(dtgv, "select * from tb_GV1");
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdGioday_CheckedChanged(object sender, EventArgs e)
        {
              dtgv.DataSource = XemDL("SELECT *FROM dbo.tb_GV1 Where TongSoTH = (SELECT MAX(TongSoTH) from dbo.tb_GV1); ");
        }

        private void rdLT_CheckedChanged(object sender, EventArgs e)
        {
            dtgv.DataSource = XemDL("SELECT *FROM dbo.tb_GV1 Where TongSoLT = (SELECT MAX(TongSoLT) from dbo.tb_GV1); ");
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

        private void txtTenHocVi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtTenHocHam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtTenKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtLoaiGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }
    }
}

