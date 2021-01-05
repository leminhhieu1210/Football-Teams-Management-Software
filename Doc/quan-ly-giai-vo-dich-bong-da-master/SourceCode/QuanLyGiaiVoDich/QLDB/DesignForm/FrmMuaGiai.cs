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
    public partial class FrmMuaGiai : Form
    {
        public FrmMuaGiai()
        {
            InitializeComponent();

        }

        private bool them;
        private bool sua;
        private bool xoa;

        private void FrmMuaGiai_Load(object sender, EventArgs e)
        {

            LoadDataGV();
            time_thoigianketthuc.Value = time_thoigianketthuc.Value.AddMonths(1);
            
        }

        private void LoadDataGV()
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.MUAGIAI' table. You can move, or remove it, as needed.
            this.mUAGIAITableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MUAGIAI);

        }

        void Databinding()
        {
            try
            {
                txt_mamua.DataBindings.Clear();
                txt_mamua.DataBindings.Add("Text", dataGridView1.DataSource, "MAMUA");

                txt_tenmua.DataBindings.Clear();
                txt_tenmua.DataBindings.Add("Text", dataGridView1.DataSource, "TENMUA");

                time_thoigianbatdau.DataBindings.Clear();
                time_thoigianbatdau.DataBindings.Add("Text", dataGridView1.DataSource, "TGBATDAU");

                time_thoigianketthuc.DataBindings.Clear();
                time_thoigianketthuc.DataBindings.Add("Text", dataGridView1.DataSource, "TGKETTHUC");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Status(string stt){
            switch (stt)
            {
                case "them":
                    button_ok.Enabled = true;
                    txt_tenmua.Enabled = true;
                    time_thoigianbatdau.Enabled = true;
                    time_thoigianketthuc.Enabled = true;
                    them = true;
                    sua = false;
                    break;
                case "sua":
                    txt_tenmua.Enabled = true;
                    time_thoigianbatdau.Enabled = true;
                    time_thoigianketthuc.Enabled = true;
                    button_ok.Enabled = true;
                    sua = true;
                    them = false;
                    break;
                case "xoa":
                    txt_tenmua.Enabled = false;
                    time_thoigianbatdau.Enabled = false;
                    time_thoigianketthuc.Enabled = false;
                    button_ok.Enabled = true;
                    them = false;
                    sua = false;
                    xoa = true;
                    break;
                default:
                    txt_tenmua.Enabled = false;
                    time_thoigianbatdau.Enabled = false;
                    time_thoigianketthuc.Enabled = false;
                    button_ok.Enabled = false;
                    them = sua = false;
                    break;
            }
        }

        private string SinhMaTuDong()
        {

            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaMuaMax().ToString();
                if (numbermax != "")
                {
                    
                    int temp = int.Parse(numbermax) + 1;
                    code = "000" + temp;
                    code = "MG" + code.Substring(code.Length - 4);
                }
                else
                {
                    code = "MG0001";
                }
                return code;
                
            }
            catch (Exception)
            {
            }
            return null;
        }

        private void button_them_Click(object sender, EventArgs e)
        {
                      
            Status("them");
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
                    DateTime batdau = Convert.ToDateTime(time_thoigianbatdau.Value.ToShortDateString());
                    DateTime ketthuc = Convert.ToDateTime(time_thoigianketthuc.Value.ToShortDateString());

                    if (batdau >= ketthuc)
                    {
                        MessageBox.Show("Thời gian bắt đầu fai nhỏ hơn thời gian kết thúc");
                        return;
                    }

                    this.mUAGIAITableAdapter.Insert(SinhMaTuDong(), txt_tenmua.Text, batdau, ketthuc);

                }
                else if (sua)
                {
                    DateTime batdau = Convert.ToDateTime(time_thoigianbatdau.Value.ToShortDateString());
                    DateTime ketthuc = Convert.ToDateTime(time_thoigianketthuc.Value.ToShortDateString());

                    if (batdau >= ketthuc)
                    {
                        MessageBox.Show("Thời gian bắt đầu fai nhỏ hơn thời gian kết thúc");
                        return;
                    }


                    this.mUAGIAITableAdapter.UpdateByMaMua(txt_tenmua.Text.Trim(), batdau, ketthuc,txt_mamua.Text.Trim());

                }
                else if(xoa)
                {
                    this.mUAGIAITableAdapter.DeleteByMaMua(txt_mamua.Text.Trim());

                }


                LoadDataGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void time_thoigianbatdau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void time_thoigianketthuc_ValueChanged(object sender, EventArgs e)
        {
            }
    }
}
