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
    public class CreateUserCommandHandler
    {
        private readonly IRepository<User> _repository;
        public CreateUserCommandHandler(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateUserCommand command)
        {
            await _repository.CreateAsync(new User
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                Address = command.Address
            });
        }
    }
}
