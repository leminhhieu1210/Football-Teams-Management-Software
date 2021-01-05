namespace Nhom06_CNTT2K59.UserControls
{
    partial class UC_BaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BaoCao));
            this.btnXuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.cbxTranDau = new System.Windows.Forms.ComboBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.cbxBaoCao = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlCenter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuat
            // 
            this.btnXuat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuat.BorderRadius = 0;
            this.btnXuat.ButtonText = " Xuất";
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuat.DisabledColor = System.Drawing.Color.Gray;
            this.btnXuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXuat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnXuat.Iconimage")));
            this.btnXuat.Iconimage_right = null;
            this.btnXuat.Iconimage_right_Selected = null;
            this.btnXuat.Iconimage_Selected = null;
            this.btnXuat.IconMarginLeft = 0;
            this.btnXuat.IconMarginRight = 0;
            this.btnXuat.IconRightVisible = true;
            this.btnXuat.IconRightZoom = 0D;
            this.btnXuat.IconVisible = true;
            this.btnXuat.IconZoom = 65D;
            this.btnXuat.IsTab = false;
            this.btnXuat.Location = new System.Drawing.Point(833, -1);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnXuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnXuat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXuat.selected = false;
            this.btnXuat.Size = new System.Drawing.Size(145, 56);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.Text = " Xuất";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Textcolor = System.Drawing.Color.White;
            this.btnXuat.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCenter.Controls.Add(this.reportViewer1);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(10, 65);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1585, 897);
            this.pnlCenter.TabIndex = 16;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nhom06_CNTT2K59.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1611, 853);
            this.reportViewer1.TabIndex = 6;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnlHeader.Controls.Add(this.cbxTranDau);
            this.pnlHeader.Controls.Add(this.lblMa);
            this.pnlHeader.Controls.Add(this.cbxBaoCao);
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Controls.Add(this.btnXuat);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1585, 55);
            this.pnlHeader.TabIndex = 15;
            // 
            // cbxTranDau
            // 
            this.cbxTranDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTranDau.FormattingEnabled = true;
            this.cbxTranDau.Location = new System.Drawing.Point(661, 14);
            this.cbxTranDau.Name = "cbxTranDau";
            this.cbxTranDau.Size = new System.Drawing.Size(121, 28);
            this.cbxTranDau.TabIndex = 7;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.Color.White;
            this.lblMa.Location = new System.Drawing.Point(519, 13);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(0, 28);
            this.lblMa.TabIndex = 6;
            // 
            // cbxBaoCao
            // 
            this.cbxBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.cbxBaoCao.BaseColor = System.Drawing.Color.White;
            this.cbxBaoCao.BorderColor = System.Drawing.Color.Silver;
            this.cbxBaoCao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaoCao.FocusedColor = System.Drawing.Color.Empty;
            this.cbxBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxBaoCao.ForeColor = System.Drawing.Color.Black;
            this.cbxBaoCao.FormattingEnabled = true;
            this.cbxBaoCao.Items.AddRange(new object[] {
            "Danh sách trận đấu",
            "Danh sách cầu thủ",
            "Danh sách top 3 ghi bàn"});
            this.cbxBaoCao.Location = new System.Drawing.Point(161, 10);
            this.cbxBaoCao.Name = "cbxBaoCao";
            this.cbxBaoCao.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxBaoCao.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxBaoCao.Size = new System.Drawing.Size(257, 35);
            this.cbxBaoCao.StartIndex = 0;
            this.cbxBaoCao.TabIndex = 4;
            this.cbxBaoCao.SelectedIndexChanged += new System.EventHandler(this.cbxBaoCao_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Báo Cáo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 962);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1585, 22);
            this.panel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(-5, -6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "© Copyrights by Nhom06 - CNTT2 - K59";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1595, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 974);
            this.panel4.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1595, 10);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 984);
            this.panel2.TabIndex = 18;
            // 
            // UC_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "UC_BaoCao";
            this.Size = new System.Drawing.Size(1605, 984);
            this.Load += new System.EventHandler(this.UC_BaoCao_Load);
            this.pnlCenter.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnXuat;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox cbxBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbxTranDau;
        private System.Windows.Forms.Label lblMa;
    }
}
