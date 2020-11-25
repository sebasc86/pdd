using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Data;
using Refit;

namespace BlazorApp1.Data
{
    public class UserService
    {

        private DataContext context;


        public UserService(DataContext _context)
        {
            context = _context;
        }

        public User[] GetUsers()
        {

            User[] result = new User[2];
            
            return result;                      
                     
        }

        public static async Task<User> GetUserID(int Id)
        {
            var ctx = new DataContext();
            return await ctx.Users.Where(i => i.Id == Id).FirstOrDefaultAsync();

            

        }

        public async Task<List<User>> FetchUser()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetAllUsers();

        }


        public async Task<User> UpdateUser(User value)
        {
            var ctx = new DataContext();

            if (value.Id == 0)
            {
                await ctx.Users.AddAsync(value);
            }
            else
            {
                ctx.Users.Update(value);
            }

            await ctx.SaveChangesAsync();
            return value;
        }


        public async Task<bool> Delete(int Id)
        {
            var ctx = new DataContext();
            User user = await ctx.Users.Where(i => i.Id == Id).SingleAsync();

            ctx.Users.Remove(user);
        

            await ctx.SaveChangesAsync();
            return true;
        }

        public async Task<List<Tasks>> GetTasks()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:44375/api/Tasks");

            return await remoteService.GetAllTasks();
        }



    }
}
