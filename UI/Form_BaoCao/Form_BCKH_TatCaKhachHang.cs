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

namespace UI.Form_BaoCao
{
    public partial class Form_BCKH_TatCaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public Form_BCKH_TatCaKhachHang()
        {
            InitializeComponent();
        }

        private void Form_BCKH_TatCaKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_BCKH_TatCaKhachHang = true;
        }
    }
}