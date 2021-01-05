namespace Nhom06_CNTT2K59.UserControls
{
    partial class UC_TimKiemTranDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TimKiemTranDau));
            this.cbxDoiNha = new System.Windows.Forms.ComboBox();
            this.dgvTimKiemTranDau = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTheDo = new System.Windows.Forms.TextBox();
            this.txtSoBanThang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFind = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemTranDau)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDoiNha
            // 
            this.cbxDoiNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoiNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxDoiNha.FormattingEnabled = true;
            this.cbxDoiNha.Location = new System.Drawing.Point(294, 137);
            this.cbxDoiNha.Name = "cbxDoiNha";
            this.cbxDoiNha.Size = new System.Drawing.Size(279, 37);
            this.cbxDoiNha.TabIndex = 28;
            // 
            // dgvTimKiemTranDau
            // 
            this.dgvTimKiemTranDau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemTranDau.Location = new System.Drawing.Point(75, 391);
            this.dgvTimKiemTranDau.Name = "dgvTimKiemTranDau";
            this.dgvTimKiemTranDau.ReadOnly = true;
            this.dgvTimKiemTranDau.RowHeadersWidth = 62;
            this.dgvTimKiemTranDau.RowTemplate.Height = 28;
            this.dgvTimKiemTranDau.Size = new System.Drawing.Size(1486, 464);
            this.dgvTimKiemTranDau.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(606, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(467, 60);
            this.label4.TabIndex = 25;
            this.label4.Text = "TÌM KIẾM TRẬN ĐẤU";
            // 
            // txtSoTheDo
            // 
            this.txtSoTheDo.Location = new System.Drawing.Point(1300, 137);
            this.txtSoTheDo.Multiline = true;
            this.txtSoTheDo.Name = "txtSoTheDo";
            this.txtSoTheDo.Size = new System.Drawing.Size(55, 37);
            this.txtSoTheDo.TabIndex = 24;
            // 
            // txtSoBanThang
            // 
            this.txtSoBanThang.Location = new System.Drawing.Point(908, 137);
            this.txtSoBanThang.Multiline = true;
            this.txtSoBanThang.Name = "txtSoBanThang";
            this.txtSoBanThang.Size = new System.Drawing.Size(55, 37);
            this.txtSoBanThang.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1164, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số thẻ đỏ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(729, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số bàn thắng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(177, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Đội nhà:";
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
            this.btnReset.IconZoom = 65D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(936, 270);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(163, 51);
            this.btnReset.TabIndex = 77;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFind
            // 
            this.btnFind.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.BorderRadius = 0;
            this.btnFind.ButtonText = "Tìm kiếm";
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.DisabledColor = System.Drawing.Color.Gray;
            this.btnFind.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFind.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFind.Iconimage")));
            this.btnFind.Iconimage_right = null;
            this.btnFind.Iconimage_right_Selected = null;
            this.btnFind.Iconimage_Selected = null;
            this.btnFind.IconMarginLeft = 0;
            this.btnFind.IconMarginRight = 0;
            this.btnFind.IconRightVisible = true;
            this.btnFind.IconRightZoom = 0D;
            this.btnFind.IconVisible = true;
            this.btnFind.IconZoom = 65D;
            this.btnFind.IsTab = false;
            this.btnFind.Location = new System.Drawing.Point(1173, 270);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnFind.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnFind.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFind.selected = false;
            this.btnFind.Size = new System.Drawing.Size(182, 51);
            this.btnFind.TabIndex = 76;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Textcolor = System.Drawing.Color.White;
            this.btnFind.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // UC_TimKiemTranDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cbxDoiNha);
            this.Controls.Add(this.dgvTimKiemTranDau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoTheDo);
            this.Controls.Add(this.txtSoBanThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Name = "UC_TimKiemTranDau";
            this.Size = new System.Drawing.Size(1585, 897);
            this.Load += new System.EventHandler(this.UC_TimKiemTranDau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemTranDau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxDoiNha;
        private System.Windows.Forms.DataGridView dgvTimKiemTranDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTheDo;
        private System.Windows.Forms.TextBox txtSoBanThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuFlatButton btnFind;
    }
}
