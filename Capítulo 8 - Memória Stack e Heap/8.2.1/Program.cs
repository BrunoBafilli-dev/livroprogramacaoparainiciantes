// Alocação de vetores na heap
int[] array = new int[5];
string[] nomes = new string[3];
// Uso dos vetores alocados na heap
array[0] = 42;
nomes[0] = "João";
nomes[1] = "Maria";
// Impressão dos valores
Console.WriteLine(array[0]);
Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
// Liberação de memória
array = null;
nomes = null;
