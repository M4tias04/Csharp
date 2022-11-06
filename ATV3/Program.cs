using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno a1 = new Aluno();
            a1.setNome("Zé");
            a1.setMatricula(234);
            a1.setEmail("ze@gmail.com");

            Aluno a2 = new Aluno("Ana");
            a2.setMatricula(789);
            a2.setEmail("ana@xy.com");

            Aluno a3 = new Aluno("Paulo", 989, "paulo@ig.com");

            a1.imprimir();
            a2.imprimir();
            a3.imprimir();

            Console.ReadKey();
        }
    }
}

