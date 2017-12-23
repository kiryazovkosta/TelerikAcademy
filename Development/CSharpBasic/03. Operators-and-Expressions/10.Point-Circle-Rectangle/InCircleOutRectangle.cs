namespace _10.Point_Circle_Rectangle
{
    using System;
    using System.Globalization;
    using System.Threading;

    /// <summary>
    /// Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y) 
    /// if it is within the circle  K({1, 1}, 1.5)  and out of the rectangle  R(top=1, left=-1, width=6, height=2) .
    /// </summary>
    public class InCircleOutRectangle
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());

            // check circle
            double circleX = 1;
            double circleY = 1;
            double radius = 1.5;

            double a = pointX - circleX;
            double b = pointY - circleY;
            double pointsDistance = Math.Sqrt((a * a) + (b * b));
            string pointPositionInCircleAsString = string.Empty;
            if (pointsDistance > radius)
            {
                pointPositionInCircleAsString = "outside circle";
            }
            else
            {
                pointPositionInCircleAsString = "inside circle";
            }

            // check rectangle
            //R(top = 1, left = -1, width = 6, height = 2)
            double rectXMin = -1;
            double rectXMax = rectXMin + 6;
            double rectYMax = 1;
            double rectYMin = rectYMax - 2;
            bool checkX = rectXMin <= pointX && pointX <= rectXMax;
            bool checkY = rectYMin <= pointY && pointY <= rectYMax;
            string pointPositionInRectangeAsString = string.Empty;
            if (checkX && checkY)
            {
                pointPositionInRectangeAsString = "inside rectangle";
            }
            else
            {
                pointPositionInRectangeAsString = "outside rectangle";
            }
            Console.WriteLine("{0} {1}", pointPositionInCircleAsString, pointPositionInRectangeAsString);
        }
    }
}