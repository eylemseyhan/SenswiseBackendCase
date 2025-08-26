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
    public class UpdateUserCommandHandler
    {
        private readonly IRepository<User> _repository;
        public UpdateUserCommandHandler(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateUserCommand command)
        {
            var user = await _repository.GetByIdAsync(command.UserId);
            user.FirstName = command.FirstName;
            user.LastName = command.LastName;
            user.Email = command.Email;
            user.Address = command.Address;
            await _repository.UpdateAsync(user);

        }
    }
}
