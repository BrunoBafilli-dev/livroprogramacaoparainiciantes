//1 - Crie uma função chamada "calcularAreaRetangulo" que recebe dois parâmetros: largura e altura. 
//A função deve calcular e retornar a área do retângulo. 
//Em seguida, chame a função com valores diferentes para largura e altura e imprima o resultado.

/**************************Solução abaixo*********************************/

// Chamar a função calcularAreaRetangulo com valores diferentes para largura e altura
double largura1 = 5.2;
double altura1 = 3.8;
double area1 = calcularAreaRetangulo(largura1, altura1);

double largura2 = 8.7;
double altura2 = 2.5;
double area2 = calcularAreaRetangulo(largura2, altura2);

// Imprimir os resultados
Console.WriteLine($"Área do retângulo com largura {largura1} e altura {altura1}: {area1}");
Console.WriteLine($"Área do retângulo com largura {largura2} e altura {altura2}: {area2}");

// Função para calcular a área do retângulo
static double calcularAreaRetangulo(double largura, double altura)
{
    // Calcula a área do retângulo multiplicando a largura pela altura
    double area = largura * altura;

    // Retorna o resultado da área calculada
    return area;
}