public class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException() : base("A idade fornecida é inválida.")
    {
    }

    public IdadeInvalidaException(string message) : base(message)
    {
    }

    public IdadeInvalidaException(string message, Exception inner) : base(message, inner)
    {
    }

    public IdadeInvalidaException(int idade)
        : base($"O valor '{idade}' não é uma idade válida. A idade deve estar entre 0 e 120 anos.")
    {
    }
}