using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;
using QLDB.QuanLyGiaiVoDichDataSetTableAdapters;


namespace QLDB.DesignForm
{
    public partial class FrmTranDau : MyFormPage
    { 
        public FrmTranDau()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            Status(null);
            LoadDateGV();
            tbSan = CreateTable();
        }

        #region Properties

        private bool them;
        private bool sua;
        private bool xoa;

        private string mavongdau;

        private string matrandau;

        private string madoi1;
        private string madoi2;

        private DateTime thoigian;
        private string masan;

        private DataTable tbSan = new DataTable();

        #endregion

        #region Status-ClearText
        private void ClearText()
        {
            txt_muagiai.Text = "";
            txt_vongdau.Text = "";
            txt_doi1.Text = "";
            txt_doi2.Text = "";
            txt_san.Text = "";
            dateTime.Value = DateTime.Now;
        }

        private void Status(string stt)
        {
            switch (stt)
            {
                case "them":
                    txt_muagiai.Enabled = true;
                    txt_vongdau.Enabled = true;
                    txt_doi1.Enabled = true;
                    txt_doi2.Enabled = true;
                    txt_san.Enabled = true;
                    dateTime.Enabled = true;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    them = true;
                    xoa = false;
                    sua = false;
                    break;
                case "sua":
                    txt_muagiai.Enabled = true;
                    txt_vongdau.Enabled = true;
                    txt_doi1.Enabled = true;
                    txt_doi2.Enabled = true;
                    txt_san.Enabled = true;
                    dateTime.Enabled = true;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    sua = true;
                    them = false;
                    xoa = false;
                    break;
                case "xoa":
                    txt_muagiai.Enabled = false;
                    txt_vongdau.Enabled = false;
                    txt_doi1.Enabled = false;
                    txt_doi2.Enabled = false;
                    txt_san.Enabled = false;
                    dateTime.Enabled = false;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    xoa = true;
                    them = false;
                    sua = false;
                    break;
                default:
                    txt_muagiai.Enabled = false;
                    txt_vongdau.Enabled = false;
                    txt_doi1.Enabled = false;
                    txt_doi2.Enabled = false;
                    txt_san.Enabled = false;
                    dateTime.Enabled = false;
                    button_ok.Enabled = false;
                    button_huy.Enabled = false;
                    them = sua = xoa = false;
                    ClearText();
                    break;
            }
        }
        #endregion

