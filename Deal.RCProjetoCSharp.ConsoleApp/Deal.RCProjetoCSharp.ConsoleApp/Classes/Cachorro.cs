using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{
    public class Cachorro : Animal
    {
        public int Idade;

        private int idadePredefinida = 2;
        public int Idade2 
        {
            get 
            { 
                return idadePredefinida;//atributo privado dentro da instância 
            }
            set
            {
                idadePredefinida = value;
            }
        }

        public int GetIdade2()
        {
            return idadePredefinida;
        }

        public void SetIdade2(int idade2)
        {
            idadePredefinida = idade2;
        }
        public override void Latir()
        {
            Console.WriteLine("Au eu sou um dog!");
        }
    }
}
