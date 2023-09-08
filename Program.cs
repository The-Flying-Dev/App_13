namespace ShapeAreaCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shape Area Calculator");
        Console.WriteLine("Choose from the following shapes to get the area");
        Console.WriteLine("For a Rectangle press 'r' and for a Circle press 'c'");

        string choice = Console.ReadLine();

        float height;
        float width;
        float radius;

        float result;

        if (choice == "r")
        {
            Console.WriteLine("Please enter the height of the rectangle.");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of the rectangle.");
            width = float.Parse(Console.ReadLine());

            result = height * width;
        }
        else
        {
            Console.WriteLine("Please enter the radius of the circle.");
            radius = float.Parse(Console.ReadLine());

            result = (float)Math.PI * (radius * radius);
        }

        Console.WriteLine("The result is " + result);

        Console.ReadKey();
    }
}
