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
using DAL;
using BLL;
using Entities;
using System.Text.RegularExpressions;

namespace UI.Form_ChucNang
{
    public partial class Form_QuanLyDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        //Biến điều khiển chức năng.
        public int KEY = 0;

        DanhMucBLL dmbll;
        QLCDDataContext db;
        public Form_QuanLyDanhMuc()
        {
            InitializeComponent();
            dmbll = new DanhMucBLL();
            db = new QLCDDataContext();
        }

        #region Hàm viết riêng
        public void LoadData()
        {
            dataGridView1.DataSource = (from a in db.DanhMucs                                 
                                        where a.TrangThaiXoa == false
                                        select new
                                        {
                                            a.IdDanhMuc,
                                            a.TenDanhMuc
                                           
                                        });
        }

        private void LoadCell()
        {
            tbIdDanhMuc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            tbTenDanhMuc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            



        }

        private void XoaPanel()
        {
            tbIdDanhMuc.Text = "";
            tbTenDanhMuc.Text = "";
       
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCell();
            btnSua.Enabled = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentClick(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_QuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form_QuanLyDanhMuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_QuanLyDanhMuc = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KEY = 1;
            XoaPanel();
            tbIdDanhMuc.Text = (dmbll.LayIdDanhMucCaoNhat() + 1).ToString();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            //btnXoa.Enabled = false;
            panelQuanLyDM.Enabled = true;
            dataGridView1.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KEY = 2;
            panelQuanLyDM.Enabled = true;

            btnThem.Enabled = false;
            //btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            dataGridView1.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(KEY == 1)
            {
                #region Sửa
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn thêm danh mục không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        if (tbTenDanhMuc.Text == "")
                        {
                            XtraMessageBox.Show("Thiếu thông tin, vui lòng nhập đủ !");
                        }
                        else
                        {
                            string reTen = @"^[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴ]+[a-zĐaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+(\s+[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴĐ]+[a-zaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+)+$";
                            Regex rgTen = new Regex(reTen);

                            string reGiaTien = @"^[0-9]{3,4,5,6,7,8,9,10}$";
                            Regex rgGiaTien = new Regex(reGiaTien);


                            //if (rgGiaTien.IsMatch(tbTenDanhMuc.Text))
                            //{
                            //    XtraMessageBox.Show("Số điện thoại gồm 10 hoặc 11 chữ số, không có kí tự , vui lòng nhập lại !");
                            //}
                            if (!dmbll.kiemTraTrungDanhMuc(tbTenDanhMuc.Text))
                            {
                                XtraMessageBox.Show("Đã có một tiêu đề trùng tên trong hệ thống , vui lòng đặt tên khác!");
                            }
                            else
                            {
                              
                                DanhMuc dm = new DanhMuc();
                                dm.IdDanhMuc =Convert.ToInt32(tbIdDanhMuc.Text);
                                dm.TenDanhMuc = tbTenDanhMuc.Text;
                               
                                dm.TrangThaiXoa = false;

                                if (dmbll.ThemDanhMuc(dm))
                                {
                                    XtraMessageBox.Show("Thêm thành công !");
                                    XoaPanel();
                                    panelQuanLyDM.Enabled = false;
                                    LoadData();
                                    btnLuu.Enabled = false;
                                    btnHuy.Enabled = false;
                                    btnThem.Enabled = true;
                                    dataGridView1.Enabled = true;
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
            else if(KEY == 2)
            {
                #region Sửa
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn sửa danh mục không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        if (tbTenDanhMuc.Text == "")
                        {
                            XtraMessageBox.Show("Thiếu thông tin, vui lòng nhập đủ !");
                        }
                        else
                        {
                            string reTen = @"^[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴ]+[a-zĐaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+(\s+[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴĐ]+[a-zaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+)+$";
                            Regex rgTen = new Regex(reTen);

                            string reGiaTien = @"^[0-9]{3,4,5,6,7,8,9,10}$";
                            Regex rgGiaTien = new Regex(reGiaTien);


                            //if (rgGiaTien.IsMatch(tbTenDanhMuc.Text))
                            //{
                            //    XtraMessageBox.Show("Số điện thoại gồm 10 hoặc 11 chữ số, không có kí tự , vui lòng nhập lại !");
                            //}
                            if (!dmbll.kiemTraTrungDanhMuc(tbTenDanhMuc.Text))
                            {
                                XtraMessageBox.Show("Đã có một danh mục trùng tên trong hệ thống , vui lòng đặt tên khác!");
                            }
                            else
                            {

                                DanhMuc dm = new DanhMuc();
                                dm.IdDanhMuc = Convert.ToInt32(tbIdDanhMuc.Text);
                                dm.TenDanhMuc = tbTenDanhMuc.Text;

                                dm.TrangThaiXoa = false;

                                if (dmbll.SuaDanhMuc(dm))
                                {
                                    XtraMessageBox.Show("Sửa thành công !");
                                    XoaPanel();
                                    panelQuanLyDM.Enabled = false;
                                    LoadData();
                                    btnLuu.Enabled = false;
                                    btnHuy.Enabled = false;
                                    btnThem.Enabled = true;
                                    dataGridView1.Enabled = true;
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
            XoaPanel();
            panelQuanLyDM.Enabled = false;
            btnSua.Enabled = false;
            //btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            dataGridView1.Enabled = true;
        }

    
    }
}