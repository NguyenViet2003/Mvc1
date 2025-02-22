using System;

namespace DEMOMVC.Models
{
    public class HeThongPhanPhoi
    {
        public string MaHTPP { get; set; }
        public string TenHTPP { get; set; }

        public void EnterData()
        {
            Console.WriteLine("Nhập MaHTPP:");
            MaHTPP = Console.ReadLine();
            Console.WriteLine("Nhập TenHTPP:");
            TenHTPP = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine($"MaHTPP: {MaHTPP}");
            Console.WriteLine($"TenHTPP: {TenHTPP}");
        }
    }
}