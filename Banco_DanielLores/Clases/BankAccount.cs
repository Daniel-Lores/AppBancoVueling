using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_DanielLores
{
    class BankAccount{
        public string Iban { get; set; }
        public decimal Money { get; set; }

        public BankAccount(string Iban, decimal Money){
            this.Iban = Iban;
            this.Money = Money;
        }
    }
}
