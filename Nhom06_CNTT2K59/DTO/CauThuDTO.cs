using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CauThuDTO
    {
        private string maCT, maDoi, tenCT, viTri, maQT;
        private DateTime ngaySinh;
        private int soAo, soBanThang, soTheVang, soTheDo, soLanRaSan;
        private byte[] anh;

        public CauThuDTO(string maCauThu, int soLanRaSan,int sbt)
        {
            MaCauThu = maCauThu;
            SoLanRaSan = soLanRaSan;
            SoBanThang = sbt;
        }

        public CauThuDTO(string maCT, string maDoi, string tenCT, string viTri,
                         DateTime ngaySinh, int soAo, int soBanThang, int soTheVang, 
                         int soTheDo, string maQT, int soLanRaSan, byte[] anh)
        {
            this.maCT = maCT;
            this.maDoi = maDoi;
            this.tenCT = tenCT;
            this.viTri = viTri;
            this.ngaySinh = ngaySinh;
            this.maQT = maQT;
            this.soAo = soAo;
            this.SoBanThang = soBanThang;
            this.SoTheVang = soTheVang;
            this.SoTheDo = soTheDo;
            this.SoLanRaSan = soLanRaSan;
            this.Anh = anh;
        }

        public string MaCauThu { get => maCT; set => maCT = value; }
        public string MaDoi { get => maDoi; set => maDoi = value; }
        public string TenCauThu { get => tenCT; set => tenCT = value; }
        public string MaViTri { get => viTri; set => viTri = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string MaQuocTich { get => maQT; set => maQT = value; }
        public int SoAo { get => soAo; set => soAo = value; }
        public int SoBanThang { get => soBanThang; set => soBanThang = value; }
        public int SoTheVang { get => soTheVang; set => soTheVang = value; }
        public int SoTheDo { get => soTheDo; set => soTheDo = value; }
        public int SoLanRaSan { get => soLanRaSan; set => soLanRaSan = value; }
        public byte[] Anh { get => anh; set => anh = value; }
    }
}
