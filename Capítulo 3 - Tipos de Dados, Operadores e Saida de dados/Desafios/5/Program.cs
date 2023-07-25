//5 - Você recebeu a idade e a altura de uma pessoa e precisa realizar algumas verificações utilizando operadores lógicos.
//A. Verifique se a idade é maior ou igual a 18 anos e a altura é maior ou igual a 1.60 metros. Armazene o resultado em uma variável booleana.
//B. Verifique se a idade é menor que 12 anos ou a altura é menor que 1.40 metros. Armazene o resultado em uma segunda variável booleana.

/**************************Solução abaixo*********************************/

// Recebendo a idade da pessoa
Console.Write("Digite a idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

// Recebendo a altura da pessoa
Console.Write("Digite a altura (em metros): ");
double altura = double.Parse(Console.ReadLine());

// A. Verifique se a idade é maior ou igual a 18 anos e a altura é maior ou igual a 1.60 metros.
bool maiorDeIdadeEAlto = idade >= 18 && altura >= 1.60;

// B. Verifique se a idade é menor que 12 anos ou a altura é menor que 1.40 metros.
bool menorDe12AnosOuBaixo = idade < 12 || altura < 1.40;

// Exibindo os resultados das verificações
Console.WriteLine("Resultado A (Maior de idade e alto): " + maiorDeIdadeEAlto);
Console.WriteLine("Resultado B (Menor de 12 anos ou baixo): " + menorDe12AnosOuBaixo);