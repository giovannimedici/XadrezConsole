using System;
using xadrez.tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            p = new Posicao(3, 4);
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
