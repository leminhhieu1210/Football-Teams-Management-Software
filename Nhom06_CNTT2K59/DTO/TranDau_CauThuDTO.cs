using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TranDau_CauThuDTO
    {
        private string maTranDau, maDoi, maCauThu, maViTri;

        public TranDau_CauThuDTO(string maTranDau, string maDoi, string maCauThu, string maViTri)
        {
            this.maTranDau = maTranDau;
            this.maDoi = maDoi;
            this.maCauThu = maCauThu;
            this.maViTri = maViTri;
        }

        public TranDau_CauThuDTO(string maTranDau, string maDoi, string maCauThu)
        {
            MaTranDau = maTranDau;
            MaDoi = maDoi;
            MaCauThu = maCauThu;
        }

        public string MaTranDau { get => maTranDau; set => maTranDau = value; }
        public string MaDoi { get => maDoi; set => maDoi = value; }
        public string MaCauThu { get => maCauThu; set => maCauThu = value; }
        public string MaViTri { get => maViTri; set => maViTri = value; }
    }
}
