using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapGiuaKy
{
    class Sach : TaiLieu
    {
        public string tenTG { get; set; }
        public int soTrang { get; set; }

        public Sach(string maXB, string tenTL, string NPH, int maDM, string tenTG, int soTrang):base(maXB, tenTL, NPH, maDM)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
        }
    }
}
