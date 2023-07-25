List<string> frutas = new List<string>() { "Maçã", "Banana", "Laranja", "Maçã" };
string primeiraMaca = frutas.FirstOrDefault(x => x == "Maçã");
string ultimaMaca = frutas.LastOrDefault(x => x == "Maçã");
string primeiraUva = frutas.FirstOrDefault(x => x == "Uva");
Console.WriteLine("Primeira Maçã: " + primeiraMaca);
Console.WriteLine("Última Maçã: " + ultimaMaca);
Console.WriteLine("Primeira Uva: " + primeiraUva);
