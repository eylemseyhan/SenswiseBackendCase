using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Application.Features.CQRS.Queries;
using UserManagement.Application.Features.CQRS.Results;
using UserManagement.Application.Interfaces;
using UserManagement.Domain.Entities;

namespace UserManagement.Application.Features.CQRS.Handlers.ReadHandlers
{
    public class GetUserByIdQueryHandler
    {
        private readonly IRepository<User> _repository;
        public GetUserByIdQueryHandler(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<GetUserByIdQueryResult> Handle(GetUserByIdQuery query)
        {
            var user = await _repository.GetByIdAsync(query.UserId);

            return new GetUserByIdQueryResult
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,

            };
        }
    }
}
