int[] vetor = new int[5]{ 55, 19, 32, 28, 1 }; 
int tamanho = vetor.Length;
for (int i = 1; i < tamanho; i++)
{
    int valorAtual = vetor[i];
    int j = i - 1;
    while (j >= 0 && vetor[j] > valorAtual)
    {
        vetor[j + 1] = vetor[j];
        j--;
    }
    vetor[j + 1] = valorAtual;
}
foreach (var item in vetor)
{
    Console.WriteLine(item);
}
