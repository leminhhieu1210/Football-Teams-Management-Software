using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TranDau_TheDTO
    {
        private string maTranDau, maCauThu, loaithe;
        private int thoiGian;

        public TranDau_TheDTO(string maTranDau, string maCauThu, int thoiGian, string loaithe)
        {
            this.maTranDau = maTranDau;
            this.maCauThu = maCauThu;
            this.thoiGian = thoiGian;
            this.loaithe = loaithe;
        }

        public TranDau_TheDTO(string maCauThu, int thoiGian, string loaiThe)
        {
            MaCauThu = maCauThu;
            ThoiGian = thoiGian;
            LoaiThe = loaiThe;
        }

        public string MaTranDau { get => maTranDau; set => maTranDau = value; }
        public string MaCauThu { get => maCauThu; set => maCauThu = value; }
        public int ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string LoaiThe { get => loaithe; set => loaithe = value; }
    }
}
