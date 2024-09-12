using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_csharp
{
    internal class Funcionario : Pessoa
    {
        protected int cep;
        public string cargo;
        public string turno;
        protected string registro;
        public string dataNasc;
        protected string tipoContrato;
        protected double salario;


        public override void cadastrarPes()
        {
            Console.WriteLine("cadastrando funcionario");
            base.cadastrarPes();

            Console.WriteLine("Digite o cep");
            cep = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu cargo");
            cargo = Console.ReadLine();

            Console.WriteLine("Digite seu turno");
            turno = Console.ReadLine();

            Console.WriteLine("Digite seu registro");
            registro = Console.ReadLine();

            Console.WriteLine("Digite seu data nascimento");
            dataNasc = Console.ReadLine();

            Console.WriteLine("Digite seu tipo de contrato");
            tipoContrato = Console.ReadLine();

            Console.WriteLine("Digite seu salario");
            salario = double.Parse(Console.ReadLine());
        }

        public override void mostrarDadosPes()
        {
            Console.WriteLine("CEP:{0}\nCargo:{1}\nTurno:{2}\nRegistro:{3}\nData Nascimento:{4}\nTipo de Contrato:{5}\nsalario:{6}", cep, cargo, turno, registro, dataNasc, tipoContrato, salario);


        }
    }
}