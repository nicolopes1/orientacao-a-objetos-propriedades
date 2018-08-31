using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_18_orientacao_a_objetos_propriedades
{
    public abstract class Animal
    {
        public string Coleira;
        public string Pelo;
        public string Olhos;

        public abstract void Latir();

        public string Correr()
        {
            return "O animal está correndo";
        }



    }
}
