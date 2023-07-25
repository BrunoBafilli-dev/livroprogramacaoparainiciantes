int numero = 1;
while (numero <= 10)
{
    Console.WriteLine("Número: " + numero);
    if (numero == 5)
    {
        Console.WriteLine("Número 5 encontrado. Saindo do loop.");
        break;
    }
    numero++;
}
Console.WriteLine("Loop concluído.");
