namespace Assignment1_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a program in C# to calculate area of triangle, square and rectangle.
            //    Write 3 different functions for each shape to take dimensions of figure and display the area. You may create menus.

            double tArea, sArea, rArea;

            tArea = TriangleArea(10, 15);

            sArea = SquareArea(20);

            rArea = RectangleArea(8, 24);

            Console.WriteLine();

        }

        // Function for Triangle area calculation (1/2(base * height))
        public static double TriangleArea(double b, double h)
        {
            double area = 0.5 * (b * h);
            Console.WriteLine("The area of this Triangle is: " + area);
            return area;
        }

        // Function for Square area calculation (x^2)
        public static double SquareArea(double x)
        {
            double area = Math.Pow(x, 2);
            Console.WriteLine("The area of this Square is: " + area);
            return area;
        }

        // Function for rectangle area calculation (Length(x) * Width(y))
        public static double RectangleArea(double x, double y)
        {
            double area = x * y;
            Console.WriteLine("The area of this Rectangle is: " + area);
            return area;
        }
    }
}