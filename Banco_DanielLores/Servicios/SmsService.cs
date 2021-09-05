using Banco_DanielLores.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_DanielLores.Servicios
{
    class SmsService : INotificable
    {
        public void SendNotification()
        {
            public void SendNotification(Client client, string text)
            {
                Console.WriteLine(client.Name + text);
            }
        }
    }
}
