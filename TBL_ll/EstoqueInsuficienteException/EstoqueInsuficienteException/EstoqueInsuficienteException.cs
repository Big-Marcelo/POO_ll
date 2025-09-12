public class EstoqueInsuficienteException : Exception
{
    public EstoqueInsuficienteException()
    {
    }

    public EstoqueInsuficienteException(string message) : base(message)
    {
    }

    public EstoqueInsuficienteException(string message, Exception inner) : base(message, inner)
    {
    }

    public EstoqueInsuficienteException(int quantidadeRetirada, int quantidadeEmEstoque)
        : base($"Não é possível retirar {quantidadeRetirada} unidades. Apenas {quantidadeEmEstoque} estão disponíveis no estoque.")
    {
    }
}