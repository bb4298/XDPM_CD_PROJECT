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
using BLL;
using Entities;
using System.Text.RegularExpressions;

namespace UI.Form_ChucNang
{
    public partial class Form_QuanLyKhoDia : DevExpress.XtraEditors.XtraForm
    {
        //Biến điều khiển chức năng.
        public int KEY = 0;
        TieuDeBLL tdbll;
        DiaBLL diabll;
        public Form_QuanLyKhoDia()
        {
            InitializeComponent();
            tdbll = new TieuDeBLL();
            diabll = new DiaBLL(); 
            dataGridViewD.AutoGenerateColumns = false;
            dataGridViewTD.AutoGenerateColumns = false;
        }


        #region Hàm viết riêng
        //Load Data Tiêu Đề
        public void LoadDataTieuDe()
        {            
            dataGridViewTD.DataSource = tdbll.LayDanhSachTieuDe_QuanLyKhoDia();
        }

        public void LoadDataDia(string IdTieuDe)
        {
            //dataGridViewD.DataSource = (from a in db.TieuDes
            //                            join b in db.Dias on a.IdTieuDe equals b.IdTieuDe
            //                            where b.TrangThaiXoa == false && a.IdTieuDe == IdTieuDe
            //                            select new
            //                            {
            //                                b.IdDia,
            //                                b.TrangThai

            //                            });
            dataGridViewD.DataSource = diabll.LayDanhSachDia(IdTieuDe);
        }
        private void LoadCell()
        {
            tbIdDia.Text = dataGridViewD.CurrentRow.Cells[0].Value.ToString().Trim();
            tbTrangThai.Text = dataGridViewD.CurrentRow.Cells[1].Value.ToString().Trim();




        }
        private void XoaPanel()
        {
            tbDanhMuc.Text = "";
            tbIdDia.Text = "";
            tbTenTieuDe.Text = "";
            tbTrangThai.Text = "";
            tbNguoiMuon.Text = "";
        }
        private void XoaPanelThem()
        {
            tbThem_IdDia.Text = "";
            tbThem_IdTieuDe.Text = "";
            cbbThem_TenTieuDe.Text = "";    
        }
        private string NextID(string maTuTang, string prefixID)
        {
            if (maTuTang == "")
            {
                return prefixID + "00000001";  // fixwidth default
            }
            int nextID = int.Parse(maTuTang.Remove(0, prefixID.Length)) + 1;
            int lengthNumerID = maTuTang.Length - prefixID.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;

        }
        #endregion


        private void Form_QuanLyKhoDia_Load(object sender, EventArgs e)
        {
            LoadDataTieuDe();
            panelThemDia.Visible = false;
        }

        private void Form_QuanLyKhoDia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_QuanLyKhoDia = true;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            KEY = 1;            
            
            panelThemDia.Visible = true;

            //Code cũ
            //cbbThem_TenTieuDe.DataSource = (from a in db.TieuDes
            //                                where a.TrangThaiXoa == false
            //                                select a.TenTieuDe
            //);
            
            // Binding dữ liệu từ List danh mục vào combobox
            BindingSource binding = new BindingSource();
            binding.DataSource = tdbll.LayDanhSachTenTieuDe();
            cbbThem_TenTieuDe.DataSource = binding.DataSource;
            cbbThem_TenTieuDe.DisplayMember = "TenTieuDe";
            cbbThem_TenTieuDe.ValueMember = "TenTieuDe";

