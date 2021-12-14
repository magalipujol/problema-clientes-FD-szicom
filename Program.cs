using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace problema_clientes_FD_szicom
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = "C:/Users/magalip/source/repos/problema-clientes-FD-szicom/clientes.txt";
            // CHECK el @ va o no va?
            string txtPath = "C:/Users/magalip/Documents/Datos problema/Datos Problemas/ventana_dia.txt";

            TXTToCSV(csvPath, txtPath);
            
            string[] csvLines = File.ReadAllLines(csvPath);
            Console.WriteLine(csvLines[0]);
        }

        public static void TXTToCSV(string csvPath, string txtPath)
        {
            string[] lines = File.ReadAllLines(txtPath);
            foreach (string line in lines)
            {
                var parts = line.Split(' ');
                string csvLine = string.Join(',', parts);
                Console.WriteLine(csvLine);
                File.AppendAllText(csvPath, csvLine + Environment.NewLine);
            }
        }

        // TODO create csv to object
        // TODO create all classes
    }
}


