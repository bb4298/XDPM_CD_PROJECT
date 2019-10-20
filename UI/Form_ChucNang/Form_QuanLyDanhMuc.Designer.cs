namespace UI.Form_ChucNang
{
    partial class Form_QuanLyDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyDanhMuc));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelQuanLyDM = new System.Windows.Forms.Panel();
            this.tbPhiTreHan = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhiThue = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdDanhMuc = new DevExpress.XtraEditors.TextEdit();
            this.tbTenDanhMuc = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelThaoTac = new System.Windows.Forms.Panel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiTreHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tbTimKiemNV = new System.Windows.Forms.TextBox();
            this.cbbTK_NV = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panelQuanLyDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhiTreHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhiThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenDanhMuc.Properties)).BeginInit();
            this.panelThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.panelQuanLyDM);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(608, 266);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông Tin Danh Mục";
            // 
            // panelQuanLyDM
            // 
            this.panelQuanLyDM.Controls.Add(this.tbPhiTreHan);
            this.panelQuanLyDM.Controls.Add(this.label4);
            this.panelQuanLyDM.Controls.Add(this.tbPhiThue);
            this.panelQuanLyDM.Controls.Add(this.label5);
            this.panelQuanLyDM.Controls.Add(this.tbIdDanhMuc);
            this.panelQuanLyDM.Controls.Add(this.tbTenDanhMuc);
            this.panelQuanLyDM.Controls.Add(this.label1);
            this.panelQuanLyDM.Controls.Add(this.label2);
            this.panelQuanLyDM.Enabled = false;
            this.panelQuanLyDM.Location = new System.Drawing.Point(25, 44);
            this.panelQuanLyDM.Name = "panelQuanLyDM";
            this.panelQuanLyDM.Size = new System.Drawing.Size(498, 189);
            this.panelQuanLyDM.TabIndex = 53;
            // 
            // tbPhiTreHan
            // 
            this.tbPhiTreHan.Location = new System.Drawing.Point(194, 143);
            this.tbPhiTreHan.Name = "tbPhiTreHan";
            this.tbPhiTreHan.Size = new System.Drawing.Size(292, 22);
            this.tbPhiTreHan.TabIndex = 1002;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 1003;
            this.label4.Text = "Phí Trễ Hạn (1 ngày):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbPhiThue
            // 
            this.tbPhiThue.Location = new System.Drawing.Point(194, 102);
            this.tbPhiThue.Name = "tbPhiThue";
            this.tbPhiThue.Size = new System.Drawing.Size(292, 22);
            this.tbPhiThue.TabIndex = 1000;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(52, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 1001;
            this.label5.Text = "Phí Thuê (1 ngày):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbIdDanhMuc
            // 
            this.tbIdDanhMuc.Enabled = false;
            this.tbIdDanhMuc.Location = new System.Drawing.Point(194, 21);
            this.tbIdDanhMuc.Name = "tbIdDanhMuc";
            this.tbIdDanhMuc.Size = new System.Drawing.Size(292, 22);
            this.tbIdDanhMuc.TabIndex = 999;
            // 
            // tbTenDanhMuc
            // 
            this.tbTenDanhMuc.Enabled = false;
            this.tbTenDanhMuc.Location = new System.Drawing.Point(194, 60);
            this.tbTenDanhMuc.Name = "tbTenDanhMuc";
            this.tbTenDanhMuc.Size = new System.Drawing.Size(292, 22);
            this.tbTenDanhMuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(76, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Danh mục:";
            this.label1.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(85, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Danh mục:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelThaoTac
            // 
            this.panelThaoTac.Controls.Add(this.btnThem);
            this.panelThaoTac.Controls.Add(this.btnHuy);
            this.panelThaoTac.Controls.Add(this.btnSua);
            this.panelThaoTac.Controls.Add(this.btnLuu);
            this.panelThaoTac.Location = new System.Drawing.Point(9, 29);
            this.panelThaoTac.Name = "panelThaoTac";
            this.panelThaoTac.Size = new System.Drawing.Size(594, 230);
            this.panelThaoTac.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(51, 69);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 87);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(441, 69);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 87);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(185, 69);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 87);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(314, 69);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 87);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDanhMuc,
            this.TenDanhMuc,
            this.PhiThue,
            this.PhiTreHan});
            this.dataGridView1.Location = new System.Drawing.Point(617, 129);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(734, 412);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdDanhMuc
            // 
            this.IdDanhMuc.DataPropertyName = "IdDanhMuc";
            this.IdDanhMuc.FillWeight = 189.6907F;
            this.IdDanhMuc.HeaderText = "ID Danh Mục";
            this.IdDanhMuc.Name = "IdDanhMuc";
            this.IdDanhMuc.ReadOnly = true;
            this.IdDanhMuc.Width = 120;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc.FillWeight = 10.30928F;
            this.TenDanhMuc.HeaderText = "Tên Danh Mục";
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.ReadOnly = true;
            this.TenDanhMuc.Width = 240;
            // 
            // PhiThue
            // 
            this.PhiThue.DataPropertyName = "PhiThue";
            this.PhiThue.HeaderText = "Phí Thuê";
            this.PhiThue.Name = "PhiThue";
            this.PhiThue.ReadOnly = true;
            this.PhiThue.Width = 180;
            // 
            // PhiTreHan
            // 
            this.PhiTreHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhiTreHan.DataPropertyName = "PhiTreHan";
            this.PhiTreHan.HeaderText = "Phí Trễ Hạn";
            this.PhiTreHan.Name = "PhiTreHan";
            this.PhiTreHan.ReadOnly = true;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl3.Controls.Add(this.tbTimKiemNV);
            this.groupControl3.Controls.Add(this.cbbTK_NV);
            this.groupControl3.Location = new System.Drawing.Point(617, 3);
            this.groupControl3.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(734, 120);
            this.groupControl3.TabIndex = 59;
            this.groupControl3.Text = "                       Tìm Kiếm";
            // 
            // tbTimKiemNV
            // 
            this.tbTimKiemNV.Location = new System.Drawing.Point(26, 77);
            this.tbTimKiemNV.Name = "tbTimKiemNV";
            this.tbTimKiemNV.Size = new System.Drawing.Size(549, 23);
            this.tbTimKiemNV.TabIndex = 8;
            // 
            // cbbTK_NV
            // 
            this.cbbTK_NV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTK_NV.FormattingEnabled = true;
            this.cbbTK_NV.Items.AddRange(new object[] {
            "Theo Tên NV",
            "Theo Mã NV",
            "Theo SDT"});
            this.cbbTK_NV.Location = new System.Drawing.Point(26, 44);
            this.cbbTK_NV.Name = "cbbTK_NV";
            this.cbbTK_NV.Size = new System.Drawing.Size(549, 24);
            this.cbbTK_NV.TabIndex = 7;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl2.Controls.Add(this.panelThaoTac);
            this.groupControl2.Location = new System.Drawing.Point(3, 275);
            this.groupControl2.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(608, 266);
            this.groupControl2.TabIndex = 54;
            this.groupControl2.Text = "Thao Tác";
            // 
            // Form_QuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 546);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_QuanLyDanhMuc";
            this.Text = "Quản Lý Danh Mục";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_QuanLyDanhMuc_FormClosed);
            this.Load += new System.EventHandler(this.Form_QuanLyDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panelQuanLyDM.ResumeLayout(false);
            this.panelQuanLyDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhiTreHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhiThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenDanhMuc.Properties)).EndInit();
            this.panelThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panelQuanLyDM;
        private DevExpress.XtraEditors.TextEdit tbIdDanhMuc;
        private DevExpress.XtraEditors.TextEdit tbTenDanhMuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TextBox tbTimKiemNV;
        private System.Windows.Forms.ComboBox cbbTK_NV;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit tbPhiThue;
        private DevExpress.XtraEditors.TextEdit tbPhiTreHan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiTreHan;
    }
}