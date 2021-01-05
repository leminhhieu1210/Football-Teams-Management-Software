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

namespace Nhom06_CNTT2K59.UserControls
{
    public partial class UC_CauThu : UserControl
    {
        int rowid = -1;
        Constant sys = new Constant();
        byte[] currentImg;
        public UC_CauThu()
        {
            InitializeComponent();
        }

        private void UC_CauThu_Load(object sender, EventArgs e)
        {
            DataTable dt = CauThuDAO.getData(); //Lấy dữ liệu từ database
            dgvCauThu.DataSource = dt; //Cho vào datagridview


            DataTable doi = DoiBongDAO.getData(); //Lấy dữ liệu từ database DoiBong
            FillCbo(doi, cbxDoiBong, "MaDoi", "TenDoi"); //Cho vào combobox


            DataTable vitri = ViTriDAO.getData();
            FillCbo(vitri, cbxViTri, "MaViTri", "TenViTri");

            DataTable quoctich = QuocTichDAO.getData();
            FillCbo(quoctich, cbxQuocTich, "MaQuocTich", "TenQuocTich");
            //txtImageSource.Text = @"E:\IT\C#\LapTrinhTrucQuan\Nhom06\Doc\unnamed.jpg";
        }

        //Chọn ảnh
        private void btnImg_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|"
                         + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            ofg.FilterIndex = 1;
            ofg.RestoreDirectory = true;
            if (ofg.ShowDialog() == DialogResult.OK)
            {
                img.ImageLocation = ofg.FileName;
                txtImageSource.Text = ofg.FileName;
            }
        }

