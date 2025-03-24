using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdivinhacaoConsoleApp
{
    public static class JogoAdivinhacao
    {
        public static int GerarNumeroAleatorio()
        {
            Random r = new Random();
            return r.Next(1, 20);
        }
        public static int VerificarRespostaUsuario(int n1, int ns, int tm, int t)
        {
            if (n1 == ns)
            {
                Console.WriteLine("Parabens, voce acertou!");
            }
            else if (n1 < 1 || n1 > 20)
            {
                Console.WriteLine("Numero invalido! Digite um numero entre 1 e 20");
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
        static (int , int)UsuarioPerdeu(int ns1 , int t)
        {
            Console.WriteLine("Voce perdeu! O numero sorteado era: " + ns1);
            Console.ReadLine();
            int ns = JogoAdivinhacao.GerarNumeroAleatorio();
            t = 0;
            return (ns, t);
        }
        public static (int, int) GerenciarTentativas(int t, int n1, int ns, int tm)
        {

            if (n1 == ns)
            {
                t = 1;
            }
            else if (n1 < 1 || n1 > 20)
            {
                t--;
            }
            else
            {
                t++;
            }

            //Verefica se o usuario ainda tem tentativas
            if (t > tm)
            {
                (ns, t) = UsuarioPerdeu(ns, t);
            }

            return (t, ns);
        }
    }
}
