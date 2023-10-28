using System.Linq.Expressions;
namespace Pitagoras
// 2.Programa en C# los dos ejercicios de este vídeo sobre el teorema de Pitágoras (fórmula).
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular hipotenusa
            double cateto1 = 3;
            double cateto2 = 4;
            double hipotenusa = Pitagoras.CalcularHipotenusa(cateto1, cateto2);
            System.Console.WriteLine($"Hipotenusa: {hipotenusa}");

            // Calcular cateto
            double cateto3 = 3;
            double hipotenusa2 = 5;
            double cateto4 = Pitagoras.CalcularCateto(cateto3, hipotenusa2);
            System.Console.WriteLine($"Cateto: {cateto4}");
        }
    }

    public static class Pitagoras
    {
        public static double CalcularHipotenusa(double cateto1, double cateto2)
        {
            var hipotenusa = System.Math.Sqrt(System.Math.Pow(cateto1, 2) + System.Math.Pow(cateto2, 2));
            return hipotenusa;
        }

        public static double CalcularCateto(double cateto, double hipotenusa)
        {
            var cateto2 = System.Math.Sqrt(System.Math.Pow(hipotenusa, 2) - System.Math.Pow(cateto, 2));
            return cateto2;
        }
    }
}