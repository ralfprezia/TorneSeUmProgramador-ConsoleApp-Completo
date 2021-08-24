using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaCliente
    {
        class TelaCliente
        {
            public static void Chamar()
            {
                var clientes = Cliente.LerClientes();//método static retorna clientes

                Cliente.Teste = "sss";

                //Método de instância-salvar um cliente
                var cliente = new Cliente();

                //cliente.olh

                cliente.Nome = "Ayrton";
                cliente.Telefone = "58479635";
                cliente.CPF = "033225698";
                cliente.Gravar();

                //Cliente c = new Cliente();

                //Cliente c2 = new Cliente { Nome = "Ralf", Telefone = "56458798", CPF = "32456789"};

                var clientes = Cliente.LerClientes();
                foreach (Cliente c in clientes)
                {
                    Console.WriteLine(c.Nome);
                    Console.WriteLine(c.Telefone);
                    Console.WriteLine(c.CPF);
                }
                Console.ReadLine();



                //var l = new List<string>();

                /*
                var cliente2 = new Cliente();
                cliente2.Nome = "Cecillia";
                cliente2.Telefone = "98563256";
                cliente2.CPF = "98563256987";
                cliente2.Gravar();
                */
                Console.Read();

            }
        }
    }
}
