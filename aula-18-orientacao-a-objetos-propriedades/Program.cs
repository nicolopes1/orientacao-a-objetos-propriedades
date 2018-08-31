using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_18_orientacao_a_objetos_propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cachorro();
            c.Idade = 21;
            Console.WriteLine(c.Idade);

            c.Idade2 = 22;
            Console.WriteLine(c.Idade2);

            


            Console.Read();
        }

    }
}
