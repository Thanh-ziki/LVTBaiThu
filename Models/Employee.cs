namespace LVTbaiThucHanh.Models
{
    public class Employee
    {
        public int MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }
        public void NhapThongTin()
        {
            System.Console.Write("ma nhan vien: ");
            MaNhanVien = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Ho Ten Nhan Vien: ");
            HoTen = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            Tuoi = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Luong: ");
            Luong = Convert.ToInt16(Console.ReadLine());
        }
        public void XuatThongTin()
        {
            System.Console.WriteLine("ma nhan vien: {0} - ho ten: {1} - tuoi: {2} - luong: {3}",MaNhanVien,HoTen,Tuoi,Luong);
        }
    }
}