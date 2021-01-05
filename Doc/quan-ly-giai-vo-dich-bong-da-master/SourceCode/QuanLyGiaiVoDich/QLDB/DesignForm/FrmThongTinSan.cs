using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDB.DesignForm
{
    public partial class FrmThongTinSan : Form
    {
        public FrmThongTinSan()
        {
            InitializeComponent();
        }

        private void FrmThongTinSan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.SAN' table. You can move, or remove it, as needed.
            this.sANTableAdapter.FillByMaSan(this.quanLyGiaiVoDichDataSet.SAN,FrmThongTinDoi.masan);

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
