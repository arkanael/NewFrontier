﻿using Flunt.Notifications;
using Flunt.Validations;
using NewFrontier.Domain.Contracts.Commands;
using System;

namespace NewFrontier.Domain.Commands
{
    public class AtualizarMedicoCommand : Notifiable, ICommand
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CRM { get; set; }
        public string Especializacao { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotEmpty(Id, "ID", "Erro ao obter o id.")

                .HasMinLengthIfNotNullOrEmpty(Nome, 2, "Nome", "O nome deve ter no mínimo 2 caracteres.")
                .HasMaxLengthIfNotNullOrEmpty(Nome, 25, "Nome", "O nome não deve ter no máximo 25 caracteres.")

                .HasMinLengthIfNotNullOrEmpty(Sobrenome, 2, "Sobrenome", "O sobrenome deve ter no mínimo 2 caracteres.")
                .HasMaxLengthIfNotNullOrEmpty(Sobrenome, 25, "Sobrenome", "O sobrenome não deve ter no máximo 25 caracteres.")

                .HasExactLengthIfNotNullOrEmpty(CRM, 4, "CRM", "O crm precisa ter 4 caracteres")

                .HasMaxLen(Especializacao, 50, "Especializacao", "A especialização precisa ter no máximo 50 caracteres"));
        }

        
    }
}
