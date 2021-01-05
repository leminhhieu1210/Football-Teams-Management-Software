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
    public partial class UC_DoiBong : UserControl
    {
        Constant sys = new Constant();
        byte[] currentImg;
        int rowid = -1;

        public UC_DoiBong()
        {
            InitializeComponent();
        }

        private void UC_DoiBong_Load(object sender, EventArgs e)
        {
            DataTable dt = DoiBongDAO.getData();
            dgvDoiBong.DataSource = dt;

            DataTable tinh = TinhDAO.getData();
            FillCbo(tinh, cbxMaTinh, "MaTinh", "TenTinh");

            DataTable sanbong = SanBongDAO.getData();
            FillCbo(sanbong, cbxMaSan, "MaSan", "TenSan");
        }

        //Chọn ảnh từ file
        private void btnImg_Click(object sender, EventArgs e)
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

        //Chuyển từ ảnh sang byte
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(txtImageSource.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        //Chuyển từ byte sang ảnh
        private Image convertBytesToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        //Hiển thị trong cbx
        public void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + ' - ' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        //Cho dữ liệu vào cbx
        public void FillCbo(DataTable t, ComboBox cbo, string ma, string ten)
        {
            string newC = "NameAndCode";
            AddMultipleColumn(t, newC, ma, ten);
            cbo.DataSource = t;
            cbo.ValueMember = ma;
            cbo.DisplayMember = newC;
            cbo.SelectedIndex = -1;
        }

        //Hiển thị các thuộc tính đội bóng
        private void dgvDoiBong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowid = e.RowIndex;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDoiBong.Rows[e.RowIndex];
                txtMaDoi.Text = row.Cells[0].Value.ToString();
                txtTenDoi.Text = row.Cells[1].Value.ToString();
                txtHLV.Text = row.Cells[3].Value.ToString();
                txtDiem.Text = row.Cells[6].Value.ToString();
                txtSoBanThang.Text = row.Cells[7].Value.ToString();
                txtSoBanThua.Text = row.Cells[8].Value.ToString();
                txtSoCauThu.Text = row.Cells[9].Value.ToString();

                if (row.Cells[5].Value == DBNull.Value)
                {
                    img.Image = null;
                }
                else
                {
                    byte[] b = (byte[])row.Cells[5].Value;
                    currentImg = b;
                    img.Image = convertBytesToImage(b);
                }

                cbxMaSan.SelectedValue = row.Cells["MaSan"].Value.ToString();
                cbxMaTinh.SelectedValue = row.Cells["MaTinh"].Value.ToString();
            }
            catch
            {
            }
        }

        //Sửa thuộc tính đội bóng
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (rowid >= 0 && rowid < dgvDoiBong.Rows.Count - 1)
            {
                try
                {
                    if (txtTenDoi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên đội bóng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenDoi.Focus();
                    }
                    else if (cbxMaTinh.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn chưa chọn mã tỉnh!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (cbxMaSan.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn chưa chọn mã sân bóng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtHLV.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên huấn luyện viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtHLV.Focus();
                    }
                    else if (txtImageSource.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn ảnh!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string maDoi = txtMaDoi.Text;
                        string tenDoi = txtTenDoi.Text;
                        string maSan = cbxMaSan.SelectedValue.ToString();
                        string hlv = txtHLV.Text;
                        string matinh = cbxMaTinh.SelectedValue.ToString();
                        string diem = txtDiem.Text;
                        string sobanthang = txtSoBanThang.Text;
                        string sobanthua = txtSoBanThua.Text;
                        string socauthu = txtSoCauThu.Text;

                        //sobanthang = sobanthua = socauthu = "0";
                        try
                        {
                            currentImg = convertImageToBytes();
                        }
                        catch
                        {

                        }
                        DoiBongDTO dto = new DoiBongDTO(maDoi,
                                                      tenDoi,
                                                      maSan,
                                                      hlv,
                                                      matinh,
                                                      currentImg,
                                                      int.Parse(diem),
                                                      int.Parse(sobanthang),
                                                      int.Parse(sobanthua),
                                                      int.Parse(socauthu)
                                                      );

                        DoiBongDAO.saveDoiBong(dto, sys.UPDATE);
                        MessageBox.Show("Sửa Thành Công!");
                        UC_DoiBong_Load(sender, e);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn đội bóng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool checkMa()
        {
            int count = 0;
            foreach (DataGridViewRow row in this.dgvDoiBong.Rows)
            {
                if (row.Cells["MaDoi"].Value != null && row.Cells["MaDoi"].Value.ToString() == txtMaDoi.Text)
                {
                    count++;
                }
            }
            return count == 0 ? true : false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDoi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã đội bóng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaDoi.Focus();
                }
                else if (txtTenDoi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đội bóng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenDoi.Focus();
                }
                else if (cbxMaTinh.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn mã tỉnh!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cbxMaSan.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn mã sân bóng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtHLV.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên huấn luyện viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHLV.Focus();
                }
                else if (txtImageSource.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn ảnh!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkMa() == false)
                {
                    MessageBox.Show("Mã đội bóng đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaDoi.Focus();
                }
                else
                {
                    string maDoi = txtMaDoi.Text;
                    string tenDoi = txtTenDoi.Text;
                    string maSan = cbxMaSan.SelectedValue.ToString();
                    string hlv = txtHLV.Text;
                    string matinh = cbxMaTinh.SelectedValue.ToString();
                    string diem = txtDiem.Text;
                    string sobanthang = "0";
                    string sobanthua = "0";
                    string socauthu = "0";

                    //sobanthang = sobanthua = socauthu = "0";
                    try
                    {
                        currentImg = convertImageToBytes();
                    }
                    catch
                    {

                    }
                    DoiBongDTO dto = new DoiBongDTO(maDoi,
                                                  tenDoi,
                                                  maSan,
                                                  hlv,
                                                  matinh,
                                                  currentImg,
                                                  int.Parse(diem),
                                                  int.Parse(sobanthang),
                                                  int.Parse(sobanthua),
                                                  int.Parse(socauthu)
                                                  );

                    DoiBongDAO.saveDoiBong(dto, sys.UPDATE);
                    MessageBox.Show("Thêm Thành Công!");
                    UC_DoiBong_Load(sender, e);
                    reset();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void reset()
        {
            txtMaDoi.Text = txtTenDoi.Text = txtImageSource.Text = txtHLV.Text = "";
            txtSoBanThang.Text = txtSoBanThua.Text = txtSoCauThu.Text = txtDiem.Text = "0";
            cbxMaSan.SelectedIndex = cbxMaTinh.SelectedIndex = -1;
            img.Image = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
