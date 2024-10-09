using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeFinancias.Models
{
    public class ContaBancaria
    {
        //Valor do saldo da conta
        public double Saldo { get; set; }

        //Construtor da classe
        public ContaBancaria()
        {
            Saldo = 10000;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public void Depositar(double valor)
        {
            this.Saldo += valor;
            Console.WriteLine("Saldo total: "+Saldo);
        }

        public string Sacar(double valor) { 
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine("Saldo total: "+Saldo);
                return "Saque realizado com sucesso!";
            }
            else
            {
                Console.WriteLine();
                return "Saldo insuficiente!";
            }
        }

    }
}
