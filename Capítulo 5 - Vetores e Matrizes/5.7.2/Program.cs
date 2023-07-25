int[] vetor = { 10, 20, 30, 40, 50 };
int itemProcurado = 30;
int indice = -1;
int inicio = 0;
int fim = vetor.Length - 1;
while (inicio <= fim)
{
    int meio = (inicio + fim) / 2;
    if (vetor[meio] == itemProcurado)
    {
        indice = meio;
        break;
    }
    else if (vetor[meio] < itemProcurado)
    {
        inicio = meio + 1;
    }
    else
    {
        fim = meio - 1;
    }
}
if (indice != -1)
{
    Console.WriteLine($"O item {itemProcurado} foi encontrado no índice {indice}.");
}
else
{
    Console.WriteLine($"O item {itemProcurado} não foi encontrado no vetor.");
}
