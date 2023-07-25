void ImprimirInformacoes(string nome, int idade, string cidade = "São paulo")
{
    Console.WriteLine($"Nome: {nome}, Idade: {idade}, Cidade: {cidade}");
}
ImprimirInformacoes(idade: 30, nome: "João");
