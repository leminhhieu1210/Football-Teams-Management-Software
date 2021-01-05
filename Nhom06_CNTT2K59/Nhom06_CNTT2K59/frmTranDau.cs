using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemConstant;

namespace Nhom06_CNTT2K59
{
    public partial class frmTranDau : Form
    {
        Constant sys = new Constant();
        DataTable dtDoiNha, dtDoiKhach;
        List<CauThuDTO> dsCauThu = new List<CauThuDTO>();  
        List<TranDau_TheDTO> dsThe = new List<TranDau_TheDTO>();
        List<TranDau_BanThangDTO> dsBThang = new List<TranDau_BanThangDTO>();
        List<TranDau_CauThuDTO> dsCauThuThamGia = new List<TranDau_CauThuDTO>();
        List<TranDau_CauThuDTO> dsCauThuThamGia1 = new List<TranDau_CauThuDTO>();
        int rowid = -1;

        public frmTranDau()
        {
            InitializeComponent();
        }

        private void frmTranDau_Load(object sender, EventArgs e)
        {
            DataTable doi1 = DoiBongDAO.getData();
            FillCbo(doi1, cbxMaDoiNha, "MaDoi", "TenDoi");

            DataTable doi2 = DoiBongDAO.getData();
            FillCbo(doi2, cbxMaDoiKhach, "MaDoi", "TenDoi");

            resetTranDau();
        }

        //Chọn mã đội nhà
        private void cbxMaDoiNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaDoiNha.SelectedIndex == -1) //hiển thị tất cả
            {
                DataTable dt = CauThuDAO.getData();
                dgvDoiNha.DataSource = dt;
            }
            else if (cbxMaDoiNha.Text == cbxMaDoiKhach.Text)
            {
                MessageBox.Show("Mã đội nhà không được trùng với mã đội khách!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaDoiNha.SelectedIndex = -1;
                imgDoiNha.Image = null;
                return;
            }
            else
            {
                DataTable dt = DoiBongDAO.getData();

                AddMultipleColumn(dt, "NameAndCode", "MaDoi", "TenDoi");
                KeyToValueOfTextWithPic(dt, cbxMaDoiNha, "NameAndCode", "Logo", imgDoiNha);

                string mdb = cbxMaDoiNha.SelectedValue.ToString();
                DataTable cauThuThuocDoi = CauThuDAO.getDatabyID(mdb);
                dtDoiNha = cauThuThuocDoi;
                foreach (DataRow item in cauThuThuocDoi.Rows)
                {
                    item["SoLanRaSan"] = (int.Parse(item["SoLanRaSan"].ToString()) + 1).ToString();
                }

                dgvDoiNha.DataSource = cauThuThuocDoi;
            }
        }

