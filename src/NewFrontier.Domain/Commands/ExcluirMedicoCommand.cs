using Flunt.Notifications;
using Flunt.Validations;
using NewFrontier.Domain.Contracts.Commands;
using System;

namespace NewFrontier.Domain.Commands
{
    public class ExcluirMedicoCommand: Notifiable, ICommand
    {
        public Guid Id { get; set; }


        public void Validate()
        {
            AddNotifications(new Contract()
               .Requires()
               .IsNotEmpty(Id, "ID", "Erro ao obter o id."));
        }
    }
}
