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
    public partial class UC_TimKiemCauThu : UserControl
    {
        DataTable tb;
        public UC_TimKiemCauThu()
        {
            InitializeComponent();
        }

        private void UC_TimKiemCauThu_Load(object sender, EventArgs e)
        {
            DataTable dt = CauThuDAO.getDataForSearch();
            tb = dt;
            dgvTimKiemCauThu.DataSource = dt;

            DataTable doi = DoiBongDAO.getData();
            FillCbo(doi, cbxDoiBong, "TenDoi");
        }

        void reset()
        {
            txtTen.Text = txtSoBanThang.Text = "";
            cbxDoiBong.SelectedIndex = -1;
            dgvTimKiemCauThu.DataSource = tb;
            txtTen.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataTable tk = CauThuDAO.getDataForSearch();
            DataView dv = tk.DefaultView;
            string filter = "";
            int check = 0;

            string tenCT = txtTen.Text;
            if (!string.IsNullOrEmpty(tenCT))
            {
                filter = filter + "TenCauThu like '%" + tenCT + "%' and";
                check = 1;
            }

            if (cbxDoiBong.SelectedIndex != -1)
            {
                string madb = cbxDoiBong.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(madb))
                {
                    filter = filter + " TenDoi like '%" + madb + "%' and";
                    check = 1;
                }
            }

            int sbt;
            if (int.TryParse(txtSoBanThang.Text, out sbt) == true)
            {
                if (!string.IsNullOrEmpty(sbt.ToString()))
                {
                    filter = filter + " SoBanThang = '" + sbt + "' and";
                    check = 1;
                }
            }
            else if (int.TryParse(txtSoBanThang.Text, out sbt) == false && txtSoBanThang.Text != "")
            {
                MessageBox.Show("Số bàn thắng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                txtSoBanThang.Focus();
            }

            if (filter.Length > 0 && check == 1)
            {
                string final = filter.Remove(filter.Length - 3, 3);
                dv.RowFilter = final;
            }

            DataTable s = dv.ToTable();
            dgvTimKiemCauThu.DataSource = s;
            if (dgvTimKiemCauThu.Rows.Count < 2)
            {
                MessageBox.Show("Không có kết quả!");
                reset();
                return;
            }
        }

        private void btnFind2_Click(object sender, EventArgs e)
        {
            DataTable tk = CauThuDAO.getDataForSearch();
            DataView dv = tk.DefaultView;
            string filter = "";
            int check = 0;

            string tenCT = txtTen.Text;
            if (!string.IsNullOrEmpty(tenCT))
            {
                filter = filter + "TenCauThu like '%" + tenCT + "%' and";
                check = 1;
            }

            if (cbxDoiBong.SelectedIndex != -1)
            {
                string madb = cbxDoiBong.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(madb))
                {
                    filter = filter + " TenDoi like '%" + madb + "%' and";
                    check = 1;
                }
            }

            int sbt;
            if (int.TryParse(txtSoBanThang.Text, out sbt) == true)
            {
                if (!string.IsNullOrEmpty(sbt.ToString()))
                {
                    filter = filter + " SoBanThang = '" + sbt + "' and";
                    check = 1;
                }
            }
            else if (int.TryParse(txtSoBanThang.Text, out sbt) == false && txtSoBanThang.Text != "")
            {
                MessageBox.Show("Số bàn thắng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                txtSoBanThang.Focus();
            }

            if (filter.Length > 0 && check == 1)
            {
                string final = filter.Remove(filter.Length - 3, 3);
                dv.RowFilter = final;
            }

            DataTable s = dv.ToTable();
            dgvTimKiemCauThu.DataSource = s;
            if (dgvTimKiemCauThu.Rows.Count < 2)
            {
                MessageBox.Show("Không có kết quả!");
                reset();
                return;
            }
        }

        public void FillCbo(DataTable t, ComboBox cbo, string ten)
        {
            cbo.DataSource = t;
            cbo.ValueMember = ten;
            cbo.SelectedIndex = -1;
        }
    }
}