            cbbThem_TenTieuDe.Text = dataGridViewTD.CurrentRow.Cells[1].Value.ToString().Trim();
            XoaPanel();
            tbThem_IdDia.Text = NextID(diabll.LayMaDiaCaoNhat(), "CD");

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            //btnSua.Enabled = false;
            btnXoa.Enabled = false;
            panelQuanLyTD.Enabled = true;
            dataGridViewD.Enabled = false;
            dataGridViewTD.Enabled = false;
        }

  
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(KEY == 1)
            {
                #region Thêm
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn thêm tiêu đề không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        if (tbThem_IdDia.Text == "" || tbThem_IdTieuDe.Text == "" || cbbThem_TenTieuDe.Text == "")
                        {
                            XtraMessageBox.Show("Thiếu thông tin, vui lòng nhập đủ !");
                        }
                        else
                        {
                          
                            string reGiaTien = @"^[0-9]{3,4,5,6,7,8,9,10}$";
                            Regex rgGiaTien = new Regex(reGiaTien);


                            //if (rgGiaTien.IsMatch(tbPhiThue.Text))
                            //{
                            //    XtraMessageBox.Show("Số điện thoại gồm 10 hoặc 11 chữ số, không có kí tự , vui lòng nhập lại !");
                            //}
                            if (!diabll.kiemTraTrungDia(tbThem_IdDia.Text))
                            {
                                XtraMessageBox.Show("Đã có một đĩa với ID này trong hệ thống , vui lòng đặt ID khác!");
                            }
                            else
                            {
                               
                                eDia dia = new eDia();
                                dia.IdDia = tbThem_IdDia.Text;
                                dia.TrangThai = false;
                                dia.TrangThaiXoa = false;                      
                                dia.IdTieuDe = tbThem_IdTieuDe.Text;

                                if (diabll.ThemDia(dia))
                                {
                                    XtraMessageBox.Show("Thêm đĩa thành công !");
                                    LoadDataDia(tbThem_IdTieuDe.Text);
                                    XoaPanel();
                                    panelQuanLyTD.Enabled = false;
                                    
                                    btnLuu.Enabled = false;
                                    btnHuy.Enabled = false;
                                    btnThem.Enabled = true;
                                    dataGridViewD.Enabled = true;
                                    dataGridViewTD.Enabled = true;
                                   
                                    KEY = 0;

                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        XtraMessageBox.Show("Lỗi: " + ex);
                    }

                }
                else
                {
                    dg = DialogResult.Cancel;
                }

                #endregion
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KEY = 0;
            XoaPanelThem();
            panelThemDia.Visible = false;
            panelQuanLyTD.Enabled = false;
            //btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            dataGridViewD.Enabled = true;
            dataGridViewTD.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            #region Xóa
            if (Form_Main.trangThaiLogin != true)
            {
                XtraMessageBox.Show("Vui lòng đăng nhập tài khoản quản lý để thực hiện chức năng này !");
            }
            else if(diabll.kiemTraDiaTaiCuaHang(tbThem_IdDia.Text) != true)
            {
                XtraMessageBox.Show("Đĩa này đang được thuê bởi một khách hàng, không thể xóa !");
            }
            else if (Form_Main.trangThaiLogin == true)
            {
                #region diglog
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn xóa đĩa này không, thao tác này không thể hoàn tác !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        eDia dia = new eDia();
                        dia.IdDia = tbThem_IdDia.Text;
                        dia.TrangThaiXoa = true;

                        if (diabll.XoaDia(dia))
                        {
                            XtraMessageBox.Show("Xóa đĩa thành công !");
                            LoadDataDia(tbThem_IdTieuDe.Text);
                            XoaPanel();
                            panelQuanLyTD.Enabled = false;
                            btnLuu.Enabled = false;
                            btnHuy.Enabled = false;
                            btnThem.Enabled = true;
                            KEY = 0;


                        }
                    }
                    catch (Exception ex)
                    {

                        XtraMessageBox.Show("Lỗi: " + ex);
                    }
                }
                else
                {
                    dg = DialogResult.Cancel;
                }
                #endregion
            }
            #endregion
        }

        private void dataGridViewD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            tbDanhMuc.Text = dataGridViewTD.CurrentRow.Cells[2].Value.ToString().Trim();
            tbIdDia.Text = dataGridViewD.CurrentRow.Cells[0].Value.ToString().Trim();
            tbTenTieuDe.Text = dataGridViewTD.CurrentRow.Cells[1].Value.ToString().Trim();
            tbTrangThai.Text = dataGridViewD.CurrentRow.Cells[1].Value.ToString().Trim();
            if (tbTrangThai.Text == "True")
            {
                tbTrangThai.Text = "Đang được thuê";
            }
            else if (tbTrangThai.Text == "False")
            {
                tbTrangThai.Text = "Có sẵn";
            }
            string tenNguoiMuon = diabll.LayTenNguoiThue((dataGridViewD.CurrentRow.Cells[0].Value.ToString()));
            tenNguoiMuon = tenNguoiMuon.Replace("{ HoTen = ", "");
            tenNguoiMuon = tenNguoiMuon.Replace(" }", "");

            tbNguoiMuon.Text = tenNguoiMuon;
            //Convert.ToInt32(dataGridViewD.CurrentRow.Cells[0].Value)
        }

        private void dataGridViewD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewD_CellContentClick(sender, e);
        }

        private void dataGridViewTD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataDia(dataGridViewTD.CurrentRow.Cells[0].Value.ToString().Trim());
            XoaPanel();
        }

        private void dataGridViewTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewTD_CellContentClick(sender, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Đang được thuê" : "Có sẵn";
                    e.FormattingApplied = true;
                }
            }
        }

        private void cbbThem_TenTieuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbThem_IdTieuDe.Text = tdbll.layIdTieuDeBangTenTieuDe(cbbThem_TenTieuDe.Text);
        }

        private void tbThem_IdTieuDe_EditValueChanged(object sender, EventArgs e)
        {
            cbbThem_TenTieuDe.Text = tdbll.layTenTieuDeBangIdTieuDe(tbThem_IdTieuDe.Text);
        }
    }
}