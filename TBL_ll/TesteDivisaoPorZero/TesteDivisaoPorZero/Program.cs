Console.WriteLine("--- Teste de Divisão ---");

try
{
    Console.WriteLine("Tentando dividir 10 por 0...");
    Calculadora.Dividir(10, 0);
}
catch (DivisaoPorZeroException ex)
{
    Console.WriteLine("\nOcorreu um erro!");
    Console.WriteLine($"Mensagem da exceção: {ex.Message}");
}
finally
{
    Console.WriteLine("\n--- Fim do Teste ---");
}

Console.ReadKey();