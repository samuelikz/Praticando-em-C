using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {


            AnalistaDeTi analistaDeTi = new AnalistaDeTi();

            analistaDeTi.AdicionarNome("Samuel", "Nunes");
            analistaDeTi.AdicionarSalarioPadrao(1000);

            analistaDeTi.Reajustar();

            Msg("Salario é: "+ analistaDeTi.Salario);
            Msg("Nome é: " + analistaDeTi.Nome);



            Console.ReadKey();










            //ContaPoupanca contaPoupanca = new ContaPoupanca(1122, 0);

            //contaPoupanca.Deposita(100);
            //contaPoupanca.Saca(10);
            //double saldopoupanca = contaPoupanca.ConsultarSaldoDisponivel();

            //Msg("Saldo poupanca é: "+saldopoupanca);

            //ContaCorrente contaCorrente = new ContaCorrente(1122, 100);

            //contaCorrente.Deposita(100);
            //contaCorrente.Saca(20);
            //double saldocorrente = contaCorrente.ConsultarSaldoDisponivel();

            //Msg("Saldo poupanca é: " + saldocorrente);

            //Console.ReadKey();

            //AnalistaDeTi analistaDeTi = new AnalistaDeTi();
            //Gerente gerente = new Gerente();
            //GerenteDeAgencia gerenteDeAgencia = new GerenteDeAgencia();
            //GerenteDeTI gerenteDeTI = new GerenteDeTI();

            //analistaDeTi.Nome = "Samuel N Silva";
            //analistaDeTi.Salario = 3000;

            //Msg("Analista de TI: " + analistaDeTi.Nome);

            //Msg("Salario do Analista de TI é: "+analistaDeTi.Salario);

            //analistaDeTi.Reajustar();

            //Msg("Salario do Analista de TI Reajustado: " + analistaDeTi.Salario);

            //Msg("________________________________________________________________\n");

            //gerente.Nome = "Davi N Silva";
            //gerente.Salario = 8000;

            //Msg("Gerente: " + gerente.Nome);

            //Msg("Salario do Gerente é: " + gerente.Salario);

            //gerente.Reajustar();

            //Msg("Salario do Gerente Reajustado: " + gerente.Salario);

            //Msg("________________________________________________________________\n");

            //gerenteDeAgencia.Nome = "Rebeca N Silva";
            //gerenteDeAgencia.Salario = 10000;

            //Msg("Gerente de Agencia: " + gerenteDeAgencia.Nome);

            //Msg("Salario do Gerente de Agencia é: " + gerenteDeAgencia.Salario);

            //gerenteDeAgencia.Reajustar();

            //Msg("Salario do Gerente de Agencia Reajustado: " + gerenteDeAgencia.Salario);

            //Msg("________________________________________________________________\n");

            //gerenteDeTI.Nome = "Fabio J Silva";
            //gerenteDeTI.Salario = 20000;

            //Msg("Gerente de TI: " + gerenteDeTI.Nome);

            //Msg("Salario do Gerente de TI é: " + gerenteDeTI.Salario);

            //gerenteDeTI.Reajustar();

            //Msg("Salario do Gerente de TI Reajustado: " + gerenteDeTI.Salario);


            //ContaPoupanca contaPoupanca = new ContaPoupanca(1103, 0);

            //contaPoupanca.Deposita(100);
            //contaPoupanca.Saca(10);

            //double saldo = contaPoupanca.ConsultarSaldoDisponivel();

            //contaPoupanca.MostrarNumeroDaConta();

            //Msg("Saldo da Conta Poupanca é : "+ saldo);

            //Conta conta = new Conta(2201, 100);

            //conta.Deposita(500);
            //conta.Saca(140);

            //double saldoContaCorrent = conta.ConsultarSaldoDisponivel();

            //Msg("Saldo da Conta Corrente é : " + saldoContaCorrent);


            //Conta contar1 = new Conta(3321, 500);
            //Conta contar2 = new Conta(3322, 100);
            //Conta contar3 = new Conta(3323, 550);
            //Conta contar4 = new Conta(3324, 550);


            //Msg("Total de Constas Criadas: " + Conta.TotalContasCriadas);

            //int total = Conta.ProximoTatalContasCriadas();

            //Msg("Proximo Total de Contas Criadas: " + total);



            ////Criando um objeto de cada classe

            //CartaoDeCredito cdc = new CartaoDeCredito();
            //Cliente c = new Cliente();

            //// Adicionando o nome do cliente
            //c.Nome = "Samuel N Silva";

            //// Adicionando o numero e data de validade do cartao
            //cdc.Numero = "5436789765432123";
            //cdc.DataDeValidade = "02/2025";
            //cdc.Cliente = c;


            //Msg("Nome do Cliente : " + c.Nome);
            //Msg("Numero do Cartão : " + cdc.Numero);
            //Msg("Data de Validade do Cartão : " + cdc.DataDeValidade);
            //Msg("Nome do Cliente Agregado: " + cdc.Cliente.Nome);

            ////Criando uma instancia da conta
            //Conta conta = new Conta(3200, 500);

            //// conta.AdicionarLimite(1500);

            //conta.Deposita(1500);
            //conta.Deposita(2500);
            //conta.Deposita(4500);

            //bool saca = conta.Saca(7000);

            //double saldo = conta.ConsultarSaldoDisponivel();

            //if (saca)
            //{
            //    Msg("Seu Saldo Disponivel: " + saldo);
            //    Msg("Seu Limite Disponivel: " + conta.Limite);
            //    Msg("Seu Numero da Sua conta é: " + conta.Numero);

            //    Console.ReadKey();

            //}
        }

        static string Msg(string Msg)
        {
            Console.WriteLine(Msg);
            return Msg;
        }

    }
}
