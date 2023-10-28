using System.Linq.Expressions;
namespace Distancia
// Programa en C# las fórmulas para calcular la distancia entre dos puntos 2D y 3D y haz ejemplos.
{
    class Program
    {
        static void Main(string[] args)
        {
            // Distancia 2D
            Punto2D punto1 = new Punto2D(1, 2);
            Punto2D punto2 = new Punto2D(3, 4);
            double distancia2D = punto1.Distancia(punto2);
            System.Console.WriteLine($"Distancia 2D: {distancia2D}");

            // Distancia 3D
            Punto3D punto3 = new Punto3D(1, 2, 3);
            Punto3D punto4 = new Punto3D(4, 5, 6);
            double distancia3D = punto3.Distancia(punto4);
            System.Console.WriteLine($"Distancia 3D: {distancia3D}");
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

        public double Distancia(Punto2D punto)
        {
            var distancia = System.Math.Sqrt(System.Math.Pow(X - punto.X, 2) + System.Math.Pow(Y - punto.Y, 2));
            return distancia;
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

        public double Distancia(Punto3D punto)
        {
            var distancia = System.Math.Sqrt(System.Math.Pow(X - punto.X, 2) + System.Math.Pow(Y - punto.Y, 2) + System.Math.Pow(Z - punto.Z, 2));
            return distancia;
        }
    }
}