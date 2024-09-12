using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_csharp
{
    internal class Gerente : Funcionario
    {
        public string setor;

        public override void cadastrarPes()
        {
            Console.WriteLine("cadastrando gerente");
            base.cadastrarPes();

            Console.WriteLine("Qual o setor");
            setor = Console.ReadLine();
        }

        public override void mostrarDadosPes()
        {
            Console.WriteLine("setor:{0}", setor);
        }
    }
}

