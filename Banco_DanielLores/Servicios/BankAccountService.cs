using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_DanielLores.Servicios
{
    class BankAccountService
    {
        public void Transfer(decimal amountTransfered, BankAccount origin, BankAccount target)
        {
            origin.Money -= amountTransfered;
            target.Money += amountTransfered;
        }
    }
}
