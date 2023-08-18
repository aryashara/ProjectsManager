using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal;
{
    public class User
    {
        [Required]
        public int Id{get; set;}
        [Required]
        public string Name{get; set;}
        [Required]
        public string Email{get; set;}
        [Required]
        public string Password{get; set;}

        public User()
        {
            //Création d'un utilisateur
            User user = new User()
            
            user.Id = Id; 
            user.Name = Name;
            user.Email = Email;
            user.Password = Password;

        }

    }
}