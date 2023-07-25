List<string> nomes = new List<string>() { "João", "Maria", "Carlos" };
nomes.RemoveAt(1);
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
