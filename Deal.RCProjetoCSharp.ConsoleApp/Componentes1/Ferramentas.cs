using System;

namespace Componentes1
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaAssembly()
        {
            return "Este método só pode ser acessado dentro da assembly componentes";
        }
        public string MetodoParaTodosQueUtilizamOAssembly()
        {
            return "Este método sé para todos";
        }

        public bool ValidarCPF(string cpf)
        {
            return true;
        }
    }
}
