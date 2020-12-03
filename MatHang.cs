using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDaiLy.DAL;

namespace QuanLyDaiLy
{
    public partial class MatHang : Form
    {
        private QLDaiLyEntities db = new QLDaiLyEntities();
        public MatHang()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }
    }
}
