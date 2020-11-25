using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1.Entidades
{
    public class Tasks
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Expiration { get; set; }
        public string Estimate { get; set; }
        public string State { get; set; }
        public int ResourceId { get; set; }
        public Resource Resource { get; set; }

        public Tasks()
        {

        }

        public Tasks(string title, DateTime Expiration, string estimate, string state, Resource resource)
        {

            this.Title = title;
            this.Expiration = DateTime.Now;
            this.Estimate = estimate;
            this.State = state;
            this.Resource = resource;
        }




        //public int ResourceId { get; set; }
        //public Resource Liable { get; set; }



    }
}
