using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_Enum.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public Client() { }

        public Client(string name, string email, DateTime birthday)
        {
            Name = name;
            Email = email;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return Name
                + ", ("
                + Birthday.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
