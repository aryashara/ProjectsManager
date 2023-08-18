using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal
{

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            //Création d'un utilisateur
            User user = new User();


            user.Id = Id;
            user.Name = Name;
            user.Email = Email;
            user.Password = Password;

        }

    }
}