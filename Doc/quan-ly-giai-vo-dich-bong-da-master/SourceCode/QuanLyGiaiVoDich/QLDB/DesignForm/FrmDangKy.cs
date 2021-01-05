using System;
using System.Data;
using System.Windows.Forms;
using QLDB.QuanLyGiaiVoDichDataSetTableAdapters;

namespace QLDB.DesignForm
{
    public partial class FrmDangKy : MyFormPage
    {
        public FrmDangKy()
        {
            InitializeComponent();
            this._Mypanel = panel5;
            Status("ok");
            LoadDataGV();

        }

        #region Properties

        private bool them;
        private bool sua;
        private bool xoa;
        private string madoi;
        private string tendoi;
        private string sannha;
        private string mamua;
        private string tenmua;
        private string masan;



        #endregion


        #region load status - clear text - Databinding
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

        private void ClearText()
        {
            txt_tendoi.Text = "";
            txt_tensan.Text = "";
            txt_muagiai.Text = "";
            txt_diachi.Text = "";
            txt_succhua.Text = "";
        }

        private void DataBinding()
        {
            txt_madoi.DataBindings.Clear();
            txt_madoi.DataBindings.Add("Text", dataGridView1.DataSource, "MADOI");

            txt_tendoi.DataBindings.Clear();
            txt_tendoi.DataBindings.Add("Text", dataGridView1.DataSource, "TENDOI");

            txt_muagiai.DataBindings.Clear();
            txt_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "TENMUA");

            txt_tensan.DataBindings.Clear();
            txt_tensan.DataBindings.Add("Text", dataGridView1.DataSource, "TENSAN");

            txt_succhua.DataBindings.Clear();
            txt_succhua.DataBindings.Add("Text", dataGridView1.DataSource, "SUCCHUA");

            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", dataGridView1.DataSource, "DIACHI");

            txt_masan.DataBindings.Clear();
            txt_masan.DataBindings.Add("Text", dataGridView1.DataSource, "MASAN");
        }

        #endregion


        #region load datagridview

