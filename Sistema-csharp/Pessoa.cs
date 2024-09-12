using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sistema_csharp
{
    internal class Pessoa
    {
        public string nome;
        public string email;
        protected string cpf;
        protected int telefone;


        public virtual void cadastrarPes()
        {
            Console.WriteLine("cadastrando pessoa");
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu email: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite seu CPF: ");
            cpf = Console.ReadLine();

            Console.WriteLine("Digite seu telefone: ");
            telefone = int.Parse(Console.ReadLine());

        }

        public virtual void mostrarDadosPes()
        {
            Console.WriteLine("Nome:{0}\nEmail:{1}\nCPF:{2}\nTelefone:{3}", nome, email, cpf, telefone);


        }
    }
}