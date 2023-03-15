namespace QLGV
{
    partial class frmMH
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongSoLT = new System.Windows.Forms.TextBox();
            this.cboChiLT = new System.Windows.Forms.ComboBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.cboMaHocPhan = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongSoTH = new System.Windows.Forms.TextBox();
            this.cboChiTH = new System.Windows.Forms.ComboBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btnTinhTC = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btnHuy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThoat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(35, 233);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 17);
            this.labelControl5.TabIndex = 250;
            this.labelControl5.Text = "Tổng số chỉ LT:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(59, 190);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 17);
            this.labelControl4.TabIndex = 249;
            this.labelControl4.Text = "Chỉ LT:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(59, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 16);
            this.labelControl3.TabIndex = 248;
            this.labelControl3.Text = "Tên Môn:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 16);
            this.labelControl2.TabIndex = 247;
            this.labelControl2.Text = "Mã Môn:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(59, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 16);
            this.labelControl1.TabIndex = 246;
            this.labelControl1.Text = "Mã HP:";
            // 
            // txtTongSoLT
            // 
            this.txtTongSoLT.Enabled = false;
            this.txtTongSoLT.Location = new System.Drawing.Point(137, 227);
            this.txtTongSoLT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongSoLT.Name = "txtTongSoLT";
            this.txtTongSoLT.ReadOnly = true;
            this.txtTongSoLT.Size = new System.Drawing.Size(169, 23);
            this.txtTongSoLT.TabIndex = 245;
            // 
            // cboChiLT
            // 
            this.cboChiLT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChiLT.FormattingEnabled = true;
            this.cboChiLT.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cboChiLT.Location = new System.Drawing.Point(135, 183);
            this.cboChiLT.Margin = new System.Windows.Forms.Padding(4);
            this.cboChiLT.Name = "cboChiLT";
            this.cboChiLT.Size = new System.Drawing.Size(169, 24);
            this.cboChiLT.TabIndex = 244;
            this.cboChiLT.SelectedIndexChanged += new System.EventHandler(this.cboChiLT_SelectedIndexChanged);
            // 
            // txtTenMon
            // 
            this.txtTenMon.Enabled = false;
            this.txtTenMon.Location = new System.Drawing.Point(135, 138);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(169, 23);
            this.txtTenMon.TabIndex = 243;
            this.txtTenMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenMon_KeyPress);
            // 
            // txtMaMon
            // 
            this.txtMaMon.Enabled = false;
            this.txtMaMon.Location = new System.Drawing.Point(135, 95);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(169, 23);
            this.txtMaMon.TabIndex = 242;
            this.txtMaMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaMon_KeyPress);
            // 
            // cboMaHocPhan
            // 
            this.cboMaHocPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaHocPhan.FormattingEnabled = true;
            this.cboMaHocPhan.Location = new System.Drawing.Point(137, 49);
            this.cboMaHocPhan.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaHocPhan.Name = "cboMaHocPhan";
            this.cboMaHocPhan.Size = new System.Drawing.Size(169, 24);
            this.cboMaHocPhan.TabIndex = 241;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(342, 148);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(103, 17);
            this.labelControl8.TabIndex = 256;
            this.labelControl8.Text = "Tổng số chỉ dạy:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(342, 106);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(97, 17);
            this.labelControl7.TabIndex = 255;
            this.labelControl7.Text = "Tổng số chỉ TH:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(346, 56);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 17);
            this.labelControl6.TabIndex = 254;
            this.labelControl6.Text = "Chỉ TH:";
            // 
            // txtTongSoTH
            // 
            this.txtTongSoTH.Enabled = false;
            this.txtTongSoTH.Location = new System.Drawing.Point(454, 99);
            this.txtTongSoTH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongSoTH.Name = "txtTongSoTH";
            this.txtTongSoTH.ReadOnly = true;
            this.txtTongSoTH.Size = new System.Drawing.Size(169, 23);
            this.txtTongSoTH.TabIndex = 253;
            // 
            // cboChiTH
            // 
            this.cboChiTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChiTH.FormattingEnabled = true;
            this.cboChiTH.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cboChiTH.Location = new System.Drawing.Point(454, 49);
            this.cboChiTH.Margin = new System.Windows.Forms.Padding(4);
            this.cboChiTH.Name = "cboChiTH";
            this.cboChiTH.Size = new System.Drawing.Size(169, 24);
            this.cboChiTH.TabIndex = 252;
            this.cboChiTH.SelectedIndexChanged += new System.EventHandler(this.cboChiTH_SelectedIndexChanged);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(454, 142);
            this.txtTong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(169, 23);
            this.txtTong.TabIndex = 251;
            // 
            // btnTinhTC
            // 
            this.btnTinhTC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhTC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTinhTC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTinhTC.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTinhTC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTinhTC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTinhTC.ForeColor = System.Drawing.Color.White;
            this.btnTinhTC.Location = new System.Drawing.Point(454, 190);
            this.btnTinhTC.Name = "btnTinhTC";
            this.btnTinhTC.Size = new System.Drawing.Size(120, 40);
            this.btnTinhTC.TabIndex = 264;
            this.btnTinhTC.Text = "Tinh";
            this.btnTinhTC.Click += new System.EventHandler(this.btnTinhTC_Click);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(646, 49);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(454, 273);
            this.dtgv.TabIndex = 263;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // btnHuy
            // 
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(269, 339);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 262;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(59, 339);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.TabIndex = 261;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(475, 339);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 40);
            this.btnThoat.TabIndex = 260;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(475, 282);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 259;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(269, 282);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 258;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(59, 282);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 257;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmMH
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 503);
            this.Controls.Add(this.btnTinhTC);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtTongSoTH);
            this.Controls.Add(this.cboChiTH);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTongSoLT);
            this.Controls.Add(this.cboChiLT);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.cboMaHocPhan);
            this.Name = "frmMH";
            this.Text = "frmMH";
            this.Load += new System.EventHandler(this.frmMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtTongSoLT;
        private System.Windows.Forms.ComboBox cboChiLT;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.ComboBox cboMaHocPhan;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtTongSoTH;
        private System.Windows.Forms.ComboBox cboChiTH;
        private System.Windows.Forms.TextBox txtTong;
        private Guna.UI2.WinForms.Guna2GradientButton btnTinhTC;
        private System.Windows.Forms.DataGridView dtgv;
        private Guna.UI2.WinForms.Guna2GradientButton btnHuy;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnThoat;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
    }
}