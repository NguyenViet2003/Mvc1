namespace TinhDiemMonHoc.Models
{
    public class DiemMonHoc
    {
        public double DiemA { get; set; }
        public double DiemB { get; set; }
        public double DiemC { get; set; }
        public double DiemTongKet { get; set; }

        public void TinhDiemTongKet()
        {
            DiemTongKet = (DiemA + DiemB + DiemC) / 3;
        }
    }
}