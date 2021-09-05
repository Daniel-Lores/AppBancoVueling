using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_DanielLores.Servicios
{
    class SignUpService
    {
        public void SignUp(string email, string pass)
        {
            if (ValidateEmail(email)==true)
            {
                //New Client
                var Client = new Client(email, Pass);
                // Bank send the message
                nServ.Send(Client, ", you created an account of client.");
                return Client;
            }
        }

        public bool ValidateEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
