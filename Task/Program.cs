namespace Task
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Please Enter Your Name :");
            string Name = Console.ReadLine() ?? "NA";

            Console.Write("Please Enter Your Age :");
            int.TryParse(Console.ReadLine() ?? "0", out int Age);

            Console.Write("Please Enter Your Salary :");
            decimal.TryParse(Console.ReadLine() ?? "0", out decimal Salary);

            Console.Clear();
            Console.Beep(500, 200);

            Console.WriteLine($"Your Name Is {Name}");
            Console.WriteLine($"Your Age Is {Age}");
            Console.WriteLine($"Your Salary Is {Salary}");
        }
    }
}
