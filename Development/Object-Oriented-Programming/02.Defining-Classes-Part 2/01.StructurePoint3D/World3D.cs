namespace StructurePoint3D
{
    using StructurePoint3D;
    using System;

    public class World3D
    {
        private const string fileName = "result.txt";

        static void Main(string[] args)
        {
            var point = new Point3D(1F, 2F, 3.5F);
            Console.WriteLine(point.ToString());
            Console.WriteLine(Point3D.Zero);

            Path path = new Path();
            path.Add(new Point3D(1F, 2F, 3F));
            path.Add(new Point3D(3F, 1F, -0.5F));
            path.Add(new Point3D(0.2F, 0.1F, 0.3F));
            path.Add(new Point3D(1F, 2F, 3.5F));
            path.Add(new Point3D(2F, 5F, 10F));
            PathStorage.Save(path, fileName);
            var newPath = PathStorage.Load(fileName);
            foreach (var p in newPath.Points)
            {
                Console.WriteLine(p.ToString());
            }
        }
    } 
}
