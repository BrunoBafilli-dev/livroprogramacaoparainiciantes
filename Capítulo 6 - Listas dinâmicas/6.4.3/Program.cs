List<int> numeros = new List<int>() { 10, 20, 30, 40, 50 };
int primeiroMaiorQueTrinta = numeros.Find(x => x > 30);
Console.WriteLine("Primeiro número maior que 30: " + primeiroMaiorQueTrinta);
