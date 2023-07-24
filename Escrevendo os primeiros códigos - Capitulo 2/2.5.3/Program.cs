// Solicita ao usuário para digitar dois números
Console.WriteLine("Digite o primeiro número:");
string input1 = Console.ReadLine();
double numero1 = Convert.ToDouble(input1);
Console.WriteLine("Digite o segundo número:");
string input2 = Console.ReadLine();
double numero2 = Convert.ToDouble(input2);
// Calcula a soma dos dois números
double soma = numero1 + numero2;
// Exibe o resultado
Console.WriteLine("A soma dos números é: " + soma);
