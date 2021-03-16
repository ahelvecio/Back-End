using System;
using System.Collections.Generic;
using System.Text;

namespace Conta_Poupança
{
    public class ContaPoupanca
    {
        public string NomeTitular;
        public int SaldoConta;
        public int NumeroConta;
        public int deposito;
        public int rendimento;

        public ContaPoupanca(string titular, int saldo, int numero, int deposito, int rendimento)
        {
            this.NomeTitular = titular;
            this.SaldoConta = saldo;
            this.NumeroConta = numero;
            this.deposito = deposito;
            this.rendimento = rendimento;
        } 

        public ContaPoupanca()
        {
        }

        public void depositar(int deposito)
        {
            SaldoConta = (SaldoConta + deposito);
        }

        public void retirar(int saque)
        {
            if (saque <= SaldoConta)

                SaldoConta = SaldoConta - deposito;
            else
                Console.WriteLine("Saldo insuficiente");
        }
        public void transferir(int transferencia)
        {
            if (transferencia <= SaldoConta)

                SaldoConta = (SaldoConta - transferencia);
            else
                Console.WriteLine("Saldo insuficiente para transferencia");
        }
        public void Rendimentos(int rendimento)
        {
            this.SaldoConta = (SaldoConta * rendimento * 2);
        }
        public void MostrarConta() 
        { 
            Console.WriteLine(NomeTitular);
            Console.WriteLine(NumeroConta);
            Console.WriteLine("R$" + SaldoConta);
        }
    }
}
