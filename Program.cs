using LVTbaiThucHanh.Models;
public class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] Arr = new int[n];
    for (int i = 0; i < Arr.Length; i++)
    {
        System.Console.Write("Nhap phan tu thu {0}: ",i+1);
        int number = Convert.ToInt32(Console.ReadLine());
        Arr[i] = number;
    }
    for (int i = 0 ; i < Arr.Count(); i++)
    {
        System.Console.Write(Arr[i] + "\t");
    }

    }
}