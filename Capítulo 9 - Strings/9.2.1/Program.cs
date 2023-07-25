char[] palavra = new char[] { 'H', 'e', 'l', 'l', 'o' };
string novaPalavra = "";
for(int i = 0; i < palavra.Length; i++){
    novaPalavra += palavra[i];
}
for(int i = 0; i < palavra.Length; i++){
    Console.Write(novaPalavra[i]);
}
