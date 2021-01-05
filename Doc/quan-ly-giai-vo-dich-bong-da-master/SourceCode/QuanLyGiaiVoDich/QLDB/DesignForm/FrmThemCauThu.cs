using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QLDB.QuanLyGiaiVoDichDataSetTableAdapters;

namespace QLDB.DesignForm
{
    public partial class FrmThemCauThu : MyFormPage
    {
        public FrmThemCauThu()
        {
            InitializeComponent();
            this._Mypanel = panel1;
            LoadStatus(null);
            LoadDataGV();
            LayQuyDinh();
        }

        #region Properties

        private bool them;
        private bool sua;
        private bool xoa;
        private string quoctich;
        private string hoten;
        private DateTime ngaysinh;
        private string ghichu;
        private string macauthu;
        private string maloaicauthu;
        private string madoi = "";
        private string mamua = "";

        private int tuoitoithieu;
        private int tuoitoida;
        private int sct_toithieu;
        private int sct_toida;
        private int sct_nuocngoai;

        QueriesTableAdapter queries = new QueriesTableAdapter();

        #endregion

        #region

        private void LayQuyDinh()
        {
            tuoitoithieu = int.Parse(queries.GetTuoiToiThieu().ToString());
            tuoitoida = int.Parse(queries.GetTuoiToiDa().ToString());
            sct_toithieu = int.Parse(queries.GetSoCauThuToiThieu().ToString());
            sct_toida = int.Parse(queries.GetSoCauThuToiDa().ToString());
            sct_nuocngoai = int.Parse(queries.GetSoCTNNToiDa().ToString());
        }
        private void LoadStatus(string stt)
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

        //private void LoadStatus(string stt)
        //{
        //    switch (stt)
        //    {
        //        case "chondoi":
        //            button_sua.Enabled = true;
        //            button_them.Enabled = true;
        //            button_xoa.Enabled = true;
        //            break;
        //        case "them":
        //            txt_quoctich.Enabled = true;
        //            txt_hoten.Enabled = true;
        //            txt_loaicauthu.Enabled = true;
        //            txt_ghichu.Enabled = true;
        //            date_ngaysinh.Enabled = true;
        //            button_ok.Enabled = true;
        //            button_huy.Enabled = true;
        //            them = true;
        //            xoa = false;
        //            sua = false;
        //            break;
        //        case "sua":
        //            txt_quoctich.Enabled = true;
        //            txt_hoten.Enabled = true;
        //            txt_loaicauthu.Enabled = true;
        //            txt_ghichu.Enabled = true;
        //            date_ngaysinh.Enabled = true;
        //            button_ok.Enabled = true;
        //            button_huy.Enabled = true;
        //            sua = true;
        //            them = false;
        //            xoa = false;
        //            break;
        //        case "xoa":
        //            txt_quoctich.Enabled = false;
        //            txt_hoten.Enabled = false;
        //            txt_loaicauthu.Enabled = false;
        //            txt_ghichu.Enabled = false;
        //            date_ngaysinh.Enabled = false;
        //            button_ok.Enabled = true;
        //            button_huy.Enabled = true;
        //            xoa = true;
        //            them = false;
        //            sua = false;
        //            break;
        //        case "ok":
        //            break;
        //        default:
        //            txt_quoctich.Enabled = false;
        //            txt_hoten.Enabled = false;
        //            txt_loaicauthu.Enabled = false;
        //            txt_ghichu.Enabled = false;
        //            button_ok.Enabled = false;
        //            button_sua.Enabled = false;
        //            button_them.Enabled = false;
        //            button_xoa.Enabled = false;
        //            button_huy.Enabled = false;
        //            date_ngaysinh.Enabled = false;
        //            break;
        //    }
        //}
        
        private void FilltextLoaiCauThu()
        {
            this.lOAICAUTHUTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LOAICAUTHU);
            txt_loaicauthu.DataSource = quanLyGiaiVoDichDataSet.LOAICAUTHU;
            txt_loaicauthu.DisplayMember = "LOAICT";
            txt_loaicauthu.ValueMember = "MALOAICT";
            txt_loaicauthu.Text = "";
        }

        private void LoadDataGV()
        {
            DataTable tb = createTable();
            this.cAUTHUTableAdapter.FillBy_Mamua_Madoi(this.quanLyGiaiVoDichDataSet.CAUTHU, madoi, mamua);
            DataTable temp = this.quanLyGiaiVoDichDataSet.CAUTHU.Copy();
            foreach (DataRow row in temp.Rows)
            {
                tb.Rows.Add(GetInfoCauThu(row["MACT"].ToString()));
            }
            dataGridView1.DataSource = tb;

        }

