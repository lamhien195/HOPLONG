using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace BaoHanh
{
    public partial class Sua_TTBH : Form
    {
        private BaoHanhEntities BH = new BaoHanhEntities();

        string dh, mkh, nvkd, mh, tthn, ttbh, nn, nt, sln, slt, ttxl;
        public Sua_TTBH()
        {
            InitializeComponent();
        }
        public Sua_TTBH(string dhang, string nnhan, string ntra, string mkhang, string nvienKD, string mhang, string snhan, string stra, string tthnhan, string ttbhanh, string ttxly )
        {
            InitializeComponent();
            dh = dhang;
            nn = nnhan;
            nt = ntra;
            mkh = mkhang;
            nvkd = nvienKD;
            mh = mhang;
            sln = snhan;
            slt = stra;
            tthn = tthnhan;
            ttbh = ttbhanh;
            ttxl = ttxly;
        }
        private void Sua_TTBH_Load(object sender, EventArgs e)
        {
            this.madonhang.Text = dh;
            this.ngaynhanhang.Text = nn;
            this.ngaytrahang.Text = nt;
            this.makh.Text = mkh;
            this.nhanvienKD.Text = nvkd;
            this.mahang.Text = mh;
            this.slnhan.Text = sln;
            this.sltrakhach.Text = slt;
            this.tinhtranghangnhan.Text = tthn;
            this.trangthaibaohanh.Text = ttbh;
            //--------------Combobox-----------------------------
            var makhachhang = BH.KhachHangs.ToList();
            this.makh.DataSource = makhachhang;
            this.makh.DisplayMember = "tenkh";
            this.makh.ValueMember = "makh";

            var masp = BH.SanPhams.ToList();
            this.mahang.DataSource = masp;
            this.mahang.DisplayMember = "tenhang";
            this.mahang.ValueMember = "mahang";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void luu_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            if (slnhan.Text != null)
            {
                a = Convert.ToInt32(slnhan.Text);
            }
            else 
            {
                a = 0;
            }

            if (sltrakhach.Text != null)
            {
                b = Convert.ToInt32(sltrakhach.Text);
            }
            else
            {
                b = 0;
            }


            DateTime ngaynhan;
            DateTime ngaytra;
            CultureInfo cultureUS = CultureInfo.CreateSpecificCulture("vi-VN");
            DateTimeStyles dateStyle = DateTimeStyles.None;
            DateTime.TryParse(ngaynhanhang.Text, cultureUS, dateStyle, out ngaynhan);
            DateTime.TryParse(ngaytrahang.Text, cultureUS, dateStyle, out ngaytra);

            try
            {
                ThongTinBaoHanh sp = BH.ThongTinBaoHanhs.Single(t => t.madonhang.Equals(dh));
                sp.ngaytrahang = ngaytra;
                sp.makh = makh.SelectedValue.ToString(); 
                sp.nhanvienKD = nhanvienKD.Text;
                sp.mahang = mahang.SelectedValue.ToString();
                sp.slnhan = a;
                sp.sltrakhach = b;
                sp.tinhtranghangnhan = tinhtranghangnhan.Text;
                sp.trangthaibaohanh = trangthaibaohanh.SelectedItem.ToString(); 
                BH.SaveChanges();
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
