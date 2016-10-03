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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void sửaĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them_TTBH opf = new Them_TTBH();
            opf.MdiParent = this;
            opf.Show();
        }

        private void danhSáchTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void danhSáchSảnPhẩmBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           DanhSachSanPham opf = new DanhSachSanPham();
            opf.MdiParent = this;
            opf.Show();
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang opf = new DanhSachKhachHang();
            opf.MdiParent = this;
            opf.Show();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void danhSáchHãngSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachHangSanPham opf = new DanhSachHangSanPham();
            opf.MdiParent = this;
            opf.Show();
        }

        private void thêmHãngSảnPhẩmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thêmĐơnHàngBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachTTBH opf = new DanhSachTTBH();
            opf.MdiParent = this;
            opf.Show();
        }

        private void thêmĐơnHàngXửLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them_XuLyBH opf = new Them_XuLyBH();
            opf.MdiParent = this;
            opf.Show();
        }

        private void danhSáchĐơnĐangXửLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSach_XuLyBH opf = new DanhSach_XuLyBH();
            opf.MdiParent = this;
            opf.Show();
        }

        private void danhSáchTàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TaiKhoan_DangNhap taikhoan = new TaiKhoan_DangNhap();
            taikhoan.MdiParent = this;
            taikhoan.Show();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void danhSáchHãngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachHangSanPham opf = new DanhSachHangSanPham();
            opf.MdiParent = this;
            opf.Show();
        }
    }
}
