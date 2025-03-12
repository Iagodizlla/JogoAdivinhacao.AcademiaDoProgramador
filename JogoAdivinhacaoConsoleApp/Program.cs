using System.Security.Principal;

namespace JogoAdivinhacaoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Gerar um numero aleatorio
            Random r = new Random();
            int ns = r.Next(1, 20), t = 0, tm = 0;

            //Pergunta quantas tentativas o usuario deseja
            Console.WriteLine("Qual dificuldade voce deseja? ");
            Console.WriteLine("_________________________");
            Console.WriteLine("1 - Facil (10 tentativas)");
            Console.WriteLine("2 - Medio (5 tentativas)");
            Console.WriteLine("3 - Dificil (3 tentativas)");
            Console.WriteLine("-------------------------");
            int di = int.Parse(Console.ReadLine());

            switch (di)
            {
                case 1: tm = 10; break;
                case 2: tm = 5; break;
                default: tm = 3; break;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("__________________");
                Console.WriteLine("Jogo de Adivinacao");
                Console.WriteLine("------------------\n");

               
                Console.WriteLine("Digite um numero entre 1 e 20");
                int n1 = int.Parse(Console.ReadLine());
                t++;

                //Verifica se acertou
                if (n1 == ns)
                {
                    Console.WriteLine("Parabens, voce acertou!");
                    Console.ReadLine();
                    break;
                }
                else if(n1 < 1 || n1 > 20)
                {
                    Console.WriteLine("Numero invalido! Digite um numero entre 1 e 20");
                    t--;
                }
                else if (n1 > ns)
                {
                    Console.WriteLine($"O numero digitado e maior que o numero sorteado|Tentativa {t} de {tm}");
                }
                else
                {
                    Console.WriteLine($"O numero digitado e menor que o numero sorteado|Tentativa {t} de {tm}");
                }

                //Verefica se o usuario ainda tem tentativas
                if (t > tm)
                {
                    Console.WriteLine("Voce perdeu! O numero sorteado era: " + ns);
                    Console.ReadLine();
                    break;
                }

                //Pergunta se deseja continuar
                Console.Write("Deseja continuar? (S/N) ");
                string c = Console.ReadLine().ToUpper();

                if (c == "N")
                {
                    break;
                }
                else if (c != "S")
                {
                    while (true)
                    {
                        Console.WriteLine("Opcao invalida!");
                        Console.Write("Deseja continuar? (S/N) ");
                        c = Console.ReadLine().ToUpper();
                        if (c == "S" || c == "N")
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
