using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aATV
{
     class Funcionario
   {
        public String nome { get; set; }
        public int matricula { get; set; }
        public int salario { get; set; }
    
        public void imprime()
        {
            Console.WriteLine(this.nome + "\n Matricula : " + this.matricula + "\n Salario : " + this.salario);
        }
    }
}
