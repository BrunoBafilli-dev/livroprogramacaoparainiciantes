List<string> frutas = new List<string>() { "Maçã", "Banana", "Laranja", "Morango" };
frutas.Remove("Laranja");
for (int i = 0; i < frutas.Count; i++)
{
    Console.WriteLine("Índice " + i + ": " + frutas[i]);
}
