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
    public partial class DanhSachSanPham : Form
    {
        private BaoHanhEntities BH = new BaoHanhEntities();
        public DanhSachSanPham()
        {
            InitializeComponent();
        }

        private void DanhSachSanPham_Load(object sender, EventArgs e)
        {
            var hsp = BH.HangSPs.ToList();
            this.mahangsp.DataSource = hsp;
            this.mahangsp.DisplayMember = "tenhangsp";
            this.mahangsp.ValueMember = "mahangsp";
            DataFill();
        }
        public void DataFill()
        {

            dataGridView1.DataSource = BH.SanPhams.Select(tk => new
            {
                mahang = tk.mahang,
                tenhang = tk.tenhang,
                seri = tk.seri,
                hangsp = tk.HangSP
            }).ToList();
            dataGridView1.Columns[0].HeaderText = "Mã SP";
            dataGridView1.Columns[1].HeaderText = "Tên Sản Phẩm";
            dataGridView1.Columns[2].HeaderText = "Seri";
            dataGridView1.Columns[3].HeaderText = "Hãng SP";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string masp = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SanPham sp = BH.SanPhams.Single(t => t.mahang.Equals(masp));
            this.mahang.Text = sp.mahang;
            this.tenhang.Text = sp.tenhang;
            this.seri.Text = sp.seri;
            this.mahangsp.Text = sp.mahangsp;
        }

        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham();
                sp.mahang = this.mahang.Text;
                sp.tenhang = this.tenhang.Text;
                sp.seri = this.seri.Text;
                sp.mahangsp = this.mahangsp.SelectedValue.ToString();
                BH.SanPhams.AddObject(sp);
                BH.SaveChanges();
                DataFill();
                MessageBox.Show("Thêm tài khoản thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            try
            {
                string mahang = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                SanPham sp = BH.SanPhams.Single(t => t.mahang.Equals(mahang));
                sp.mahang = this.mahang.Text;
                sp.tenhang = this.tenhang.Text;
                sp.seri = this.seri.Text;
                sp.mahangsp = this.mahangsp.Text; 
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
            string mahang = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    SanPham sp = BH.SanPhams.Single(t => t.mahang.Equals(mahang));
                    BH.SanPhams.DeleteObject(sp);
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

    }
}
