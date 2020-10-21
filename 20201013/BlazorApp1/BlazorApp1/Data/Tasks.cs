using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Expiration { get; set; }
        public string Estimate { get; set; }
        public string State { get; set; }

        public Tasks()
        {

        }

        public Tasks(int id, string title, DateTime expiration, string estimate, string state)
        {
            Id = id;
            Title = title;
            Expiration = expiration;
            Estimate = estimate;
            State = state;
        }


        //public int ResourceId { get; set; }
        //public Resource Liable { get; set; }



    }
}
