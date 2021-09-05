using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_DanielLores.Interfaces
{
    interface INotificable
    { 
        public void SendNotification(Client client, string text);
    }
}
