using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
     class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static /*UserViewModel*/ explicit operator UserViewModel(User user)
        {
            string[]? Names = user.Name ?.Split(" ");
            return new UserViewModel
            {
                Id = user.Id,
                FirstName = Names?.Length > 0 ? Names[0] : string.Empty,
                LastName = Names?.Length > 1 ? Names[1] : string.Empty,
                Email=user.Email??string.Empty,
                Password= user.Password??string.Empty
            };
        }
    }
}
