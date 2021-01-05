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
    public partial class UC_TimKiem : UserControl
    {
        public UC_TimKiem()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(c);
        }

        private void btnTimKiemCauThu_Click(object sender, EventArgs e)
        {
            UC_TimKiemCauThu uct = new UC_TimKiemCauThu();
            AddControlsToPanel(uct);
        }

        private void btnTimKiemTranDau_Click(object sender, EventArgs e)
        {
            UC_TimKiemTranDau utd = new UC_TimKiemTranDau();
            AddControlsToPanel(utd);
        }
    }
}
