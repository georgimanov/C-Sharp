namespace _3DPoint
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void Save(Path path, string pathName)
        {

            string fullPath = GenerateFullPath(pathName);
            using (var writer = new StreamWriter(fullPath))
            {
                writer.Write(path);
            }
        }

        public static Path Load(string pathName)
        {
            Path path = new Path();
            string fullPath = GenerateFullPath(pathName);

            try
            {
                using (var reader = new StreamReader(fullPath))
                {
                    string[] points = reader.ReadToEnd()
                        .Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var point in points)
                    {
                        double[] coordinates = point.Trim('[').Trim(']')
                            .Split(new[] { ' ', ';', 'X', 'Y', 'Z', ':' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => double.Parse(x))
                            .ToArray();

                        path.AddPoint(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The path \"{0}\" couldn't be found", pathName);
                return null;
            }

            return path;
        }

        private static string GenerateFullPath(string filename)
        {
            return @"..\..\" + filename.Trim() + ".txt";
        }
    }
}
