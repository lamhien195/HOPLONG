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
    public partial class DanhSachKhachHang : Form
    {
        private BaoHanhEntities BH = new BaoHanhEntities();
        public DanhSachKhachHang()
        {
            InitializeComponent();
        }

        public void DataFill()
        {

            dataGridView1.DataSource = BH.KhachHangs.Select(kh => new
            {
                makh = kh.makh,
                tenkh = kh.tenkh,
                sdt = kh.sdt,
                diachi = kh.diachi
            }).ToList();
            dataGridView1.Columns[0].HeaderText = "Mã KH";
            dataGridView1.Columns[1].HeaderText = "Tên KH";
            dataGridView1.Columns[2].HeaderText = "SĐT";
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
        }

        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang();
                kh.makh = this.makh.Text;
                kh.tenkh = this.tenkh.Text;
                kh.sdt = this.sdt.Text;
                kh.diachi = this.diachi.Text;
                BH.KhachHangs.AddObject(kh);
                BH.SaveChanges();
                DataFill();
                MessageBox.Show("Thêm tài khoản thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string makh = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            KhachHang kh = BH.KhachHangs.Single(t => t.makh.Equals(makh));
            this.makh.Text = kh.makh;
            this.tenkh.Text = kh.tenkh;
            this.sdt.Text = kh.sdt;
            this.diachi.Text = kh.diachi;
        }

        private void sua_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                KhachHang kh = BH.KhachHangs.Single(t => t.makh.Equals(makh));
                kh.makh = this.makh.Text;
                kh.tenkh = this.tenkh.Text;
                kh.sdt = this.sdt.Text;
                kh.diachi = this.diachi.Text;
                BH.SaveChanges();
                DataFill();
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {

            string makh = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    KhachHang kh = BH.KhachHangs.Single(t => t.makh.Equals(makh));
                    BH.KhachHangs.DeleteObject(kh);
                    BH.SaveChanges();
                    DataFill();
                    MessageBox.Show("Xóa tài khoản thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            DataFill();
        }
    }
}
