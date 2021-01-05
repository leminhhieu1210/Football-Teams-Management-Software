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
    public partial class FrmVongDau : Form
    {
        public FrmVongDau()
        {
            InitializeComponent();
            Status(null);
        }

        private bool them;
        private bool sua;
        private bool xoa;

        private void FrmVongDau_Load(object sender, EventArgs e)
        {
            LoadDataGV();
        }

        private void FillTextMuaGiai()
        {
            this.muagiaiTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MUAGIAI);
            txt_muagiai.DataSource = this.quanLyGiaiVoDichDataSet.MUAGIAI;
            txt_muagiai.DisplayMember = "TENMUA";
            txt_muagiai.ValueMember = "MAMUA";
        }


        void Databinding()
        {
            try
            {
                txt_mavong.DataBindings.Clear();
                txt_mavong.DataBindings.Add("Text", dataGridView1.DataSource, "MAVONG");

                txt_tenvong.DataBindings.Clear();
                txt_tenvong.DataBindings.Add("Text", dataGridView1.DataSource, "TENVONG");

                txt_muagiai.DataBindings.Clear();
                txt_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "TENMUA");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadDataGV()
        {
            DataTable table = newTable();
            this.vongdauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.VONGDAU);
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.VONGDAU.Rows)
            {
                string mavong = row["MAVONG"].ToString();
                string tenvong = row["TENVONG"].ToString();
                string mamua = row["MAMUA"].ToString();
                table.Rows.Add(addRows(mavong, tenvong, mamua));
            }
            dataGridView1.DataSource = table;
            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        }

        private DataTable newTable()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("MAVONG", typeof (string));
            tb.Columns.Add("TENVONG", typeof (string));
            tb.Columns.Add("TENMUA", typeof (string));
            return tb;
        }

        private Object[] addRows(string mavong, string tenvong, string mamua)
        {

            string[] temp = new string[3];
            temp[0] = mavong;
            temp[1] = tenvong;
            temp[2] = LayTenMua(mamua);
            return temp;
        }

        private string LayTenMua(string mamua)
        {
            string tenmua = "";
            this.muagiaiTableAdapter.FillByMaMua(this.quanLyGiaiVoDichDataSet.MUAGIAI,mamua);
            foreach (DataRow row in  this.quanLyGiaiVoDichDataSet.MUAGIAI.Rows)
            {
                 tenmua = row["TENMUA"].ToString();
            }
            return tenmua;
        }

        private void Status(string stt)
        {
            switch (stt)
            {
                case "them":
                    button_ok.Enabled = true;
                    txt_tenvong.Enabled = true;
                    txt_muagiai.Enabled = true;
                    them = true;
                    sua = false;
                    xoa = false;
                    break;
                case "sua":
                    txt_tenvong.Enabled = true;
                    txt_muagiai.Enabled = true;
                    button_ok.Enabled = true;
                    sua = true;
                    them = false;
                    xoa = false;
                    break;
                case "xoa":
                    txt_tenvong.Enabled = false;
                    txt_muagiai.Enabled = false;
                    button_ok.Enabled = true;
                    them = false;
                    sua = false;
                    xoa = true;
                    break;
                default:
                    txt_tenvong.Enabled = false;
                    txt_muagiai.Enabled = false;
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
                string numbermax = queries.GetMaVongDauMax().ToString();
                if (numbermax != "")
                {

                    int temp = int.Parse(numbermax) + 1;
                    code = "0000" + temp;
                    code = "VD" + code.Substring(code.Length - 4);
                }
                else
                {
                    code = "VD0001";
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
            FillTextMuaGiai();
            txt_muagiai.Text = "";
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Status("sua");
            FillTextMuaGiai();
            Databinding();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            Status("xoa");
            Databinding();

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (them)
            {

                this.vongdauTableAdapter.Insert(SinhMaTuDong(), txt_tenvong.Text.Trim(), txt_muagiai.SelectedValue.ToString());
            }
            else if (sua)
            {

                this.vongdauTableAdapter.UpdateByMaVong(txt_tenvong.Text.Trim(), txt_muagiai.SelectedValue.ToString(), txt_mavong.Text.Trim());
            }
            
            else if (xoa)
            {
                this.vongdauTableAdapter.DeleteByMaVong(txt_mavong.Text.Trim());
            }
            LoadDataGV();
        }
    }
}
