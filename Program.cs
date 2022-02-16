using System;
using LearnCSharp;

class Program
{
    public static void Main(string[] args)
    {
        Point centrePoint = new Point
        {
            X = 0,
            Y = 0
        };

        int pointX = 10;
        int pointY = 10;

        try
        {
            Ellipse ellipse = new Ellipse(centrePoint, pointX, pointY);

            double length = ellipse.GetLength();
            double square = ellipse.GetSquare();

            Console.WriteLine($"X = {ellipse.PointX.ToString()}, Y = {ellipse.PointY.ToString()}, Centre Point = {ellipse.CentrePoint.ToString()}"); // write x, y, centre point

            Console.Write( "Length = " ); // write "length ="
            Console.WriteLine( length ); // write value length 

            Console.Write( "Square = " ); // write "square ="
            Console.WriteLine( square ); // write value square       
        }

        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
