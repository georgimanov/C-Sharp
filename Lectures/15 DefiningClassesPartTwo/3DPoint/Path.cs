namespace _3DPoint
{
    using System.Collections.Generic;

    public class Path
    {
        ICollection<Point3D> SequenceOfPoints { get; set; }

        public Path()
        {
            this.SequenceOfPoints = new HashSet<Point3D>();
        }

        public ICollection<Point3D> GetPath()
        {
            if (this.SequenceOfPoints != null)
            {
                return this.SequenceOfPoints;
            }
            else
            {
                this.SequenceOfPoints = new HashSet<Point3D>();

                return this.SequenceOfPoints;
            }

        }
    }
}
