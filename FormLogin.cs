using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy
{
    public partial class FormLogin : Form
    {
        int mov;
        int movX;
        int movY;

        public FormLogin()
        {
            InitializeComponent();
        }
        private void Authentication()
        {
            string u = txt_User.Text;
            string p = txt_Password.Text;

            if (u == "admin" && p == "admin")
            {
                MainForm f = new MainForm();
                f.Show();
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG", "THÔNG BÁO");
                this.Hide();

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.FromArgb(25, 30, 39);
                checkBox1.Image = QuanLyDaiLy.Properties.Resources.visible_32;
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                checkBox1.BackColor = Color.FromArgb(25, 30, 39);
                checkBox1.Image = QuanLyDaiLy.Properties.Resources.eye_3_32;
                txt_Password.UseSystemPasswordChar = true;

            }
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            Authentication();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "THÔNG BÁO"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else { }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btn_ExitApp_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "THÔNG BÁO"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else { }
        }

        private void txt_User_Enter(object sender, EventArgs e)
        {
            if (txt_User.Text == "Tên đăng nhập")
            {
                txt_User.Text = "";
                txt_User.ForeColor = Color.White;
            }
        }

        private void txt_User_Leave(object sender, EventArgs e)
        {
            if (txt_User.Text == "")
            {
                txt_User.Text = "Tên đăng nhập";
                txt_User.ForeColor = Color.DimGray;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Mật khẩu")
            {
                txt_Password.Text = "";
                txt_Password.ForeColor = Color.White;
                txt_Password.UseSystemPasswordChar = true;
                checkBox1.Image = QuanLyDaiLy.Properties.Resources.eye_3_32;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Mật khẩu";
                txt_Password.ForeColor = Color.DimGray;
                checkBox1.Image = QuanLyDaiLy.Properties.Resources.visible_32;
                txt_Password.UseSystemPasswordChar = false;
            }
        }
    }
}
