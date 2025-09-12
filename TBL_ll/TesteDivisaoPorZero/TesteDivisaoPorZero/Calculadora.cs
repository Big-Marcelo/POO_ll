public class Calculadora
{
    public static double Dividir(double dividendo, double divisor)
    {
        if (divisor == 0)
        {
            throw new DivisaoPorZeroException();
        }

        double resultado = dividendo / divisor;
        Console.WriteLine($"Resultado da divisão: {resultado}");
        return resultado;
    }
}