namespace _3DPoint
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Point3D pointOne = new Point3D(10, 15, 20);
            Point3D pointTwo = new Point3D(1, 2, 3);
            Console.WriteLine("Point 1 " + pointOne);
            Console.WriteLine("Point 2 " + pointTwo);
            Console.WriteLine("Point zero " + Point3D.PointZero);

            var distance = DistanceCalculator.Calculate(pointOne, pointTwo);

            Console.WriteLine("Distance between {0} and {1} is {2:F2}", pointOne, pointTwo, distance);

            string fileName = "StorageTest";

            Path path = new Path();
            path.AddPoints(pointOne, pointTwo);
            PathStorage.Save(path, fileName);
            PathStorage.Load(fileName);
            Console.WriteLine(path);
            Console.WriteLine(PathStorage.Load("test"));
        }
    }
}