        #region Load datagridview
        private void LoadDateGV()
        {
            this.trandauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.TRANDAU);
            DataTable table = newTable();
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.TRANDAU.Rows)
            {
                matrandau = row["MATD"].ToString();
                madoi1 = row["MADOI1"].ToString();
                madoi2 = row["MADOI2"].ToString();
                thoigian = Convert.ToDateTime(row["NGAYGIO"].ToString());
                masan = row["MASAN"].ToString();
                mavongdau = row["MAVONG"].ToString();
                table.Rows.Add(newRow(matrandau, madoi1, madoi2, thoigian, masan, mavongdau));

            }
            dataGridView1.DataSource = table;
            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        }

        private DataTable newTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MATD", typeof(string));
            table.Columns.Add("TENDOI1", typeof(string));
            table.Columns.Add("TENDOI2", typeof(string));
            table.Columns.Add("NGAYGIO", typeof(string));
            table.Columns.Add("SAN", typeof(string));
            table.Columns.Add("VONGDAU", typeof(string));
            table.Columns.Add("MUAGIAI", typeof(string));
            return table;
        }

        private Object[] newRow(string matd, string madoi1, string madoi2, DateTime ngaygio, string masan, string mavong)
        {
            string[] row = new string[7];
            row[0] = matd;
            row[1] = LayTenDoi(madoi1);
            row[2] = LayTenDoi(madoi2);
            row[3] = ngaygio.ToString("HH:mm MM/dd/yyyy");
            row[4] = LayTenSan(masan);
            row[5] = LayTenVongDau(mavong);
            row[6] = LayTenMua(mavong);
            return row;
        }

        private string LayTenDoi(string madoi)
        {
            string tendoi = "";
            this.doibongTableAdapter.FillByMadoi(this.quanLyGiaiVoDichDataSet.DOIBONG, madoi);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.DOIBONG.Rows)
            {
                tendoi = r["TENDOI"].ToString();
            }
            return tendoi;
        }

        private string LayTenSan(string masan)
        {
            string tensan = "";
            this.sanTableAdapter.FillByMaSan(this.quanLyGiaiVoDichDataSet.SAN, masan);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.SAN.Rows)
            {
                tensan = r["TENSAN"].ToString();
            }
            return tensan;
        }

        private string LayTenVongDau(string mavong)
        {
            string tenvong = "";
            this.vongdauTableAdapter.FillByMaVong(this.quanLyGiaiVoDichDataSet.VONGDAU, mavong);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.VONGDAU.Rows)
            {
                tenvong = r["TENVONG"].ToString();
            }
            return tenvong;
        }

        private string LayTenMua(string mavong)
        {
            string tenmua = "";
            string mamua = "";
            this.vongdauTableAdapter.FillByMaVong(this.quanLyGiaiVoDichDataSet.VONGDAU, mavong);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.VONGDAU.Rows)
            {
                mamua = r["MAMUA"].ToString();
            }
            this.muagiaiTableAdapter.FillByMaMua(this.quanLyGiaiVoDichDataSet.MUAGIAI, mamua);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.MUAGIAI.Rows)
            {
                tenmua = r["TENMUA"].ToString();
            }

            return tenmua;
        }

        private DataTable CreateTable()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("TENSAN", typeof(string));
            tb.Columns.Add("MASAN", typeof(string));
            return tb;
        }

        private void AddRow(ref DataTable tb, string[] row)
        {
            tb.Rows.Add(row);
        }

        private string[] GetInfo_San(string _madoi, string _mamua)
        {
            string[] temp = new string[2];
            this.sanTableAdapter.FillBy_Madoi_Mamua(this.quanLyGiaiVoDichDataSet.SAN, _madoi, _mamua);
            foreach (DataRow dataRow in this.quanLyGiaiVoDichDataSet.SAN.Rows)
            {
                temp[0] = dataRow["TENSAN"].ToString();
                temp[1] = dataRow["MASAN"].ToString();
            }
            return temp;
        }


        #endregion

        #region filltext databinding

        private void Filltext_Muagiai()
        {
            try
            {
                this.muagiaiTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MUAGIAI);
                txt_muagiai.DataSource = this.quanLyGiaiVoDichDataSet.MUAGIAI;
                txt_muagiai.DisplayMember = "TENMUA";
                txt_muagiai.ValueMember = "MAMUA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Filltext_vongdau(string _mamua)
        {
            try
            {
                this.vongdauTableAdapter.FillByMaMua(this.quanLyGiaiVoDichDataSet.VONGDAU, _mamua);
                txt_vongdau.DataSource = this.quanLyGiaiVoDichDataSet.VONGDAU;
                txt_vongdau.DisplayMember = "TENVONG";
                txt_vongdau.ValueMember = "MAVONG";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void Filltext_Tendoi(ref ComboBox cbox, DataTable table)
        {
            try
            {
                cbox.DataSource = table;
                cbox.DisplayMember = "TENDOI";
                cbox.ValueMember = "MADOI";
                cbox.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbox.AutoCompleteSource = AutoCompleteSource.ListItems;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Databiding()
        {
            txt_muagiai.DataBindings.Clear();
            txt_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "MUAGIAI");

            txt_doi1.DataBindings.Clear();
            txt_doi1.DataBindings.Add("Text", dataGridView1.DataSource, "TENDOI1");

            txt_doi2.DataBindings.Clear();
            txt_doi2.DataBindings.Add("Text", dataGridView1.DataSource, "TENDOI2");

            dateTime.DataBindings.Clear();
            dateTime.DataBindings.Add("Text", dataGridView1.DataSource, "NGAYGIO");

            txt_san.DataBindings.Clear();
            txt_san.DataBindings.Add("Text", dataGridView1.DataSource, "SAN");

            txt_vongdau.DataBindings.Clear();
            txt_vongdau.DataBindings.Add("Text", dataGridView1.DataSource, "VONGDAU");

            txt_muagiai.DataBindings.Clear();
            txt_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "MUAGIAI");

            txt_matrandau.DataBindings.Clear();
            txt_matrandau.DataBindings.Add("Text", dataGridView1.DataSource, "MATD");
        }

        private string SinhMaTuDong()
        {

            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaTranDauMax().ToString();
                if (numbermax != "")
                {

                    int temp = int.Parse(numbermax) + 1;
                    code = "0000" + temp;
                    code = "TD" + code.Substring(code.Length - 4);
                }
                else
                {
                    code = "TD0001";
                }
                return code;

            }
            catch (Exception)
            {
            }
            return null;
        }
        #endregion
        
        #region event

        private void button_them_Click(object sender, EventArgs e)
        {
            Status("them");
            Filltext_Muagiai();
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            Status("sua");
            Filltext_Muagiai();
            Filltext_vongdau(txt_muagiai.SelectedValue.ToString());
            Databiding();

                
            
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            Status("xoa");
            Databiding();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (them)
                {
                    matrandau = SinhMaTuDong();
                    madoi1 = txt_doi1.SelectedValue.ToString();
                    madoi2 = txt_doi2.SelectedValue.ToString();
                    thoigian = Convert.ToDateTime(dateTime.Value.ToString("MM-dd-yyyy HH:mm"));
                    masan = txt_san.SelectedValue.ToString();
                    mavongdau = txt_vongdau.SelectedValue.ToString();

                    this.trandauTableAdapter.Insert(matrandau, madoi1, madoi2, thoigian, masan, mavongdau, null, null, null);
                    MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (sua)
                {
                    matrandau = txt_matrandau.Text.Trim();
                    madoi1 = txt_doi1.SelectedValue.ToString();
                    madoi2 = txt_doi2.SelectedValue.ToString();
                    thoigian = Convert.ToDateTime(dateTime.Value.ToString());
                    masan = txt_san.SelectedValue.ToString();
                    mavongdau = txt_vongdau.SelectedValue.ToString();

                    this.trandauTableAdapter.UpdateByMaTranDau(madoi1, madoi2, thoigian, masan, mavongdau, matrandau);
                    MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (xoa)
                {
                    if (
                        MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                        DialogResult.Yes)
                    {
                        matrandau = txt_matrandau.Text.Trim();
                        this.trandauTableAdapter.DeleteByMaTranDau(matrandau);
                    }
                    
                }
                LoadDateGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            Status(null);
        }

        private void FrmTranDau_Load(object sender, EventArgs e)
        {

        }

        private void txt_muagiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_muagiai.SelectedValue != null)
            {
                this.doibongTableAdapter.FillBy_Mamua(this.quanLyGiaiVoDichDataSet.DOIBONG, txt_muagiai.SelectedValue.ToString());
                DataTable tb1 = this.quanLyGiaiVoDichDataSet.DOIBONG.Copy();
                DataTable tb2 = this.quanLyGiaiVoDichDataSet.DOIBONG.Copy();
                Filltext_vongdau(txt_muagiai.SelectedValue.ToString());
                Filltext_Tendoi(ref txt_doi1, tb1);
                Filltext_Tendoi(ref txt_doi2, tb2);
            }
            
                
        }

        private void txt_doi1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddRow(ref tbSan,GetInfo_San(txt_doi1.SelectedValue.ToString(),txt_muagiai.SelectedValue.ToString()));
            txt_san.DataSource = tbSan;
            txt_san.DisplayMember = "TENSAN";
            txt_san.ValueMember = "MASAN";
        }

        private void txt_doi2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            AddRow(ref tbSan, GetInfo_San(txt_doi2.SelectedValue.ToString(), txt_muagiai.SelectedValue.ToString()));
            txt_san.DataSource = tbSan;
            txt_san.DisplayMember = "TENSAN";
            txt_san.ValueMember = "MASAN";
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            if (dateTime.Value < DateTime.Now)
                dateTime.Value = dateTime.Value.AddDays(1);

            if (dateTime.Value < DateTime.Now)
            {
                MessageBox.Show("Thời gian diển ra phải lớn hơn thời gian hiện tại");
                dateTime.Value = dateTime.Value.AddDays(1);

            }

        }

        #endregion
    }
}