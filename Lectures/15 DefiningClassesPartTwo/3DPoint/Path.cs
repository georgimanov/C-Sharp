namespace _3DPoint
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public int Count
        {
            get
            {
                return this.points.Count;
            }
        }

        public Point3D this[int index]
        {
            get
            {
                return this.points[index];
            }
            set
            {
                this.points[index] = value;
            }
        }

        public void AddPoint(Point3D point3D)
        {
            this.points.Add(point3D);
        }

        public void AddPoints(params Point3D[] point3D)
        {
            this.points.AddRange(point3D);
        }

        public void AddPoints(ICollection<Point3D> point3D)
        {
            this.points.AddRange(point3D);
        }

        public override string ToString()
        {
            return String.Join("\n", this.points);
        }
    }
}
