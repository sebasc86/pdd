using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(string name, string lastName, string password)
        {

            Name = name;
            LastName = lastName;
            Password = password;
        }




        //public int ResourceId { get; set; }
        //public Resource Liable { get; set; }



    }
}
