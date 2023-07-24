int[] vetor = { 10, 20, 30, 40, 50 };
int itemProcurado = 30;
int indice = -1;
for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] == itemProcurado)
    {
        indice = i;        
        break;    
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
