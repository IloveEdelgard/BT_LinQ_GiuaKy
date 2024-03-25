using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapGiuaKy
{
    class Bao:TaiLieu
    {
        public DateTime ngayPH { get; set; }
        public Bao(string maXB, string tenTL, string NPH, int maDM, DateTime ngayPH) : base(maXB, tenTL, NPH, maDM)
        {
            this.ngayPH = ngayPH;
        }
    }
}
