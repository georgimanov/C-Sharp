namespace _3DPoint
{
    using System;

    public class DistanceCalculator
    {
        public static double Calculate(Point3D p1, Point3D p2)
        {
            double result = Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2) + Math.Pow((p1.Z - p2.Z), 2));

            return result;
        }
    }
}
