using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio
{
    class ArquivoCSV
    {
        static void Main(string[] args)
        {
            string caminho = "C:\\Projetos\\C_Sharp\\arquivo.csv"; //arquivo local

            StreamReader sr = new StreamReader(caminho);

            string linhaAtual = null;

            while ((linhaAtual = sr.ReadLine()) != null)
            {
                string[] coluna = linhaAtual.Split(';');
                Console.WriteLine("- - - - -\nSalario: " + coluna[0]);
                Console.WriteLine("Funcionario: " + coluna[1]);
                Console.WriteLine("Cargo: " + coluna[2]);

                // Console.WriteLine("Salário: " + coluna[0] + " - Funcionário: " + coluna[1] + " - Cargo: " + coluna[2]);
            }

            Console.ReadKey();

        }

    }
}
