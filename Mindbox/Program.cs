using FigureLib;

namespace MindboxConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var test1 = new Triangle(9, 4, 6);
            var test2 = new Triangle(5, 8.5, 5);
            var test3 = new Triangle(5, 5, 5);

            Console.WriteLine(test1.GetSquare());
            Console.WriteLine(test2.GetSquare());
            Console.WriteLine(test3.GetSquare());

            var ttest1 = new Circle(3);
            var ttest2 = new Circle(4.4);
            var ttest3 = new Circle(5);

            Console.WriteLine(ttest1.GetSquare());
            Console.WriteLine(ttest2.GetSquare());
            Console.WriteLine(ttest3.GetSquare());
        }
    }
}