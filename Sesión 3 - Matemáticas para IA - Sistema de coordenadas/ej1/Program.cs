using System.Linq.Expressions;
namespace PuntoMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Punto medio 2D
            var punto1 = new Punto2D(1, 2);
            var punto2 = new Punto2D(3, 4);
            var puntoMedio2D = punto1.PuntoMedio(punto2);
            System.Console.WriteLine($"Punto medio 2D: {puntoMedio2D}");

            // Punto medio 3D
            var punto3 = new Punto3D(1, 2, 3);
            var punto4 = new Punto3D(4, 5, 6);
            var puntoMedio3D = punto3.PuntoMedio(punto4);
            System.Console.WriteLine($"Punto medio 3D: {puntoMedio3D}");
        }
    }

    public class Punto2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Punto2D PuntoMedio(Punto2D punto)
        {
            var x = (X + punto.X) / 2;
            var y = (Y + punto.Y) / 2;
            return new Punto2D(x, y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public class Punto3D : Punto2D
    {
        public double Z { get; set; }

        public Punto3D(double x, double y, double z) : base(x, y)
        {
            Z = z;
        }

        public Punto3D PuntoMedio(Punto3D punto)
        {
            var x = (X + punto.X) / 2;
            var y = (Y + punto.Y) / 2;
            var z = (Z + punto.Z) / 2;
            return new Punto3D(x, y, z);
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
