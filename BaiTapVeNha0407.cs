using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap vao ten sinh vien: ");
        string ten = Console.ReadLine();
        Console.Write("Nhap vao tuoi sinh vien: ");
        string tuoi = Console.ReadLine();
        Console.Write("Nhap vao diem toan: ");
        double toan = double.Parse(Console.ReadLine());
        Console.Write("Nhap vao diem van: ");
        double van = double.Parse(Console.ReadLine());
        Console.Write("Nhap vao diem anh: ");
        double anh = double.Parse(Console.ReadLine());
        Console.Write("Nhap vao diem ly: ");
        double ly = double.Parse(Console.ReadLine());
        Console.Write("Nhap vao diem hoa: ");
        double hoa = double.Parse(Console.ReadLine());
        double dtb = (toan + van + anh + ly + hoa) / 5;
        Console.WriteLine("ten sinh vien:{0} - tuoi sinh vien:{1} - diem toan:{2} - diem van:{3} - diem anh:{4} - diem ly:{5} - diem hoa:{6} - diem trung binh mon hoc:{7}", ten, tuoi, toan, van, anh, ly, hoa, dtb);
    }
}
