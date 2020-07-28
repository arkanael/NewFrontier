using System;
using System.Collections.Generic;
using System.Text;

namespace NewFrontier.Domain.Entities
{
    public class Paciente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string  Email { get; set; }
        public List<Atendimento> Atendimentos { get; set; }
    }
}