        //Đổi ảnh sang byte
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(txtImageSource.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        //Đổi byte sang ảnh
        private Image convertBytesToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        //Tạo mã cầu thủ tự động
        private void btnID_Click(object sender, EventArgs e)
        {
            txtMaCT.Text = GenericDAO.getKey("select dbo.getKeyMaCauThu()");
        }

        //Thêm cầu thủ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int soao;
            try
            {
                if (txtMaCT.Text == "")
                {
                    MessageBox.Show("Bạn chưa tạo mã cầu thủ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaCT.Focus();
                }
                else if (txtTenCT.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên cầu thủ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenCT.Focus();
                }
                else if (cbxDoiBong.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn đội bóng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cbxViTri.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn vị trí!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtSoAo.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số áo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoAo.Focus();
                }
                else if (int.TryParse(txtSoAo.Text, out soao) == false)
                {
                    MessageBox.Show("Số áo không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoAo.Text = "";
                    txtSoAo.Focus();
                }
                else if (cbxQuocTich.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn quốc tịch!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtImageSource.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn ảnh!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (soao <= 0 || soao > 99)
                    {
                        MessageBox.Show("Số áo không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSoAo.Text = "";
                        txtSoAo.Focus();
                        return;
                    }

                    string maCT = txtMaCT.Text;
                    string maDoi = cbxDoiBong.SelectedValue.ToString();
                    string tenCT = txtTenCT.Text;
                    string viTri = cbxViTri.SelectedValue.ToString();
                    DateTime ngaySinh = dtpNgaySinh.Value;
                    string soAo = txtSoAo.Text;
                    string soBanThang = txtSoBanThang.Text;
                    string soTheVang = txtSoTheVang.Text;
                    string soTheDo = txtSoTheDo.Text;
                    string maQuocTich = cbxQuocTich.SelectedValue.ToString();
                    string soLanRaSan = txtSoLanRaSan.Text;

                    soBanThang = soTheVang = soTheDo = soLanRaSan = "0";

                    //Khởi tạo 1 cầu thủ
                    CauThuDTO dto = new CauThuDTO(maCT,
                                      maDoi,
                                      tenCT,
                                      viTri,
                                      ngaySinh,
                                      int.Parse(soAo),
                                      int.Parse(soBanThang),
                                      int.Parse(soTheVang),
                                      int.Parse(soTheDo),
                                      maQuocTich,
                                      int.Parse(soLanRaSan),
                                      convertImageToBytes());

                    //Insert xuống database
                    CauThuDAO.saveCauThu(dto, sys.INSERT);
                    MessageBox.Show("Thêm cầu thủ thành công.");

                    UC_CauThu_Load(sender, e);
                    reset();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Sửa cầu thủ
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (rowid >= 0 && rowid < dgvCauThu.Rows.Count - 1) //Nếu đã chọn cầu thủ để sửa
            {
                try
                {
                    if (txtMaCT.Text == "")
                    {
                        MessageBox.Show("Bạn chưa tạo mã cầu thủ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaCT.Focus();
                    }
                    else if (txtTenCT.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên cầu thủ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenCT.Focus();
                    }
                    else if (cbxDoiBong.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn chưa chọn đội bóng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (cbxViTri.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn chưa chọn vị trí!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtSoAo.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập số áo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSoAo.Focus();
                    }
                    else if (cbxQuocTich.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn chưa chọn quốc tịch!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtImageSource.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn ảnh!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string maCT = txtMaCT.Text;
                        string maDoi = cbxDoiBong.SelectedValue.ToString();
                        string tenCT = txtTenCT.Text;
                        string viTri = cbxViTri.SelectedValue.ToString();
                        DateTime ngaySinh = dtpNgaySinh.Value;
                        string soAo = txtSoAo.Text;
                        string soBanThang = txtSoBanThang.Text;
                        string soTheVang = txtSoTheVang.Text;
                        string soTheDo = txtSoTheDo.Text;
                        string maQuocTich = cbxQuocTich.SelectedValue.ToString();
                        string soLanRaSan = txtSoLanRaSan.Text;

                        soBanThang = soTheVang = soTheDo = soLanRaSan = "0";
                        try
                        {
                            currentImg = convertImageToBytes();
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        CauThuDTO dto = new CauThuDTO(maCT,
                                                        maDoi,
                                                        tenCT,
                                                        viTri,
                                                        ngaySinh,
                                                        int.Parse(soAo),
                                                        int.Parse(soBanThang),
                                                        int.Parse(soTheVang),
                                                        int.Parse(soTheDo),
                                                        maQuocTich,
                                                        int.Parse(soLanRaSan),
                                                        currentImg);

                        CauThuDAO.saveCauThu(dto, sys.UPDATE);
                        MessageBox.Show("Sửa cầu thủ thành công!");

                        UC_CauThu_Load(sender, e);
                        reset();
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn cầu thủ để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Xoá cầu thủ
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (rowid >= 0 && rowid < dgvCauThu.Rows.Count - 1)
            {
                DialogResult h = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (h == DialogResult.Yes)
                {
                    string id = dgvCauThu.Rows[rowid].Cells[0].Value.ToString();
                    CauThuDAO.DeleteCT(id);
                    MessageBox.Show("Xoá thành công!");
                    UC_CauThu_Load(sender, e);
                    reset();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn cầu thủ để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Hàm làm mới form
        void reset()
        {
            txtMaCT.Text = txtSoAo.Text = txtTenCT.Text = txtImageSource.Text = "";
            txtSoBanThang.Text = txtSoLanRaSan.Text = txtSoTheDo.Text = txtSoTheVang.Text = "0";
            txtTenCT.Focus();
            img.Image = null;
            //txtImageSource.Text = @"E:\IT\C#\LapTrinhTrucQuan\Nhom06\Doc\unnamed.jpg";

            dtpNgaySinh.Value = DateTimePicker.MinimumDateTime;
            cbxQuocTich.SelectedIndex = cbxViTri.SelectedIndex = -1;
            cbxDoiBong.SelectedIndex = -1;
        }

        //Làm mới form
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        //Click hiển thị cầu thủ
        private void dgvCauThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowid = e.RowIndex;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCauThu.Rows[e.RowIndex];
                txtMaCT.Text = row.Cells[0].Value.ToString();
                txtTenCT.Text = row.Cells[2].Value.ToString();
                txtSoAo.Text = row.Cells[5].Value.ToString();
                txtSoBanThang.Text = row.Cells[6].Value.ToString();
                txtSoTheVang.Text = row.Cells[7].Value.ToString();
                txtSoTheDo.Text = row.Cells[8].Value.ToString();
                txtSoLanRaSan.Text = row.Cells[10].Value.ToString();

                if (row.Cells[11].Value == DBNull.Value)
                {
                    img.Image = null;
                }
                else
                {
                    byte[] b = (byte[])row.Cells[11].Value;
                    currentImg = b;
                    img.Image = convertBytesToImage(b);
                }

                dtpNgaySinh.Value = (DateTime)row.Cells[4].Value;
                cbxDoiBong.SelectedValue = row.Cells["MaDoi"].Value.ToString();
                cbxViTri.SelectedValue = row.Cells["MaViTri"].Value.ToString();
                cbxQuocTich.SelectedValue = row.Cells["MaQuocTich"].Value.ToString();
            }
            catch
            {
            }
        }

        //Hàm ghép dữ liệu vào combobox
        public void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + ' - ' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        //Hàm cho dữ liệu đã ghép vào combobox
        public void FillCbo(DataTable t, ComboBox cbo, string ma, string ten)
        {
            string newC = "NameAndCode";
            AddMultipleColumn(t, newC, ma, ten);
            cbo.DataSource = t;
            cbo.ValueMember = ma;
            cbo.DisplayMember = newC;
            cbo.SelectedIndex = -1;
        }

        //Hiển thị combobox
        private void cbxDoiBong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDoiBong.SelectedIndex == -1) //hiển thị tất cả danh sách
            {
                DataTable dt = CauThuDAO.getData();
                dgvCauThu.DataSource = dt;
            }
            else
            {
                string mdb = cbxDoiBong.SelectedValue.ToString(); //mã đội bóng được chọn
                dgvCauThu.DataSource = CauThuDAO.getDatabyID(mdb); //Gọi proc dưới sql
            }
        }
    }
}
