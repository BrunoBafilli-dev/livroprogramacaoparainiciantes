int[] vetorOriginal = { 1, 2, 3 };
int novoTamanho = 5;
int[] novoVetor = new int[novoTamanho];
for (int i = 0; i < vetorOriginal.Length; i++)
{
    novoVetor[i] = vetorOriginal[i];
}
vetorOriginal = novoVetor;
Console.WriteLine(vetorOriginal.Length);
