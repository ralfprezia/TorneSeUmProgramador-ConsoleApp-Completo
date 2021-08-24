using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaUsuario
    {
        public string Telefone { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }

        public static void Chamar()
        {
            Console.WriteLine("===================== Cadastro de Usuarios===============");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo;" +
                    "\n     0 - Sair do cadastro" +
                    "\n     1 - Para cadastrar usuários" +
                    "\n     2 - Para listar usuários";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var usuario = new Usuario();

                    Console.WriteLine("Digite o nome do usuário");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do usuário");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do usuário");
                    usuario.CPF = Console.ReadLine();

                    usuario.Gravar();
                }
                else
                {
                    var Usuarios = new Usuario().Ler();
                    foreach (Usuario c in Usuarios)
                    {
                        Console.WriteLine("========================");
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone:" + c.Telefone);
                        Console.WriteLine("CPF: " + c.CPF);
                        Console.WriteLine("========================");
                    }
                }
            }
        }

        private void Gravar()
        {
            throw new NotImplementedException();
        }

        internal object Ler()
        {
            throw new NotImplementedException();
        }
    }
}
