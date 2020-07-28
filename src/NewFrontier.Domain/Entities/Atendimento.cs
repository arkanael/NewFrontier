using System;
using System.Collections.Generic;
using System.Text;

namespace NewFrontier.Domain.Entities
{
    public class Atendimento
    {
        public Guid Id { get; set; }
        public DateTime DataAtendimento { get; set; }
        public string Local { get; set; }
        public string Observacoes { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
    }
}
