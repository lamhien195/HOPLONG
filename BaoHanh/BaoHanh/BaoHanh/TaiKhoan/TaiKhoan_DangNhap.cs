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
    public partial class TaiKhoan_DangNhap : Form
    {
        private BaoHanhEntities BH = new BaoHanhEntities();
        public TaiKhoan_DangNhap()
        {
            InitializeComponent();
        }

        private void TaiKhoan_DangNhap_Load(object sender, EventArgs e)
        {
            DataFill();
        }

        public void DataFill()
        {
            dataGridView1.DataSource = BH.TaiKhoans.Select(tk => new
            {
                username = tk.username,
                hoten = tk.hoten,
                sdt = tk.sdt
            }).ToList();
            dataGridView1.Columns[0].HeaderText = "Username";
            dataGridView1.Columns[1].HeaderText = "Họ và tên";
            dataGridView1.Columns[2].HeaderText = "Số điện thoại";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
           DialogResult dr = MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo);
           if (dr == System.Windows.Forms.DialogResult.Yes)
           {
               try
               {
                   TaiKhoan tk = BH.TaiKhoans.Single(t => t.username.Equals(username));
                   BH.TaiKhoans.DeleteObject(tk);
                   BH.SaveChanges();
                   DataFill();
                   MessageBox.Show("Xóa tài khoản thành công");
               }
               catch(Exception ex)
               {
                   MessageBox.Show(""+ex, "Lỗi");
               }
           }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string username = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TaiKhoan tk = BH.TaiKhoans.Single(t => t.username.Equals(username));
            this.username.Text = tk.username;
            this.hoten.Text = tk.hoten;
            this.sdt.Text = tk.sdt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan();
                tk.username = this.username.Text;
                tk.password = this.password.Text;
                tk.hoten = this.hoten.Text;
                tk.sdt = this.sdt.Text;
                BH.TaiKhoans.AddObject(tk);
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
                string username = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TaiKhoan tk = BH.TaiKhoans.Single(t => t.username.Equals(username));
                if (this.password.Text.Length != 0)
                    tk.password = this.password.Text;
                tk.hoten = this.hoten.Text;
                tk.sdt = this.sdt.Text;
                BH.SaveChanges();
                DataFill();
               MessageBox.Show("Cập nhật tài khoản thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
