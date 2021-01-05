

using System;
using System.Data;
using System.Windows.Forms;
using QLDB.QuanLyGiaiVoDichDataSetTableAdapters;

namespace QLDB.DesignForm
{
    public partial class FrmKetQua : MyFormPage
    {
        public FrmKetQua()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            LoadDataGV();
            Status(null);
        }

        #region properties
        
        private bool them;
        private bool sua;
        public static string tenmua;
        public static string tenvongdau;
        public static string matrandau;
        public static string tendoi1;
        public static string tendoi2;
        public static DateTime thoigian;
        public static string tensan;


        public static string madoi1;
        public static string madoi2;
        public static string masan;
        public static string mamua;
        public static string mavongdau;

        public static string sobanthangdoi1;
        public static string sobanthangdoi2;
        public static string thoiluong;


        #endregion

        #region status - cleartext - databinding

        private void ClearText()
        {
            txt_banthangdoi1.Text = txt_banthangdoi2.Text = txt_thoiluong.Text = "";
        }

        private void Status(string stt)
        {
            switch (stt)
            {
                case "them":
                    txt_banthangdoi1.Enabled = true;
                    txt_banthangdoi2.Enabled = true;
                    txt_thoiluong.Enabled = true;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    them = true;
                    sua = false;
                    break;
                case "sua":
                    txt_banthangdoi1.Enabled = true;
                    txt_banthangdoi2.Enabled = true;
                    txt_thoiluong.Enabled = true;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    sua = true;
                    them = false;
                    break;
                case "xoa":
                    txt_banthangdoi1.Enabled = false;
                    txt_banthangdoi2.Enabled = false;
                    txt_thoiluong.Enabled = false;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    them = false;
                    sua = false;
                    break;
                default:
                    txt_banthangdoi1.Enabled = false;
                    txt_banthangdoi2.Enabled = false;
                    txt_thoiluong.Enabled = false;
                    button_ok.Enabled = false;
                    button_huy.Enabled = false;
                    them = sua = false;
                    ClearText();
                    break;
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


            txt_vongthidau.DataBindings.Clear();
            txt_vongthidau.DataBindings.Add("Text", dataGridView1.DataSource, "VONGDAU");

            txt_muagiai.DataBindings.Clear();
            txt_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "MUAGIAI");

            txt_matrandau.DataBindings.Clear();
            txt_matrandau.DataBindings.Add("Text", dataGridView1.DataSource, "MATD");

            txt_banthangdoi1.DataBindings.Clear();
            txt_banthangdoi1.DataBindings.Add("Text", dataGridView1.DataSource, "SBTDOI1");

            txt_banthangdoi2.DataBindings.Clear();
            txt_banthangdoi2.DataBindings.Add("Text", dataGridView1.DataSource, "SBTDOI2");

            txt_thoiluong.DataBindings.Clear();
            txt_thoiluong.DataBindings.Add("Text", dataGridView1.DataSource, "THOILUONG");
        }

        #endregion

        #region load datagridview

        private void LoadDataGV()
        {
            this.trandauTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.TRANDAU);
            DataTable table = newTable();
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.TRANDAU.Rows)
            {
                if (row["SBTDOI1"].ToString() != "")
                {
                    matrandau = row["MATD"].ToString();
                    madoi1 = row["MADOI1"].ToString();
                    madoi2 = row["MADOI2"].ToString();
                    thoigian = Convert.ToDateTime(row["NGAYGIO"].ToString());
                    masan = row["MASAN"].ToString();
                    mavongdau = row["MAVONG"].ToString();
                    sobanthangdoi1 = row["SBTDOI1"].ToString();
                    sobanthangdoi2 = row["SBTDOI2"].ToString();
                    thoiluong = row["THOILUONG"].ToString();
                    table.Rows.Add(newRow(matrandau, madoi1, madoi2, mavongdau, sobanthangdoi1, sobanthangdoi2, thoiluong));
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
            table.Columns.Add("VONGDAU", typeof(string));
            table.Columns.Add("MUAGIAI", typeof(string));
            table.Columns.Add("SBTDOI1", typeof (string));
            table.Columns.Add("SBTDOI2", typeof (string));
            table.Columns.Add("THOILUONG", typeof (string));
            return table;
        }

        private Object[] newRow(string matd, string madoi1, string madoi2, string mavong, string sbtdoi1, string sbtdoi2, string thoiluong)
        {
            string[] row = new string[8];
            row[0] = matd;
            row[1] = LayTenDoi(madoi1);
            row[2] = LayTenDoi(madoi2);
            row[3] = LayTenVongDau(mavong);
            row[4] = LayTenMua(mavong);
            row[5] = sbtdoi1;
            row[6] = sbtdoi2;
            row[7] = thoiluong;
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

        private void ChonDoi()
        {
            FrmChonTranDau chondoi = new FrmChonTranDau();
            chondoi.ShowDialog();

            matrandau = FrmChonTranDau.matrandau;
            tenmua = FrmChonTranDau.tenmua;
            tenvongdau = FrmChonTranDau.tenvongdau;
            tendoi1 = FrmChonTranDau.doi1;
            tendoi2 = FrmChonTranDau.doi2;
            thoigian = FrmChonTranDau.thoigian;
            tensan = FrmChonTranDau.tensan;

            txt_muagiai.Text = tenmua;
            txt_vongthidau.Text = tenvongdau;
            txt_doi1.Text = tendoi1;
            txt_doi2.Text = tendoi2;

        }

        #endregion

        #region event

        private void button_them_Click(object sender, System.EventArgs e)
        {
            ChonDoi();
            if(FrmChonTranDau.ok)
                Status("them");
            ClearText();
        
        }

        private void button_sua_Click(object sender, System.EventArgs e)
        {
            Status("sua");
            Databiding();
        }


        private void button_ok_Click(object sender, System.EventArgs e)
        {
            try
            {

                if (them||sua)
                {
                    sobanthangdoi1 = txt_banthangdoi1.Text.Trim();
                    sobanthangdoi2 = txt_banthangdoi2.Text.Trim();
                    thoiluong = txt_thoiluong.Text.Trim();
                    this.trandauTableAdapter.Update_Kq(int.Parse(sobanthangdoi1), int.Parse(sobanthangdoi2),
                        int.Parse(thoiluong), matrandau);
                    MessageBox.Show("Tao tác thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                LoadDataGV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button_huy_Click(object sender, System.EventArgs e)
        {

        }

        private void FrmKetQua_Load(object sender, System.EventArgs e)
        {
            
            

        }

        private void txt_banthangdoi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_banthangdoi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_thoiluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
