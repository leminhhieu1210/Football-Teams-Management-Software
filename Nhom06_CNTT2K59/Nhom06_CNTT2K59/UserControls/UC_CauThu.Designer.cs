namespace Nhom06_CNTT2K59.UserControls
{
    partial class UC_CauThu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CauThu));
            this.dgvCauThu = new System.Windows.Forms.DataGridView();
            this.cbxQuocTich = new System.Windows.Forms.ComboBox();
            this.cbxViTri = new System.Windows.Forms.ComboBox();
            this.txtSoLanRaSan = new System.Windows.Forms.TextBox();
            this.txtSoBanThang = new System.Windows.Forms.TextBox();
            this.txtSoTheDo = new System.Windows.Forms.TextBox();
            this.txtSoTheVang = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSoAo = new System.Windows.Forms.TextBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.txtImageSource = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDoiBong = new System.Windows.Forms.ComboBox();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnID = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCauThu
            // 
            this.dgvCauThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauThu.Location = new System.Drawing.Point(35, 583);
            this.dgvCauThu.Name = "dgvCauThu";
            this.dgvCauThu.ReadOnly = true;
            this.dgvCauThu.RowHeadersWidth = 62;
            this.dgvCauThu.RowTemplate.Height = 28;
            this.dgvCauThu.Size = new System.Drawing.Size(1568, 292);
            this.dgvCauThu.TabIndex = 59;
            this.dgvCauThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCauThu_CellClick);
            // 
            // cbxQuocTich
            // 
            this.cbxQuocTich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuocTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxQuocTich.FormattingEnabled = true;
            this.cbxQuocTich.Location = new System.Drawing.Point(906, 227);
            this.cbxQuocTich.Name = "cbxQuocTich";
            this.cbxQuocTich.Size = new System.Drawing.Size(312, 37);
            this.cbxQuocTich.TabIndex = 58;
            // 
            // cbxViTri
            // 
            this.cbxViTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxViTri.FormattingEnabled = true;
            this.cbxViTri.Location = new System.Drawing.Point(905, 164);
            this.cbxViTri.Name = "cbxViTri";
            this.cbxViTri.Size = new System.Drawing.Size(313, 37);
            this.cbxViTri.TabIndex = 57;
            // 
            // txtSoLanRaSan
            // 
            this.txtSoLanRaSan.Enabled = false;
            this.txtSoLanRaSan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoLanRaSan.Location = new System.Drawing.Point(906, 343);
            this.txtSoLanRaSan.Multiline = true;
            this.txtSoLanRaSan.Name = "txtSoLanRaSan";
            this.txtSoLanRaSan.ReadOnly = true;
            this.txtSoLanRaSan.Size = new System.Drawing.Size(48, 37);
            this.txtSoLanRaSan.TabIndex = 55;
            this.txtSoLanRaSan.Text = "0";
            // 
            // txtSoBanThang
            // 
            this.txtSoBanThang.Enabled = false;
            this.txtSoBanThang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoBanThang.Location = new System.Drawing.Point(317, 284);
            this.txtSoBanThang.Multiline = true;
            this.txtSoBanThang.Name = "txtSoBanThang";
            this.txtSoBanThang.ReadOnly = true;
            this.txtSoBanThang.Size = new System.Drawing.Size(48, 37);
            this.txtSoBanThang.TabIndex = 54;
            this.txtSoBanThang.Text = "0";
            // 
            // txtSoTheDo
            // 
            this.txtSoTheDo.Enabled = false;
            this.txtSoTheDo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoTheDo.Location = new System.Drawing.Point(317, 341);
            this.txtSoTheDo.Multiline = true;
            this.txtSoTheDo.Name = "txtSoTheDo";
            this.txtSoTheDo.ReadOnly = true;
            this.txtSoTheDo.Size = new System.Drawing.Size(48, 37);
            this.txtSoTheDo.TabIndex = 53;
            this.txtSoTheDo.Text = "0";
            // 
            // txtSoTheVang
            // 
            this.txtSoTheVang.Enabled = false;
            this.txtSoTheVang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoTheVang.Location = new System.Drawing.Point(317, 401);
            this.txtSoTheVang.Multiline = true;
            this.txtSoTheVang.Name = "txtSoTheVang";
            this.txtSoTheVang.ReadOnly = true;
            this.txtSoTheVang.Size = new System.Drawing.Size(48, 37);
            this.txtSoTheVang.TabIndex = 52;
            this.txtSoTheVang.Text = "0";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(317, 227);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(165, 39);
            this.dtpNgaySinh.TabIndex = 51;
            // 
            // txtSoAo
            // 
            this.txtSoAo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoAo.Location = new System.Drawing.Point(906, 284);
            this.txtSoAo.Multiline = true;
            this.txtSoAo.Name = "txtSoAo";
            this.txtSoAo.Size = new System.Drawing.Size(49, 37);
            this.txtSoAo.TabIndex = 50;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(18, 21);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(252, 252);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 28;
            this.img.TabStop = false;
            // 
            // txtImageSource
            // 
            this.txtImageSource.Location = new System.Drawing.Point(1286, 49);
            this.txtImageSource.Name = "txtImageSource";
            this.txtImageSource.ReadOnly = true;
            this.txtImageSource.Size = new System.Drawing.Size(218, 26);
            this.txtImageSource.TabIndex = 67;
            this.txtImageSource.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.img);
            this.groupBox1.Location = new System.Drawing.Point(1258, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 285);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh";
            // 
            // cbxDoiBong
            // 
            this.cbxDoiBong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoiBong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxDoiBong.FormattingEnabled = true;
            this.cbxDoiBong.Location = new System.Drawing.Point(905, 100);
            this.cbxDoiBong.Name = "cbxDoiBong";
            this.cbxDoiBong.Size = new System.Drawing.Size(313, 37);
            this.cbxDoiBong.TabIndex = 56;
            this.cbxDoiBong.SelectedIndexChanged += new System.EventHandler(this.cbxDoiBong_SelectedIndexChanged);
            // 
            // txtTenCT
            // 
            this.txtTenCT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenCT.Location = new System.Drawing.Point(317, 169);
            this.txtTenCT.Multiline = true;
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(240, 37);
            this.txtTenCT.TabIndex = 49;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaCT.Location = new System.Drawing.Point(317, 105);
            this.txtMaCT.Multiline = true;
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.ReadOnly = true;
            this.txtMaCT.Size = new System.Drawing.Size(165, 37);
            this.txtMaCT.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(725, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 32);
            this.label12.TabIndex = 47;
            this.label12.Text = "Số lần ra sân:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(722, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 32);
            this.label11.TabIndex = 46;
            this.label11.Text = "Mã quốc tịch:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(146, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 32);
            this.label10.TabIndex = 45;
            this.label10.Text = "Số thẻ vàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(808, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 32);
            this.label9.TabIndex = 44;
            this.label9.Text = "Số áo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(768, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 32);
            this.label8.TabIndex = 43;
            this.label8.Text = "Mã Vị trí:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(722, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 32);
            this.label7.TabIndex = 42;
            this.label7.Text = "Mã đội bóng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(172, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 32);
            this.label6.TabIndex = 41;
            this.label6.Text = "Số thẻ đỏ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(129, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 32);
            this.label5.TabIndex = 40;
            this.label5.Text = "Số bàn thắng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(166, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 32);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(148, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tên cầu thủ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã cầu thủ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(557, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 54);
            this.label1.TabIndex = 36;
            this.label1.Text = "DANH MỤC CẦU THỦ";
            // 
            // btnImg
            // 
            this.btnImg.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImg.BorderRadius = 0;
            this.btnImg.ButtonText = "   Chọn ảnh";
            this.btnImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImg.DisabledColor = System.Drawing.Color.Gray;
            this.btnImg.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImg.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImg.Iconimage")));
            this.btnImg.Iconimage_right = null;
            this.btnImg.Iconimage_right_Selected = null;
            this.btnImg.Iconimage_Selected = null;
            this.btnImg.IconMarginLeft = 0;
            this.btnImg.IconMarginRight = 0;
            this.btnImg.IconRightVisible = true;
            this.btnImg.IconRightZoom = 0D;
            this.btnImg.IconVisible = true;
            this.btnImg.IconZoom = 64D;
            this.btnImg.IsTab = false;
            this.btnImg.Location = new System.Drawing.Point(1299, 401);
            this.btnImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImg.Name = "btnImg";
            this.btnImg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnImg.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnImg.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImg.selected = false;
            this.btnImg.Size = new System.Drawing.Size(205, 55);
            this.btnImg.TabIndex = 68;
            this.btnImg.Text = "   Chọn ảnh";
            this.btnImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImg.Textcolor = System.Drawing.Color.White;
            this.btnImg.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click_1);
            // 
            // btnID
            // 
            this.btnID.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnID.BorderRadius = 0;
            this.btnID.ButtonText = "Tạo Mã CT";
            this.btnID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnID.DisabledColor = System.Drawing.Color.Gray;
            this.btnID.Iconcolor = System.Drawing.Color.Transparent;
            this.btnID.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnID.Iconimage")));
            this.btnID.Iconimage_right = null;
            this.btnID.Iconimage_right_Selected = null;
            this.btnID.Iconimage_Selected = null;
            this.btnID.IconMarginLeft = 0;
            this.btnID.IconMarginRight = 0;
            this.btnID.IconRightVisible = true;
            this.btnID.IconRightZoom = 0D;
            this.btnID.IconVisible = true;
            this.btnID.IconZoom = 65D;
            this.btnID.IsTab = false;
            this.btnID.Location = new System.Drawing.Point(94, 501);
            this.btnID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnID.Name = "btnID";
            this.btnID.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnID.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnID.OnHoverTextColor = System.Drawing.Color.White;
            this.btnID.selected = false;
            this.btnID.Size = new System.Drawing.Size(197, 55);
            this.btnID.TabIndex = 69;
            this.btnID.Text = "Tạo Mã CT";
            this.btnID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnID.Textcolor = System.Drawing.Color.White;
            this.btnID.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "  Thêm";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 64D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(372, 501);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(154, 55);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.Text = "  Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "  Xoá";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 64D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(826, 501);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(154, 55);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "  Xoá";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "  Sửa";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 64D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(597, 501);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(154, 55);
            this.btnEdit.TabIndex = 72;
            this.btnEdit.Text = "  Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Làm mới";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReset.Iconimage")));
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 64D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(1044, 501);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(174, 55);
            this.btnReset.TabIndex = 73;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // UC_CauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.dgvCauThu);
            this.Controls.Add(this.cbxQuocTich);
            this.Controls.Add(this.cbxViTri);
            this.Controls.Add(this.txtSoLanRaSan);
            this.Controls.Add(this.txtSoBanThang);
            this.Controls.Add(this.txtSoTheDo);
            this.Controls.Add(this.txtSoTheVang);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtSoAo);
            this.Controls.Add(this.txtImageSource);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxDoiBong);
            this.Controls.Add(this.txtTenCT);
            this.Controls.Add(this.txtMaCT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Name = "UC_CauThu";
            this.Size = new System.Drawing.Size(1585, 897);
            this.Load += new System.EventHandler(this.UC_CauThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCauThu;
        private System.Windows.Forms.ComboBox cbxQuocTich;
        private System.Windows.Forms.ComboBox cbxViTri;
        private System.Windows.Forms.TextBox txtSoLanRaSan;
        private System.Windows.Forms.TextBox txtSoBanThang;
        private System.Windows.Forms.TextBox txtSoTheDo;
        private System.Windows.Forms.TextBox txtSoTheVang;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSoAo;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.TextBox txtImageSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxDoiBong;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnImg;
        private Bunifu.Framework.UI.BunifuFlatButton btnID;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
    }
}
