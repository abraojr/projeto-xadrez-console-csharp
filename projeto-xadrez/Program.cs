﻿using System;
using tabuleiro;

namespace projeto_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3, 4);

            Console.WriteLine("Posição:"+P);

            Console.ReadLine();
        }
    }
}
