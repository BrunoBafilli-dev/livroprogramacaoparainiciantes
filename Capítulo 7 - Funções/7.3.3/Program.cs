int resultado = SomarNovamente(Soma(5, 3), 2);
Console.WriteLine(resultado);
int Soma(int a, int b)
{
    int resultado = a + b;
    return resultado;
}
int SomarNovamente(int resultadoPrimeiraSoma, int multiplicar){
    int resultado = resultadoPrimeiraSoma * multiplicar;
    return resultado;
}
