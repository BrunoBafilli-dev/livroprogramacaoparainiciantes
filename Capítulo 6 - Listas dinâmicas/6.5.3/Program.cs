List<int> numeros = new List<int>() { 10, 20, 30, 40, 50 };
numeros.RemoveAll(x => x > 30);
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
