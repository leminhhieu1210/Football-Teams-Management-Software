using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevExpress.XtraBars;
using QLDB.DesignForm;

namespace QLDB
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            
          }


       
        public bool CheckOpenTabs(string name)
        {
            for (int i = 0; i < superTabControl.Tabs.Count; i++)
            {
                if (superTabControl.Tabs[i].Text == name)
                {
                    superTabControl.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private bool Add_SuperTab(ref SuperTabControl tabControl, string title, MyFormPage form)
        {
            try
            {
                if (CheckOpenTabs(title))
                {
                    superTabControl.TabIndex = superTabControl.Tabs.Count - 1;
                }
                else
                {
                    SuperTabItem tabPage = tabControl.CreateTab(title);
                    tabPage.AttachedControl.Controls.Add(form._Mypanel);
                    superTabControl.SelectedTabIndex = superTabControl.Tabs.Count - 1;

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        private void barButton_DangKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_SuperTab(ref superTabControl, "Đăng Ký Đội", new FrmDangKy());
        }

        private void barButton_ThemCauThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_SuperTab(ref superTabControl, "Thêm Cầu Thủ", new FrmThemCauThu());
        }

        private void barButton_ThongTinDoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_SuperTab(ref superTabControl, "Thông Tin Đội", new FrmThongTinDoi());
        }

        private void barButton_LapLichThiDau_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_SuperTab(ref superTabControl, "Lập Lịch Thi Đấu", new FrmTranDau());
        }

        private void barButton_XemLichThiDau_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_SuperTab(ref superTabControl, "Thông Tin Lịch Thi Đấu", new FrmThongTinLichThiDau());
        }

        private void barButton_GhiNhanKetQua_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_SuperTab(ref superTabControl, "Ghi Nhận Kết Quả", new FrmKetQua());
        }

        private void barButton_ThemCauThuGhiBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_SuperTab(ref superTabControl, "Chi Tiết Trận Đấu", new FrmChiTietTranDau());
        }

        private void barButton_XemKetQua_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_SuperTab(ref superTabControl, "Xem Kết Quả", new FrmThongTinKetQua());
        }

        private void barButton_BangXepHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButton_DanhSachCauThuGhiBan_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem_search_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_SuperTab(ref superTabControl, "Tìm Kiếm", new FrmTimKiem());
        }

        private void barButton_QuyDinhCauThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_SuperTab(ref superTabControl, "Quy Đinh Cầu Thủ", new FrmQuyDinhCauThu());
        }

        private void barButton_QuyDinhBanThang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_SuperTab(ref superTabControl, "Quy Định Bàn Thắng", new FrmQuyDinhBanThang());
        }

        private void barButton_LoaiCauThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmLoaiCauThu frm = new FrmLoaiCauThu();
            frm.ShowDialog();
        }

        private void barButton_VongDau_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmVongDau frm = new FrmVongDau();
            frm.ShowDialog();
        }

        private void barButton_MuaGiai_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMuaGiai frm = new FrmMuaGiai();
            frm.ShowDialog();
        
        }

        private void applicationMenu_CloseUp(object sender, EventArgs e)
        {
            MessageBox.Show("e");
        }

    }
}