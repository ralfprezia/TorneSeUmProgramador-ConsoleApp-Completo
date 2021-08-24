using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaFornecedor
    {
        public static void Chamar()
        {
            Console.WriteLine("===================== Cadastro de Fornecedores===============");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo;" +
                    "\n     0 - Sair do cadastro" +
                    "\n     1 - Para cadastrar fornecedores" +
                    "\n     2 - Para listar fornecedores";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var fornecedor = new Fornecedor();

                    Console.WriteLine("Digite o CNPJ do fornecedor");
                    fornecedor.CNPJ = Console.ReadLine();

                    Console.WriteLine("Digite o nome do fornecedor");
                    fornecedor.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do fornecedor");
                    fornecedor.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do gerente");
                    fornecedor.CPF = Console.ReadLine();

                    fornecedor.Gravar();
                }
                else
                {
                    var fornecedores = new Usuario().Ler();
                    foreach (Fornecedor c in fornecedores)
                    {
                        Console.WriteLine("========================");
                        Console.WriteLine("CNPJ: "+ c.CNPJ);
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF do gerente: " + c.CPF);
                        Console.WriteLine("========================");
                    }
                }
            }
        }
    }
}
