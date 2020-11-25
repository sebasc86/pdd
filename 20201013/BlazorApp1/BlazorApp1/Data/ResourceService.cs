using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp1.Data
{
    public class ResourceService
    {

        private DataContext context;


        public ResourceService(DataContext _context)
        {
            context = _context;
        }

        public Resource[] GetResources()
        {

            Resource[] result = new Resource[2];
            
            return result;                      
                     
        }

        public async Task<Resource> GetResourcID(int Id)
        {
            var ctx = new DataContext();
            return await ctx.Resources.Where(i => i.Id == Id).FirstOrDefaultAsync();
           // Console.WriteLine($"-----Fetch Task----- \nTitulo: {task.Title} - Expiracion: {task.Expiration} - Estado: {task.State}");
            

        }

        public static async Task<List<Resource>> FetchResurce()
        {
            /*var ctx = new DataContext();
            return ctx.Resources.Include(i=>i.User).ToList();*/

            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetAllResources();

        }


        public async Task<Resource> UpdateResource(Resource value)
        {
            var ctx = new DataContext();

            if (value.Id == 0)
            {
                await ctx.Resources.AddAsync(value);
            }
            else
            {
                ctx.Resources.Update(value);
            }

            await ctx.SaveChangesAsync();
            return value;
        }


        public async Task<bool> Delete(int Id)
        {
            var ctx = new DataContext();
            Resource task = await ctx.Resources.Where(i => i.Id == Id).SingleAsync();

            ctx.Resources.Remove(task);
        

            await ctx.SaveChangesAsync();
            return true;
        }

        public async Task<List<User>> GetUser()
        {
            var ctx = new DataContext();
            return await ctx.Users.ToListAsync();
        }



    }
}
