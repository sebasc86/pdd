using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp1.Data
{
    public class TasksService
    {

        private DataContext context;


        public TasksService(DataContext _context)
        {
            context = _context;
        }

        public Tasks[] GetTasks()
        {

            Tasks[] result = new Tasks[2];
            
            return result;                      
                     
        }

        public static List<Tasks> FetchTasks()
        {
            var ctx = new DataContext();
            return ctx.Tasks.ToList();
                      

            
        }

    }
}
