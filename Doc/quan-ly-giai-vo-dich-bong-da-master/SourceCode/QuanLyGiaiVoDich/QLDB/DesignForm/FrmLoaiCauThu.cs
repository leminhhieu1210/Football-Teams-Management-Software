using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDB.QuanLyGiaiVoDichDataSetTableAdapters;

namespace QLDB.DesignForm
{
    public partial class FrmLoaiCauThu : Form
    {
        public FrmLoaiCauThu()
        {
            InitializeComponent();
        }

        private bool them;
        private bool sua;
        private bool xoa;

        private void FrmLoaiCauThu_Load(object sender, EventArgs e)
        {
            LoadDataGV();
            Status(null);
        }

       
        private void LoadDataGV()
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.LOAICAUTHU' table. You can move, or remove it, as needed.
            this.lOAICAUTHUTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LOAICAUTHU);        
        }

        void Databinding()
        {
            try
            {
                txt_maloaict.DataBindings.Clear();
                txt_maloaict.DataBindings.Add("Text", dataGridView1.DataSource, "MALOAICT");

                txt_tenloaict.DataBindings.Clear();
                txt_tenloaict.DataBindings.Add("Text", dataGridView1.DataSource, "LOAICT");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Status(string stt)
        {
            switch (stt)
            {
                case "them":
                    button_ok.Enabled = true;
                    txt_tenloaict.Enabled = true;
                    them = true;
                    sua = false;
                    xoa = false;
                    break;
                case "sua":
                    txt_tenloaict.Enabled = true;
                    button_ok.Enabled = true;
                    sua = true;
                    them = false;
                    xoa = false;
                    break;
                case "xoa":
                    txt_tenloaict.Enabled = true;
                    button_ok.Enabled = true;
                    them = false;
                    sua = false;
                    xoa = true;
                    break;
                default:
                    txt_tenloaict.Enabled = false;
                    button_ok.Enabled = false;
                    them = sua = xoa = false;
                    break;
            }
        }

        private string SinhMaTuDong()
        {

            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaLoaiCauThuMax().ToString();
                if (numbermax != "")
                {

                    int temp = int.Parse(numbermax) + 1;
                    code = "000" + temp;
                    code = "LCT" + code.Substring(code.Length - 3);
                }
                else
                {
                    code = "LCT001";
                }
                return code;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Status("them");
            txt_tenloaict.Text = "";
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Status("sua");
            Databinding();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            Status("xoa");
            Databinding();

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (them)
                {
                    this.lOAICAUTHUTableAdapter.Insert(SinhMaTuDong(), txt_tenloaict.Text.Trim());
                }
                else if (sua)
                {
                    this.lOAICAUTHUTableAdapter.UpdateByMaLoaiCT(txt_tenloaict.Text.Trim(), txt_maloaict.Text.Trim());
                }
                else if (xoa)
                {
                    this.lOAICAUTHUTableAdapter.DeleteByMaLoaiCT(txt_maloaict.Text.Trim());
                }
                LoadDataGV();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
