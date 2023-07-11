namespace LVTbaiThucHanh.Models
{
    public class Student : Person
    {
        public string StudentCode {get; set;}
        public void Nhapdulieu()
        {
            base.Input();
            System.Console.Write("Student Code = ");
            StudentCode = Console.ReadLine();
        }
        public void Display()
        {
            base.Output();
            System.Console.Write("- Ma sinh vien: {0} ", StudentCode);
        }
        
    }
    
}