public class Produto
{
    public string Nome { get; set; }
    public int QuantidadeEmEstoque { get; private set; }

    public Produto(string nome, int quantidadeInicial)
    {
        Nome = nome;
        QuantidadeEmEstoque = quantidadeInicial;
    }

    public void RetirarDoEstoque(int quantidade)
    {
        Console.WriteLine($"\nTentando retirar {quantidade} unidades...");
        if (quantidade > QuantidadeEmEstoque)
        {
            throw new EstoqueInsuficienteException(quantidade, QuantidadeEmEstoque);
        }

        QuantidadeEmEstoque -= quantidade;
        Console.WriteLine($"Retirada bem-sucedida. Estoque atual: {QuantidadeEmEstoque}");
    }
}