using System;
using System.Data;
using System.Windows.Forms;

namespace QLDB.DesignForm
{
    public partial class FrmTimKiem : MyFormPage
    {
        public FrmTimKiem()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            FillText_MuaGiai();
            cbox_muagiai.Text = "";
        }

        private bool search = false;

        private void FillText_MuaGiai()
        {
            this.muagiaiTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MUAGIAI);
            cbox_muagiai.DataSource = this.quanLyGiaiVoDichDataSet.MUAGIAI;
            cbox_muagiai.DisplayMember = "TENMUA";
            cbox_muagiai.ValueMember = "MAMUA";


        }

        private void FillText_Doi(string mamua)
        {
            this.doibongTableAdapter.FillBy_Mamua(this.quanLyGiaiVoDichDataSet.DOIBONG, mamua);
            cbox_chondoi.DataSource = this.quanLyGiaiVoDichDataSet.DOIBONG;
            cbox_chondoi.DisplayMember = "TENDOI";
            cbox_chondoi.ValueMember = "MADOI";
        }

        private void AddItemListView(ListView lv, ListViewItem item)
        {
            lv.Items.Add(item);
        }

        private void Getinfo_Doi(string mamua)
        {
            string[] temp = new string[5];
            this.doibonG_MUAGIAITableAdapter.FillByMaMua(this.quanLyGiaiVoDichDataSet.DOIBONG_MUAGIAI, mamua);
            int i = 0;
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.DOIBONG_MUAGIAI.Rows)
            {
                string[] info = GetInfoSan(row["MASANNHA"].ToString());
                temp[0] = Convert.ToString(++i);
                temp[1] = GetTenDoi(row["MADOI"].ToString());
                temp[2] = info[0];
                temp[3] = info[1];
                temp[4] = info[2];
                AddItemListView(listView_doi, new ListViewItem(temp));
            }
        }

        private string GetTenDoi(string madoi)
        {
            string tendoi = "";
            this.doibongTableAdapter.FillByMadoi(this.quanLyGiaiVoDichDataSet.DOIBONG, madoi);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.DOIBONG.Rows)
            {
                tendoi = r["TENDOI"].ToString();
            }
            return tendoi;
        }

        private string[] GetInfoSan(string masan)
        {
            string[] info = new string[3];
            this.sanTableAdapter.FillByMaSan(this.quanLyGiaiVoDichDataSet.SAN, masan);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.SAN.Rows)
            {
                info[0] = r["TENSAN"].ToString();
                info[1] = r["SUCCHUA"].ToString();
                info[2] = r["DIACHI"].ToString();
            }
            return info;
        }

        private void Getinfo_CauThu(string madoi, string mamua)
        {
            string[] temp = new string[7];
            this.doibonG_CAUTHUTableAdapter.FillBy_Madoi_Mamua(this.quanLyGiaiVoDichDataSet.DOIBONG_CAUTHU, madoi, mamua);
            int i = 0;
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.DOIBONG_CAUTHU.Rows)
            {
                string[] info = GetInfoCauThu(row["MACT"].ToString());
                temp[0] = Convert.ToString(++i);
                temp[1] = info[0];
                temp[2] = info[1];
                temp[3] = info[2];
                temp[4] = info[3];
                temp[5] = info[4];
                temp[6] = row["SOLUONGBT"].ToString();
                AddItemListView(listView_cauthu, new ListViewItem(temp));
            }
        }

        private string[] GetInfoCauThu(string macauthu)
        {
            string[] info = new string[5];
            this.cauthuTableAdapter.FillBy_MaCauthu(this.quanLyGiaiVoDichDataSet.CAUTHU, macauthu);
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.CAUTHU.Rows)
            {
                info[0] = row["TENCT"].ToString();
                info[1] = row["NGAYSINH"].ToString();
                info[2] = GetLoaiCauThu(row["MALOAICT"].ToString());
                info[3] = row["QUOCTICH"].ToString();
                info[4] = row["GHICHU"].ToString();
            }
            return info;
        }

        private string GetLoaiCauThu(string maloaicauthu)
        {
            string loaict = "";
            this.loaicauthuTableAdapter.FillBy_MaLoaiCT(this.quanLyGiaiVoDichDataSet.LOAICAUTHU, maloaicauthu);
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.LOAICAUTHU.Rows)
            {
                loaict = row["LOAICT"].ToString();
            }
            return loaict;
        }


        private void button_search_Click(object sender, EventArgs e)
        {
            listView_doi.Items.Clear();
            Getinfo_Doi(cbox_muagiai.SelectedValue.ToString());
            FillText_Doi(cbox_muagiai.SelectedValue.ToString());
            search = true;
        }

        private void cbox_muagiai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbox_chondoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (search)
            {
                listView_cauthu.Items.Clear();
                Getinfo_CauThu(cbox_chondoi.SelectedValue.ToString(), cbox_muagiai.SelectedValue.ToString());
            }
        }

        private void txt_cauthu_MouseClick(object sender, MouseEventArgs e)
        {
            txt_cauthu.Text = "";
        }

        private void button_searchct_Click(object sender, EventArgs e)
        {
            //this.cauthuTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.CAUTHU);
            //foreach (DataRow row in this.quanLyGiaiVoDichDataSet.CAUTHU.Rows)
            //{
            //    if (!Search(row["TENCT"].ToString(), txt_cauthu.Text.Trim()))
            //    {
            //        this.quanLyGiaiVoDichDataSet.CAUTHU.Rows.Remove(row);
            //    }
            //}

            //string[] temp = new string[5];

            //int i = 0;
            //foreach (DataRow row in this.quanLyGiaiVoDichDataSet.CAUTHU.Rows)
            //{
            //    string[] info = GetInfoCauThu(row["MACT"].ToString());
            //    temp[0] = Convert.ToString(++i);
            //    temp[1] = info[0];
            //    temp[2] = info[1];
            //    temp[3] = info[2];
            //    temp[4] = info[3];
            //    temp[5] = info[4];
            //    AddItemListView(listView_cauthu, new ListViewItem(temp));
            //}

        }

        private bool Search(string text, string textsearch)
        {
            if (textsearch != "")
            {

                if (text.ToLower().Contains(textsearch.ToLower()))
                {

                    return true;
                }
            }
            return false;
        }
    }
}