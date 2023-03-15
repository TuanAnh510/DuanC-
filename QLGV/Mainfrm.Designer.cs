namespace QLGV
{
    partial class Mainfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_quyen = new DevExpress.XtraEditors.LabelControl();
            this.lb_taikhoan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mntTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mntQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mntKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mntGV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnthv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnthh = new System.Windows.Forms.ToolStripMenuItem();
            this.mntdt = new System.Windows.Forms.ToolStripMenuItem();
            this.mntMh = new System.Windows.Forms.ToolStripMenuItem();
            this.mntHp = new System.Windows.Forms.ToolStripMenuItem();
            this.mntTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mntTTGV = new System.Windows.Forms.ToolStripMenuItem();
            this.mntThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mntTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mntTH = new System.Windows.Forms.ToolStripMenuItem();
            this.mntGD = new System.Windows.Forms.ToolStripMenuItem();
            this.mntTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mntMail = new System.Windows.Forms.ToolStripMenuItem();
            this.mntPm = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.guna2NotificationPaint2 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_quyen);
            this.panel1.Controls.Add(this.lb_taikhoan);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_quyen
            // 
            this.lb_quyen.Location = new System.Drawing.Point(213, 13);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(0, 16);
            this.lb_quyen.TabIndex = 6;
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.Location = new System.Drawing.Point(72, 13);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(0, 16);
            this.lb_taikhoan.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(161, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 17);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Quyền:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Xin chào:";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(177, 2);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1071, 28);
            this.miniToolStrip.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 492);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.BackgroundImage = global::QLGV.Properties.Resources._2;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 28);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1093, 464);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImage = global::QLGV.Properties.Resources._1;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(140, 119);
            this.guna2Panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntTaiKhoan,
            this.mntDanhMuc,
            this.mntTimkiem,
            this.mntThongke,
            this.mntTrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mntTaiKhoan
            // 
            this.mntTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntDangNhap,
            this.mntDoiMatKhau,
            this.mntQuanLyTaiKhoan,
            this.mntDangXuat});
            this.mntTaiKhoan.Image = global::QLGV.Properties.Resources.icons8_home_32;
            this.mntTaiKhoan.Name = "mntTaiKhoan";
            this.mntTaiKhoan.Size = new System.Drawing.Size(103, 24);
            this.mntTaiKhoan.Text = "Tài khoản";
            // 
            // mntDangNhap
            // 
            this.mntDangNhap.Image = global::QLGV.Properties.Resources.icons8_login_321;
            this.mntDangNhap.Name = "mntDangNhap";
            this.mntDangNhap.Size = new System.Drawing.Size(199, 26);
            this.mntDangNhap.Text = "Đăng nhập";
            this.mntDangNhap.Click += new System.EventHandler(this.mntDangNhap_Click);
            // 
            // mntDoiMatKhau
            // 
            this.mntDoiMatKhau.Image = global::QLGV.Properties.Resources.icons8_user_shield_32;
            this.mntDoiMatKhau.Name = "mntDoiMatKhau";
            this.mntDoiMatKhau.Size = new System.Drawing.Size(199, 26);
            this.mntDoiMatKhau.Text = "Đổi mật khẩu";
            this.mntDoiMatKhau.Click += new System.EventHandler(this.mntDoiMatKhau_Click);
            // 
            // mntQuanLyTaiKhoan
            // 
            this.mntQuanLyTaiKhoan.Image = global::QLGV.Properties.Resources.icons8_user_32;
            this.mntQuanLyTaiKhoan.Name = "mntQuanLyTaiKhoan";
            this.mntQuanLyTaiKhoan.Size = new System.Drawing.Size(199, 26);
            this.mntQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.mntQuanLyTaiKhoan.Click += new System.EventHandler(this.mntQuanLyTaiKhoan_Click);
            // 
            // mntDangXuat
            // 
            this.mntDangXuat.Image = global::QLGV.Properties.Resources.icons8_shutdown_32;
            this.mntDangXuat.Name = "mntDangXuat";
            this.mntDangXuat.Size = new System.Drawing.Size(199, 26);
            this.mntDangXuat.Text = "Đăng xuất";
            this.mntDangXuat.Click += new System.EventHandler(this.mntDangXuat_Click);
            // 
            // mntDanhMuc
            // 
            this.mntDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntKhoa,
            this.mntGV,
            this.mnthv,
            this.mnthh,
            this.mntdt,
            this.mntMh,
            this.mntHp});
            this.mntDanhMuc.Image = global::QLGV.Properties.Resources.agt_update_product;
            this.mntDanhMuc.Name = "mntDanhMuc";
            this.mntDanhMuc.Size = new System.Drawing.Size(108, 24);
            this.mntDanhMuc.Text = "Danh mục";
            // 
            // mntKhoa
            // 
            this.mntKhoa.Image = global::QLGV.Properties.Resources.settings_512px;
            this.mntKhoa.Name = "mntKhoa";
            this.mntKhoa.Size = new System.Drawing.Size(219, 26);
            this.mntKhoa.Text = "Quản lý khoa";
            this.mntKhoa.Click += new System.EventHandler(this.mntKhoa_Click_1);
            // 
            // mntGV
            // 
            this.mntGV.Image = global::QLGV.Properties.Resources.settings_512px;
            this.mntGV.Name = "mntGV";
            this.mntGV.Size = new System.Drawing.Size(219, 26);
            this.mntGV.Text = "Quản lý giáo viên";
            this.mntGV.Click += new System.EventHandler(this.mntGV_Click);
            // 
            // mnthv
            // 
            this.mnthv.Image = global::QLGV.Properties.Resources.settings_512px;
            this.mnthv.Name = "mnthv";
            this.mnthv.Size = new System.Drawing.Size(219, 26);
            this.mnthv.Text = "Quản lý học vị";
            this.mnthv.Click += new System.EventHandler(this.mnthv_Click);
            // 
            // mnthh
            // 
            this.mnthh.Image = global::QLGV.Properties.Resources.settings_512px;
            this.mnthh.Name = "mnthh";
            this.mnthh.Size = new System.Drawing.Size(219, 26);
            this.mnthh.Text = "Quản lý học hàm";
            this.mnthh.Click += new System.EventHandler(this.mnthh_Click_1);
            // 
            // mntdt
            // 
            this.mntdt.Image = global::QLGV.Properties.Resources.settings_512px;
            this.mntdt.Name = "mntdt";
            this.mntdt.Size = new System.Drawing.Size(219, 26);
            this.mntdt.Text = "Quản lý nơi đào tạo ";
            this.mntdt.Click += new System.EventHandler(this.mntdt_Click);
            // 
            // mntMh
            // 
            this.mntMh.Image = global::QLGV.Properties.Resources.settings_512px;
            this.mntMh.Name = "mntMh";
            this.mntMh.Size = new System.Drawing.Size(219, 26);
            this.mntMh.Text = "Quản lý môn học ";
            this.mntMh.Click += new System.EventHandler(this.mntMh_Click);
            // 
            // mntHp
            // 
            this.mntHp.Image = global::QLGV.Properties.Resources.settings_512px;
            this.mntHp.Name = "mntHp";
            this.mntHp.Size = new System.Drawing.Size(219, 26);
            this.mntHp.Text = "Quản lý học phần";
            this.mntHp.Click += new System.EventHandler(this.mntHp_Click);
            // 
            // mntTimkiem
            // 
            this.mntTimkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntTTGV});
            this.mntTimkiem.Image = global::QLGV.Properties.Resources.find__1_;
            this.mntTimkiem.Name = "mntTimkiem";
            this.mntTimkiem.Size = new System.Drawing.Size(166, 24);
            this.mntTimkiem.Text = "Tìm kiếm thông tin";
            // 
            // mntTTGV
            // 
            this.mntTTGV.Image = global::QLGV.Properties.Resources.find__1_;
            this.mntTTGV.Name = "mntTTGV";
            this.mntTTGV.Size = new System.Drawing.Size(274, 26);
            this.mntTTGV.Text = "Tìm kiếm thông tin giáo viên";
            this.mntTTGV.Click += new System.EventHandler(this.mntTTGV_Click);
            // 
            // mntThongke
            // 
            this.mntThongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntTK,
            this.mntTH,
            this.mntGD});
            this.mntThongke.Image = global::QLGV.Properties.Resources.sort_ascend;
            this.mntThongke.Name = "mntThongke";
            this.mntThongke.Size = new System.Drawing.Size(102, 24);
            this.mntThongke.Text = "Thống kê";
            // 
            // mntTK
            // 
            this.mntTK.Image = global::QLGV.Properties.Resources.icons8_print_32;
            this.mntTK.Name = "mntTK";
            this.mntTK.Size = new System.Drawing.Size(260, 26);
            this.mntTK.Text = "Thống kê giáo viên ";
            this.mntTK.Click += new System.EventHandler(this.mntTK_Click);
            // 
            // mntTH
            // 
            this.mntTH.Image = global::QLGV.Properties.Resources.icons8_print_32;
            this.mntTH.Name = "mntTH";
            this.mntTH.Size = new System.Drawing.Size(260, 26);
            this.mntTH.Text = "Tổng hợp giáo viên";
            this.mntTH.Click += new System.EventHandler(this.mntTH_Click);
            // 
            // mntGD
            // 
            this.mntGD.Image = global::QLGV.Properties.Resources.icons8_print_32;
            this.mntGD.Name = "mntGD";
            this.mntGD.Size = new System.Drawing.Size(260, 26);
            this.mntGD.Text = "Thống kê giờ dạy lí thuyết ";
            this.mntGD.Click += new System.EventHandler(this.mntGD_Click);
            // 
            // mntTrogiup
            // 
            this.mntTrogiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntMail,
            this.mntPm});
            this.mntTrogiup.Image = global::QLGV.Properties.Resources._741;
            this.mntTrogiup.Name = "mntTrogiup";
            this.mntTrogiup.Size = new System.Drawing.Size(97, 24);
            this.mntTrogiup.Text = "Trợ Giúp";
            // 
            // mntMail
            // 
            this.mntMail.Image = global::QLGV.Properties.Resources.gmail_logo_512px;
            this.mntMail.Name = "mntMail";
            this.mntMail.Size = new System.Drawing.Size(222, 26);
            this.mntMail.Text = "Gửi Mail";
            this.mntMail.Click += new System.EventHandler(this.mntMail_Click);
            // 
            // mntPm
            // 
            this.mntPm.Image = global::QLGV.Properties.Resources.gnome_preferences_system;
            this.mntPm.Name = "mntPm";
            this.mntPm.Size = new System.Drawing.Size(222, 26);
            this.mntPm.Text = "Thông tin phần mềm";
            this.mntPm.Click += new System.EventHandler(this.mntPm_Click);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mainfrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lb_quyen;
        private DevExpress.XtraEditors.LabelControl lb_taikhoan;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem mntTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mntDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mntDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mntQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mntDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mntDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mntKhoa;
        private System.Windows.Forms.ToolStripMenuItem mntGV;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.ToolStripMenuItem mntTimkiem;
        private System.Windows.Forms.ToolStripMenuItem mntTTGV;
        private System.Windows.Forms.ToolStripMenuItem mnthv;
        private System.Windows.Forms.ToolStripMenuItem mnthh;
        private System.Windows.Forms.ToolStripMenuItem mntdt;
        private System.Windows.Forms.ToolStripMenuItem mntMh;
        private System.Windows.Forms.ToolStripMenuItem mntHp;
        private System.Windows.Forms.ToolStripMenuItem mntThongke;
        private System.Windows.Forms.ToolStripMenuItem mntTrogiup;
        private System.Windows.Forms.ToolStripMenuItem mntMail;
        private System.Windows.Forms.ToolStripMenuItem mntTK;
        private System.Windows.Forms.ToolStripMenuItem mntPm;
        private System.Windows.Forms.ToolStripMenuItem mntTH;
        private System.Windows.Forms.ToolStripMenuItem mntGD;
    }
}

