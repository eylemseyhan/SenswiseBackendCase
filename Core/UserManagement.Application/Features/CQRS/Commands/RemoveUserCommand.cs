using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Application.Features.CQRS.Commands
{
    public class RemoveUserCommand
    {
        public RemoveUserCommand(int userId)
        {
            UserId = userId;
        }

        public int UserId { get; set; }
    }
}
