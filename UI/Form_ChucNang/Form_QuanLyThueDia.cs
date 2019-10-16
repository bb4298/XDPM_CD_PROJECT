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

namespace UI.Form_ChucNang
{
    public partial class Form_QuanLyThueDia : DevExpress.XtraEditors.XtraForm
    {
        List<eThongTinPhieuThue> listTtPhieuThue;
        KhachHangBLL khbll;
        DiaBLL diabll;
        TieuDeBLL tdbll;
        DanhMucBLL dmbll;

        public Form_QuanLyThueDia()
        {
            InitializeComponent();
            tdbll = new TieuDeBLL();
            khbll = new KhachHangBLL();
            diabll = new DiaBLL();
            dmbll = new DanhMucBLL();
            listTtPhieuThue = new List<eThongTinPhieuThue>();
            
            dataGridView1.AutoGenerateColumns = false;
        }
        #region Hàm tự viết
        public void XoaPanelTTKH()
        {
            tbTenKhachHang.Text = "";
            tbDiaChi.Text = "";
            tbSDT.Text = "";
        }
        #endregion

        private void Form_QuanLyThueDia_Load(object sender, EventArgs e)
        {

        }


        

        



        private void dataGridViewCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form_QuanLyThueDia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_QuanLyThueDia = true;
        }

        private void btnXacNhanKH_Click(object sender, EventArgs e)
        {
            if(btnXacNhanKH.Text == "Xác Nhận")
            {
                eKhachHang ekh = khbll.LayThongTinKhachHang(tbIdKH.Text);
                if (ekh == null)
                {
                    XtraMessageBox.Show("ID này không có trong hệ thống !");
                }
                else if (ekh != null)
                {
                    tbTenKhachHang.Text = ekh.HoTen;
                    tbDiaChi.Text = ekh.DiaChi;
                    tbSDT.Text = ekh.SoDienThoai;
                    btnXacNhanKH.Text = "Hủy";

                    tbIdDia.Enabled = true;
                    btnThemDia.Enabled = true;
                    tbIdKH.Enabled = false;
                    tbSoNgayThue.Enabled = true;
                   
                }
            }
            else if(btnXacNhanKH.Text == "Hủy")
            {
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Chưa hoàn tất phiếu thuê, bạn có muốn hủy không, thao tác này không thể hoàn tác !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    tbIdKH.Text = "";
                    XoaPanelTTKH();
                    btnXacNhanKH.Text = "Xác Nhận";
                    tbIdDia.Enabled = false;
                    btnThemDia.Enabled = false;
                    tbIdKH.Enabled = true;
                    tbSoNgayThue.Enabled = false;
                    
                }
                else
                {
                    dg = DialogResult.Cancel;
                }
                   
            }
          
           
        }

        private void btnThemDia_Click(object sender, EventArgs e)
        {
            if(tbIdDia.Text =="" || tbSoNgayThue.Text=="")
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ ID đĩa và số ngày thuê !");
            }
            else if (tdbll.LayTenTieuDeBangIdDia(tbIdDia.Text)=="null")
            {
                XtraMessageBox.Show("Không có Đĩa này trong hệ thống, vui lòng nhập ID khác !");
            }
            else if (diabll.kiemTraDiaTaiCuaHang(tbIdDia.Text))
            {
                XtraMessageBox.Show("Đĩa đang được thuê bởi người khác, vui lòng nhập ID khác !");
            }
            else if("a"=="da")
            {
                //regex
            }
            else
            {
               
                DateTime ngayTra = DateTime.Now.AddDays(5);  
               
                string tenDia = tdbll.LayTenTieuDeBangIdDia(tbIdDia.Text);
                string tenDanhMuc = dmbll.LayTenDanhMucBangIdDia(tbIdDia.Text);
              
                decimal phiThue = dmbll.LayPhiThueBangIdDia(tbIdDia.Text);
                decimal phiTreHan = dmbll.LayPhiTreHanBangIdDia(tbIdDia.Text);
                eThongTinPhieuThue ettpt = new eThongTinPhieuThue(tbIdDia.Text, tenDia, tenDanhMuc, Convert.ToDecimal(phiThue)* Convert.ToDecimal(tbSoNgayThue.Text), Convert.ToDecimal(phiTreHan), ngayTra);
                if(listTtPhieuThue.Count()==0)
                {
                    listTtPhieuThue.Add(ettpt);
                    var bindingList = new BindingList<eThongTinPhieuThue>(listTtPhieuThue);
                    var source = new BindingSource(bindingList, null);
                    dataGridView1.DataSource = source;
                    thayDoiThongTinPhieuThue(listTtPhieuThue);
                }
                else if (listTtPhieuThue != null)
                {
                    int temp = 0;
                    foreach (eThongTinPhieuThue item in listTtPhieuThue)
                    {
                        if (item.IdDia == tbIdDia.Text)
                        {
                            temp = temp + 1;
                        }                   
                    }
                    if (temp == 0)
                    {
                        listTtPhieuThue.Add(ettpt);
                        var bindingList = new BindingList<eThongTinPhieuThue>(listTtPhieuThue);
                        var source = new BindingSource(bindingList, null);
                        dataGridView1.DataSource = source;
                        thayDoiThongTinPhieuThue(listTtPhieuThue);
                    }
                    else if (temp >0)
                    {
                        XtraMessageBox.Show("Đĩa này đã có trong phiếu thuê, vui lòng không nhập lại !");
                    }
                }
            }          
        }
        public void thayDoiThongTinPhieuThue(List<eThongTinPhieuThue> listTTPT)
        {
            decimal tongPhiThue = 0;
            int tongSoDia = 0;
            foreach(eThongTinPhieuThue item in listTTPT)
            {
                tongPhiThue = tongPhiThue + item.PhiThue;
                tongSoDia++;
            }
            tbNgaythue.Text = DateTime.Now.ToShortDateString();
            tbTongSoDia.Text = tongSoDia.ToString();
            tbTongTienThanhToan.Text = tongPhiThue.ToString();
        }

    }
}