        private void LoadDataGV()
        {
            DataTable tb = createTable();
            this.dOIBONG_MUAGIAITableAdapter.Fill(this.quanLyGiaiVoDichDataSet.DOIBONG_MUAGIAI);
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.DOIBONG_MUAGIAI.Rows)
            {
                string[] doi = LayDoi(row["MADOI"].ToString());
                string[] san = LaySan(row["MASANNHA"].ToString());
                string mua = LayMua(row["MAMUA"].ToString());
                AddRows(ref tb,doi[0],doi[1],mua,san[0],san[1],san[2],san[3]);
            }
            dataGridView1.DataSource = tb;foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        }

        private DataTable createTable()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("MADOI", typeof (string));
            tb.Columns.Add("TENDOI", typeof (string));
            tb.Columns.Add("TENMUA", typeof (string));
            tb.Columns.Add("MASAN", typeof (string));
            tb.Columns.Add("TENSAN", typeof (string));
            tb.Columns.Add("DIACHI", typeof (string));
            tb.Columns.Add("SUCCHUA", typeof (string));
            return tb;
        }

        private void AddRows(ref DataTable tb, string madoi, string tendoi, string tenmua, string masan, string tensan,
            string diachi,
            string succhua)
        {
            tb.Rows.Add(madoi, tendoi, tenmua, masan, tensan, diachi, succhua);
        }

        private string[] LayDoi(string madoi)
        {
            string[] doi = new string[2];
            this.doibongTableAdapter.FillByMadoi(this.quanLyGiaiVoDichDataSet.DOIBONG, madoi);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.DOIBONG.Rows)
            {
                doi[0] = r["MADOI"].ToString();
                doi[1] = r["TENDOI"].ToString();
            }
            return doi;
        }

        private string[] LaySan(string masan)
        {
            string[] san = new string[4];
            this.sanTableAdapter.FillByMaSan(this.quanLyGiaiVoDichDataSet.SAN, masan);
            foreach (DataRow r in this.quanLyGiaiVoDichDataSet.SAN.Rows)
            {
                san[0] = r["MASAN"].ToString();
                san[1] = r["TENSAN"].ToString();
                san[2] = r["DIACHI"].ToString();
                san[3] = r["SUCCHUA"].ToString();
            }
            return san;
        }

        private string LayMua(string mamua)
        {
            this.mUAGIAITableAdapter.FillByMaMua(this.quanLyGiaiVoDichDataSet.MUAGIAI, mamua);
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.MUAGIAI.Rows)
            {
                return row["TENMUA"].ToString();
            }
            return null;
        }

        #endregion load datagridvie

        private void FilltextMuaGiai()
        {
            try
            {
                this.mUAGIAITableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MUAGIAI);
                txt_muagiai.DataSource = quanLyGiaiVoDichDataSet.MUAGIAI;
                txt_muagiai.DisplayMember = "TENMUA";
                txt_muagiai.ValueMember = "MAMUA";

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        private string SinhMaTuDong_Doi()
        {

            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaDoiMax().ToString();
                if (numbermax != "")
                {

                    int temp = int.Parse(numbermax) + 1;
                    code = "0000" + temp;
                    code = "DB" + code.Substring(code.Length - 4);
                }
                else
                {
                    code = "DB0001";
                }
                return code;

            }
            catch (Exception)
            {
            }
            return null;
        }

        private string SinhMaTuDong_San()
        {

            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaSanMax().ToString();
                if (numbermax != "")
                {

                    int temp = int.Parse(numbermax) + 1;
                    code = "0000" + temp;
                    code = "SA" + code.Substring(code.Length - 4);
                }
                else
                {
                    code = "SA0001";
                }
                return code;

            }
            catch (Exception)
            {
            }
            return null;
        }

        #region event
        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (them)
                {
                    madoi = SinhMaTuDong_Doi();
                    tendoi = txt_tendoi.Text.Trim();
                    sannha = txt_tensan.Text.Trim();
                    masan = SinhMaTuDong_San();
                    string diachi = txt_diachi.Text.Trim();
                    string succhua = txt_succhua.Text.Trim();


                    if (txt_tendoi.Text == "")
                    {
                        MessageBox.Show("Nhập tên đội");
                        return;
                    }

                    if (txt_tensan.Text == "")
                    {
                        MessageBox.Show("Nhập tên sân");
                        return;
                    }

                    if (txt_succhua.Text == "")
                    {
                        MessageBox.Show("Nhập sức chưa");
                        return;
                    }

                    if (txt_diachi.Text == "")
                    {
                        MessageBox.Show("Nhập địa chỉ sân");
                        return;
                    }


                    this.doibongTableAdapter.Insert(madoi, tendoi);//insert doi
                    this.sanTableAdapter.Insert(masan, sannha, diachi, int.Parse(succhua));// insert san
                    this.dOIBONG_MUAGIAITableAdapter.Insert(mamua, madoi, masan);//insert doibong_muagiai
                    MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
                else if (sua)
                {
                    madoi = txt_madoi.Text.Trim();
                    masan = txt_masan.Text.Trim();

                    if (txt_tendoi.Text == "")
                    {
                        MessageBox.Show("Nhập tên đội");
                        return;
                    }

                    if (txt_tensan.Text == "")
                    {
                        MessageBox.Show("Nhập tên sân");
                        return;
                    }

                    if (txt_succhua.Text == "")
                    {
                        MessageBox.Show("Nhập sức chưa");
                        return;
                    }

                    if (txt_diachi.Text == "")
                    {
                        MessageBox.Show("Nhập địa chỉ sân");
                        return;
                    }

                    this.doibongTableAdapter.UpdateByMaDoi(txt_tendoi.Text.Trim(), madoi);

                    this.dOIBONG_MUAGIAITableAdapter.FillByMaDoiMaMua(this.quanLyGiaiVoDichDataSet.DOIBONG_MUAGIAI, madoi, mamua);

                    this.sanTableAdapter.UpdateByMaSan(txt_tensan.Text.Trim(), txt_diachi.Text.Trim(), int.Parse(txt_succhua.Text.Trim()), masan);

                    this.dOIBONG_MUAGIAITableAdapter.UpdateBy_Madoi_Masan(mamua, madoi, masan);
                    MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (xoa)
                {
                    madoi = txt_madoi.Text.Trim();
                    if (txt_muagiai.SelectedValue != null && MessageBox.Show("Bạn có muốn xoá","Warning!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        masan = txt_masan.Text.Trim();
                        mamua = txt_muagiai.SelectedValue.ToString();
                        this.dOIBONG_MUAGIAITableAdapter.DeleteBy_MaMua_MaDoi(mamua, madoi);
                        this.doibongTableAdapter.DeleteByMaDoi(madoi);
                        this.sanTableAdapter.DeleteByMaSan(masan);
                    }
                    ClearText();
                    DataBinding();
                }
                LoadDataGV();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            Status("them");
            FilltextMuaGiai();
            ClearText();
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            FilltextMuaGiai();
            Status("sua");
            DataBinding();
            
            
        }
    
        private void button_xoa_Click(object sender, EventArgs e)
        {
            Status("xoa");
            ClearText();
            FilltextMuaGiai();
            DataBinding();
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            Status("ok");
            ClearText();
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {

            
        }

        private void txt_muagiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_muagiai.Text != "")
            {
                mamua = txt_muagiai.SelectedValue.ToString();
            }
        }

        private void txt_succhua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    #endregion
}
