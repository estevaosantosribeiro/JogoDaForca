namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogo.SortearPalavra();

            char[] letrasEncontradas = Jogo.ExibirLetrasOcultas();

            bool jogadorEnforcou = false;
            bool jogadorAcertou = false;

            do
            {
                Jogo.ExibirBoneco(letrasEncontradas);

                char chute = Jogo.FazerChute();

                bool letraFoiEncontrada = Jogo.VerificarChute(chute, letrasEncontradas);

                if (letraFoiEncontrada == false)
                    Jogo.quantidadeErros++;

                string palavraEncontrada = String.Join("", letrasEncontradas);

                jogadorEnforcou = Jogo.quantidadeErros > 5;

                if (Jogo.JogadorAcertou(palavraEncontrada))
                {
                    Jogo.ExibirVitoria();
                }
                else if (jogadorEnforcou)
                {
                    Jogo.ExibirDerrota();
                }

                Console.ReadLine();

            } while (jogadorEnforcou == false && jogadorAcertou == false);
        }
    }
}