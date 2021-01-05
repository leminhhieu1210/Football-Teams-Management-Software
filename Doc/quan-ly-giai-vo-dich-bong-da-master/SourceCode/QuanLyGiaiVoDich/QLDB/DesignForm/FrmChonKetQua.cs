using System;
using System.Data;
using System.Windows.Forms;

namespace QLDB.DesignForm
{
    public partial class FrmChonKetQua : Form
    {
        public FrmChonKetQua()
        {
            InitializeComponent();
            FillDateGridView();
            Databiding();
            ok = false;
        }



        private string thoigian;
        private string madoi1;
        private string madoi2;
        private string mavongdau;
        private string masan;


        public static bool ok;
        public static string tendoi1;
        public static string tendoi2;
        public static string matrandau;
        public static string mamua;
        public static string sobanthangdoi1;
        public static string sobanthangdoi2;
        public static string thoiluong;

   
        private void Databiding()
        {
            

            txt_doi1.DataBindings.Clear();
            txt_doi1.DataBindings.Add("Text", dataGridView1.DataSource, "TENDOI1");

            txt_doi2.DataBindings.Clear();
            txt_doi2.DataBindings.Add("Text", dataGridView1.DataSource, "TENDOI2");

            txt_thoigian.DataBindings.Clear();
            txt_thoigian.DataBindings.Add("Text", dataGridView1.DataSource, "NGAYGIO");

            txt_san.DataBindings.Clear();
            txt_san.DataBindings.Add("Text", dataGridView1.DataSource, "SAN");

            txt_matrandau.DataBindings.Clear();
            txt_matrandau.DataBindings.Add("Text", dataGridView1.DataSource, "MATD");

            txt_banthangdoi1.DataBindings.Clear();
            txt_banthangdoi1.DataBindings.Add("Text", dataGridView1.DataSource, "SBTDOI1");

            txt_banthangdoi2.DataBindings.Clear();
            txt_banthangdoi2.DataBindings.Add("Text", dataGridView1.DataSource, "SBTDOI2");

            txt_thoiluong.DataBindings.Clear();
            txt_thoiluong.DataBindings.Add("Text", dataGridView1.DataSource, "THOILUONG");

            txt_mamua.DataBindings.Clear();
            txt_mamua.DataBindings.Add("Text", dataGridView1.DataSource, "MUAGIAI");
        }

        private void FillDateGridView()
        {
            DataTable table = newTable();
            this.trandauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.TRANDAU);
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.TRANDAU.Rows)
            {
                if (row["SBTDOI1"].ToString() != "")
                {
                    matrandau = row["MATD"].ToString();
                    madoi1 = row["MADOI1"].ToString();
                    madoi2 = row["MADOI2"].ToString();
                    thoigian = row["NGAYGIO"].ToString();
                    masan = row["MASAN"].ToString();
                    mavongdau = row["MAVONG"].ToString();
                    sobanthangdoi1 = row["SBTDOI1"].ToString();
                    sobanthangdoi2 = row["SBTDOI2"].ToString();
                    thoiluong = row["THOILUONG"].ToString();
                    table.Rows.Add(newRow(matrandau, madoi1, madoi2, thoigian, masan, mavongdau, sobanthangdoi1, sobanthangdoi2, thoiluong));
                }
                
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
            table.Columns.Add("SBTDOI1", typeof(string));
            table.Columns.Add("SBTDOI2", typeof(string));
            table.Columns.Add("THOILUONG", typeof(string));
            return table;
        }

        private Object[] newRow(string matd, string madoi1, string madoi2, string ngaygio, string masan, string mavong, string sbtdoi1, string sbtdoi2, string tholuong)
        {
            string[] row = new string[10];
            row[0] = matd;
            row[1] = LayTenDoi(madoi1);
            row[2] = LayTenDoi(madoi2);
            row[3] = ngaygio;
            row[4] = LayTenSan(masan);
            row[5] = LayTenVongDau(mavong);
            row[6] = LayTenMua(mavong);
            row[7] = sbtdoi1;
            row[8] = sbtdoi2;
            row[9] = thoiluong;
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
            string _mamua="";
            this.vongdauTableAdapter.FillByMaVong(this.quanLyGiaiVoDichDataSet.VONGDAU, mavong);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.VONGDAU.Rows)
            {
                _mamua = r["MAMUA"].ToString();
            }
            this.muagiaiTableAdapter.FillByMaMua(this.quanLyGiaiVoDichDataSet.MUAGIAI, _mamua);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.MUAGIAI.Rows)
            {
                tenmua = r["TENMUA"].ToString();
            }

            return tenmua;
        }

        private string LayMaMua(string mavong)
        {
            string _mamua = "";
            this.vongdauTableAdapter.FillByMaVong(this.quanLyGiaiVoDichDataSet.VONGDAU, mavong);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.VONGDAU.Rows)
            {
                _mamua = r["MAMUA"].ToString();
            }
            return _mamua;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            tendoi1 = txt_doi1.Text.Trim();
            tendoi2 = txt_doi2.Text.Trim();
            sobanthangdoi1 = txt_banthangdoi1.Text.Trim();
            sobanthangdoi2 = txt_banthangdoi2.Text.Trim();
            thoiluong = txt_thoiluong.Text.Trim();
            matrandau = txt_matrandau.Text.Trim();
            mamua = LayMaMua(mavongdau);
            ok = true;
            this.Close();
        }
        
        private void button_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
