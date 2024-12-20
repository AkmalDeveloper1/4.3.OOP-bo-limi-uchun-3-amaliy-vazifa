using OOP_Student;
using OOP_Car;
using OOP_Boxer;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\t1 - vazifa\n\t2 - vazifa\n\t3 - vazifa\n\t4 - Tugatish");
            Console.Write("Qaysi vazifani tekshirishni istaysiz\nvazifa tartib raqamini kriting: ");
            byte.TryParse(Console.ReadLine(), out byte number);

            switch (number)
            {
                case 1:
                    MainStudent mainStudent = new MainStudent();
                    break;
                case 2:
                    MainCar mainCar = new MainCar();
                    break;
                case 3:
                    MainBoxer mainBoxer = new MainBoxer();
                    break;
                case 4:
                    ConsoleColor color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tVazifani tekshirib berganingiz uchun Raxmat !!!");
                    Console.ForegroundColor = color;
                    break;

                default: Console.WriteLine("Qayta kriting"); break;
            }
            if (number == 4) break;
            Console.Clear();

        }
    }
}