using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapGiuaKy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaiLieu> dsTL312 = new List<TaiLieu>();

            //them danh sach S, B, TC
            dsTL312.Add(new Sach("S01", "Lap trinh C#", "NPH A", 1, "Van A", 200));
            dsTL312.Add(new Sach("S02", "Cong nghe phan mem", "NPH B", 1, "Van C", 120));
            dsTL312.Add(new TapChi("TC01", "Tap chi A", "NPH F", 2, "So 221", "Trang AAS"));
            dsTL312.Add(new TapChi("RC01", "Tap chi khoa hoc", "NPH Doi song", 2, "So 2024", "Trang KH-DS"));
            dsTL312.Add(new Bao("B01", "Bao A", "NPH FD", 3, new DateTime(2024, 5, 20)));
            dsTL312.Add(new Bao("B01", "Bao B", "NPH ND", 3, new DateTime(2021, 8, 24)));

            //tim theo loai
            Console.WriteLine("Nhap loai tai lieu can tim: ");
            string cateKey = Console.ReadLine();
            var danhmuc312 = DanhMuc.getDanhMucs();

            var search312 = dsTL312.Join(danhmuc312,
                                        ds=>ds.maDM,
                                        dm=>dm.idDM, 
                                        (ds, dm) => new { DS = ds, DM = dm })
                                    .Where(dm=>dm.DM.cateName.Contains(cateKey))
                                    .Select(result => result.DS);
            //var search312 = dsTL312.Where(ds=> danhmuc.Any(dm => dm.idDM == ds.maDM && dm.cateName == cateKey));
            foreach (var item312 in search312)
            {
                if (item312 is Bao)
                {
                    var bao312 = (Bao)item312;
                    Console.WriteLine($"Bao: {bao312.tenTL} - Ngay phat hanh: {bao312.ngayPH}");
                }
                else if (item312 is TapChi)
                {
                    var tapChi312 = (TapChi)item312;
                    Console.WriteLine($"Tap Chi: {tapChi312.tenTL} - So PH: {tapChi312.soPH}, Trang PH: {tapChi312.trangPH}");
                }
                else if (item312 is Sach)
                {
                    var sach312 = (Sach)item312;
                    Console.WriteLine($"Sach: {sach312.tenTL} - Tac gia: {sach312.tenTG}, So trang: {sach312.soTrang}");
                }
            }
            Console.WriteLine("");

            //tim bao co ngay ph trong thang 3/2024
            Console.WriteLine("Tim bao co ngay ph trong thang 3/2024");
            var baoNgayPH312 = dsTL312.OfType<Bao>().Where(b => b.ngayPH.Month == 3 && b.ngayPH.Year == 2024);
            if (baoNgayPH312.Any())
            {
                foreach (var item312 in baoNgayPH312)
                {
                    Console.WriteLine($"Bao: {item312.tenTL} - Published on: {item312.ngayPH}");
                }
            }
            else
            {
                Console.WriteLine("Khong co bao phat hanh trong thang 3/2024");
            }

            Console.ReadKey();
        }
    }
}
