namespace QLDB.DesignForm
{
    partial class FrmQuyDinhBanThang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuyDinhBanThang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_quydinh = new System.Windows.Forms.DataGridView();
            this.mAQDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHOIDIEMGHIBANTOIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHUADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUYDINHBANTHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGiaiVoDichDataSet = new QLDB.QuanLyGiaiVoDichDataSet();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_maqd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_thoidiem = new System.Windows.Forms.TextBox();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.txt_hoa = new System.Windows.Forms.TextBox();
            this.txt_thua = new System.Windows.Forms.TextBox();
            this.button_dongy = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_maloai = new System.Windows.Forms.TextBox();
            this.txt_loaibt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.button_huy = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.dataGridView_loaibt = new System.Windows.Forms.DataGridView();
            this.mALOAIBTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIBTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIBANTHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIBANTHANGTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.LOAIBANTHANGTableAdapter();
            this.qUYDINHBANTHANGTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.QUYDINHBANTHANGTableAdapter();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_quydinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUYDINHBANTHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loaibt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIBANTHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 415);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 415);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView_quydinh, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_dongy, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.71394F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.38386F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(545, 409);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView_quydinh
            // 
            this.dataGridView_quydinh.AutoGenerateColumns = false;
            this.dataGridView_quydinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_quydinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_quydinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAQDDataGridViewTextBoxColumn,
            this.tHOIDIEMGHIBANTOIDADataGridViewTextBoxColumn,
            this.tHANGDataGridViewTextBoxColumn,
            this.hOADataGridViewTextBoxColumn,
            this.tHUADataGridViewTextBoxColumn});
            this.dataGridView_quydinh.DataSource = this.qUYDINHBANTHANGBindingSource;
            this.dataGridView_quydinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_quydinh.Location = new System.Drawing.Point(3, 248);
            this.dataGridView_quydinh.Name = "dataGridView_quydinh";
            this.dataGridView_quydinh.Size = new System.Drawing.Size(539, 45);
            this.dataGridView_quydinh.TabIndex = 0;
            // 
            // mAQDDataGridViewTextBoxColumn
            // 
            this.mAQDDataGridViewTextBoxColumn.DataPropertyName = "MAQD";
            this.mAQDDataGridViewTextBoxColumn.HeaderText = "MAQD";
            this.mAQDDataGridViewTextBoxColumn.Name = "mAQDDataGridViewTextBoxColumn";
            // 
            // tHOIDIEMGHIBANTOIDADataGridViewTextBoxColumn
            // 
            this.tHOIDIEMGHIBANTOIDADataGridViewTextBoxColumn.DataPropertyName = "THOIDIEMGHIBANTOIDA";
            this.tHOIDIEMGHIBANTOIDADataGridViewTextBoxColumn.HeaderText = "THOIDIEMGHIBANTOIDA";
            this.tHOIDIEMGHIBANTOIDADataGridViewTextBoxColumn.Name = "tHOIDIEMGHIBANTOIDADataGridViewTextBoxColumn";
            // 
            // tHANGDataGridViewTextBoxColumn
            // 
            this.tHANGDataGridViewTextBoxColumn.DataPropertyName = "THANG";
            this.tHANGDataGridViewTextBoxColumn.HeaderText = "THANG";
            this.tHANGDataGridViewTextBoxColumn.Name = "tHANGDataGridViewTextBoxColumn";
            // 
            // hOADataGridViewTextBoxColumn
            // 
            this.hOADataGridViewTextBoxColumn.DataPropertyName = "HOA";
            this.hOADataGridViewTextBoxColumn.HeaderText = "HOA";
            this.hOADataGridViewTextBoxColumn.Name = "hOADataGridViewTextBoxColumn";
            // 
            // tHUADataGridViewTextBoxColumn
            // 
            this.tHUADataGridViewTextBoxColumn.DataPropertyName = "THUA";
            this.tHUADataGridViewTextBoxColumn.HeaderText = "THUA";
            this.tHUADataGridViewTextBoxColumn.Name = "tHUADataGridViewTextBoxColumn";
            // 
            // qUYDINHBANTHANGBindingSource
            // 
            this.qUYDINHBANTHANGBindingSource.DataMember = "QUYDINHBANTHANG";
            this.qUYDINHBANTHANGBindingSource.DataSource = this.quanLyGiaiVoDichDataSet;
            // 
            // quanLyGiaiVoDichDataSet
            // 
            this.quanLyGiaiVoDichDataSet.DataSetName = "QuanLyGiaiVoDichDataSet";
            this.quanLyGiaiVoDichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.37975F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.48608F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_thoidiem, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_thang, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_hoa, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txt_thua, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99812F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(539, 239);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel9);
            this.panel2.Controls.Add(this.txt_maqd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(394, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 53);
            this.panel2.TabIndex = 12;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(142, 53);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // txt_maqd
            // 
            this.txt_maqd.Location = new System.Drawing.Point(16, 6);
            this.txt_maqd.Name = "txt_maqd";
            this.txt_maqd.Size = new System.Drawing.Size(100, 20);
            this.txt_maqd.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Điểm Thua:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời diểm ghi bàn tối đa:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điểm Hòa:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm Thắng:";
            // 
            // txt_thoidiem
            // 
            this.txt_thoidiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thoidiem.Location = new System.Drawing.Point(166, 19);
            this.txt_thoidiem.Name = "txt_thoidiem";
            this.txt_thoidiem.Size = new System.Drawing.Size(222, 20);
            this.txt_thoidiem.TabIndex = 6;
            this.txt_thoidiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_thoidiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thoidiem_KeyPress);
            // 
            // txt_thang
            // 
            this.txt_thang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thang.Location = new System.Drawing.Point(166, 78);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(222, 20);
            this.txt_thang.TabIndex = 7;
            this.txt_thang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_thang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thang_KeyPress);
            // 
            // txt_hoa
            // 
            this.txt_hoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hoa.Location = new System.Drawing.Point(166, 137);
            this.txt_hoa.Name = "txt_hoa";
            this.txt_hoa.Size = new System.Drawing.Size(222, 20);
            this.txt_hoa.TabIndex = 8;
            this.txt_hoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hoa_KeyPress);
            // 
            // txt_thua
            // 
            this.txt_thua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thua.Location = new System.Drawing.Point(166, 198);
            this.txt_thua.Name = "txt_thua";
            this.txt_thua.Size = new System.Drawing.Size(222, 20);
            this.txt_thua.TabIndex = 9;
            this.txt_thua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_thua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thua_KeyPress);
            // 
            // button_dongy
            // 
            this.button_dongy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_dongy.Location = new System.Drawing.Point(235, 335);
            this.button_dongy.Name = "button_dongy";
            this.button_dongy.Size = new System.Drawing.Size(75, 35);
            this.button_dongy.TabIndex = 10;
            this.button_dongy.Text = "Đồng Ý";
            this.button_dongy.UseVisualStyleBackColor = true;
            this.button_dongy.Click += new System.EventHandler(this.button_dongy_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView_loaibt, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(554, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.1687F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.8313F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(291, 409);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 244);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(285, 162);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25123F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.74877F));
            this.tableLayoutPanel6.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txt_loaibt, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(279, 26);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel8);
            this.panel4.Controls.Add(this.txt_maloai);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 20);
            this.panel4.TabIndex = 11;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(86, 20);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại BT:";
            // 
            // txt_maloai
            // 
            this.txt_maloai.Location = new System.Drawing.Point(16, 6);
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Size = new System.Drawing.Size(100, 20);
            this.txt_maloai.TabIndex = 0;
            // 
            // txt_loaibt
            // 
            this.txt_loaibt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_loaibt.Location = new System.Drawing.Point(95, 3);
            this.txt_loaibt.Name = "txt_loaibt";
            this.txt_loaibt.Size = new System.Drawing.Size(181, 20);
            this.txt_loaibt.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Controls.Add(this.button_sua, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.button_them, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.button_xoa, 2, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(279, 58);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // button_sua
            // 
            this.button_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_sua.Location = new System.Drawing.Point(102, 11);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(75, 35);
            this.button_sua.TabIndex = 6;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_them
            // 
            this.button_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_them.Location = new System.Drawing.Point(9, 11);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(75, 35);
            this.button_them.TabIndex = 3;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_xoa.Location = new System.Drawing.Point(195, 11);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 35);
            this.button_xoa.TabIndex = 4;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.button_huy, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.button_ok, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(279, 60);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // button_huy
            // 
            this.button_huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_huy.Location = new System.Drawing.Point(171, 12);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(75, 35);
            this.button_huy.TabIndex = 6;
            this.button_huy.Text = "Hủy";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ok.Location = new System.Drawing.Point(32, 12);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 35);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "Xác Nhận";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // dataGridView_loaibt
            // 
            this.dataGridView_loaibt.AutoGenerateColumns = false;
            this.dataGridView_loaibt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_loaibt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_loaibt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mALOAIBTDataGridViewTextBoxColumn,
            this.lOAIBTDataGridViewTextBoxColumn});
            this.dataGridView_loaibt.DataSource = this.lOAIBANTHANGBindingSource;
            this.dataGridView_loaibt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_loaibt.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_loaibt.Name = "dataGridView_loaibt";
            this.dataGridView_loaibt.Size = new System.Drawing.Size(285, 235);
            this.dataGridView_loaibt.TabIndex = 0;
            // 
            // mALOAIBTDataGridViewTextBoxColumn
            // 
            this.mALOAIBTDataGridViewTextBoxColumn.DataPropertyName = "MALOAIBT";
            this.mALOAIBTDataGridViewTextBoxColumn.HeaderText = "MALOAIBT";
            this.mALOAIBTDataGridViewTextBoxColumn.Name = "mALOAIBTDataGridViewTextBoxColumn";
            // 
            // lOAIBTDataGridViewTextBoxColumn
            // 
            this.lOAIBTDataGridViewTextBoxColumn.DataPropertyName = "LOAIBT";
            this.lOAIBTDataGridViewTextBoxColumn.HeaderText = "LOAIBT";
            this.lOAIBTDataGridViewTextBoxColumn.Name = "lOAIBTDataGridViewTextBoxColumn";
            // 
            // lOAIBANTHANGBindingSource
            // 
            this.lOAIBANTHANGBindingSource.DataMember = "LOAIBANTHANG";
            this.lOAIBANTHANGBindingSource.DataSource = this.quanLyGiaiVoDichDataSet;
            // 
            // lOAIBANTHANGTableAdapter
            // 
            this.lOAIBANTHANGTableAdapter.ClearBeforeFill = true;
            // 
            // qUYDINHBANTHANGTableAdapter
            // 
            this.qUYDINHBANTHANGTableAdapter.ClearBeforeFill = true;
            // 
            // FrmQuyDinhBanThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 415);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuyDinhBanThang";
            this.Text = "Quy Định Bàn Thắng";
            this.Load += new System.EventHandler(this.FrmQuyDinhBanThang_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_quydinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUYDINHBANTHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loaibt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIBANTHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView_quydinh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView_loaibt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_maloai;
        private System.Windows.Forms.TextBox txt_loaibt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_thoidiem;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.TextBox txt_hoa;
        private System.Windows.Forms.TextBox txt_thua;
        private System.Windows.Forms.Button button_dongy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox txt_maqd;
        private QuanLyGiaiVoDichDataSet quanLyGiaiVoDichDataSet;
        private System.Windows.Forms.BindingSource lOAIBANTHANGBindingSource;
        private QuanLyGiaiVoDichDataSetTableAdapters.LOAIBANTHANGTableAdapter lOAIBANTHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOAIBTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIBTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource qUYDINHBANTHANGBindingSource;
        private QuanLyGiaiVoDichDataSetTableAdapters.QUYDINHBANTHANGTableAdapter qUYDINHBANTHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAQDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHOIDIEMGHIBANTOIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHUADataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button button_huy;
    }
}