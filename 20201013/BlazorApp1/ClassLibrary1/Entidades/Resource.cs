using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1.Entidades
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


        public Resource()
        {

        }

        public Resource(string name, int UserId)
        {

       
            Name = name;
            this.UserId = UserId;
            
        }




      



    }
}
