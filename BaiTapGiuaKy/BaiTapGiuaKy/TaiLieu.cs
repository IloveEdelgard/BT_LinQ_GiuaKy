using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapGiuaKy
{
    class TaiLieu
    {
        public string maXB { get; set; }
        public string tenTL { get; set; }
        public string NPH { get; set; }
        public int maDM { get; set; }

        public TaiLieu(string maXB, String tenTL, string NPH, int maDM)
        {
            this.maXB = maXB;
            this.tenTL = tenTL;
            this.NPH = NPH;
            this.maDM = maDM;
        }
    }
}
