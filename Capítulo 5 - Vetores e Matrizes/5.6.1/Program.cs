int[] vetor = new int[5]{ 55, 19, 32, 28, 1 }; 
int tamanho = vetor.Length;
for (int i = 0; i < tamanho - 1; i++)
{
    int indiceMinimo = i;
  for (int j = i + 1; j < tamanho; j++)
    {
        if (vetor[j] < vetor[indiceMinimo])
        { 
            indiceMinimo = j;
        }
    }
    int temp = vetor[i];
    vetor[i] = vetor[indiceMinimo];
    vetor[indiceMinimo] = temp;
}
foreach (var item in vetor)
{
    Console.WriteLine(item);
}
