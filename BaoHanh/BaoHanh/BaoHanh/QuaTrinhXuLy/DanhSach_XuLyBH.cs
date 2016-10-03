using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaoHanh
{
    public partial class DanhSach_XuLyBH : Form
    {
        BaoHanhEntities BH = new BaoHanhEntities();
        string madh;
        public DanhSach_XuLyBH()
        {
            InitializeComponent();
        }
        public DanhSach_XuLyBH(string mdh)
        {
            InitializeComponent();
            madh = mdh;
        }

        private void DanhSach_XuLyBH_Load(object sender, EventArgs e)
        {
            XuLyDonHang sp = BH.XuLyDonHangs.Single(t => t.madonhang.Equals(madh));
            madonhang.Text = sp.madonhang;
            ngayhethan.Text = sp.ngayhethan.ToString();
            nvbh.Text = "";
            ghichu1.Text = sp.ghichu1;
            ghichu2.Text = sp.ghichu2;
            ghichu3.Text = sp.Ghichu3;
            kq.Text = sp.ketqua;
            ttxl.Text = sp.trangthaixuly;



        }
    }
}
