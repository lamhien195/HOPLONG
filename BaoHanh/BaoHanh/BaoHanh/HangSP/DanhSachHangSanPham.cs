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
    public partial class DanhSachHangSanPham : Form
    {
        private BaoHanhEntities BH = new BaoHanhEntities();
        public DanhSachHangSanPham()
        {
            InitializeComponent();
        }

        private void DanhSachHangSanPham_Load(object sender, EventArgs e)
        {
            DataFill();
        }
        public void DataFill()
        {

            dataGridView1.DataSource = BH.HangSPs.Select(hsp => new
            {
                mahangsp = hsp.mahangsp,
                tenhangsp = hsp.tenhangsp,
                kythuat = hsp.kythuat,
                sdt = hsp.sdt
            }).ToList();
            dataGridView1.Columns[0].HeaderText = "Mã hãng";
            dataGridView1.Columns[1].HeaderText = "Tên hãng";
            dataGridView1.Columns[2].HeaderText = "Kỹ thuật";
            dataGridView1.Columns[3].HeaderText = "SĐT";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahangsp = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            HangSP sp = BH.HangSPs.Single(t => t.mahangsp.Equals(mahangsp));
            this.mahangsp.Text = sp.mahangsp;
            this.tenhangsp.Text = sp.tenhangsp;
            this.tenkythuat.Text = sp.kythuat;
            this.sdt.Text = sp.sdt;
        }

        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                HangSP sp = new HangSP();
                sp.mahangsp = this.mahangsp.Text;
                sp.tenhangsp = this.tenhangsp.Text;
                sp.kythuat = this.tenkythuat.Text;
                sp.sdt = this.sdt.Text; ;
                BH.HangSPs.AddObject(sp);
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
                string mahangsp = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                HangSP sp = BH.HangSPs.Single(t => t.mahangsp.Equals(mahangsp));
                sp.mahangsp = this.mahangsp.Text;
                sp.tenhangsp = this.tenhangsp.Text;
                sp.kythuat = this.tenkythuat.Text;
                sp.sdt = this.sdt.Text; ;
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
            string mahangsp = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    HangSP sp = BH.HangSPs.Single(t => t.mahangsp.Equals(mahangsp));
                    BH.HangSPs.DeleteObject(sp);
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
