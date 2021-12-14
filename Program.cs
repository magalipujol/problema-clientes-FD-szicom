using System;
using System.Collections.Generic;
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
            string txtPath = "C:/Users/magalip/Documents/Datos problema/Datos Problemas/clientes.txt";


            var clientes = TXTToCSV(txtPath);
            foreach (var client in clientes)
            {
                Console.WriteLine($"{client.Id}, {client.Mercado}, {client.NombreCliente}");
            }

        }

        // TODO this should be for all classes
        public static List<Cliente> TXTToCSV(string txtPath)
        {
            string[] lines = File.ReadAllLines(txtPath);
            List<Cliente> clientes = new List<Cliente>();
            foreach (string line in lines)
            {
                string[] csvLine = line.Split('	');
                clientes.Add(new Cliente { Id = csvLine[0], Mercado = csvLine[1], NombreCliente = csvLine[2] });
                // TODO esto va a tener que pedir que tipo de clase quiere y usar el metodo segun la clase
            }
            return clientes;
        }

        // TODO create all classes
    }
}


