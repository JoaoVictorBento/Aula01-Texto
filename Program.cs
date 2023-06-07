using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01Texto
{

    class Program
    {

        static void Main(string[] args)
        {

            //Mensagem de boas-vindas

            Console.Write("Bem-Vindo a cafeteria do Conradito!");

            Console.WriteLine("\n\n"); //Pular linhas

            //Opções do menu
            
            Console.WriteLine("Essas são nossas opções de hoje:");

            Console.WriteLine("-café R$ 2,00");

            Console.WriteLine("-Capuccino R$ 3,50");

            Console.WriteLine("-Moccacino R$ 2.000,00");

            Console.WriteLine("\n\n"); //pular linhas

            //Processo final

            Console.WriteLine("Escolha uma opção e dirija-se ao caixa...");

            Console.ReadKey();

        }

    }

}
