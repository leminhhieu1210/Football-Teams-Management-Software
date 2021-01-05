using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace QLDB.DesignForm
{
    public partial class FrmThongTinLichThiDau : MyFormPage
    {
        public FrmThongTinLichThiDau()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            Filltext_MuaGiai();
            LoadListView();


        }

        #region fill text
        private void Filltext_MuaGiai()
        {
            this.muagiaiTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MUAGIAI);
            DataTable tb = this.quanLyGiaiVoDichDataSet.MUAGIAI.Copy();
            cbox_muagiai.DataSource = tb;cbox_muagiai.DisplayMember = "TENMUA";
            cbox_muagiai.ValueMember = "MAMUA";

        }

        private void Filltext_VongDau(string mamua)
        {
            this.vongdauTableAdapter.FillByMaMua(this.quanLyGiaiVoDichDataSet.VONGDAU, mamua);
            DataTable tb = this.quanLyGiaiVoDichDataSet.VONGDAU;
            cbox_vong.DataSource = tb;
            cbox_vong.DisplayMember = "TENVONG";
            cbox_vong.ValueMember = "MAVONG";
        }
        #endregion

        #region Load listview

        private void AddItemListView(ListView lv, ListViewItem item)
        {
            lv.Items.Add(item);
        }

        private void LoadListView()
        {
            string matrandau, madoi1, madoi2, mavongdau, masan;
            DateTime thoigian;
            listView.Items.Clear();
            this.trandauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.TRANDAU);
            int i = 0;
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.TRANDAU.Rows)
            {
                matrandau = row["MATD"].ToString();
                madoi1 = row["MADOI1"].ToString();
                madoi2 = row["MADOI2"].ToString();
                thoigian = Convert.ToDateTime(row["NGAYGIO"].ToString());
                masan = row["MASAN"].ToString();
                mavongdau = row["MAVONG"].ToString();
                AddItemListView(listView, newItemListView(Convert.ToString(++i), madoi1, madoi2, thoigian, masan, mavongdau));
            }
        }

        private ListViewItem newItemListView(string matd, string madoi1, string madoi2, DateTime ngaygio, string masan,
            string mavong)
        {
            string[] item = new string[7];
            ListViewItem listitem;
            item[0] = matd;
            item[1] = LayTenDoi(madoi1);
            item[2] = LayTenDoi(madoi2);
            item[3] = ngaygio.ToString("HH:mm MM/dd/yyyy");
            item[4] = LayTenSan(masan);
            item[5] = LayTenVongDau(mavong);
            item[6] = LayTenMua(mavong);
            listitem = new ListViewItem(item);
            listitem.Tag = item[1] + " - " + item[2];
            listitem.Name = item[6] + " - " + item[5];
            return listitem;
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

        #endregion

        #region event

        private void cbox_muagiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_muagiai.SelectedValue != null)
            {
                Filltext_VongDau(cbox_muagiai.SelectedValue.ToString());
                try
                {
                    int kq = int.Parse(cbox_muagiai.SelectedValue.ToString().Substring(2))/1;
                    LoadListView();
                    Search_MuaGiai(cbox_muagiai.Text.Trim());
                }
                catch (Exception)
                {
                    
                }

            }
        }

        private void cbox_vong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_vong.SelectedValue != null)
            {
                try
                {
                    int kq = int.Parse(cbox_vong.SelectedValue.ToString().Substring(2)) / 1;
                    LoadListView();
                    Search_Vong(cbox_muagiai.Text.Trim());
                }
                catch (Exception)
                {

                }

            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {

            if (txt_search.Text != "")
            {
                Search(txt_search.Text.Trim());

            }

        }

        private void Search(string textsearch)
        {
            if (textsearch != "")
            {
                foreach (ListViewItem item in listView.Items)
                {
                    if (Convert.ToString(item.Tag).ToLower().Contains(textsearch.ToLower()))
                    {

                        item.Selected = true;
                    }
                    else
                    {
                        listView.Items.Remove(item);
                    }
                }

                if (listView.SelectedItems.Count == 1)
                {
                    listView.Focus();
                }
            }
        }

        private void Search_MuaGiai(string textsearch)
        {
            if (textsearch != "")
            {
                foreach (ListViewItem item in listView.Items)
                {
                    if (Convert.ToString(item.SubItems[6]).ToLower().Contains(textsearch.ToLower()))
                    {

                        item.Selected = true;
                    }
                    else
                    {
                        listView.Items.Remove(item);
                    }
                }

                if (listView.SelectedItems.Count == 1)
                {
                    listView.Focus();
                }
            }
        }

        private void Search_Vong(string textsearch)
        {
            if (textsearch != "")
            {
                foreach (ListViewItem item in listView.Items)
                {
                    if (Convert.ToString(item.SubItems[5]).ToLower().Contains(textsearch.ToLower()))
                    {

                        item.Selected = true;
                    }
                    else
                    {
                        listView.Items.Remove(item);
                    }
                }

                if (listView.SelectedItems.Count == 1)
                {
                    listView.Focus();
                }
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            button_refresh_Click(sender, e);

        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            label_doi1.Text = listView.SelectedItems[0].SubItems[1].Text;
            label_doi2.Text = listView.SelectedItems[0].SubItems[2].Text;
            label_thoigian.Text = listView.SelectedItems[0].SubItems[3].Text;
            label_san.Text = listView.SelectedItems[0].SubItems[4].Text;
            label_vong.Text = listView.SelectedItems[0].SubItems[5].Text;
            label_mua.Text = listView.SelectedItems[0].SubItems[6].Text;
        }
        #endregion
    }

}

