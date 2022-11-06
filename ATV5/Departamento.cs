using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departamentoefuncionarios
{
    internal class Departamento
    {
        private string nome_;
        ArrayList ListaDeFuncionarios = new ArrayList();

        public Departamento(string nome)
        {
            nome_ = nome;
        }
        public string getNome()
        {
            return this.nome_;
        }
        public void setNome(string nome_)
        {
            this.nome_ = nome_;
        }

        public void addFuncionario(Funcionario func)
        {
            ListaDeFuncionarios.Add(func);
        }

        public void ImprimeDepartamento()
        {
            Console.WriteLine("Funcionarios : " + nome_ + " ");
            foreach (Funcionario func in ListaDeFuncionarios)
            {
                Console.WriteLine(func.nome + " ");
            }
        }
    }
}
