using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01Textos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a Cafeteria Conradito\n\n");
            Console.WriteLine("\n");
            Console.WriteLine("Essas são nossas opções");
            Console.WriteLine("- Café expresso R$ 2,50");
            Console.WriteLine("- Capuccino R$ 3,00");
            Console.WriteLine("- Mocca R$ 4,000");
            Console.WriteLine("\n \n \n");
            Console.WriteLine("Volte sempre");

            // Barras duplas comentam o codigo
            // WriteLine para escrever linha e pular p proxima
            // Write comando para escrita   
            // Read e ReadKey para travar tela
            // \n pular linha         
            // "" entre () após comandos Write e Write line para inserir texto
            // Console representa os fluxos de entrada,saida e erro padrão para aplicativos de console

            Console.Read();
        }
    }
}