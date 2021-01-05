using DAL;
using Microsoft.Reporting.WinForms;
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

namespace Nhom06_CNTT2K59.UserControls
{
    public partial class UC_BaoCao : UserControl
    {
        public UC_BaoCao()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(c);
            //
            UC_DoiBong udb = new UC_DoiBong();
            AddControlsToPanel(udb);
        }

        public void FillCbo(DataTable t, ComboBox cbo, string ma, string ten)
        {
            cbo.DataSource = t;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
            cbo.SelectedIndex = -1;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string exeFolder = Application.StartupPath;
            if (index == 0)
            {
                string maTranDau = cbxTranDau.Text;
                ReportParameter[] parms = new ReportParameter[1];
                parms[0] = new ReportParameter("trandau", cbxTranDau.Text);
                string reportPath = Path.Combine(exeFolder, @"Reports\Report2.rdlc");
                reportViewer1.LocalReport.ReportPath = reportPath;
                reportViewer1.LocalReport.SetParameters(parms);
                DataSet ds = DAL.ReportDAO.getDataRP2(maTranDau);
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không Có Kết Quả Để Xuất Báo Cáo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "report2";
                    rds.Value = ds.Tables[0];
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
            }
            else if (index == 1)
            {
                string reportPath = Path.Combine(exeFolder, @"Reports\Report1.rdlc");
                reportViewer1.LocalReport.ReportPath = reportPath;

                DataSet ds = DAL.ReportDAO.getDataRP1();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không Có Kết Quả Để Xuất Báo Cáo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "rp1";
                    rds.Value = ds.Tables[0];
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
            }
            else if (index == 2)
            {
                string reportPath = Path.Combine(exeFolder, @"Reports\Report3.rdlc");
                reportViewer1.LocalReport.ReportPath = reportPath;

                DataSet ds = DAL.ReportDAO.getDataRP3();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không Có Kết Quả Để Xuất Báo Cáo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "report3";
                    rds.Value = ds.Tables[0];
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void UC_BaoCao_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            DataTable dt = TranDauDAO.getData();
            FillCbo(dt, cbxTranDau, "MaTranDau", "MaTranDau");

            lblMa.Text = "Mã trận đấu:";
            cbxTranDau.Visible = true;
            cbxTranDau.SelectedIndex = 0;
        }

        int index = 0;
        private void cbxBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBaoCao.SelectedIndex == 0)
            {
                lblMa.Text = "Mã trận đấu:";
                cbxTranDau.Visible = true;
                cbxTranDau.SelectedIndex = 0;
                index = 0;
            }
            else if (cbxBaoCao.SelectedIndex == 1)
            {
                lblMa.Text = "";
                cbxTranDau.Visible = false;
                index = 1;
            }
            else if (cbxBaoCao.SelectedIndex == 2)
            {
                lblMa.Text = "";
                cbxTranDau.Visible = false;
                index = 2;
            }
        }
    }
}
