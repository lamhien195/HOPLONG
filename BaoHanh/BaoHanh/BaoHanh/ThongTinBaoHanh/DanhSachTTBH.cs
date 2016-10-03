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
    public partial class DanhSachTTBH : Form
    {
        private BaoHanhEntities BH = new BaoHanhEntities();

        string dh,mkh, nvkd, mh, tthn, ttbh, nn , nt, sln, slt, ttxl;
 
        public DanhSachTTBH()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string madonhang = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ThongTinBaoHanh sp = BH.ThongTinBaoHanhs.Single(t => t.madonhang.Equals(madonhang));
                dh = sp.madonhang ;
                nn = sp.ngaynhanhang.ToString();
                nt = sp.ngaytrahang.ToString() ;
                mkh = sp.makh; 
                nvkd = sp.nhanvienKD;
                mh = sp.mahang;
                sln = sp.slnhan.ToString();
                slt = sp.sltrakhach.ToString(); 
                tthn = sp.tinhtranghangnhan;
                ttbh = sp.trangthaibaohanh;
                ttbh = sp.trangthaibaohanh;
                ttxl = sp.trangthaixuly;
           
            
            //CultureInfo cultureFR = CultureInfo.CreateSpecificCulture("fr-FR");
            //CultureInfo cultureUS = CultureInfo.CreateSpecificCulture("en-US");
            //DateTimeStyles dateStyle = DateTimeStyles.None;
            //DateTime.TryParse(ngayxuathoadon.Text, cultureFR, dateStyle, out date);
            Sua_TTBH opf = new Sua_TTBH(dh, nn, nt, mkh, nvkd, mh, sln, slt, tthn, ttbh, ttxl );
            
            if (opf.ShowDialog() == DialogResult.OK)
            {
                DataFill();
            }
        }

        public void DataFill()
        {

            dataGridView1.DataSource = BH.ThongTinBaoHanhs.Select(tk => new
            {
                madonhang = tk.madonhang,
                ngaynhanhang = tk.ngaynhanhang,
                ngaytrahang = tk.ngaytrahang,
                makh = tk.makh,
                nhanvienKD = tk.nhanvienKD,
                mahang = tk.mahang,
                slnhan = tk.slnhan,
                sltrakhach = tk.sltrakhach,
                tinhtranghangnhan = tk.tinhtranghangnhan,
                trangthaibaohanh = tk.trangthaibaohanh,
                trangthaixuly = tk.trangthaixuly
                
            }).ToList();
            dataGridView1.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView1.Columns[1].HeaderText = "Ngày nhận";
            dataGridView1.Columns[2].HeaderText = "Ngày Trả";
            dataGridView1.Columns[3].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[4].HeaderText = "Nhân viên kinh doanh";
            dataGridView1.Columns[5].HeaderText = "Mã hàng";
            dataGridView1.Columns[6].HeaderText = "Số lượng nhận";
            dataGridView1.Columns[7].HeaderText = "Số lượng trả khách";
            dataGridView1.Columns[8].HeaderText = "Tình trạng hàng nhận";
            dataGridView1.Columns[9].HeaderText = "Trạng thái bảo hành";
            dataGridView1.Columns[10].HeaderText = "Trạng thái xử lý";
        }

        private void DanhSachTTBH_Load(object sender, EventArgs e)
        {
            DataFill();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void them_Click(object sender, EventArgs e)
        {
            Them_TTBH opf = new Them_TTBH();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                DataFill();
            }

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string madonhang = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    ThongTinBaoHanh sp = BH.ThongTinBaoHanhs.Single(t => t.madonhang.Equals(madonhang));
                    BH.ThongTinBaoHanhs.DeleteObject(sp);
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

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ctdh_Click(object sender, EventArgs e)
        {
            string madonhang = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DanhSach_XuLyBH opf = new DanhSach_XuLyBH(madonhang);
            opf.Show();
        }

        private void them_ctdh_Click(object sender, EventArgs e)
        {
            string madonhang = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Them_XuLyBH opf = new Them_XuLyBH(madonhang);
            opf.Show();
        
        }
    }
}
