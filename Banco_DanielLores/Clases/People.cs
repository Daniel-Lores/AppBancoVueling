using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_DanielLores
{
    abstract class People
    {
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public People()
        {

        }
    }
}
