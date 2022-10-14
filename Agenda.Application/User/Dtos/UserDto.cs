using Agenda.Application.Generic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Application.User.Dtos
{
    public class UserDto : BaseDto
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        
    }
}
