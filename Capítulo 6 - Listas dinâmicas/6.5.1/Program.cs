List<int> numeros = new List<int>() { 10, 20, 30, 40, 50 };
numeros.Remove(30);
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
