using System;
using Banco_DanielLores.Servicios;

namespace Banco_DanielLores
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountService bankAccountService = new BankAccountService();
            // creados los empleados
            Worker w1 = new Worker("Mariano", "18345687P", "worker1@nowhere.net", 40, 648006739);
            Worker w2 = new Worker("Manuel", "18982802P", "worker2@nowhere.net", 50, 609876541);
            // creadas las cuentas bancarias
            BankAccount bankAccount1 = new BankAccount("q087456t2", 900.50m);
            BankAccount bankAccount2 = new BankAccount("456298435", 1700.75m);
            // creados los clientes
            Client c1 = new Client("Daniel", "728564F", "client1@nowhere.com", 35, 567998765, bankAccount1);
            Client c2 = new Client("Pedro", "57935R", "client2@nowhere.com", 20, 786954312, bankAccount2);
            // llamada a los metodos
            bankAccountService.Transfer(150.00m, bankAccount1, bankAccount2);
        }
    }
}
