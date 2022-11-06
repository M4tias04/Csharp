using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departamentoefuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Funcionario func1 = new Funcionario("Maria", 123, "6765657");
                Funcionario func2 = new Funcionario("Pedro", 789, "2213438");
                Departamento vendas = new Departamento("Vendas");

                vendas.addFuncionario(func1);
                vendas.addFuncionario(func2);
                vendas.ImprimeDepartamento();
           
        }
        }
    }

