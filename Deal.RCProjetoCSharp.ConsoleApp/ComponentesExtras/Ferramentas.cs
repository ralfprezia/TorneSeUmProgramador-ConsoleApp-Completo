﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentesExtras
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Este método só pode ser acessado dentro deste assembly";
        }
        public string MetodoParaTodosQueUtilizaremOAssembly()
        {
            return "Este método para todos";
        }

        public bool ValidarCPF(string cpf)
        {
            return true;
        }
    }
}
