// Exibe a mensagem "Digite 3 palavras" para solicitar ao usuário que insira três palavras
Console.WriteLine("Digite 3 palavras");

// Solicitar ao usuário que insira a primeira palavra e armazenar na variável palavra1
string palavra1 = Console.ReadLine();

// Solicitar ao usuário que insira a segunda palavra e armazenar na variável palavra2
Console.WriteLine("Digite a segunda palavra:");
string palavra2 = Console.ReadLine();

// Solicitar ao usuário que insira a terceira palavra e armazenar na variável palavra3
Console.WriteLine("Digite a terceira palavra:");
string palavra3 = Console.ReadLine();

// Concatenar as três palavras em uma única string, separando-as com um espaço
string resultado = palavra1 + " " + palavra2 + " " + palavra3;

// Exibir a string resultante na tela, mostrando as palavras concatenadas
Console.WriteLine("Palavras concatenadas: " + resultado);
