using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom06_CNTT2K59
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUser.Focus();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            this.KeyPreview = true;
            //this.AcceptButton = btnLogin;
        }

        void reset()
        {
            txtUser.Text = txtPass.Text = "";
            txtUser.Focus();
        }

        bool check()
        {
            if (txtUser.Text != "Admin" && txtUser.Text != "admin")
                return false;
            if (txtPass.Text == "Admin" && txtPass.Text == "admin")
                return false;
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (check() == false)
            if (check())
            {
                this.Hide();
                frmMain fd = new frmMain();
                fd.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
