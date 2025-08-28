using System.Linq;

namespace BibliotecaEstatistica
{
    public class Calculos
    {
        public double CalcularMedia(double[] numeros)
        {
            if (numeros == null || numeros.Length == 0)
                return 0;
            return numeros.Average();
        }

        public double CalcularSoma(double[] numeros)
        {
            if (numeros == null)
                return 0;
            return numeros.Sum();
        }
    }
}