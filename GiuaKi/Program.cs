// See https://aka.ms/new-console-template for more information

using GiuaKi.Model;

internal class Program
{
    private static List<Sach> sachs343 = new List<Sach>
    {
        new Sach(1, "Vat Ly", "Giao Duc", 1, "Quang", 100),
        new Sach(2, "Toan", "Giao Duc", 2, "Quang", 200),
    };
    
    private static List<Bao> baos343 = new List<Bao>
    {
        new Bao(1, "Tuoi Tre", "Dong A", 1, new DateTime(2024, 3, 15)),
        new Bao(2, "Nguoi Lon", "Dao Da", 2, new DateTime(2024, 5, 21)),
    };
    
    private static List<TapChi> tapChis343 = new List<TapChi>
    {
        new TapChi(1, "Hoc Duong", "Kim Dong", 1, 1, 20),
        new TapChi(2, "Nguoi Lon", "Lau Da", 2, 2, 20),
    };

    private static List<DanhMuc> danhMucs343 = new List<DanhMuc>
    {
        new DanhMuc(1, "Hoc Sinh", 1, 1, 1),
        new DanhMuc(2, "Nguoi Lon", 2, 2, 2),
    };

    private static List<TaiLieu> taiLieus343 = new List<TaiLieu>
    {
    };
    
    public static void Main(string[] args)
    {
        taiLieus343.AddRange(sachs343);
        taiLieus343.AddRange(baos343);
        taiLieus343.AddRange(tapChis343);

        var sachLoc343 = taiLieus343.Where(tl => tl.GetType() == typeof(Sach));
        var baoLoc343 = taiLieus343.Where(tl => tl.GetType() == typeof(Bao));
        var tapChiLoc343 = taiLieus343.Where(tl => tl.GetType() == typeof(TapChi));

        var firstMarch343 = new DateTime(2024, 3, 1);
        var lastMarch343 = new DateTime(2024, 3, 31);
        
        var baoInMarch343 = baos343.Where(b => b.NgayPh >= firstMarch343 && b.NgayPh <= lastMarch343);

    }
}