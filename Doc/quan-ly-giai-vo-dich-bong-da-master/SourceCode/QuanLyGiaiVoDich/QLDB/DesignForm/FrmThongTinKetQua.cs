
using System;
using System.Data;
using System.Windows.Forms;

namespace QLDB.DesignForm
{
    public partial class FrmThongTinKetQua : MyFormPage
    {
        public FrmThongTinKetQua()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            LoadTreeView();
        }


        private void LoadTreeView()
        {
            this.muagiaiTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MUAGIAI);
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.MUAGIAI.Rows)
            {
                TreeNode muagiaiNode = new TreeNode();
                muagiaiNode.Text = row["TENMUA"].ToString();
                muagiaiNode.Tag = row["MAMUA"].ToString();
                muagiaiNode.Name = "muagiai";
                muagiaiNode.Nodes.Add("*");
                treeView.Nodes.Add(muagiaiNode);
            }
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

        private string LayTenCauThu(string macauthu)
        {
            string tencauthu = "";
            this.cauthuTableAdapter.FillBy_MaCauthu(this.quanLyGiaiVoDichDataSet.CAUTHU, macauthu);
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.CAUTHU)
            {
                tencauthu = row["TENCT"].ToString();
            }
            return tencauthu;
        }

        private string LayLoaiBanThang(string maloaibanthang)
        {
            string loaibanthang = "";
            this.loaibanthangTableAdapter.FillByMaLoaiBanThang(this.quanLyGiaiVoDichDataSet.LOAIBANTHANG, maloaibanthang);
            foreach (DataRow row in quanLyGiaiVoDichDataSet.LOAIBANTHANG.Rows)
            {
                loaibanthang = row["LOAIBT"].ToString();
            }
            return loaibanthang;
        }


        private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "muagiai")
            {
                e.Node.Nodes.Clear();
                this.vongdauTableAdapter.FillByMaMua(this.quanLyGiaiVoDichDataSet.VONGDAU, e.Node.Tag.ToString());
                foreach (DataRow dataRow in this.quanLyGiaiVoDichDataSet.VONGDAU.Rows)
                {
                    TreeNode vongNode = new TreeNode();
                    vongNode.Text = dataRow["TENVONG"].ToString();
                    vongNode.Tag = dataRow["MAVONG"].ToString();
                    vongNode.Name = "vongdau";
                    vongNode.Nodes.Add("*");
                    e.Node.Nodes.Add(vongNode);

                }
            }
            if (e.Node.Name == "vongdau")
            {
                e.Node.Nodes.Clear();          
                this.trandauTableAdapter.FillBy_MaMua_MaVong(this.quanLyGiaiVoDichDataSet.TRANDAU,
                    e.Node.Parent.Tag.ToString(), e.Node.Tag.ToString());
                foreach (DataRow dataRow in this.quanLyGiaiVoDichDataSet.TRANDAU.Rows)
                {
                    TreeNode doiNode = new TreeNode();
                    string tendoi1 = LayTenDoi(dataRow["MADOI1"].ToString());
                    string tendoi2 = LayTenDoi(dataRow["MADOI2"].ToString());
                    doiNode.Text = tendoi1 + " - " + tendoi2;
                    doiNode.Tag = dataRow["MATD"].ToString();
                    doiNode.Name = "doi";
                    e.Node.Nodes.Add(doiNode);
                }
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "doi")
            {
                this.trandauTableAdapter.FillByMaTranDau(this.quanLyGiaiVoDichDataSet.TRANDAU, e.Node.Tag.ToString());
                foreach (DataRow dataRow in this.quanLyGiaiVoDichDataSet.TRANDAU.Rows)
                {
                    txt_doi1.Text = LayTenDoi(dataRow["MADOI1"].ToString());
                    txt_doi2.Text = LayTenDoi(dataRow["MADOI2"].ToString());
                    txt_san.Text = LayTenSan(dataRow["MASAN"].ToString());
                    txt_sobanthangdoi1.Text = dataRow["SBTDOI1"].ToString();
                    txt_sobanthangdoi2.Text = dataRow["SBTDOI2"].ToString();
                    dateTime.Value = Convert.ToDateTime(dataRow["NGAYGIO"].ToString());
                    LoadListView(e.Node.Tag.ToString());
                }
            }
        }

        private void LoadListView(string matrandau)
        {
            this.chitiettrandauTableAdapter.FillByMaTranDau(this.quanLyGiaiVoDichDataSet.CHITIETTRANDAU, matrandau);
            int i = 0;
            foreach (DataRow dataRow in this.quanLyGiaiVoDichDataSet.CHITIETTRANDAU.Rows)
            {
                string tencauthu = LayTenCauThu(dataRow["MACT"].ToString());
                string loaibanthang = LayLoaiBanThang(dataRow["MALOAIBT"].ToString());
                string thoidiem = dataRow["THOIDIEM"].ToString();
                listView.Items.Add(createListViewItem(++i, tencauthu, loaibanthang, thoidiem));
            }
        }

        private ListViewItem createListViewItem(int i,string tencauthu, string loaibanthang, string thoidiem)
        {
            string[] item = new string[4];
            item[0] = i.ToString();
            item[1] = tencauthu;
            item[2] = loaibanthang;
            item[3] = thoidiem;
            return new ListViewItem(item);
        }


    }
}
