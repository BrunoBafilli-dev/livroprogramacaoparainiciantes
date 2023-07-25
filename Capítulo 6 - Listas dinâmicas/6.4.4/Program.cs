List<int> numeros = new List<int>() { 10, 20, 30, 40, 50 };
List<int> maioresQueVinte = numeros.FindAll(x => x > 20);
foreach (int numero in maioresQueVinte)
{
    Console.WriteLine(numero);
}
