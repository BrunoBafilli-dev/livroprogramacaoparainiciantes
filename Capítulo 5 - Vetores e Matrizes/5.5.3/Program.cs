int[] vetorOriginal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int novoTamanho = 5;
Array.Resize(ref vetorOriginal, novoTamanho);
foreach (var item in vetorOriginal)
{
    Console.WriteLine(item);
}
