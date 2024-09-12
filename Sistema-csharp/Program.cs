using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Cliente cliente = new Cliente();    
            Funcionario funcionario = new Funcionario();
            Gerente gerente = new Gerente();    
            Diretor diretor = new Diretor();

             pessoa.cadastrarPes(); 
             pessoa.mostrarDadosPes();

             cliente.cadastrarPes();
             cliente.mostrarDadosPes();

             funcionario.cadastrarPes();
             funcionario.mostrarDadosPes();

             gerente.cadastrarPes();
             gerente.mostrarDadosPes();

            diretor.cadastrarPes();
            diretor.mostrarDadosPes();

            Console.ReadKey();
        }
    }
}
