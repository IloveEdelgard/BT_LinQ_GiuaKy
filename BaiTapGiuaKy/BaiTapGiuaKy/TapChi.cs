using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapGiuaKy
{
    class TapChi:TaiLieu
    {
        public string soPH { get; set; }
        public string trangPH { get; set; }
        public TapChi(string maXB, string tenTL, string NPH, int maDM, string soPH, string trangPH) : base(maXB, tenTL, NPH, maDM)
        {
            this.soPH = soPH;
            this.trangPH = trangPH;
        }
    }
}
