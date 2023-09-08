namespace ShapeAreaCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shape Area Calculator");
        Console.WriteLine("Choose from the following shapes to get the area");
        Console.WriteLine(
            "For a Rectangle press 'r', for a Triangle press 't' and for a Circle press 'c'"
        );

        string choice = Console.ReadLine().Trim().ToLower();

        // Variables declared to store the inputted data
        float height;
        float width;
        float radius;

        float result;

        if (choice == "r")
        {
            result = Rectangle();

            // Console.WriteLine("Please enter the height of the rectangle.");
            // height = float.Parse(Console.ReadLine());

            // Console.WriteLine("Please enter the width of the rectangle.");
            // width = float.Parse(Console.ReadLine());

            // result = height * width;
        }
        else if (choice == "t")
        {
            result = Triangle();
            // Console.WriteLine("Please enter the height of the triangle.");
            // height = float.Parse(Console.ReadLine());

            // Console.WriteLine("Please enter the base of the triangle.");
            // width = float.Parse(Console.ReadLine());

            // result = 0.5f * (height * width);
        }
        else
        {
            result = Circle();
            // Console.WriteLine("Please enter the radius of the circle.");
            // radius = float.Parse(Console.ReadLine());

            // result = (float)Math.PI * (radius * radius);
        }

        Console.WriteLine("The result is " + result);

        Console.ReadKey();

        // Now using Local Functions to complete the calculations
        // Does not need to include the member access modifier
        // since all Local Functions are Private doing so will result in an error
        float Rectangle()
        {
            Console.WriteLine("Please enter the height of the rectangle.");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of the rectangle.");
            width = float.Parse(Console.ReadLine());

            result = height * width;
            return result;
        }

        // Local Function
        float Triangle()
        {
            Console.WriteLine("Please enter the height of the triangle.");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the base of the triangle.");
            width = float.Parse(Console.ReadLine());

            result = 0.5f * (height * width);

            return result;
        }

        // Local Function
        float Circle()
        {
            Console.WriteLine("Please enter the radius of the circle.");
            radius = float.Parse(Console.ReadLine());

            result = (float)Math.PI * (radius * radius);
            return result;
            //float resultRounded = MathF.Round(result, 2, MidpointRounding.ToEven);
            //return resultRounded;
        }
    }
}
