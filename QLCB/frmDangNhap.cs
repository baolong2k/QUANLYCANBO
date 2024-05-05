using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCB
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Download\Phân Tích Thiết Kế Hệ Thống\FormLogin.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string Username = txtTaiKhoan.Text;
            string Password = txtMatKhau.Text;

            // Kiểm tra xem username và password có được nhập không
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                // Thực hiện truy vấn để kiểm tra username và password trong cơ sở dữ liệu
                string sql = "SELECT * FROM Login WHERE Username = @username AND Password = @password";
                // Thực hiện truy vấn SQL ở đây
                // Nếu tìm thấy người dùng, tiến hành hiển thị MainForm
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !", "Cảnh báo", MessageBoxButtons.OK);
            }
            if (String.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLayLaiMatKhau layLaiMatKhau = new frmLayLaiMatKhau();
            layLaiMatKhau.Show();
            this.Hide();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
