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

      

        public static async Task<User> GetUserID(int Id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetUser(Id);


        }

        public async Task<List<User>> GetUsers()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetAllUsers();

        }

        public async Task<User> SaveUser(User valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");

            return await remoteService.CreateUser(valor);
        }

        //public async Task<bool> Delete(int Id)
        //{
        //    var ctx = new DataContext();
        //    User user = await ctx.Users.Where(i => i.Id == Id).SingleAsync();

        //    ctx.Users.Remove(user);


        //    await ctx.SaveChangesAsync();
        //    return true;
        //}


        public async Task<bool> DeleteUserId(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            await remoteService.DeleteUser(id);
            return true;
        }



    }
}
