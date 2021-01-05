using System;
using System.Data;
using System.Windows.Forms;

namespace QLDB.DesignForm
{
    public partial class FrmChonTranDau : Form
    {
        public FrmChonTranDau()
        {
            InitializeComponent();
            LoadDateGV();
            Databiding();
            ok = false;

        }

        public static bool ok;

        public static string mamua;
        public static string tenmua;

        public static string mavongdau;
        public static string tenvongdau;

        public static string matrandau;

        public static string madoi1;
        public static string doi1;
        public static string madoi2;
        public static string doi2;

        public static DateTime thoigian;
        public static string masan;
        public static string tensan;

        private void Databiding()
        {
            txt_muagiai.DataBindings.Clear();
            txt_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "MUAGIAI");

            txt_doi1.DataBindings.Clear();
            txt_doi1.DataBindings.Add("Text", dataGridView1.DataSource, "TENDOI1");

            txt_doi2.DataBindings.Clear();
            txt_doi2.DataBindings.Add("Text", dataGridView1.DataSource, "TENDOI2");

            txt_thoigian.DataBindings.Clear();
            txt_thoigian.DataBindings.Add("Text", dataGridView1.DataSource, "NGAYGIO");

            txt_san.DataBindings.Clear();
            txt_san.DataBindings.Add("Text", dataGridView1.DataSource, "SAN");

            txt_vongdau.DataBindings.Clear();
            txt_vongdau.DataBindings.Add("Text", dataGridView1.DataSource, "VONGDAU");

            txt_muagiai.DataBindings.Clear();
            txt_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "MUAGIAI");

            txt_matrandau.DataBindings.Clear();
            txt_matrandau.DataBindings.Add("Text", dataGridView1.DataSource, "MATD");
        }

        //private void FillDateGridView()
        //{
        //    _tranDauData.TranDauConnect();
        //    DataTable table = newTable();
        //    foreach (DataRow row in _tranDauData.FillTable().Rows)
        //    {
        //        if (row["SBTDOI1"].ToString() == "")
        //        {
        //            matrandau = row["MATD"].ToString();
        //            madoi1 = row["MADOI1"].ToString();madoi2 = row["MADOI2"].ToString();
        //            thoigian = row["NGAYGIO"].ToString();
        //            masan = row["MASAN"].ToString();
        //            mavongdau = row["MAVONG"].ToString();
        //            table.Rows.Add(newRow(matrandau, madoi1, madoi2, thoigian, masan, mavongdau)); 
        //        }
                
        //    }
        //    _tranDauData.TranDauClose();
        //    dataGridView1.DataSource = table;

        //    foreach (DataGridViewBand band in dataGridView1.Columns)
        //    {
        //        band.ReadOnly = true;
        //    }
        //}


        //private DataTable newTable()
        //{
        //    DataTable table = new DataTable();
        //    table.Columns.Add("MATD", typeof(string));
        //    table.Columns.Add("TENDOI1", typeof(string));
        //    table.Columns.Add("TENDOI2", typeof(string));
        //    table.Columns.Add("NGAYGIO", typeof(string));
        //    table.Columns.Add("SAN", typeof(string));
        //    table.Columns.Add("VONGDAU", typeof(string));
        //    table.Columns.Add("MUAGIAI", typeof(string));
        //    return table;
        //}

        //private Object[] newRow(string matd, string madoi1, string madoi2, string ngaygio, string masan, string mavong)
        //{
        //    string[] row = new string[7];
        //    row[0] = matd;
        //    row[1] = LayTenDoi(madoi1);
        //    row[2] = LayTenDoi(madoi2);
        //    row[3] = ngaygio;
        //    row[4] = LayTenSan(masan);
        //    row[5] = LayTenVongDau(mavong);
        //    row[6] = LayTenMua(mavong);
        //    return row;
        //}

        //private string LayTenDoi(string madoi)
        //{
        //    string tendoi = "";
        //    _doiBongData.DoiBongConnect();
        //    foreach (DataRow r in _doiBongData.FillTable_tendoi(madoi).Rows)
        //    {
        //        tendoi = r["TENDOI"].ToString();
        //    }
        //    _doiBongData.DoiBongClose();
        //    return tendoi;
        //}

        //private string LayTenSan(string masan)
        //{
        //    string tensan = "";
        //    _sanData.SanConnect();
        //    foreach (DataRow r in _sanData.FillTable_tensan(masan).Rows)
        //    {
        //        tensan = r["TENSAN"].ToString();
        //    }
        //    _sanData.SanClose();
        //    return tensan;
        //}

        //private string LayTenVongDau(string mavong)
        //{
        //    string tenvong = "";
        //    _vongDauData.VongDauConnect();
        //    foreach (DataRow r in _vongDauData.FillTable_tenvong(mavong).Rows)
        //    {
        //        tenvong = r["TENVONG"].ToString();
        //    }
        //    _vongDauData.VongDauClose();
        //    return tenvong;
        //}

        //private string LayTenMua(string mavong)
        //{
        //    string tenmua = "";
        //    string mamua = "";
        //    _vongDauData.VongDauConnect();
        //    foreach (DataRow r in _vongDauData.FillTable_tenvong(mavong).Rows)
        //    {
        //        mamua = r["MAMUA"].ToString();
        //    }
        //    _vongDauData.VongDauClose();

        //    _muaGiaiData.MuaGiaiConnect();
        //    foreach (DataRow r in _muaGiaiData.FillData_tenmua(mamua).Rows)
        //    {
        //        tenmua = r["TENMUA"].ToString();
        //    }
        //    _muaGiaiData.MuaGiaiClose();
        //    return tenmua;
        //}

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
                if(row["SBTDOI1"] != null && row["SBTDOI1"].ToString() =="")
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
            row[3] = ngaygio.ToShortDateString();
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

        private void button_ok_Click(object sender, EventArgs e)
        {
            matrandau = txt_matrandau.Text.Trim();
            tenmua = txt_muagiai.Text.Trim();
            tenvongdau = txt_vongdau.Text.Trim();
            tensan = txt_san.Text.Trim();
            doi1 = txt_doi1.Text.Trim();
            doi2 = txt_doi2.Text.Trim();
            ok = true;
            this.Close();
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
