namespace LVTbaiThucHanh.Models
{
    public class Person
    {
        public int studentID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public void Input()
        {
            System.Console.Write("StudentID: ");
            studentID = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Ho Ten Sinh Vien: ");
            FullName = Console.ReadLine();
            System.Console.Write("Age: ");
           do
           {
            try
           {
             Age = Convert.ToInt16(Console.ReadLine());
           }
           catch (Exception ex)
           {
            Age = 0;
           }
           } while (Age == 0);

        }
        public void Output()
        {
            System.Console.WriteLine("Ma Sinh Vien: {0} - Ho va ten: {1} - Tuoi: {2}", studentID,FullName,Age);
        }
        
    }
    
}