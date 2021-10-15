using System;

namespace Console_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Willyara Amorim", "000.000.000-00", "Desenvolvedora");

          /*Código inicial inutilizado após o método construtor
           *cliente.setNome ();
           *cliente.setCPF ();
           *cliente.setProfissao ();*/

            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);
            /*conta.titular = c;
            conta.agencia = 01;
            conta.conta = 0001;*/

            Console.WriteLine("Conta Corrente Criada!");
            Console.WriteLine("Titular: {0}", conta.getTitular().getName());
            Console.WriteLine("Agencia: {0}", conta.getAgencia());
            Console.WriteLine("Conta: {0}", conta.getConta());

            Console.WriteLine("Parabéns! Seu saldo é de {0}, obrigado por criar a sua conta", conta.getSaldo());

            double valorDeposito = 100;
            conta.Depositar(valorDeposito);
            Console.WriteLine ("Valor depositado! O Seu saldo é de {0}", conta.getSaldo());

            double valorSaque = 200;
            conta.Sacar(valorSaque);
            Console.WriteLine("Seu saldo é de {0}", conta.getSaldo());

            Cliente clienteVitor = new Cliente("Vitor David", "0000000000", "UX Designer");
            ContaCorrente contaVitor = new ContaCorrente(clienteVitor, 02, 0002);
            double valorPix = 100;
            conta.Pix(valorPix, contaVitor);

            Console.WriteLine("Seu saldo é de R${0}", contaVitor.getSaldo());
            Console.Write("Seu saldo é de R${0}",contaVitor.getSaldo());
        
        }
    }
}
