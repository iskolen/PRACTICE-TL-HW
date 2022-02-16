using System;
namespace LearnCSharp

{
    public class Ellipse
    {
        public Point CentrePoint { get; private set; }
        public int PointX { get; private set; }
        public int PointY { get; private set; }

        public Ellipse(Point centrePoint, int pointX, int pointY)
        {
            if (pointX < 0)
            {
                throw new ArgumentException("X-value cannot be less than zero");
            }
            if (pointY < 0)
            {
                throw new ArgumentException("Y-value cannot be less than zero");
            }

            PointY = pointY;
            PointX = pointX;
            CentrePoint = centrePoint;
        }
        public double GetLength() // L = Pi * ( a + b )
        {
            int a = PointX - CentrePoint.X;
            int b = PointY - CentrePoint.Y;
            return Math.PI * (a + b);
        }

        public double GetSquare() // S = Pi * a * b
        {
             int a = PointX - CentrePoint.X;
             int b = PointY - CentrePoint.Y;
             return Math.PI * a * b; 
        }
        
    }
}
