namespace BaoHanh
{
    partial class DanhSachTTBH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tukhoa = new System.Windows.Forms.TextBox();
            this.thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.ctdh = new System.Windows.Forms.Button();
            this.them_ctdh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SẢN PHẨM BẢO HÀNH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1285, 437);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1322, 487);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơn hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.them_ctdh);
            this.groupBox2.Controls.Add(this.ctdh);
            this.groupBox2.Controls.Add(this.tukhoa);
            this.groupBox2.Controls.Add(this.thoat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.xoa);
            this.groupBox2.Controls.Add(this.sua);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Controls.Add(this.timkiem);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1322, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tukhoa
            // 
            this.tukhoa.Location = new System.Drawing.Point(132, 22);
            this.tukhoa.Name = "tukhoa";
            this.tukhoa.Size = new System.Drawing.Size(154, 20);
            this.tukhoa.TabIndex = 1;
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(1229, 19);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 0;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ khóa:";
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(1115, 19);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 0;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(999, 19);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 0;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.button3_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(890, 19);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 0;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(356, 19);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(75, 23);
            this.timkiem.TabIndex = 0;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            // 
            // ctdh
            // 
            this.ctdh.Location = new System.Drawing.Point(738, 19);
            this.ctdh.Name = "ctdh";
            this.ctdh.Size = new System.Drawing.Size(128, 23);
            this.ctdh.TabIndex = 2;
            this.ctdh.Text = "Xem chi tiết đơn hàng";
            this.ctdh.UseVisualStyleBackColor = true;
            this.ctdh.Click += new System.EventHandler(this.ctdh_Click);
            // 
            // them_ctdh
            // 
            this.them_ctdh.Location = new System.Drawing.Point(589, 19);
            this.them_ctdh.Name = "them_ctdh";
            this.them_ctdh.Size = new System.Drawing.Size(143, 23);
            this.them_ctdh.TabIndex = 3;
            this.them_ctdh.Text = "Thêm chi tiết đơn hàng";
            this.them_ctdh.UseVisualStyleBackColor = true;
            this.them_ctdh.Click += new System.EventHandler(this.them_ctdh_Click);
            // 
            // DanhSachTTBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachTTBH";
            this.Text = "DanhSachTTBH";
            this.Load += new System.EventHandler(this.DanhSachTTBH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tukhoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button ctdh;
        private System.Windows.Forms.Button them_ctdh;
    }
}