using Banco_DanielLores.Interfaces;
using Banco_DanielLores.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_DanielLores.Servicios
{
    class EmailService : INotificable
    {
        public void SendNotification(Client client, string text)
        {
            Console.WriteLine(client.Name + text);
        }
    }
}
