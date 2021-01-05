using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoiBongDTO
    {
        private string maDoi, tenDoi, maSan, HLV, maTinh;
        private byte[] logo;
        private int diem, soBanThang, soBanThua, soCauThu;

        public DoiBongDTO(string maDoi, string tenDoi, string maSan, string hLV, string maTinh, byte[] logo, int diem, int soBanThang, int soBanThua, int soCauThu)
        {
            this.maDoi = maDoi;
            this.tenDoi = tenDoi;
            this.maSan = maSan;
            HLV = hLV;
            this.maTinh = maTinh;
            this.logo = logo;
            this.diem = diem;
            this.soBanThang = soBanThang;
            this.soBanThua = soBanThua;
            this.soCauThu = soCauThu;
        }

        public string MaDoi { get => maDoi; set => maDoi = value; }
        public string TenDoi { get => tenDoi; set => tenDoi = value; }
        public string MaSan { get => maSan; set => maSan = value; }
        public string HLV1 { get => HLV; set => HLV = value; }
        public string MaTinh { get => maTinh; set => maTinh = value; }
        public byte[] Logo { get => logo; set => logo = value; }
        public int Diem { get => diem; set => diem = value; }
        public int SoBanThang { get => soBanThang; set => soBanThang = value; }
        public int SoBanThua { get => soBanThua; set => soBanThua = value; }
        public int SoCauThu { get => soCauThu; set => soCauThu = value; }
    }
}
