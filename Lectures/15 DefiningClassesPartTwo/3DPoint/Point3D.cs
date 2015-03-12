namespace _3DPoint
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D pointZero;

        public double X { get; set; }
        
        public double Y { get; set; }
        
        public double Z { get; set; }

        public static Point3D PointZero
        {
            get
            {
                return pointZero;
            }
        }

        public Point3D(double x, double y, double z)
            :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        static Point3D()
        {
            pointZero = new Point3D(0, 0, 0);
        }

        public override string ToString()
        {
            return String.Format("[X:{0}; Y:{1}; Z:{2}]", this.X, this.Y, this.Z);
        }
    }
}
