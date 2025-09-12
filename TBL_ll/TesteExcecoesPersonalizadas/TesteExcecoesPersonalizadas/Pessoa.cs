public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Cadastrar(string nome, int idade)
    {
        this.Nome = nome;

        if (idade < 0 || idade > 120)
        {
            throw new IdadeInvalidaException(idade);
        }

        this.Idade = idade;
        Console.WriteLine("Pessoa cadastrada com sucesso!");
    }
}