        //Chọn mã đội khách
        private void cbxMaDoiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaDoiKhach.SelectedIndex == -1)
            {
                DataTable dt = CauThuDAO.getData();
                dgvDoiKhach.DataSource = dt;
            }
            else if (cbxMaDoiNha.Text == cbxMaDoiKhach.Text)
            {
                MessageBox.Show("Mã đội khách không được trùng với mã đội nhà!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaDoiKhach.SelectedIndex = -1;
                imgDoiKhach.Image = null;
                return;
            }
            else
            {
                DataTable dt = DoiBongDAO.getData();
                AddMultipleColumn(dt, "NameAndCode", "MaDoi", "TenDoi");
                KeyToValueOfTextWithPic(dt, cbxMaDoiKhach, "NameAndCode", "Logo", imgDoiKhach);

                string mdb = cbxMaDoiKhach.SelectedValue.ToString();
                dtDoiKhach = CauThuDAO.getDatabyID(mdb); //hiển thị danh sách theo cầu thủ tương ứng
                dgvDoiKhach.DataSource = CauThuDAO.getDatabyID(mdb);
            }
        }

        //Hiển thị cầu thủ đội nhà
        private void dgvDoiNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowid = e.RowIndex;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDoiNha.Rows[e.RowIndex];
                txtMaCT.Text = row.Cells[0].Value.ToString();
                txtTenCT.Text = row.Cells[2].Value.ToString();
                txtViTri.Text = row.Cells["MaViTri"].Value.ToString();
            }
            catch
            {

            }
        }

        //Hiển thị cầu thủ đội khách
        private void dgvDoiKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowid = e.RowIndex;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDoiKhach.Rows[e.RowIndex];
                txtMaCT.Text = row.Cells[0].Value.ToString();
                txtTenCT.Text = row.Cells[2].Value.ToString();
                txtViTri.Text = row.Cells["MaViTri"].Value.ToString();
            }
            catch
            {

            }
        }

        //kiểm tra thời gian có bị trùng lặp không
        bool checkTG()
        {
            int count = 0;
            foreach (DataGridViewRow row in this.dgvghiban.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == txtThoiGian.Text)
                {
                    count++;
                }
            }
            return count == 0 ? true : false;
        }

        //Thêm bàn thắng
        private void btnGhiban_Click(object sender, EventArgs e)
        {
            if ((rowid >= 0 && rowid < dgvDoiNha.Rows.Count - 1) || (rowid >= 0 && rowid < dgvDoiKhach.Rows.Count - 1))
            {
                if (txtThoiGian.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập thời gian!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThoiGian.Focus();
                    return;
                }
                int tg;
                if (int.TryParse(txtThoiGian.Text, out tg) == false)
                {
                    MessageBox.Show("Thời gian không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThoiGian.Focus();
                    txtThoiGian.Text = "";
                    return;
                }
                tg = int.Parse(txtThoiGian.Text);
                if (tg <= 0 || tg > 120)
                {
                    MessageBox.Show("Thời gian không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThoiGian.Focus();
                    txtThoiGian.Text = "";
                    return;
                }
                if (checkTG() == false)
                {
                    MessageBox.Show("Thời gian đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThoiGian.Focus();
                    return;
                }

                int sbt = 1;

                foreach (DataRow item in dtDoiNha.Rows)
                {
                    if (txtMaCT.Text == item["MaCauThu"].ToString())
                    {
                        item["SoBanThang"] = (int.Parse(item["SoBanThang"].ToString()) + sbt).ToString();
                        txtSBTDoiNha.Text = (int.Parse(txtSBTDoiNha.Text) + sbt).ToString();
                        dgvDoiNha.DataSource = dtDoiNha;
                    }
                }

                foreach (DataRow item in dtDoiKhach.Rows)
                {
                    if (txtMaCT.Text == item["MaCauThu"].ToString())
                    {
                        item["SoBanThang"] = (int.Parse(item["SoBanThang"].ToString()) + sbt).ToString();
                        txtSBThDoiNha.Text = (int.Parse(txtSBThDoiNha.Text) + sbt).ToString();
                        dgvDoiKhach.DataSource = dtDoiKhach;
                    }
                }
                dsBThang.Add(new TranDau_BanThangDTO(txtMaTranDau.Text, txtMaCT.Text, int.Parse(txtThoiGian.Text)));
                updateSoBanThang();

                resetThephat();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn cầu thủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetThephat();
            }
        }

        void resetThephat()
        {
            cbxThePhat.SelectedIndex = -1;
            txtThoiGian.Text = txtMaCT.Text = txtTenCT.Text = txtViTri.Text = "";
            rowid = -1;
        }

        //Thêm thẻ phạt
        private void btnPhat_Click(object sender, EventArgs e)
        {
            if ((rowid >= 0 && rowid < dgvDoiNha.Rows.Count - 1) || (rowid >= 0 && rowid < dgvDoiKhach.Rows.Count - 1))
            {
                if (cbxThePhat.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn loại thẻ phạt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtThoiGian.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập thời gian!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThoiGian.Focus();
                    return;
                }
                int tg;
                if (int.TryParse(txtThoiGian.Text, out tg) == false)
                {
                    MessageBox.Show("Thời gian không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThoiGian.Focus();
                    txtThoiGian.Text = "";
                    return;
                }
                tg = int.Parse(txtThoiGian.Text);
                if (tg <= 0 || tg > 120)
                {
                    MessageBox.Show("Thời gian không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThoiGian.Focus();
                    txtThoiGian.Text = "";
                    return;
                }
                string loaiThe = cbxThePhat.Text;
                foreach (DataRow item in dtDoiNha.Rows)
                {
                    if (txtMaCT.Text == item["MaCauThu"].ToString())
                    {
                        if (loaiThe == "Thẻ đỏ")
                        {
                            item["SoTheDo"] = (int.Parse(item["SoTheDo"].ToString()) + 1).ToString();
                            txtSoTheDoDoiNha.Text = (int.Parse(txtSoTheDoDoiNha.Text) + 1).ToString();
                            dgvDoiNha.DataSource = dtDoiNha;
                        }
                        else
                        {
                            item["SoTheVang"] = (int.Parse(item["SoTheVang"].ToString()) + 1).ToString();
                            txtSoTheVangDoiNha.Text = (int.Parse(txtSoTheVangDoiNha.Text) + 1).ToString();
                            dgvDoiNha.DataSource = dtDoiNha;
                        }
                    }
                }

                foreach (DataRow item in dtDoiKhach.Rows)
                {
                    if (txtMaCT.Text == item["MaCauThu"].ToString())
                    {
                        if (loaiThe == "Thẻ đỏ")
                        {
                            item["SoTheDo"] = (int.Parse(item["SoTheDo"].ToString()) + 1).ToString();
                            txtSoTheDoDoiKhach.Text = (int.Parse(txtSoTheDoDoiKhach.Text) + 1).ToString();
                            dgvDoiNha.DataSource = dtDoiNha;
                        }
                        else
                        {
                            item["SoTheVang"] = (int.Parse(item["SoTheVang"].ToString()) + 1).ToString();
                            txtSoTheVangDoiKhach.Text = (int.Parse(txtSoTheVangDoiKhach.Text) + 1).ToString();
                            dgvDoiNha.DataSource = dtDoiNha;
                        }
                    }
                }
                /* luu thong tin*/
                dsThe.Add(new TranDau_TheDTO(txtMaTranDau.Text, txtMaCT.Text, int.Parse(txtThoiGian.Text), cbxThePhat.Text));

                updateThephat();
                resetThephat();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn cầu thủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetThephat();
            }
        }

        //update diễn biến trong bảng bàn thắng
        private void updateSoBanThang()
        {
            dgvghiban.Rows.Add(txtMaCT.Text, txtThoiGian.Text);
        }

        //update diễn biến trong bảng thẻ phạt
        private void updateThephat()
        {
            if (cbxThePhat.SelectedIndex == 0)
            {
                dgvphatthe.Rows.Add(txtMaCT.Text, "1", "0", txtThoiGian.Text);
            }
            else
            {
                dgvphatthe.Rows.Add(txtMaCT.Text, "0", "1", txtThoiGian.Text);
            }
            
        }

        void resetTranDau()
        {
            txtMaTranDau.Text = txtVongDau.Text = "";
            cbxLuotDau.SelectedIndex = cbxMaDoiNha.SelectedIndex = cbxMaDoiKhach.SelectedIndex = -1;
            txtSBThDoiNha.Text = txtSBTDoiNha.Text = "0";
            txtSoTheDoDoiKhach.Text = txtSoTheDoDoiNha.Text = txtSoTheVangDoiNha.Text = txtSoTheVangDoiKhach.Text = "0";
            imgDoiNha.Image = null;
            imgDoiKhach.Image = null;

            dgvghiban.Rows.Clear();
            dgvghiban.Refresh();
            dgvphatthe.Rows.Clear();
            dgvphatthe.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetTranDau();
            resetThephat();
        }

        private void btnTaoMaTD_Click(object sender, EventArgs e)
        {
            txtMaTranDau.Text = GenericDAO.getKey("select dbo.getKeyMaTranDau()");
        }

        //Thêm trận đấu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int vongdau;
            try
            {
                if (txtMaTranDau.Text == "")
                {
                    MessageBox.Show("Bạn chưa tạo mã trận đấu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaCT.Focus();
                }
                else if (cbxLuotDau.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn lượt đấu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtVongDau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập vòng đấu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVongDau.Focus();
                }
                else if (int.TryParse(txtVongDau.Text, out vongdau) == false)
                {
                    MessageBox.Show("Vòng đấu không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVongDau.Text = "";
                    txtVongDau.Focus();
                }
                else if (cbxMaDoiNha.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn đội nhà!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cbxMaDoiKhach.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn đội khách!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (vongdau <= 0 || vongdau > 40)
                    {
                        MessageBox.Show("Vòng đấu không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtVongDau.Text = "";
                        txtVongDau.Focus();
                        return;
                    }

                    string maTran = txtMaTranDau.Text;

                    TranDauDTO tranDauDTO = new TranDauDTO(maTran, cbxLuotDau.Text, int.Parse(txtVongDau.Text), cbxMaDoiNha.SelectedValue.ToString(), cbxMaDoiKhach.SelectedValue.ToString());
                    TranDauDAO.saveTranDau(tranDauDTO, sys.INSERT);

                    /*Luu thong tin cau thu doi nha -----------------------------*/
                    foreach (DataRow item in dtDoiNha.Rows)
                    {
                        item["SoLanRaSan"] = (int.Parse(item["SoLanRaSan"].ToString()) + 1).ToString();
                        TranDau_CauThuDTO dto = new TranDau_CauThuDTO(maTran, item["MaDoi"].ToString(), item["MaCauThu"].ToString());
                        dsCauThuThamGia.Add(dto);
                    }

                    foreach (TranDau_CauThuDTO item in dsCauThuThamGia)
                    {
                        TranDau_CauThu_DAO.saveTranDau_CauThu(item, sys.INSERT);
                    }

                    /*Luu thong tin cau thu doi khach ------------------------*/
                    foreach (DataRow item in dtDoiKhach.Rows)
                    {
                        item["SoLanRaSan"] = (int.Parse(item["SoLanRaSan"].ToString()) + 1).ToString();
                        TranDau_CauThuDTO dto = new TranDau_CauThuDTO(maTran, item["MaDoi"].ToString(), item["MaCauThu"].ToString());
                        dsCauThuThamGia1.Add(dto);
                    }

                    foreach (TranDau_CauThuDTO item in dsCauThuThamGia1)
                    {
                        TranDau_CauThu_DAO.saveTranDau_CauThu(item, sys.INSERT);
                    }

                    /* luu thong tin the phat cua tran dau*/
                    foreach (TranDau_TheDTO item in dsThe)
                    {
                        TranDau_The.saveTranDau_The(item, sys.INSERT);
                    }

                    /*luu thong tin ban thang cua tran dau */
                    foreach (TranDau_BanThangDTO item in dsBThang)
                    {
                        TranDau_BanThang_DAO.saveTranDau_BanThang(item, sys.INSERT);
                    }

                    TranDauDAO.tinhDiemDoiBong(maTran, sys.INSERT);
                    TranDauDAO.TinhSBT_SauTranDau(maTran, sys.INSERT);

                    MessageBox.Show("Thêm trận đấu thành công!");
                    resetTranDau();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetTranDau();
            }
        }

        /**/
        //Hiển thị các ảnh
        public void KeyToValueOfTextWithPic(DataTable dt, ComboBox cbxKey, string key, string value, PictureBox pic)
        {
            if (cbxKey.SelectedIndex == -1) pic.Image = null;
            string name = cbxKey.Text;
            foreach (DataRow row in dt.Rows)
            {
                if (row[key].ToString() == name)
                {
                    if (row[value] == DBNull.Value)
                    {
                        pic.Image = null;
                    }
                    else
                    {
                        byte[] b = (byte[])row[value];
                        pic.Image = convertBytesToImage(b);
                    }
                }
            }
        }

        //Hiển thị giá trị trong cbx
        public void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + ' - ' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        //Cho data vào cbx
        public void FillCbo(DataTable t, ComboBox cbo, string ma, string ten)
        {
            string newC = "NameAndCode";
            AddMultipleColumn(t, newC, ma, ten);
            cbo.DataSource = t;
            cbo.ValueMember = ma;
            cbo.DisplayMember = newC;
            cbo.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Đổi từ byte sang ảnh
        private Image convertBytesToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
    }
}
