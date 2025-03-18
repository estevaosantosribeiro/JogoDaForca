namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = {
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

            Random random = new Random();

            int indiceEscolhido = random.Next(palavras.Length);

            string palavraEscolhida = palavras[indiceEscolhido];

            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                letrasEncontradas[caractere] = '_';

            int quantidadeErros = 0;
            bool jogadorEnforcou = false;
            bool jogadorAcertou = false;

            do
            {
                Jogo.ExibirBoneco(quantidadeErros, letrasEncontradas);

                char chute = Jogo.FazerChute();

                bool letraFoiEncontrada = VerificarChute(palavraEscolhida, chute, letrasEncontradas);

                if (letraFoiEncontrada == false)
                    quantidadeErros++;

                string palavraEncontrada = String.Join("", letrasEncontradas);

                jogadorAcertou = palavraEncontrada == palavraEscolhida;
                jogadorEnforcou = quantidadeErros > 5;

                if (jogadorAcertou)
                {
                    Jogo.ExibirVitoria(palavraEscolhida);
                }
                else if (jogadorEnforcou)
                {
                    Jogo.ExibirDerrota();
                }

                Console.ReadLine();

            } while (jogadorEnforcou == false && jogadorAcertou == false);
        }

        static bool VerificarChute(string palavraEscolhida, char chute, char[] letrasEncontradas)
        {
            bool letraFoiEncontrada = false;

            for (int contador = 0; contador < palavraEscolhida.Length; contador++)
            {
                char letraAtual = palavraEscolhida[contador];

                if (chute == letraAtual)
                {
                    letrasEncontradas[contador] = letraAtual;
                    letraFoiEncontrada = true;
                }
            }

            return letraFoiEncontrada;
        }
    }
}