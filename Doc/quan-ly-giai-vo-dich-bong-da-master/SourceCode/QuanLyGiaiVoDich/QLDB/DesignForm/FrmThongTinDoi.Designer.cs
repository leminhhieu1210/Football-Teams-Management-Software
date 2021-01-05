namespace QLDB.DesignForm
{
    partial class FrmThongTinDoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongTinDoi));
            this.quanLyGiaiVoDichDataSet = new QLDB.QuanLyGiaiVoDichDataSet();
            this.cauthuTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.CAUTHUTableAdapter();
            this.doibongTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.DOIBONGTableAdapter();
            this.muagiaiTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.MUAGIAITableAdapter();
            this.doibonG_CAUTHUTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.DOIBONG_CAUTHUTableAdapter();
            this.sanTableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.SANTableAdapter();
            this.doibonG_MUAGIAITableAdapter = new QLDB.QuanLyGiaiVoDichDataSetTableAdapters.DOIBONG_MUAGIAITableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView_info = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView_Player = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_tendoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_san = new System.Windows.Forms.TextBox();
            this.link_thongtinsan = new System.Windows.Forms.LinkLabel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // quanLyGiaiVoDichDataSet
            // 
            this.quanLyGiaiVoDichDataSet.DataSetName = "QuanLyGiaiVoDichDataSet";
            this.quanLyGiaiVoDichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cauthuTableAdapter
            // 
            this.cauthuTableAdapter.ClearBeforeFill = true;
            // 
            // doibongTableAdapter
            // 
            this.doibongTableAdapter.ClearBeforeFill = true;
            // 
            // muagiaiTableAdapter
            // 
            this.muagiaiTableAdapter.ClearBeforeFill = true;
            // 
            // doibonG_CAUTHUTableAdapter
            // 
            this.doibonG_CAUTHUTableAdapter.ClearBeforeFill = true;
            // 
            // sanTableAdapter
            // 
            this.sanTableAdapter.ClearBeforeFill = true;
            // 
            // doibonG_MUAGIAITableAdapter
            // 
            this.doibonG_MUAGIAITableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 474);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView_info);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(819, 474);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView_info
            // 
            this.treeView_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_info.Location = new System.Drawing.Point(0, 0);
            this.treeView_info.Name = "treeView_info";
            this.treeView_info.ShowLines = false;
            this.treeView_info.Size = new System.Drawing.Size(211, 474);
            this.treeView_info.TabIndex = 0;
            this.treeView_info.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView_info_AfterExpand);
            this.treeView_info.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_info_NodeMouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listView_Player, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listView_Player
            // 
            this.listView_Player.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Player.Location = new System.Drawing.Point(3, 74);
            this.listView_Player.Name = "listView_Player";
            this.listView_Player.Size = new System.Drawing.Size(598, 397);
            this.listView_Player.TabIndex = 0;
            this.listView_Player.UseCompatibleStateImageBehavior = false;
            this.listView_Player.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cầu Thủ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại Cầu Thủ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quốc Tịch";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi Chú";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label_tendoi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_san, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.link_thongtinsan, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(598, 65);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label_tendoi
            // 
            this.label_tendoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tendoi.AutoSize = true;
            this.label_tendoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tendoi.Location = new System.Drawing.Point(3, 26);
            this.label_tendoi.Name = "label_tendoi";
            this.label_tendoi.Size = new System.Drawing.Size(193, 13);
            this.label_tendoi.TabIndex = 0;
            this.label_tendoi.Text = "Tên Đội";
            this.label_tendoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sân Nhà:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_san
            // 
            this.txt_san.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_san.Location = new System.Drawing.Point(301, 22);
            this.txt_san.Name = "txt_san";
            this.txt_san.ReadOnly = true;
            this.txt_san.Size = new System.Drawing.Size(193, 20);
            this.txt_san.TabIndex = 0;
            // 
            // link_thongtinsan
            // 
            this.link_thongtinsan.ActiveLinkColor = System.Drawing.Color.Red;
            this.link_thongtinsan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.link_thongtinsan.AutoSize = true;
            this.link_thongtinsan.DisabledLinkColor = System.Drawing.Color.White;
            this.link_thongtinsan.LinkColor = System.Drawing.Color.Black;
            this.link_thongtinsan.Location = new System.Drawing.Point(500, 26);
            this.link_thongtinsan.Name = "link_thongtinsan";
            this.link_thongtinsan.Size = new System.Drawing.Size(72, 13);
            this.link_thongtinsan.TabIndex = 1;
            this.link_thongtinsan.TabStop = true;
            this.link_thongtinsan.Text = "Thông tin sân";
            this.link_thongtinsan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_thongtinsan_LinkClicked);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmThongTinDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 474);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmThongTinDoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Đội";
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView_info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView_Player;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private QuanLyGiaiVoDichDataSet quanLyGiaiVoDichDataSet;
        private QuanLyGiaiVoDichDataSetTableAdapters.CAUTHUTableAdapter cauthuTableAdapter;
        private QuanLyGiaiVoDichDataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter;
        private QuanLyGiaiVoDichDataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter;
        private QuanLyGiaiVoDichDataSetTableAdapters.DOIBONG_CAUTHUTableAdapter doibonG_CAUTHUTableAdapter;
        private QuanLyGiaiVoDichDataSetTableAdapters.SANTableAdapter sanTableAdapter;
        private QuanLyGiaiVoDichDataSetTableAdapters.DOIBONG_MUAGIAITableAdapter doibonG_MUAGIAITableAdapter;
        private System.Windows.Forms.Label label_tendoi;
        private System.Windows.Forms.TextBox txt_san;
        private System.Windows.Forms.LinkLabel link_thongtinsan;
        private System.Windows.Forms.ImageList imageList;
    }
}