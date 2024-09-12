using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_csharp
{
    internal class Diretor : Gerente 
    {
        private string filial;

        public override void cadastrarPes()
        {
            Console.WriteLine("Diretor");
            base.cadastrarPes();
            Console.WriteLine("qual a filial:");
            filial = Console.ReadLine();  
        }
        public override void mostrarDadosPes()
        {
            Console.WriteLine("Filial:{0}", filial);
        }
    }
}
