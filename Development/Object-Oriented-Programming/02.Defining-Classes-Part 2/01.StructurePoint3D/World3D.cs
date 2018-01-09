namespace StructurePoint3D
{
    using StructurePoint3D;
    using System;

    public class World3D
    {
        static void Main(string[] args)
        {
            var point = new Point3D(1F, 2F, 3.5F);
            Console.WriteLine(point.ToString());
            Console.WriteLine(Point3D.Zero);
        }
    } 
}
