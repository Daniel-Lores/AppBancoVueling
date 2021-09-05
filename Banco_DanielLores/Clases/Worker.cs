using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_DanielLores
{
    class Worker : People
    {
        public Worker(string Name, string Dni, string Email, int Age, int PhoneNumber){
            this.Name = Name;
            this.Dni = Dni;
            this.Email = Email;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
        }
    }
}
