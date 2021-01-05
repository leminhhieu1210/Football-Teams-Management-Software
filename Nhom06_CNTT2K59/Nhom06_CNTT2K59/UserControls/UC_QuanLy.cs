using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom06_CNTT2K59.UserControls
{
    public partial class UC_QuanLy : UserControl
    {
        public UC_QuanLy()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(c);
        }

        private void btnDoiBong_Click(object sender, EventArgs e)
        {
            UC_DoiBong udb = new UC_DoiBong();
            AddControlsToPanel(udb);
        }

        private void btnCauThu_Click(object sender, EventArgs e)
        {
            UC_CauThu uct = new UC_CauThu();
            AddControlsToPanel(uct);
        }
    }
}
