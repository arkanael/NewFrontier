using System;
using System.Collections.Generic;
using System.Text;

namespace NewFrontier.Domain.Entities
{
    public class Medico
    {
        public Medico(string nome, string sobrenome, string cRM, string especializacao)
        {
            Id = new Guid();
            Nome = nome;
            Sobrenome = sobrenome;
            CRM = cRM;
            Especializacao = especializacao;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CRM { get; set; }
        public string Especializacao { get; set; }
        public List<Atendimento> Atendimentos { get; set; }

        public void Update(string nome, string sobrenome, string crm, string especializacao)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CRM = crm;
            Especializacao = especializacao;
        }


    }
}
