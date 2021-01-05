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
    public partial class FrmQuyDinhBanThang : MyFormPage
    {
        public FrmQuyDinhBanThang()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            DataBinding_loaict();
            DataBinding_quydinh();
            this.qUYDINHBANTHANGTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.QUYDINHBANTHANG);
            this.lOAIBANTHANGTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LOAIBANTHANG);


        
        }

        private void FrmQuyDinhBanThang_Load(object sender, EventArgs e)
        {
         
        }

        private bool them;
        private bool sua;
        private bool xoa;

        private void Status(string stt)
        {
            switch (stt)
            {
                case "them":
                    button_ok.Enabled = true;
                    button_sua.Enabled = false;
                    button_xoa.Enabled = false;
                    them = true;
                    xoa = false;
                    sua = false;
                    break;
                case "sua":
                    button_ok.Enabled = true;
                    button_them.Enabled = false;
                    button_xoa.Enabled = false;
                    sua = true;
                    them = false;
                    xoa = false;
                    break;
                case "xoa":
                    button_ok.Enabled = true;
                    button_them.Enabled = false;
                    button_sua.Enabled = false;
                    xoa = true;
                    them = false;
                    sua = false;
                    break;
                default:
                    button_ok.Enabled = false;
                    them = sua = xoa = false;
                    button_ok.Enabled = true;
                    button_them.Enabled = true;
                    button_sua.Enabled = true;
                    button_xoa.Enabled = true;
                    break;
            }
        }


        private void DataBinding_loaict()
        {
            txt_maloai.DataBindings.Clear();
            txt_maloai.DataBindings.Add("Text", dataGridView_loaibt.DataSource, "MALOAIBT");

            txt_loaibt.DataBindings.Clear();
            txt_loaibt.DataBindings.Add("Text", dataGridView_loaibt.DataSource, "LOAIBT");
        }

        private void DataBinding_quydinh()
        {
            txt_maqd.DataBindings.Clear();
            txt_maqd.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "MAQD");


            txt_thoidiem.DataBindings.Clear();
            txt_thoidiem.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "THOIDIEMGHIBANTOIDA");

            txt_thang.DataBindings.Clear();
            txt_thang.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "THANG");

            txt_hoa.DataBindings.Clear();
            txt_hoa.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "HOA");

            txt_thua.DataBindings.Clear();
            txt_thua.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "THUA");


        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Status("them");
            txt_loaibt.Text = "";
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Status("sua");
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            Status("xoa");
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {

                if (them)
                {
                    string t = txt_loaibt.Text.Trim();
                    string v = SinhMaTuDong();
                    this.lOAIBANTHANGTableAdapter.Insert(v, t);
                }
                else if (sua)
                {
                    this.lOAIBANTHANGTableAdapter.UpdateByMaBT(txt_loaibt.Text.Trim(), txt_maloai.Text.Trim());
                }
                else if (xoa)
                {
                    this.lOAIBANTHANGTableAdapter.DeleteByMaBT(txt_maloai.Text.Trim());
                }
                this.lOAIBANTHANGTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LOAIBANTHANG);
            
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_dongy_Click(object sender, EventArgs e)
        {
            int thoidiem = int.Parse(txt_thoidiem.Text.Trim());
            int thang = int.Parse(txt_thang.Text.Trim());
            int hoa = int.Parse(txt_hoa.Text.Trim());
            int thua = int.Parse(txt_thua.Text.Trim());
            this.qUYDINHBANTHANGTableAdapter.UpdateByMaqd(thoidiem, thang, hoa, thua, int.Parse(txt_maqd.Text.Trim()));
            this.qUYDINHBANTHANGTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.QUYDINHBANTHANG);
            
        }

        private string SinhMaTuDong()
        {

            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaLoaiBanThangMax().ToString();
                if (numbermax != "")
                {

                    int temp = int.Parse(numbermax) + 1;
                    code = "000" + temp;
                    code = "LBT" + code.Substring(code.Length - 3);
                }
                else
                {
                    code = "LBT001";
                }
                return code;

            }
            catch (Exception)
            {
            }
            return null;
        }

        private void txt_thoidiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_thang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_hoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_thua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            Status("");
            txt_loaibt.Text = "";
        }



    }
}
