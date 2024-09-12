using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_csharp
{
    internal class Cliente : Pessoa
    {
        public string tipo;
        public string endereco;


        public override void cadastrarPes()
        {
            Console.WriteLine("cadastrando cliente");
            base.cadastrarPes();

            Console.WriteLine("Digite seu endereco");
            endereco = Console.ReadLine();

            Console.WriteLine("Digite seu tipo");
            tipo = Console.ReadLine();
        }

        public override void mostrarDadosPes()
        {
            Console.WriteLine("Endereço:{0}\nTipo:{1}", endereco, tipo);
        }
    }
}
