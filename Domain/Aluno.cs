using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domain
{
    public class Aluno
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string  SobreNome { get; set; }

        public string NomeCompleto { get; set; }


public DateTime DataNascimento {get; set; }
        public string Matricula { get; set; }

}
}
