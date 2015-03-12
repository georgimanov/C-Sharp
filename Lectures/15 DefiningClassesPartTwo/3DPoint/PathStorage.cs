namespace _3DPoint
{
    using System;
    using System.IO;

    public static class PathStorage
    {
        public static void Save()
        {
            Path path = new Path();
            var sequence = path.GetType();

            using (var writer = new StreamWriter(Constants.pathFile)) 
            {
                
            }
        }

        public static void Print()
        {
            using(var reader = new StreamReader(Constants.pathFile))
            {

            }
            
        }
    }
}
