﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHoraDoPitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alarme alarme = new Alarme();
            string resposta = "S";
            while (resposta != "N")
            {
                Console.Clear();
                Console.WriteLine("A hora do Picyh");
                Console.Write("informe a Duração do Picth: ");
                int tempo = Convert.ToInt32(Console.ReadLine());
                alarme.Tempo = tempo;
                Console.Write("Informe o efeito sonoro (1 até 500): ");
                int efeitoSonoro = Convert.ToInt32(Console.ReadLine());
                alarme.EfeitoSonoro = efeitoSonoro;
                alarme.Iniciar();
                Console.WriteLine("Que pena!!! O seu tempo acabou!!!");
                Console.WriteLine("Executar o programa novamente: S/N");
                resposta = Console.ReadLine().ToUpper();
            }


        }
    }
}
