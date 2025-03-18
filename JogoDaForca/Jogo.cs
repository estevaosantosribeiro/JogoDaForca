namespace JogoDaForca
{
    public static class Jogo
    {
        public static void ExibirBoneco(int quantidadeErros, char[] letrasEncontradas)
        {
            string cabecaDoBoneco = quantidadeErros >= 1 ? " o " : " ";
            string tronco = quantidadeErros >= 2 ? "x" : " ";
            string troncoBaixo = quantidadeErros >= 2 ? " x " : " ";
            string bracoEsquerdo = quantidadeErros >= 3 ? "/" : " ";
            string bracoDireito = quantidadeErros >= 4 ? @"\" : " ";
            string pernas = quantidadeErros >= 5 ? "/ \\" : " ";

            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
            Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
            Console.WriteLine(" |        {0}       ", troncoBaixo);
            Console.WriteLine(" |        {0}       ", pernas);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Erros do jogador: " + quantidadeErros);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Palavra escolhida: " + String.Join("", letrasEncontradas));
            Console.WriteLine("----------------------------------------------");
        }

        public static void ExibirVitoria(string palavraEscolhida)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Você acertou a palavra secreta {palavraEscolhida}, parabéns!");
            Console.WriteLine("----------------------------------------------");
        }

        public static void ExibirDerrota()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Que azar! Tente novamente!");
            Console.WriteLine("----------------------------------------------");
        }

        public static char FazerChute()
        {
            Console.Write("Digite uma letra: ");
            char chute = Console.ReadLine()!.ToUpper()[0];
            return chute;
        }
    }
}
