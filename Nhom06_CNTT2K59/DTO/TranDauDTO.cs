using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TranDauDTO
    {
        string matrandau, luotdau;
        int vongdau;
        string madoinha, madoikhach;

        public TranDauDTO(string matrandau)
        {
            Matrandau = matrandau;
        }

        public TranDauDTO(string matrandau, string luotdau, int vongdau, string madoinha, string madoikhach)
        {
            this.Matrandau = matrandau;
            this.Luotdau = luotdau;
            this.Vongdau = vongdau;
            this.Madoinha = madoinha;
            this.Madoikhach = madoikhach;
        }

        public string Matrandau { get => matrandau; set => matrandau = value; }
        public string Luotdau { get => luotdau; set => luotdau = value; }
        public int Vongdau { get => vongdau; set => vongdau = value; }
        public string Madoinha { get => madoinha; set => madoinha = value; }
        public string Madoikhach { get => madoikhach; set => madoikhach = value; }
    }
}
