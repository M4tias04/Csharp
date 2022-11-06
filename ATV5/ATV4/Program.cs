using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aATV
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] func = new Funcionario[4];

            /* for(int i = 0; i < 4; i++)
                 {
                     func[i] = new Funcionario();
                     func[i].nome = Console.ReadLine();
                     func[i].matricula = int.Parse(Console.ReadLine());
                     func[i].salario = int.Parse(Console.ReadLine());
                 }
            */

            func[0] = new Funcionario();
            func[0].nome = "Zezeu";
            func[0].matricula = 2345;
            func[0].salario = 1500;

            func[1] = new Funcionario();
            func[1].nome = "Adriano Matias";
            func[1].matricula = 987;
            func[1].salario = 3500;

            func[2] = new Funcionario();
            func[2].nome = "Rafael Moreira";
            func[2].matricula = 777;
            func[2].salario = 1700;

            func[3] = new Funcionario();
            func[3].nome = "Eduardo";
            func[3].matricula = 2213;
            func[3].salario = 5670;

            int Soma = 0;

        for (int i = 0; i < 4;i++)
            {
                Soma += func[i].salario;
            }
            
        float Media = Soma / 4;

        for (int i = 0; i < 4; i++) 
            { 
                if (func[i].salario > Media)
                {
                    func[i].imprime();
                }
            }

            Console.ReadKey();
        }
    }
}
 