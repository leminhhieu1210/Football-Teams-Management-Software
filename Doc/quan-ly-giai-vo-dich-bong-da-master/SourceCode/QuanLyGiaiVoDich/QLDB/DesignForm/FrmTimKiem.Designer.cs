﻿namespace QLDB.DesignForm
{
    partial class FrmTimKiem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button_search = new System.Windows.Forms.Button();
            this.cbox_chondoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cbox_muagiai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_doi = new System.Windows.Forms.ListView();
            this.cl_stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_tendoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_sannha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_succhua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView_cauthu = new System.Windows.Forms.ListView();
            this.cl_stt2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_loaict = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_quoctich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_ghichu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_sobt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.button_searchct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cauthu = new System.Windows.Forms.TextBox();
            this.quanLyGiaiVoDichDataSet = new QLDB.QuanLyGiaiVoDichDataSet();
            this.muagiaiTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.MUAGIAITableAdapter();
            this.doibonG_MUAGIAITableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.DOIBONG_MUAGIAITableAdapter();
            this.doibongTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.DOIBONGTableAdapter();
            this.sanTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.SANTableAdapter();
            this.doibonG_CAUTHUTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.DOIBONG_CAUTHUTableAdapter();
            this.cauthuTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.CAUTHUTableAdapter();
            this.loaibanthangTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.LOAIBANTHANGTableAdapter();
            this.loaicauthuTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.LOAICAUTHUTableAdapter();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 468);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.88034F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.11966F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1039, 468);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.66989F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33011F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1033, 189);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(230, 164);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.button_search, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.cbox_chondoi, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 44);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(224, 117);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // button_search
            // 
            this.button_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_search.Location = new System.Drawing.Point(74, 80);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 34);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Tìm Kiếm";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // cbox_chondoi
            // 
            this.cbox_chondoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_chondoi.FormattingEnabled = true;
            this.cbox_chondoi.Location = new System.Drawing.Point(3, 43);
            this.cbox_chondoi.Name = "cbox_chondoi";
            this.cbox_chondoi.Size = new System.Drawing.Size(218, 21);
            this.cbox_chondoi.TabIndex = 2;
            this.cbox_chondoi.SelectedIndexChanged += new System.EventHandler(this.cbox_chondoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn Đội";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.78572F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.21429F));
            this.tableLayoutPanel6.Controls.Add(this.cbox_muagiai, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(224, 35);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // cbox_muagiai
            // 
            this.cbox_muagiai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_muagiai.FormattingEnabled = true;
            this.cbox_muagiai.Location = new System.Drawing.Point(63, 7);
            this.cbox_muagiai.Name = "cbox_muagiai";
            this.cbox_muagiai.Size = new System.Drawing.Size(158, 21);
            this.cbox_muagiai.TabIndex = 1;
            this.cbox_muagiai.SelectedIndexChanged += new System.EventHandler(this.cbox_muagiai_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mùa Giải:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_doi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(245, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 183);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đội";
            // 
            // listView_doi
            // 
            this.listView_doi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_stt,
            this.cl_tendoi,
            this.cl_sannha,
            this.cl_succhua,
            this.cl_diachi});
            this.listView_doi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_doi.Location = new System.Drawing.Point(3, 16);
            this.listView_doi.Name = "listView_doi";
            this.listView_doi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView_doi.Size = new System.Drawing.Size(779, 164);
            this.listView_doi.TabIndex = 2;
            this.listView_doi.UseCompatibleStateImageBehavior = false;
            this.listView_doi.View = System.Windows.Forms.View.Details;
            // 
            // cl_stt
            // 
            this.cl_stt.Text = "STT";
            this.cl_stt.Width = 52;
            // 
            // cl_tendoi
            // 
            this.cl_tendoi.Text = "Tên Đội";
            this.cl_tendoi.Width = 190;
            // 
            // cl_sannha
            // 
            this.cl_sannha.Text = "Sân Nhà";
            this.cl_sannha.Width = 159;
            // 
            // cl_succhua
            // 
            this.cl_succhua.Text = "Sức Chứa";
            this.cl_succhua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_succhua.Width = 168;
            // 
            // cl_diachi
            // 
            this.cl_diachi.Text = "Địa Chỉ";
            this.cl_diachi.Width = 244;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.52941F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.47059F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 198);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1033, 267);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView_cauthu);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(246, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(784, 261);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Cầu Thủ";
            // 
            // listView_cauthu
            // 
            this.listView_cauthu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_stt2,
            this.cl_hoten,
            this.cl_ngaysinh,
            this.cl_loaict,
            this.cl_quoctich,
            this.cl_ghichu,
            this.cl_sobt});
            this.listView_cauthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_cauthu.Location = new System.Drawing.Point(3, 16);
            this.listView_cauthu.Name = "listView_cauthu";
            this.listView_cauthu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView_cauthu.Size = new System.Drawing.Size(778, 242);
            this.listView_cauthu.TabIndex = 1;
            this.listView_cauthu.UseCompatibleStateImageBehavior = false;
            this.listView_cauthu.View = System.Windows.Forms.View.Details;
            // 
            // cl_stt2
            // 
            this.cl_stt2.Text = "STT";
            this.cl_stt2.Width = 51;
            // 
            // cl_hoten
            // 
            this.cl_hoten.Text = "Họ Tên";
            this.cl_hoten.Width = 193;
            // 
            // cl_ngaysinh
            // 
            this.cl_ngaysinh.Text = "Ngày Sinh";
            this.cl_ngaysinh.Width = 159;
            // 
            // cl_loaict
            // 
            this.cl_loaict.Text = "Loại Cầu Thủ";
            this.cl_loaict.Width = 116;
            // 
            // cl_quoctich
            // 
            this.cl_quoctich.Text = "Quốc Tịch";
            this.cl_quoctich.Width = 98;
            // 
            // cl_ghichu
            // 
            this.cl_ghichu.DisplayIndex = 6;
            this.cl_ghichu.Text = "Ghi Chú";
            // 
            // cl_sobt
            // 
            this.cl_sobt.DisplayIndex = 5;
            this.cl_sobt.Text = "Số Bàn Thắng";
            this.cl_sobt.Width = 127;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel7);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 163);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.button_searchct, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.txt_cauthu, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(231, 144);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // button_searchct
            // 
            this.button_searchct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_searchct.Location = new System.Drawing.Point(78, 102);
            this.button_searchct.Name = "button_searchct";
            this.button_searchct.Size = new System.Drawing.Size(75, 35);
            this.button_searchct.TabIndex = 7;
            this.button_searchct.Text = "Tìm Kiếm";
            this.button_searchct.UseVisualStyleBackColor = true;
            this.button_searchct.Click += new System.EventHandler(this.button_searchct_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm Kiếm Theo Cầu Thủ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cauthu
            // 
            this.txt_cauthu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cauthu.Location = new System.Drawing.Point(3, 62);
            this.txt_cauthu.Name = "txt_cauthu";
            this.txt_cauthu.Size = new System.Drawing.Size(225, 20);
            this.txt_cauthu.TabIndex = 6;
            this.txt_cauthu.Text = "Nhập tên cầu thủ cần tìm";
            this.txt_cauthu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_cauthu_MouseClick);
            // 
            // quanLyGiaiVoDichDataSet
            // 
            this.quanLyGiaiVoDichDataSet.DataSetName = "QuanLyGiaiVoDichDataSet";
            this.quanLyGiaiVoDichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muagiaiTableAdapter
            // 
            this.muagiaiTableAdapter.ClearBeforeFill = true;
            // 
            // doibonG_MUAGIAITableAdapter
            // 
            this.doibonG_MUAGIAITableAdapter.ClearBeforeFill = true;
            // 
            // doibongTableAdapter
            // 
            this.doibongTableAdapter.ClearBeforeFill = true;
            // 
            // sanTableAdapter
            // 
            this.sanTableAdapter.ClearBeforeFill = true;
            // 
            // doibonG_CAUTHUTableAdapter
            // 
            this.doibonG_CAUTHUTableAdapter.ClearBeforeFill = true;
            // 
            // cauthuTableAdapter
            // 
            this.cauthuTableAdapter.ClearBeforeFill = true;
            // 
            // loaibanthangTableAdapter
            // 
            this.loaibanthangTableAdapter.ClearBeforeFill = true;
            // 
            // loaicauthuTableAdapter
            // 
            this.loaicauthuTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 468);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTimKiem";
            this.Text = "Tìm Kiếm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbox_muagiai;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_doi;
        private System.Windows.Forms.ColumnHeader cl_stt;
        private System.Windows.Forms.ColumnHeader cl_tendoi;
        private System.Windows.Forms.ColumnHeader cl_sannha;
        private System.Windows.Forms.ColumnHeader cl_succhua;
        private System.Windows.Forms.ColumnHeader cl_diachi;
        private QuanLyGiaiVoDichDataSet quanLyGiaiVoDichDataSet;
        private QuanLyGiaiVoDichDataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView_cauthu;
        private System.Windows.Forms.ColumnHeader cl_stt2;
        private System.Windows.Forms.ColumnHeader cl_hoten;
        private System.Windows.Forms.ColumnHeader cl_ngaysinh;
        private System.Windows.Forms.ColumnHeader cl_loaict;
        private System.Windows.Forms.ColumnHeader cl_quoctich;
        private System.Windows.Forms.ColumnHeader cl_sobt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ColumnHeader cl_ghichu;
        private QuanLyGiaiVoDichDataSetTableAdapters.DOIBONG_MUAGIAITableAdapter doibonG_MUAGIAITableAdapter;
        private QuanLyGiaiVoDichDataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter;
        private QuanLyGiaiVoDichDataSetTableAdapters.SANTableAdapter sanTableAdapter;
        private QuanLyGiaiVoDichDataSetTableAdapters.DOIBONG_CAUTHUTableAdapter doibonG_CAUTHUTableAdapter;
        private QuanLyGiaiVoDichDataSetTableAdapters.CAUTHUTableAdapter cauthuTableAdapter;
        private QuanLyGiaiVoDichDataSetTableAdapters.LOAIBANTHANGTableAdapter loaibanthangTableAdapter;
        private QuanLyGiaiVoDichDataSetTableAdapters.LOAICAUTHUTableAdapter loaicauthuTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cbox_chondoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button button_searchct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cauthu;
    }
}