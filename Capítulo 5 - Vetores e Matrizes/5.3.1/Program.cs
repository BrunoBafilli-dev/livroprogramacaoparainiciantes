int[] vetorOriginal = { 1, 2, 3, 4, 5 };
int[] vetorCopia = vetorOriginal;
vetorCopia[0] = 10;

Console.Write("Vetor Original: ");
for (int i = 0; i < vetorOriginal.Length; i++)
{
    Console.Write(vetorOriginal[i]+",");
}
Console.WriteLine();
Console.Write("Vetor Cópia: ");
for (int i = 0; i < vetorCopia.Length; i++)
{
    Console.Write(vetorCopia[i]+",");
}
