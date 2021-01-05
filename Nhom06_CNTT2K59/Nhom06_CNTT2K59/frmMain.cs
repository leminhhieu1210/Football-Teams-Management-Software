using Nhom06_CNTT2K59.UserControls;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            labelTime.Text = DateTime.Now.ToLongTimeString();
            timerTime.Start();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelDay.Text = dt.ToString("dd/MM/yyyy");
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmLogin f = new frmLogin();
            f.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(c);
        }

        private void tab1_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(uC_TranDau1);
            bunifuTransition1.HideSync(uC_TimKiem1);
            bunifuTransition1.HideSync(uC_BaoCao1);
            bunifuTransition1.HideSync(uC_TroGiup1);
            bunifuTransition2.ShowSync(uC_QuanLy1);

            //UC_QuanLy uql = new UC_QuanLy();
            //AddControlsToPanel(uql);
        }

        private void tab2_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(uC_QuanLy1);
            bunifuTransition1.HideSync(uC_TimKiem1);
            bunifuTransition1.HideSync(uC_BaoCao1);
            bunifuTransition1.HideSync(uC_TroGiup1);
            bunifuTransition2.ShowSync(uC_TranDau1);
            //UC_TranDau utd = new UC_TranDau();
            //AddControlsToPanel(utd);


        }

        private void tab3_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(uC_QuanLy1);
            bunifuTransition1.HideSync(uC_TranDau1);
            bunifuTransition1.HideSync(uC_BaoCao1);
            bunifuTransition1.HideSync(uC_TroGiup1);
            bunifuTransition2.ShowSync(uC_TimKiem1);
            //UC_TimKiem utk = new UC_TimKiem();
            //AddControlsToPanel(utk);
        }

        private void tab4_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(uC_QuanLy1);
            bunifuTransition1.HideSync(uC_TranDau1);
            bunifuTransition1.HideSync(uC_TroGiup1);
            bunifuTransition1.HideSync(uC_TimKiem1);
            bunifuTransition2.ShowSync(uC_BaoCao1);
            //UC_BaoCao ubc = new UC_BaoCao();
            //AddControlsToPanel(ubc);
        }

        private void tab5_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(uC_QuanLy1);
            bunifuTransition1.HideSync(uC_TranDau1);
            bunifuTransition1.HideSync(uC_BaoCao1);
            bunifuTransition1.HideSync(uC_TimKiem1);
            bunifuTransition2.ShowSync(uC_TroGiup1);
            //UC_TroGiup utg = new UC_TroGiup();
            //AddControlsToPanel(utg);
        }
    }
}
