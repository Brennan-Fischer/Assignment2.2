using System.Formats.Asn1;

namespace Assignment2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int readResult;
            do
            {
                Console.WriteLine("Please select the shape to calculate area. Type 1 for circle or 2 for square or 3 to exit");
                readResult = Convert.ToInt32(Console.ReadLine());
                switch (readResult)
                {
                    case 1:
                        Console.WriteLine("Input radius of circle");
                        double userRadius = Convert.ToDouble(Console.ReadLine());
                        Circle userCircle = new Circle(userRadius);
                        userCircle.calculateArea();
                        break;
                    case 2:
                        Console.WriteLine("Input length of square side");
                        double userSideLength = Convert.ToDouble(Console.ReadLine());
                        Square userSquare = new Square(userSideLength);
                        userSquare.calculateArea();
                        break;
                    case 3:
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            }
            while (readResult != 3);

            

            }

        }
    }

    public abstract class Shape
    {
        public int ShapeId { get; set; }
        public string ShapeName { get; set; }
        public string ShapeColor { get; set; }

        public virtual double calculateArea()
        {
            double area = 0;
            Console.WriteLine("The area of this shape is undefined");
            return area;
        }

    }

    public class Circle : Shape 
    { 
        public double radius { get; set; }

        public override double calculateArea()
        {
            double area = radius * radius * 3.14;
            Console.WriteLine("The area of the circle is " + area);
            return area;
        }
        public Circle(double inputRadiusLength)
        {
            radius = inputRadiusLength;
            ShapeId = 1;
            ShapeColor = "white";
            ShapeName = "userCircle";

        }
    }
    public class Square : Shape
    {
        public double sideLength { get; set; }

        public override double calculateArea()
        {
            double area = sideLength * sideLength;
            Console.WriteLine("The area of the square is " + area);
            return area;
        }
        public Square(double inputSideLength) 
        { 
            sideLength = inputSideLength;
            ShapeId = 1;
            ShapeColor = "white";
            ShapeName = "userSquare"; 

        }
    }

