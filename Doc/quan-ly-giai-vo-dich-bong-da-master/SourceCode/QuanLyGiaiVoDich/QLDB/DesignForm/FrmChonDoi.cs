
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDB.DesignForm
{
    public partial class FrmChonDoi : Form
    {
        public FrmChonDoi()
        {
            InitializeComponent();
            FillDataGridView();
            FilltextMuaGiai();
            DataBinding();
        }

        public static string madoi = "";
        public static string tendoi = "";
        public static string mamua = "";
        public static string tenmua = "";


        void DataBinding()
        {
            txt_madoi.DataBindings.Clear();
            txt_madoi.DataBindings.Add("Text", dataGridView1.DataSource, "MADOI");

            txt_tendoi.DataBindings.Clear();
            txt_tendoi.DataBindings.Add("Text", dataGridView1.DataSource, "TENDOI");

            txt_sannha.DataBindings.Clear();
            txt_sannha.DataBindings.Add("Text", dataGridView1.DataSource, "TENSAN");

            txt_muagiai.DataBindings.Clear();
            txt_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "TENMUA");

        }

        private void FilltextMuaGiai()
        {
            this.mUAGIAITableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MUAGIAI);
            txt_muagiai.DataSource = quanLyGiaiVoDichDataSet.MUAGIAI;
            txt_muagiai.DisplayMember = "TENMUA";
            txt_muagiai.ValueMember = "MAMUA";
        }

        void FillDataGridView()
        {

            this.doibongTableAdapter.FillBy_Mamua_Madoi_Masan(this.quanLyGiaiVoDichDataSet.DOIBONG);
            dataGridView1.DataSource = quanLyGiaiVoDichDataSet.DOIBONG;
            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        
        }

        private void button_OK_Click(object sender, System.EventArgs e)
        {
            madoi = txt_madoi.Text.Trim();
            tendoi = txt_tendoi.Text.Trim();
            tenmua = txt_muagiai.Text.Trim();
            mamua = txt_muagiai.SelectedValue.ToString();
            this.Close();
        }

        private void button_huy_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void FrmChonDoi_Load(object sender, System.EventArgs e)
        {


        }

        private void txt_muagiai_SelectedIndexChanged(object sender, System.EventArgs e)
        {
      
        }

    }
}
