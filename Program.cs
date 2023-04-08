using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_TiposReferenciaEValores
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaAna = new ContaCorrente();
            contaAna.titular = "Ana";
            contaAna.agencia = 123;
            contaAna.numConta = 123456;

            ContaCorrente contaAna2 = new ContaCorrente();
            contaAna2.titular = "Ana";
            contaAna2.agencia = 123;
            contaAna2.numConta = 123456;

            Console.WriteLine("Banco Virtual - Tipos de Referência e Valores: \r\n");

            Console.WriteLine("Igualdade do tipo de referência: " + (contaAna == contaAna2));

            Console.WriteLine("____________________________________________________________________ \r\n");

            contaAna = contaAna2;
            Console.WriteLine("Igualdade do tipo de valor após a conta da Ana receber a conta da Ana2: " + (contaAna == contaAna2));

            Console.WriteLine("____________________________________________________________________ \r\n");

            contaAna.saldo = 400;
            Console.WriteLine("O saldo da conta da Ana é: " + contaAna.saldo);
            Console.WriteLine("O saldo da conta da Ana2 é: " + contaAna2.saldo);
            //Os dois saldos possuem o mesmo valor, pois as variáveis guardam as referências do mesmo objeto na memória do computador, ou seja, se inserir o valor em uma das variáveis, ambas terão o mesmo valor.

            Console.ReadLine();
        }
    }
}
