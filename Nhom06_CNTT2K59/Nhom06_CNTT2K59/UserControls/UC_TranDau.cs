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
    public partial class UC_TranDau : UserControl
    {
        public UC_TranDau()
        {
            InitializeComponent();
        }

        private void btnThemTranDau_Click(object sender, EventArgs e)
        {
            using (frmTranDau td = new frmTranDau())
            {
                td.ShowDialog();
                btnThemTranDau.IsTab = false;
            }
        }

        private void UC_TranDau_Load(object sender, EventArgs e)
        {
            btnThemTranDau.IsTab = true;
        }
    }
}
