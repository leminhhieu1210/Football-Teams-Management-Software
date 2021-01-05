using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TranDau_BanThangDTO
    {
        private string maTranDau, maCauThu;
        private int thoigian;

        public TranDau_BanThangDTO(string maTranDau, string maCauThu, int thoigian)
        {
            this.maTranDau = maTranDau;
            this.maCauThu = maCauThu;
            this.thoigian = thoigian;
        }

        public TranDau_BanThangDTO(string maCauThu, int thoigian)
        {
            MaCauThu = maCauThu;
            Thoigian = thoigian;
        }

        public string MaTranDau { get => maTranDau; set => maTranDau = value; }
        public string MaCauThu { get => maCauThu; set => maCauThu = value; }
        public int Thoigian { get => thoigian; set => thoigian = value; }
    }
}
