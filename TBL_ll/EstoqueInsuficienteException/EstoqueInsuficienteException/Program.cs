Console.WriteLine("--- Teste de Controle de Estoque ---");

Produto caneta = new Produto("Caneta Azul", 10);
Console.WriteLine($"Produto '{caneta.Nome}' criado com {caneta.QuantidadeEmEstoque} unidades.");

try
{
    caneta.RetirarDoEstoque(4);

    caneta.RetirarDoEstoque(8);
}
catch (EstoqueInsuficienteException ex)
{
    Console.WriteLine("\nOcorreu um erro de operação!");
    Console.WriteLine($"Mensagem: {ex.Message}");
}
finally
{
    Console.WriteLine($"\nOperação finalizada. Estoque final: {caneta.QuantidadeEmEstoque}");
}

Console.ReadKey();