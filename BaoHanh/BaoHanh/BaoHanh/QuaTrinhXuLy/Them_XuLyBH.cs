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
    public partial class Them_XuLyBH : Form
    {
        string madh;
        public Them_XuLyBH()
        {
            InitializeComponent();
        }
        public Them_XuLyBH(string mdh)
        {
            InitializeComponent();
            madh = mdh;
        }

        private void Them_XuLyBH_Load(object sender, EventArgs e)
        {
            madonhang.Text = madh;
        }
    }
}