        private DataTable createTable()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("MACT", typeof (string));
            tb.Columns.Add("TENCT", typeof (string));
            tb.Columns.Add("NGAYSINH", typeof (string));
            tb.Columns.Add("LOAICT", typeof (string));
            tb.Columns.Add("QUOCTICH", typeof (string));
            tb.Columns.Add("GHICHU", typeof (string));
            return tb;
        }

        private string[] GetInfoCauThu(string macauthu)
        {
            string[] info = new string[6];
            this.cAUTHUTableAdapter.FillBy_MaCauthu(this.quanLyGiaiVoDichDataSet.CAUTHU, macauthu);
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.CAUTHU.Rows)
            {
                info[0] = row["MACT"].ToString();
                info[1] = row["TENCT"].ToString();
                info[2] = row["NGAYSINH"].ToString();
                info[3] = GetLoaiCauThu(row["MALOAICT"].ToString());
                info[4] = row["QUOCTICH"].ToString();
                info[5] = row["GHICHU"].ToString();
            }
            return info;
        }

        private string GetLoaiCauThu(string maloaicauthu)
        {
            string loaict = "";
            this.lOAICAUTHUTableAdapter.FillBy_MaLoaiCT(this.quanLyGiaiVoDichDataSet.LOAICAUTHU, maloaicauthu);
            foreach (DataRow row in this.quanLyGiaiVoDichDataSet.LOAICAUTHU.Rows)
            {
                loaict = row["LOAICT"].ToString();
            }
            return loaict;
        }

        private void Databinding()
        {
            txt_macauthu.DataBindings.Clear();
            txt_macauthu.DataBindings.Add("Text", dataGridView1.DataSource, "MACT");

            txt_hoten.DataBindings.Clear();
            txt_hoten.DataBindings.Add("Text", dataGridView1.DataSource, "TENCT");

            date_ngaysinh.DataBindings.Clear();
            date_ngaysinh.DataBindings.Add("Text", dataGridView1.DataSource, "NGAYSINH");

            txt_quoctich.DataBindings.Clear();
            txt_quoctich.DataBindings.Add("Text", dataGridView1.DataSource, "QUOCTICH");

            txt_ghichu.DataBindings.Clear();
            txt_ghichu.DataBindings.Add("Text", dataGridView1.DataSource, "GHICHU");

            txt_loaicauthu.DataBindings.Clear();
            txt_loaicauthu.DataBindings.Add("Text", dataGridView1.DataSource, "LOAICT");

        }

        private string SinhMaTuDong()
        {
            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaCauThuMax().ToString();
                if (numbermax != "")
                {

                    int temp = int.Parse(numbermax) + 1;
                    code = "0000" + temp;
                    code = "CT" + code.Substring(code.Length - 4);
                }
                else
                {
                    code = "CT0001";
                }
                return code;

            }
            catch (Exception)
            {
            }
            return null;
        }

        private void Cleartext()
        {
            txt_hoten.Text = "";
            txt_loaicauthu.Text = "";
            txt_quoctich.Text = "";
            txt_ghichu.Text = "";
        }

        private int TinhTuoi(DateTime namsinh)
        {
            if (namsinh < DateTime.Now)
                return DateTime.Now.Year - namsinh.Year;
            return 0;
        }

        #endregion

        #region event

        private void button_chondoi_Click(object sender, System.EventArgs e)
        {
            //LoadStatus("");
            FilltextLoaiCauThu();
            FrmChonDoi chondoi = new FrmChonDoi();
            chondoi.ShowDialog();
            txt_tendoi.Text = FrmChonDoi.tendoi;
            madoi = FrmChonDoi.madoi;
            mamua = FrmChonDoi.mamua;
            LoadDataGV();
        }

        private void button_them_Click(object sender, System.EventArgs e)
        {
            LoadStatus("them");
            Cleartext();
            FilltextLoaiCauThu();

        }

        private void button_sua_Click(object sender, System.EventArgs e)
        {
            LoadStatus("sua");
            Databinding();
        }

        private void button_xoa_Click(object sender, System.EventArgs e)
        {
            LoadStatus("xoa");
            Databinding();
        }

        private void button_ok_Click(object sender, System.EventArgs e)
        {

            if (them)
            {
                if (int.Parse(queries.CountSoCauThuCuaDoi(mamua, madoi).ToString()) >= sct_toida)
                {
                    MessageBox.Show("Không thể thêm cầu thủ, Số Cầu thủ của đội đã đủ");
                    return;
                }
                ngaysinh = Convert.ToDateTime(date_ngaysinh.Value.ToString("MM-dd-yyyy"));


                if (!(TinhTuoi(ngaysinh) >= tuoitoithieu && TinhTuoi(ngaysinh) <= tuoitoida))
                {
                    MessageBox.Show("Tuổi không đúng quy định, " + tuoitoithieu + "< tuoi <" + tuoitoida);
                    return;
                }
                
                hoten = txt_hoten.Text.Trim();

                if (hoten == "")
                {
                    MessageBox.Show("Nhập tên cầu thủ");
                    return;
                }
                quoctich = txt_quoctich.Text.Trim();

                if (quoctich == "")
                {
                    MessageBox.Show("Nhập quốc tịch cầu thủ");
                    return;
                }
                macauthu = SinhMaTuDong();
                ghichu = txt_ghichu.Text.Trim();
                this.cAUTHUTableAdapter.Insert(macauthu, hoten, ngaysinh, maloaicauthu, quoctich, ghichu);
                this.dOIBONG_CAUTHUTableAdapter.Insert(mamua, madoi, macauthu, 0);
                MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sua)
            {
                macauthu = txt_macauthu.Text.Trim();
                hoten = txt_hoten.Text.Trim();

                if (hoten == "")
                {
                    MessageBox.Show("Nhập tên cầu thủ");
                    return;
                }
                quoctich = txt_quoctich.Text.Trim();

                if (quoctich == "")
                {
                    MessageBox.Show("Nhập tên cầu thủ");
                    return;
                }
                ngaysinh = Convert.ToDateTime(date_ngaysinh.Value.ToString("MM-dd-yyyy"));

                if (!(TinhTuoi(ngaysinh) >= tuoitoithieu && TinhTuoi(ngaysinh) <= tuoitoida))
                {
                    MessageBox.Show("Tuổi không đúng quy định, " + tuoitoithieu + "< tuoi <" + tuoitoida);
                    return;
                }
                quoctich = txt_quoctich.Text.Trim();
                ghichu = txt_ghichu.Text.Trim();

                this.cAUTHUTableAdapter.UpdateByMaCauThu(hoten, ngaysinh, maloaicauthu, quoctich, ghichu, macauthu);
                MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (xoa)
            {
                if(MessageBox.Show("Bạn có muốn xoá","Warning!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    macauthu = txt_macauthu.Text.Trim();
                    this.dOIBONG_CAUTHUTableAdapter.DeleteBy_MaMua_MaDoi_MaCt(mamua, madoi, macauthu);
                    this.cAUTHUTableAdapter.DeleteByMaCauThu(macauthu);
                }
                
            }
            Cleartext();
            LoadDataGV();
            FilltextLoaiCauThu();}

        private void button_huy_Click(object sender, System.EventArgs e)
        {
            LoadStatus(null);
            txt_tendoi.Text = "";
        }


        private void txt_loaicauthu_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (txt_loaicauthu.SelectedValue != null)
            {
                maloaicauthu = txt_loaicauthu.SelectedValue.ToString();
            }
        }

        private void FrmCauThu_Load(object sender, System.EventArgs e)
        {
        }

        private void txt_hoten_TextChanged(object sender, EventArgs e)
        {
            DeleteLast(ref txt_hoten);
        }

        private void DeleteLast(ref TextBox textBox)
        {
            foreach (char i in textBox.Text)
            {
                string j = Convert.ToString(i);
                if (IsNumber(j) == true)
                {
                    MessageBox.Show("Tên không hợp lệ!");
                    textBox.Text = textBox.Text.Substring(0, textBox.TextLength - 1);
                }
            }
        }

        private bool IsNumber(string s)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(s);
        }

        private void txt_quoctich_TextChanged(object sender, EventArgs e)
        {
            DeleteLast(ref txt_quoctich);
        }

        private void date_ngaysinh_ValueChanged(object sender, EventArgs e)
        {
            if (date_ngaysinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn thời gian hiện tại");
                date_ngaysinh.Value = Convert.ToDateTime("12/14/1994");
            
            
            }

        }

        #endregion

    }
}
