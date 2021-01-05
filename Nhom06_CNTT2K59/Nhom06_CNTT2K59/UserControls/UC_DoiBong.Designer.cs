namespace Nhom06_CNTT2K59.UserControls
{
    partial class UC_DoiBong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DoiBong));
            this.dgvDoiBong = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.PictureBox();
            this.txtImageSource = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoCauThu = new System.Windows.Forms.TextBox();
            this.txtSoBanThua = new System.Windows.Forms.TextBox();
            this.txtSoBanThang = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.cbxMaTinh = new System.Windows.Forms.ComboBox();
            this.cbxMaSan = new System.Windows.Forms.ComboBox();
            this.txtHLV = new System.Windows.Forms.TextBox();
            this.txtTenDoi = new System.Windows.Forms.TextBox();
            this.txtMaDoi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiBong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDoiBong
            // 
            this.dgvDoiBong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoiBong.Location = new System.Drawing.Point(36, 532);
            this.dgvDoiBong.Name = "dgvDoiBong";
            this.dgvDoiBong.ReadOnly = true;
            this.dgvDoiBong.RowHeadersWidth = 62;
            this.dgvDoiBong.RowTemplate.Height = 28;
            this.dgvDoiBong.Size = new System.Drawing.Size(1579, 325);
            this.dgvDoiBong.TabIndex = 58;
            this.dgvDoiBong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoiBong_CellClick);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(15, 25);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(300, 300);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 28;
            this.img.TabStop = false;
            // 
            // txtImageSource
            // 
            this.txtImageSource.Enabled = false;
            this.txtImageSource.Location = new System.Drawing.Point(1302, 25);
            this.txtImageSource.Name = "txtImageSource";
            this.txtImageSource.ReadOnly = true;
            this.txtImageSource.Size = new System.Drawing.Size(229, 26);
            this.txtImageSource.TabIndex = 61;
            this.txtImageSource.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.img);
            this.groupBox1.Location = new System.Drawing.Point(1249, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 340);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logo";
            // 
            // txtSoCauThu
            // 
            this.txtSoCauThu.Enabled = false;
            this.txtSoCauThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCauThu.Location = new System.Drawing.Point(244, 230);
            this.txtSoCauThu.Multiline = true;
            this.txtSoCauThu.Name = "txtSoCauThu";
            this.txtSoCauThu.Size = new System.Drawing.Size(65, 37);
            this.txtSoCauThu.TabIndex = 56;
            this.txtSoCauThu.Text = "0";
            // 
            // txtSoBanThua
            // 
            this.txtSoBanThua.Enabled = false;
            this.txtSoBanThua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBanThua.Location = new System.Drawing.Point(840, 291);
            this.txtSoBanThua.Multiline = true;
            this.txtSoBanThua.Name = "txtSoBanThua";
            this.txtSoBanThua.Size = new System.Drawing.Size(65, 37);
            this.txtSoBanThua.TabIndex = 55;
            this.txtSoBanThua.Text = "0";
            // 
            // txtSoBanThang
            // 
            this.txtSoBanThang.Enabled = false;
            this.txtSoBanThang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBanThang.Location = new System.Drawing.Point(244, 291);
            this.txtSoBanThang.Multiline = true;
            this.txtSoBanThang.Name = "txtSoBanThang";
            this.txtSoBanThang.Size = new System.Drawing.Size(65, 37);
            this.txtSoBanThang.TabIndex = 54;
            this.txtSoBanThang.Text = "0";
            // 
            // txtDiem
            // 
            this.txtDiem.Enabled = false;
            this.txtDiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.Location = new System.Drawing.Point(840, 356);
            this.txtDiem.Multiline = true;
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(65, 37);
            this.txtDiem.TabIndex = 53;
            this.txtDiem.Text = "0";
            // 
            // cbxMaTinh
            // 
            this.cbxMaTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaTinh.FormattingEnabled = true;
            this.cbxMaTinh.Location = new System.Drawing.Point(840, 111);
            this.cbxMaTinh.Name = "cbxMaTinh";
            this.cbxMaTinh.Size = new System.Drawing.Size(342, 37);
            this.cbxMaTinh.TabIndex = 52;
            // 
            // cbxMaSan
            // 
            this.cbxMaSan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaSan.FormattingEnabled = true;
            this.cbxMaSan.Location = new System.Drawing.Point(840, 171);
            this.cbxMaSan.Name = "cbxMaSan";
            this.cbxMaSan.Size = new System.Drawing.Size(342, 37);
            this.cbxMaSan.TabIndex = 51;
            // 
            // txtHLV
            // 
            this.txtHLV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHLV.Location = new System.Drawing.Point(840, 230);
            this.txtHLV.Multiline = true;
            this.txtHLV.Name = "txtHLV";
            this.txtHLV.Size = new System.Drawing.Size(342, 37);
            this.txtHLV.TabIndex = 50;
            // 
            // txtTenDoi
            // 
            this.txtTenDoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDoi.Location = new System.Drawing.Point(244, 171);
            this.txtTenDoi.Multiline = true;
            this.txtTenDoi.Name = "txtTenDoi";
            this.txtTenDoi.Size = new System.Drawing.Size(342, 37);
            this.txtTenDoi.TabIndex = 49;
            // 
            // txtMaDoi
            // 
            this.txtMaDoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDoi.Location = new System.Drawing.Point(244, 111);
            this.txtMaDoi.Multiline = true;
            this.txtMaDoi.Name = "txtMaDoi";
            this.txtMaDoi.Size = new System.Drawing.Size(342, 37);
            this.txtMaDoi.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label11.Location = new System.Drawing.Point(12, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 32);
            this.label11.TabIndex = 47;
            this.label11.Text = "Số lượng cầu thủ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Location = new System.Drawing.Point(662, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 32);
            this.label9.TabIndex = 46;
            this.label9.Text = "Số bàn thua:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label8.Location = new System.Drawing.Point(56, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 32);
            this.label8.TabIndex = 45;
            this.label8.Text = "Số bàn thắng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(738, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 32);
            this.label7.TabIndex = 44;
            this.label7.Text = "Điểm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(708, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 43;
            this.label6.Text = "Mã tỉnh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(612, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 32);
            this.label5.TabIndex = 42;
            this.label5.Text = "Huấn luyện viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Location = new System.Drawing.Point(714, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mã sân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(123, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tên đội:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(127, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã đội:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(599, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 60);
            this.label1.TabIndex = 38;
            this.label1.Text = "ĐỘI BÓNG";
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
            this.btnImg.Location = new System.Drawing.Point(1313, 427);
            this.btnImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImg.Name = "btnImg";
            this.btnImg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnImg.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnImg.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImg.selected = false;
            this.btnImg.Size = new System.Drawing.Size(205, 55);
            this.btnImg.TabIndex = 62;
            this.btnImg.Text = "   Chọn ảnh";
            this.btnImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImg.Textcolor = System.Drawing.Color.White;
            this.btnImg.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(599, 427);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(154, 55);
            this.btnEdit.TabIndex = 63;
            this.btnEdit.Text = "  Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "  Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThem.Iconimage")));
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 64D;
            this.btnThem.IsTab = false;
            this.btnThem.Location = new System.Drawing.Point(170, 427);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(154, 55);
            this.btnThem.TabIndex = 64;
            this.btnThem.Text = "  Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnReset.Location = new System.Drawing.Point(1008, 427);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(174, 55);
            this.btnReset.TabIndex = 74;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // UC_DoiBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.dgvDoiBong);
            this.Controls.Add(this.txtImageSource);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoCauThu);
            this.Controls.Add(this.txtSoBanThua);
            this.Controls.Add(this.txtSoBanThang);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.cbxMaTinh);
            this.Controls.Add(this.cbxMaSan);
            this.Controls.Add(this.txtHLV);
            this.Controls.Add(this.txtTenDoi);
            this.Controls.Add(this.txtMaDoi);
            this.Controls.Add(this.label11);
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
            this.Name = "UC_DoiBong";
            this.Size = new System.Drawing.Size(1585, 897);
            this.Load += new System.EventHandler(this.UC_DoiBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiBong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDoiBong;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.TextBox txtImageSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoCauThu;
        private System.Windows.Forms.TextBox txtSoBanThua;
        private System.Windows.Forms.TextBox txtSoBanThang;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.ComboBox cbxMaTinh;
        private System.Windows.Forms.ComboBox cbxMaSan;
        private System.Windows.Forms.TextBox txtHLV;
        private System.Windows.Forms.TextBox txtTenDoi;
        private System.Windows.Forms.TextBox txtMaDoi;
        private System.Windows.Forms.Label label11;
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
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
    }
}
