using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_DanielLores
{
    class Client : People
    {
        // PROPIEDADES
        public BankAccount BankAccount { get; protected set; }

        /// <summary>
        /// Constructor del objeto cliente
        /// </summary>
        /// <param name="Name"> nombre del cliente </param>
        /// <param name="Dni"> dni del cliente </param>
        /// <param name="Email"> email del cliente </param>
        /// <param name="Age"> edad del cliente </param>
        /// <param name="PhoneNumber"> numero de telefono del cliente </param>
        /// <param name="BankAccount"> cuenta de banco del cliente </param>
        public Client(string Name, string Dni, string Email, int Age, int PhoneNumber, BankAccount BankAccount){
            this.Name = Name;
            this.Dni = Dni;
            this.Email = Email;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
            this.BankAccount = BankAccount;
        }               
    }
}
