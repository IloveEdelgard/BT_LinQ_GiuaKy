using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapGiuaKy
{
    class DanhMuc
    {
        public int idDM { get; set; }
        public string cateName { get; set; }

        public static List<DanhMuc> getDanhMucs()
        {
            return new List<DanhMuc>()
            {
                new DanhMuc{idDM=1, cateName="Sach"},
                new DanhMuc{idDM=2, cateName="Tap chi"},
                new DanhMuc{idDM=3, cateName="Bao"}
            };
        }
    }
}
