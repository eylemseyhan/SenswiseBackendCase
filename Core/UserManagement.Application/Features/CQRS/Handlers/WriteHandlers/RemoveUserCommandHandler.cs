using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Application.Features.CQRS.Commands;
using UserManagement.Application.Interfaces;
using UserManagement.Domain.Entities;

namespace UserManagement.Application.Features.CQRS.Handlers.WriteHandlers
{
    public class RemoveUserCommandHandler
    {
        private readonly IRepository<User> _repository;
        public RemoveUserCommandHandler(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveUserCommand command)
        {
            var user = await _repository.GetByIdAsync(command.UserId);
            await _repository.RemoveAsync(user);

        }
    }
}
