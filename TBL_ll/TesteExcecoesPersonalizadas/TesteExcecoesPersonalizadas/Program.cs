Console.WriteLine("--- Teste de Cadastro ---");

Pessoa pessoa1 = new Pessoa();

try
{
    Console.WriteLine("Tentando cadastrar pessoa com idade inválida (150)...");

    pessoa1.Cadastrar("Maria", 150);
}
catch (IdadeInvalidaException ex)
{
    Console.WriteLine("\nOcorreu um erro!");
    Console.WriteLine($"Mensagem da exceção: {ex.Message}");
}
finally
{
    Console.WriteLine("\n--- Fim do Teste ---");
}

Console.ReadKey();