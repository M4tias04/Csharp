using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departamentoefuncionarios
{
    internal class Funcionario
    {
        public String nome;
        private int matricula;
        private String cpf;

        public Funcionario(string nome, int matricula, string cpf)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.cpf = cpf;
        }

        public string getNome()
        {
            return this.nome;
        }

        public int getMatricula()
        {
            return this.matricula;
        }

        public string getCpf()
        {
            return this.cpf;
        }


        public void imprime()
        {
            Console.WriteLine(this.nome + "  " + this.matricula + " " + this.cpf);
        }
    }
}

