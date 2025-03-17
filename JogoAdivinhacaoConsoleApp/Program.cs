using System.Security.Principal;

namespace JogoAdivinhacaoConsoleApp
{
    internal class Program
    {
        static int t = 0;
        static void Main(string[] args)
        {

            //Gerar um numero aleatorio
            int tm1 = 0, ns = GerarNumeroAleatorio();

            //Pergunta quantas tentativas o usuario deseja
            int tm = EscolhaDificuldade(tm1);

            while (true)
            {
                Cabecalho();

                //Verifica se acertou
                ns = VerificaRespostaUsuario(ns, tm);

                //Verefica se o usuario ainda tem tentativas
                if (t > tm)
                {
                    ns = UsuarioPerdeu(ns);
                }

                //Pergunta se deseja continuar
                string c = UsuarioContinuar();


                if (c != "S" && c != "N")
                {
                    c = OpcaoInvalida(c);
                }
                else if (c == "N")
                {
                    break;
                }
            }
        }
        static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("__________________");
            Console.WriteLine("Jogo de Adivinacao");
            Console.WriteLine("------------------\n");
        }
        static int EscolhaDificuldade(int tm)
        {
            int di = 0;
            Console.WriteLine("Qual dificuldade voce deseja? ");
            Console.WriteLine("_________________________");
            Console.WriteLine("1 - Facil (10 tentativas)");
            Console.WriteLine("2 - Medio (5 tentativas)");
            Console.WriteLine("3 - Dificil (3 tentativas)");
            Console.WriteLine("-------------------------");

            di = int.Parse(Console.ReadLine()!);

            switch (di)
            {
                case 1: tm = 10; break;
                case 2: tm = 5; break;
                default: tm = 3; break;
            }
            return tm;
        }
        static int VerificaRespostaUsuario(int ns, int tm)
        {
            Console.WriteLine("Digite um numero entre 1 e 20");
            int n1 = int.Parse(Console.ReadLine()!);
            t++;

            if (n1 == ns)
            {
                Console.WriteLine("Parabens, voce acertou!");
                t = 0;
                ns = GerarNumeroAleatorio();
                Console.ReadLine();
            }
            else if (n1 < 1 || n1 > 20)
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
            return ns;
        }
        static int GerarNumeroAleatorio()
        {
            Random r = new Random();
            return r.Next(1, 20);
        }
        static int UsuarioPerdeu(int ns1)
        {
            Console.WriteLine("Voce perdeu! O numero sorteado era: " + ns1);
            Console.ReadLine();
            int ns = GerarNumeroAleatorio();
            t = 0;
            return ns;
        }
        static string UsuarioContinuar()
        {
            Console.Write("Deseja continuar? (S/N) ");
            string c = Console.ReadLine()!.ToUpper();
            return c;
        }
        static string OpcaoInvalida(string c)
        {
            while (true)
            {
                Console.WriteLine("Opcao invalida!");
                c = UsuarioContinuar();
                if (c == "S" || c == "N")
                {
                    break;
                }
            }
            return c;
        }
    }
}