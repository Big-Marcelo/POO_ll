public class DivisaoPorZeroException : Exception
{
    public DivisaoPorZeroException() : base("O divisor não pode ser zero.")
    {
    }

    public DivisaoPorZeroException(string message) : base(message)
    {
    }

    public DivisaoPorZeroException(string message, Exception inner) : base(message, inner)
    {
    }
}