using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Application.Features.CQRS.Commands;
using UserManagement.Application.Features.CQRS.Handlers.ReadHandlers;
using UserManagement.Application.Features.CQRS.Handlers.WriteHandlers;
using UserManagement.Application.Features.CQRS.Queries;


namespace UserManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CreateUserCommandHandler _createUserCommandHandler;
        private readonly GetUserByIdQueryHandler _getUserByIdQueryHandler;
        private readonly GetUserQueryHandler _getUserQueryHandler;
        private readonly UpdateUserCommandHandler _updateUserCommandHandler;
        private readonly RemoveUserCommandHandler _removeUserCommandHandler;

        public UsersController(CreateUserCommandHandler createUserCommandHandler, GetUserByIdQueryHandler getUserByIdQueryHandler, GetUserQueryHandler getUserQueryHandler, UpdateUserCommandHandler updateUserCommandHandler, RemoveUserCommandHandler removeUserCommandHandler)
        {
            _createUserCommandHandler = createUserCommandHandler;
            _getUserByIdQueryHandler = getUserByIdQueryHandler;
            _getUserQueryHandler = getUserQueryHandler;
            _updateUserCommandHandler = updateUserCommandHandler;
            _removeUserCommandHandler = removeUserCommandHandler;
        
        }
        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            var users = await _getUserQueryHandler.Handle();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _getUserByIdQueryHandler.Handle(new GetUserByIdQuery(id));
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {

           await _createUserCommandHandler.Handle(command);
            return Ok("Kullanıcı eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserCommand command)
        {
            await _updateUserCommandHandler.Handle(command);
            return Ok("Kullanıcı güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _removeUserCommandHandler.Handle(new RemoveUserCommand(id));
            return Ok("Kullanıcı silindi");
        }

    }

}
