using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom06_CNTT2K59.UserControls
{
    public partial class UC_TimKiemTranDau : UserControl
    {
        DataTable tb;
        public UC_TimKiemTranDau()
        {
            InitializeComponent();
        }

        private void UC_TimKiemTranDau_Load(object sender, EventArgs e)
        {
            DataTable dt = TranDauDAO.getDataForSearch();
            tb = dt;
            dgvTimKiemTranDau.DataSource = dt;

            DataTable doi = DoiBongDAO.getData();
            FillCbo(doi, cbxDoiNha, "TenDoi");
        }

        void reset()
        {
            txtSoBanThang.Text = txtSoTheDo.Text = "";
            cbxDoiNha.SelectedIndex = -1;
            dgvTimKiemTranDau.DataSource = tb;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void FillCbo(DataTable t, ComboBox cbo, string ten)
        {
            cbo.DataSource = t;
            cbo.ValueMember = ten;
            cbo.SelectedIndex = -1;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataTable tk = TranDauDAO.getDataForSearch();
            DataView dv = tk.DefaultView;
            string filter = "";
            int check = 0;

            if (cbxDoiNha.SelectedIndex != -1)
            {
                string madb = cbxDoiNha.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(madb))
                {
                    filter = filter + "TenDoi like '%" + madb + "%' and";
                    check = 1;
                }
            }

            int sbt;
            if (int.TryParse(txtSoBanThang.Text, out sbt) == true)
            {
                if (!string.IsNullOrEmpty(sbt.ToString()))
                {
                    filter = filter + " SoBanThangDoiNha = '" + sbt + "' and";
                    check = 1;
                }
            }
            else if (int.TryParse(txtSoBanThang.Text, out sbt) == false && txtSoBanThang.Text != "")
            {
                MessageBox.Show("Số bàn thắng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                txtSoBanThang.Focus();
            }

            int sthd;
            if (int.TryParse(txtSoTheDo.Text, out sthd) == true)
            {
                if (!string.IsNullOrEmpty(sthd.ToString()))
                {
                    filter = filter + " SoTheDoDoiNha = '" + sthd + "' and";
                    check = 1;
                }
            }
            else if (int.TryParse(txtSoTheDo.Text, out sthd) == false && txtSoTheDo.Text != "")
            {
                MessageBox.Show("Số thẻ đỏ không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                txtSoTheDo.Focus();
            }

            if (filter.Length > 0 && check == 1)
            {
                string final = filter.Remove(filter.Length - 3, 3);
                dv.RowFilter = final;
            }

            DataTable s = dv.ToTable();
            dgvTimKiemTranDau.DataSource = s;
            if (dgvTimKiemTranDau.Rows.Count < 2)
            {
                MessageBox.Show("Không có kết quả!");
                reset();
                return;
            }
        }
    }
}
