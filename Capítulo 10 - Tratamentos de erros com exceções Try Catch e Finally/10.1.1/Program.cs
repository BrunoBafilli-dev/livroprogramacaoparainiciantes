try
{
    int divisor = 0;
    int resultado = 10 / divisor; // Gera uma exceção de divisão por zero
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Ocorreu um erro de divisão por zero: " + ex.Message);
}
finally
{
    Console.WriteLine("Este bloco será sempre executado, independentemente de ocorrer uma exceção ou não.");
}
