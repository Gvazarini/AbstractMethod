using AbstractMethods.Entities.Enums;
using AbstractMethods.Entities;
using System.Globalization;
namespace AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Shapes: ");
            int n = int.Parse(Console.ReadLine());
            List<Shapes> list = new List<Shapes>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter figure #{i} data: ");
                Console.Write("Rectangle or Circle, (r/c)? : ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Color (Black , Red or Green)? ");
                Color pickcolor = Enum.Parse<Color>(Console.ReadLine());
                if (c == 'r')
                {
                    Console.Write("Width: ");
                    double wdt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double hgt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                    list.Add(new Rectangle(wdt, hgt, pickcolor));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, pickcolor));
                } 
            }
            Console.WriteLine();
            Console.WriteLine("Shapes Areas");
            foreach (Shapes shapes in list)
            {
                Console.WriteLine(shapes.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}