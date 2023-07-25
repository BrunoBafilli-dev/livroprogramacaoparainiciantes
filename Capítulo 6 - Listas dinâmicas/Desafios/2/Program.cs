// Criar a lista "minhaLista"
List<int> minhaLista = new List<int>();

// Adicionar os números de 1 a 5 à lista
for (int i = 1; i <= 5; i++)
{
    minhaLista.Add(i);
}

// Imprimir a lista
Console.WriteLine("Elementos da lista:");
foreach (int numero in minhaLista)
{
    Console.WriteLine(numero);
}