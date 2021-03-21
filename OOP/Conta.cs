using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Conta : IConta
    {
        public Conta(int numero, double valor){
            this.Numero = numero;
            this.Limite = valor;
            Conta.TotalContasCriadas++;
        }

        protected double Saldo { get; set; }
        public double Limite { get;  private set; }
        public int Numero { get; private set; }

        public static int TotalContasCriadas { get; set; }

        public static int ProximoTatalContasCriadas()
        {
            return Conta.TotalContasCriadas + 1;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual bool Saca(double valor)
        {
            double saldoDisponivel = this.ConsultarSaldoDisponivel();

            if (valor > saldoDisponivel)
            {
                Console.WriteLine("Saque e saldo indisponivel");
                Console.ReadKey();

                return false;
            }

            this.Saldo -= valor;
            return true;
        }
        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }

        public double ConsultarSaldoDisponivel()
        {
            return this.Saldo + Limite; 
        }

    }
}
