using System;

namespace Primeiro
{
    class Estudantes
    {
        public string Nome { get; set; }
        public double Email { get; set; }

        public Estudantes (string nome,double email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
