using System;

namespace DEMOMVC.Models
{
    public class DaiLy
    {
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }
        public string MaHTPP { get; set; }

        public void EnterData()
        {
            Console.WriteLine("Nhập MaDaiLy:");
            MaDaiLy = Console.ReadLine();
            Console.WriteLine("Nhập TenDaiLy:");
            TenDaiLy = Console.ReadLine();
            Console.WriteLine("Nhập DiaChi:");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhập NguoiDaiDien:");
            NguoiDaiDien = Console.ReadLine();
            Console.WriteLine("Nhập DienThoai:");
            DienThoai = Console.ReadLine();
            Console.WriteLine("Nhập MaHTPP:");
            MaHTPP = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine($"MaDaiLy: {MaDaiLy}");
            Console.WriteLine($"TenDaiLy: {TenDaiLy}");
            Console.WriteLine($"DiaChi: {DiaChi}");
            Console.WriteLine($"NguoiDaiDien: {NguoiDaiDien}");
            Console.WriteLine($"DienThoai: {DienThoai}");
            Console.WriteLine($"MaHTPP: {MaHTPP}");
        }
    }
}