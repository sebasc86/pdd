using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp1.Data
{
    public class DetailService
    {

        private DataContext context;


        public DetailService(DataContext _context)
        {
            context = _context;
        }

        public Detail[] GetDetails()
        {

            Detail[] result = new Detail[2];
            
            return result;                      
                     
        }

        public  async Task<Detail> GetDetailID(int Id)
        {
            var ctx = new DataContext();
            return await ctx.Details.Where(i => i.Id == Id).FirstOrDefaultAsync();
           // Console.WriteLine($"-----Fetch Task----- \nTitulo: {task.Title} - Expiracion: {task.Expiration} - Estado: {task.State}");
            

        }

        public async Task<List<Detail>> FetchDetails()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetAllDetails();

            /*var ctx = new DataContext();
           return ctx.Details.Include(i=>i.Task).Include(i => i.Resource).ToList();*/

        }



        public async Task<Detail> UpdateDetail(Detail value)
        {
            var ctx = new DataContext();

            if (value.Id == 0)
            {
                await ctx.Details.AddAsync(value);
            }
            else
            {
                ctx.Details.Update(value);
            }

            await ctx.SaveChangesAsync();
            return value;
        }


        public async Task<bool> Delete(int Id)
        {
            var ctx = new DataContext();
            Detail detail = await ctx.Details.Where(i => i.Id == Id).SingleAsync();

            ctx.Details.Remove(detail);
        

            await ctx.SaveChangesAsync();
            return true;
        }



    }
}
