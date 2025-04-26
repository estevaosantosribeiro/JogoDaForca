namespace JogoDaForca
{
    public static class Jogo
    {
        private static string[] palavras = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };
        private static string palavraSorteada = "";
        public static int quantidadeErros;

        public static char[] ExibirLetrasOcultas()
        {
            char[] letrasEncontradas = new char[palavraSorteada.Length];

            for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                letrasEncontradas[caractere] = '_';
            return letrasEncontradas;
        }

        public static bool VerificarChute(char chute, char[] letrasEncontradas)
        {
            bool letraFoiEncontrada = false;

            for (int contador = 0; contador < palavraSorteada?.Length; contador++)
            {
                char letraAtual = palavraSorteada[contador];

                if (chute == letraAtual)
                {
                    letrasEncontradas[contador] = letraAtual;
                    letraFoiEncontrada = true;
                }
            }

            return letraFoiEncontrada;
        }

        public static void SortearPalavra()
        {
            Random random = new();

            int indiceEscolhido = random.Next(palavras.Length);

            palavraSorteada = palavras[indiceEscolhido];
        }

        public static bool JogadorAcertou(string palavraEncontrada)
        {
            return palavraSorteada == palavraEncontrada;
        }

        public static void ExibirBoneco(char[] letrasEncontradas)
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

        public static void ExibirVitoria()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Você acertou a palavra secreta {palavraSorteada}, parabéns!");
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
