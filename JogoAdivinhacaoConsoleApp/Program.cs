using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace JogoAdivinhacaoConsoleApp
{
    internal class Program
    {
        static int t = 1;
        static void Main(string[] args)
        {

            //Gerar um numero aleatorio
            int tm1 = 0, ns = JogoAdivinhacao.GerarNumeroAleatorio();

            //Pergunta quantas tentativas o usuario deseja
            int tm = EscolhaDificuldade(tm1);

            while (true)
            {
                Cabecalho();

                Console.WriteLine("Digite um numero entre 1 e 20");
                int n1 = int.Parse(Console.ReadLine()!);

                ns = JogoAdivinhacao.VerificarRespostaUsuario(n1, ns, tm, t);

                (t, ns) = JogoAdivinhacao.GerenciarTentativas(t, n1, ns, tm);

                //Verifica se acertou
                if (n1 == ns)
                {
                    ns = JogoAdivinhacao.GerarNumeroAleatorio();
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