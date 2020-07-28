using System;
using System.Collections.Generic;
using System.Text;

namespace NewFrontier.Domain.Entities
{
    public class Medico
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sbrenome { get; set; }
        public string CRM { get; set; }
        public string Especializacao { get; set; }
        public List<Atendimento> Atendimentos { get; set; }

    }
}
