﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correçãoprova
{
    class Program
    {
        static void Main(string[] args)
        {
            Program metodos = new Program();
            IMC imc = new IMC();


            //Cabeçalho da questão UM.
            Console.WriteLine("Digite dois numeros por favor. ");
            Console.Write("\nPrimeiro numero: ");
            int pri_n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Segundo numero: ");
            int seg_n = Convert.ToInt32(Console.ReadLine());

            metodos.Maior(pri_n, seg_n);
            //Final do cabeçalho da questão UM.

            //ReadKey sem precisar ficar escrevendo um milhao de vezes a mesma coisa.
            metodos.ReadKey();
            //Final do ReadKey.

            //Limpar a tela.
            metodos.Clear();
            //Limpou

            //Cabeçalho da questão DOIS.
            Console.WriteLine("Digite seu peso e altura. ");
            Console.Write("\nPeso: ");
            double pes = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura: ");
            double alt = Convert.ToDouble(Console.ReadLine());
            imc.IMC_(pes, alt);
            // Final  da questão DOIS.

            metodos.ReadKey();
            metodos.Clear();

            //Cabeçalho da questão TRES.
            Console.WriteLine("Digite um numero para verificar se é par.");
            Console.Write("Numero: ");
            int par_impar = Convert.ToInt32(Console.ReadLine());

            metodos.Par(par_impar);
            // Final da questão TRES.

            metodos.ReadKey();
            metodos.Clear();

            //Cabeçalho da questão QUATRO.
            metodos.quatro();
            //Final da questão QUATRO.

            //ReadKey sem precisar ficar escrevendo varias vezes a mesma coisa
            metodos.ReadKey();

        }

        public void ReadKey()
        {
            Console.WriteLine("\nAperte QUALQUER TECLA para sair.");
            Console.ReadKey();
        }

        public void Clear()
        {
            Console.Clear();
        }

        // Começo da questão UM.
        public int Maior(int a, int b)
        {

            if (a > b)
            {
                Console.WriteLine("\nA maior que B.");
            }
            else if (b > a)
            {
                Console.WriteLine("\nB maior que A.");
            }
            else
            {
                Console.WriteLine("\nNúmeros iguais.");
            }

            return 0;

        }
        //Final da questão UM.

        //Começo da questão TRES.
        public bool Par(int numero)
        {

            int teste = numero % 2;
            if (teste == 0)
            {
                Console.WriteLine("Verdadeiro.");
                return true;
            }
            else
            {
                Console.WriteLine("Falso.");
                return false;
            }
        }
        // Final da questão TRES.

        // Começo da questão QUATRO.
        public void quatro()
        {

            double a = Math.Abs(7.5);
            double b = Math.Floor(7.5);
            double c = Math.Abs(0.0);
            double d = Math.Ceiling(0.0);
            double e = Math.Abs(-6.4);
            double f = Math.Ceiling(-6.4);
            double g = Math.Ceiling(-Math.Abs(-8 + Math.Floor(-5.5)));

            Console.WriteLine("a.x = Math.Abs(7.5);"
                              + "\n" + "b.x = Math.Floor(7.5);"
                              + "\n" + "c.x = Math.Abs(0.0);"
                              + "\n" + "d.x = Math.Ceiling(0.0);"
                              + "\n" + "e.x = Math.Abs(-6.4);"
                              + "\n" + "f.x = Math.Ceiling(-6.4);"
                              + "\n" + "g.x = Math.Ceiling(-Math.Abs(-8 + Math.Floor(-5.5)));",
                              a, b, c, d, e, f, g);

            Console.WriteLine("\n" + "a. " + a);
            Console.WriteLine("b. " + b);
            Console.WriteLine("c. " + c);
            Console.WriteLine("d. " + d);
            Console.WriteLine("e. " + e);
            Console.WriteLine("f. " + f);
            Console.WriteLine("g. " + g);
        }
        // Final da questão QUATRO.

    }
}
