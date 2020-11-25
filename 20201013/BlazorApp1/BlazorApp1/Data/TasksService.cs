using Microsoft.EntityFrameworkCore;
using Refit;
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

        public static async Task<Tasks> GetTaskID(int Id)
        {
            var ctx = new DataContext();
            return await ctx.Tasks.Where(i => i.Id == Id).FirstOrDefaultAsync();
            // Console.WriteLine($"-----Fetch Task----- \nTitulo: {task.Title} - Expiracion: {task.Expiration} - Estado: {task.State}");


        }

        public static async Task<List<Tasks>> FetchTasks()
        {
           /* var ctx = new DataContext();
            return ctx.Tasks.Include(i=>i.Resource).ToList();*/
            //return await ctx.Tareas.Include(i => i.Responsable).ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetAllTasks();


        }


        public async Task<Tasks> UpdateTask(Tasks value)
        {
            var ctx = new DataContext();

            if (value.Id == 0)
            {
                await ctx.Tasks.AddAsync(value);
            }
            else
            {
                ctx.Tasks.Update(value);
            }

            await ctx.SaveChangesAsync();
            return value;
        }


        public async Task<bool> Delete(int Id)
        {
            var ctx = new DataContext();
            Tasks task = await ctx.Tasks.Where(i => i.Id == Id).SingleAsync();

            ctx.Tasks.Remove(task);


            await ctx.SaveChangesAsync();
            return true;
        }

        public async Task<List<Resource>> GetResource()
        {
            var ctx = new DataContext();
            return await ctx.Resources.ToListAsync();
        }



    }
}
