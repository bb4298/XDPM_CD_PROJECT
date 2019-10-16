namespace UI.Form_ChucNang
{
    partial class Form_QuanLyKhoDia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyKhoDia));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelQuanLyTD = new System.Windows.Forms.Panel();
            this.panelThemDia = new System.Windows.Forms.Panel();
            this.cbbThem_TenTieuDe = new System.Windows.Forms.ComboBox();
            this.tbThem_IdTieuDe = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.tbThem_IdDia = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDanhMuc = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTrangThai = new DevExpress.XtraEditors.TextEdit();
            this.tbNguoiMuon = new DevExpress.XtraEditors.TextEdit();
            this.tbTenTieuDe = new DevExpress.XtraEditors.TextEdit();
            this.tbIdDia = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelThaoTac = new System.Windows.Forms.Panel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewD = new System.Windows.Forms.DataGridView();
            this.IdDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbTK_NV = new System.Windows.Forms.ComboBox();
            this.tbTimKiemNV = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewTD = new System.Windows.Forms.DataGridView();
            this.IdTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panelQuanLyTD.SuspendLayout();
            this.panelThemDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbThem_IdTieuDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThem_IdDia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNguoiMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTieuDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdDia.Properties)).BeginInit();
            this.panelThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.panelQuanLyTD);
            this.groupControl1.Location = new System.Drawing.Point(5, 6);
            this.groupControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(456, 269);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông Tin Đĩa";
            // 
            // panelQuanLyTD
            // 
            this.panelQuanLyTD.Controls.Add(this.panelThemDia);
            this.panelQuanLyTD.Controls.Add(this.tbDanhMuc);
            this.panelQuanLyTD.Controls.Add(this.label1);
            this.panelQuanLyTD.Controls.Add(this.tbTrangThai);
            this.panelQuanLyTD.Controls.Add(this.tbNguoiMuon);
            this.panelQuanLyTD.Controls.Add(this.tbTenTieuDe);
            this.panelQuanLyTD.Controls.Add(this.tbIdDia);
            this.panelQuanLyTD.Controls.Add(this.label4);
            this.panelQuanLyTD.Controls.Add(this.label3);
            this.panelQuanLyTD.Controls.Add(this.label2);
            this.panelQuanLyTD.Controls.Add(this.label8);
            this.panelQuanLyTD.Enabled = false;
            this.panelQuanLyTD.Location = new System.Drawing.Point(7, 35);
            this.panelQuanLyTD.Name = "panelQuanLyTD";
            this.panelQuanLyTD.Size = new System.Drawing.Size(442, 229);
            this.panelQuanLyTD.TabIndex = 53;
            // 
            // panelThemDia
            // 
            this.panelThemDia.Controls.Add(this.cbbThem_TenTieuDe);
            this.panelThemDia.Controls.Add(this.tbThem_IdTieuDe);
            this.panelThemDia.Controls.Add(this.label5);
            this.panelThemDia.Controls.Add(this.tbThem_IdDia);
            this.panelThemDia.Controls.Add(this.label7);
            this.panelThemDia.Controls.Add(this.label9);
            this.panelThemDia.Location = new System.Drawing.Point(0, 0);
            this.panelThemDia.Name = "panelThemDia";
            this.panelThemDia.Size = new System.Drawing.Size(442, 229);
            this.panelThemDia.TabIndex = 63;
            // 
            // cbbThem_TenTieuDe
            // 
            this.cbbThem_TenTieuDe.FormattingEnabled = true;
            this.cbbThem_TenTieuDe.Items.AddRange(new object[] {
            "Theo Tên NV",
            "Theo Mã NV",
            "Theo SDT"});
            this.cbbThem_TenTieuDe.Location = new System.Drawing.Point(108, 151);
            this.cbbThem_TenTieuDe.Name = "cbbThem_TenTieuDe";
            this.cbbThem_TenTieuDe.Size = new System.Drawing.Size(322, 24);
            this.cbbThem_TenTieuDe.TabIndex = 40;
            this.cbbThem_TenTieuDe.SelectedIndexChanged += new System.EventHandler(this.cbbThem_TenTieuDe_SelectedIndexChanged);
            // 
            // tbThem_IdTieuDe
            // 
            this.tbThem_IdTieuDe.Location = new System.Drawing.Point(108, 102);
            this.tbThem_IdTieuDe.Name = "tbThem_IdTieuDe";
            this.tbThem_IdTieuDe.Size = new System.Drawing.Size(322, 22);
            this.tbThem_IdTieuDe.TabIndex = 55;
            this.tbThem_IdTieuDe.EditValueChanged += new System.EventHandler(this.tbThem_IdTieuDe_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tên Tiêu Đề:";
            // 
            // tbThem_IdDia
            // 
            this.tbThem_IdDia.Location = new System.Drawing.Point(108, 59);
            this.tbThem_IdDia.Name = "tbThem_IdDia";
            this.tbThem_IdDia.Size = new System.Drawing.Size(322, 22);
            this.tbThem_IdDia.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(7, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID Tiêu Đề:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(46, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "ID Đĩa:";
            // 
            // tbDanhMuc
            // 
            this.tbDanhMuc.Location = new System.Drawing.Point(108, 18);
            this.tbDanhMuc.Name = "tbDanhMuc";
            this.tbDanhMuc.Size = new System.Drawing.Size(322, 22);
            this.tbDanhMuc.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Danh Mục:";
            // 
            // tbTrangThai
            // 
            this.tbTrangThai.Location = new System.Drawing.Point(108, 137);
            this.tbTrangThai.Name = "tbTrangThai";
            this.tbTrangThai.Size = new System.Drawing.Size(322, 22);
            this.tbTrangThai.TabIndex = 60;
            // 
            // tbNguoiMuon
            // 
            this.tbNguoiMuon.Location = new System.Drawing.Point(108, 178);
            this.tbNguoiMuon.Name = "tbNguoiMuon";
            this.tbNguoiMuon.Size = new System.Drawing.Size(322, 22);
            this.tbNguoiMuon.TabIndex = 59;
            // 
            // tbTenTieuDe
            // 
            this.tbTenTieuDe.Location = new System.Drawing.Point(108, 100);
            this.tbTenTieuDe.Name = "tbTenTieuDe";
            this.tbTenTieuDe.Size = new System.Drawing.Size(322, 22);
            this.tbTenTieuDe.TabIndex = 52;
            // 
            // tbIdDia
            // 
            this.tbIdDia.Location = new System.Drawing.Point(108, 59);
            this.tbIdDia.Name = "tbIdDia";
            this.tbIdDia.Size = new System.Drawing.Size(322, 22);
            this.tbIdDia.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(2, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Người mượn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Tiêu Đề:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Đĩa:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(15, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Trạng Thái:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panelThaoTac
            // 
            this.panelThaoTac.Controls.Add(this.btnThem);
            this.panelThaoTac.Controls.Add(this.btnHuy);
            this.panelThaoTac.Controls.Add(this.btnXoa);
            this.panelThaoTac.Controls.Add(this.btnLuu);
            this.panelThaoTac.Location = new System.Drawing.Point(14, 29);
            this.panelThaoTac.Name = "panelThaoTac";
            this.panelThaoTac.Size = new System.Drawing.Size(435, 224);
            this.panelThaoTac.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(20, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 48);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(20, 91);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(168, 48);
            this.btnHuy.TabIndex = 59;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(230, 18);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(168, 48);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(230, 91);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(168, 48);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridViewD
            // 
            this.dataGridViewD.AllowUserToAddRows = false;
            this.dataGridViewD.AllowUserToDeleteRows = false;
            this.dataGridViewD.AllowUserToResizeRows = false;
            this.dataGridViewD.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDia,
            this.TrangThai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewD.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewD.Location = new System.Drawing.Point(947, 115);
            this.dataGridViewD.MultiSelect = false;
            this.dataGridViewD.Name = "dataGridViewD";
            this.dataGridViewD.ReadOnly = true;
            this.dataGridViewD.RowHeadersVisible = false;
            this.dataGridViewD.RowTemplate.Height = 24;
            this.dataGridViewD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewD.Size = new System.Drawing.Size(406, 427);
            this.dataGridViewD.TabIndex = 8;
            this.dataGridViewD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewD_CellClick);
            this.dataGridViewD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewD_CellContentClick);
            this.dataGridViewD.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewD_CellFormatting);
            // 
            // IdDia
            // 
            this.IdDia.DataPropertyName = "IdDia";
            this.IdDia.HeaderText = "ID Đĩa";
            this.IdDia.Name = "IdDia";
            this.IdDia.ReadOnly = true;
            this.IdDia.Width = 110;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // cbbTK_NV
            // 
            this.cbbTK_NV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTK_NV.FormattingEnabled = true;
            this.cbbTK_NV.Items.AddRange(new object[] {
            "Theo Tên NV",
            "Theo Mã NV",
            "Theo SDT"});
            this.cbbTK_NV.Location = new System.Drawing.Point(26, 35);
            this.cbbTK_NV.Name = "cbbTK_NV";
            this.cbbTK_NV.Size = new System.Drawing.Size(236, 24);
            this.cbbTK_NV.TabIndex = 39;
            // 
            // tbTimKiemNV
            // 
            this.tbTimKiemNV.Location = new System.Drawing.Point(26, 65);
            this.tbTimKiemNV.Name = "tbTimKiemNV";
            this.tbTimKiemNV.Size = new System.Drawing.Size(236, 23);
            this.tbTimKiemNV.TabIndex = 38;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl2.Controls.Add(this.tbTimKiemNV);
            this.groupControl2.Controls.Add(this.cbbTK_NV);
            this.groupControl2.Location = new System.Drawing.Point(1066, 6);
            this.groupControl2.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(287, 103);
            this.groupControl2.TabIndex = 54;
            this.groupControl2.Text = "                       Tìm Kiếm Đĩa";
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl3.Controls.Add(this.panelThaoTac);
            this.groupControl3.Location = new System.Drawing.Point(5, 281);
            this.groupControl3.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(456, 261);
            this.groupControl3.TabIndex = 54;
            this.groupControl3.Text = "Thao Tác";
            // 
            // dataGridViewTD
            // 
            this.dataGridViewTD.AllowUserToAddRows = false;
            this.dataGridViewTD.AllowUserToDeleteRows = false;
            this.dataGridViewTD.AllowUserToResizeRows = false;
            this.dataGridViewTD.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTieuDe,
            this.tenTieuDe,
            this.TenDanhMuc,
            this.SoLuongDia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTD.Location = new System.Drawing.Point(467, 115);
            this.dataGridViewTD.MultiSelect = false;
            this.dataGridViewTD.Name = "dataGridViewTD";
            this.dataGridViewTD.ReadOnly = true;
            this.dataGridViewTD.RowHeadersVisible = false;
            this.dataGridViewTD.RowTemplate.Height = 24;
            this.dataGridViewTD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTD.Size = new System.Drawing.Size(474, 427);
            this.dataGridViewTD.TabIndex = 55;
            this.dataGridViewTD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTD_CellClick);
            this.dataGridViewTD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTD_CellContentClick);
            // 
            // IdTieuDe
            // 
            this.IdTieuDe.DataPropertyName = "IdTieuDe";
            this.IdTieuDe.FillWeight = 70F;
            this.IdTieuDe.HeaderText = "ID Tiêu Đề";
            this.IdTieuDe.Name = "IdTieuDe";
            this.IdTieuDe.ReadOnly = true;
            this.IdTieuDe.Width = 110;
            // 
            // tenTieuDe
            // 
            this.tenTieuDe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenTieuDe.DataPropertyName = "TenTieuDe";
            this.tenTieuDe.HeaderText = "Tên Tiêu Đề";
            this.tenTieuDe.Name = "tenTieuDe";
            this.tenTieuDe.ReadOnly = true;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc.HeaderText = "Danh Mục";
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.ReadOnly = true;
            // 
            // SoLuongDia
            // 
            this.SoLuongDia.DataPropertyName = "SoLuongDia";
            this.SoLuongDia.HeaderText = "Số Lượng";
            this.SoLuongDia.Name = "SoLuongDia";
            this.SoLuongDia.ReadOnly = true;
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl4.Appearance.Options.UseBackColor = true;
            this.groupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl4.Controls.Add(this.textBox1);
            this.groupControl4.Controls.Add(this.comboBox3);
            this.groupControl4.Location = new System.Drawing.Point(467, 6);
            this.groupControl4.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(593, 103);
            this.groupControl4.TabIndex = 55;
            this.groupControl4.Text = "                       Tìm Kiếm Tiêu Đề";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(550, 23);
            this.textBox1.TabIndex = 38;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Theo Tên NV",
            "Theo Mã NV",
            "Theo SDT"});
            this.comboBox3.Location = new System.Drawing.Point(17, 35);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(550, 24);
            this.comboBox3.TabIndex = 39;
            // 
            // Form_QuanLyKhoDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 546);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.dataGridViewTD);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridViewD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_QuanLyKhoDia";
            this.Text = "Quản Lý Kho Đĩa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_QuanLyKhoDia_FormClosed);
            this.Load += new System.EventHandler(this.Form_QuanLyKhoDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panelQuanLyTD.ResumeLayout(false);
            this.panelQuanLyTD.PerformLayout();
            this.panelThemDia.ResumeLayout(false);
            this.panelThemDia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbThem_IdTieuDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThem_IdDia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNguoiMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTieuDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdDia.Properties)).EndInit();
            this.panelThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panelQuanLyTD;
        private DevExpress.XtraEditors.TextEdit tbNguoiMuon;
        private DevExpress.XtraEditors.TextEdit tbTenTieuDe;
        private DevExpress.XtraEditors.TextEdit tbIdDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.DataGridView dataGridViewD;
        private System.Windows.Forms.ComboBox cbbTK_NV;
        private System.Windows.Forms.TextBox tbTimKiemNV;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dataGridViewTD;
        private DevExpress.XtraEditors.TextEdit tbTrangThai;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private DevExpress.XtraEditors.TextEdit tbDanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelThemDia;
        private DevExpress.XtraEditors.TextEdit tbThem_IdDia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbThem_TenTieuDe;
        private DevExpress.XtraEditors.TextEdit tbThem_IdTieuDe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDia;
    }
}