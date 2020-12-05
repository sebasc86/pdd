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

        public async Task<bool> Delete(int Id)
        {
            var ctx = new DataContext();
            User user = await ctx.Users.Where(i => i.Id == Id).SingleAsync();

            ctx.Users.Remove(user);


            await ctx.SaveChangesAsync();
            return true;
        }



        //public async Task<User> UpdateUser(User value)
        //{
        //    var ctx = new DataContext();

        //    if (value.Id == 0)
        //    {
        //        await ctx.Users.AddAsync(value);
        //    }
        //    else
        //    {
        //        ctx.Users.Update(value);
        //    }

        //    await ctx.SaveChangesAsync();
        //    return value;
        //}

        ///*Task*/

        //public async Task<Tasks> GetTasksId(int Id)
        //{

        //    var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
        //    return await remoteService.GetTasks(Id);

        //}

        //public async Task<List<Tasks>> GetTasks()
        //{
        //    var remoteService = RestService.For<IRemoteService>("http://localhost:44375/api/");

        //    return await remoteService.GetAllTasks();


        //}



        //public async Task<bool> Delete(int Id)
        //{
        //    var ctx = new DataContext();
        //    User user = await ctx.Users.Where(i => i.Id == Id).SingleAsync();

        //    ctx.Users.Remove(user);


        //    await ctx.SaveChangesAsync();
        //    return true;
        //}





        //public async Task<Tasks> SaveTask(Tasks valor)
        //{
        //    var remoteService = RestService.For<IRemoteService>("http://localhost:44375/api/");

        //    return await remoteService.CreateTasks(valor);
        //}

        ///*Details*/



        //public async Task<List<Detail>> GetDetails()
        //{
        //    var remoteService = RestService.For<IRemoteService>("http://localhost:44375/api/");

        //    return await remoteService.GetAllDetails();


        //}

        //public async Task<Detail> GetDetailId(int Id)
        //{

        //    var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
        //    return await remoteService.GetDetail(Id);

        //}



        //public async Task<Detail> SaveDetail(Detail valor)
        //{
        //    var remoteService = RestService.For<IRemoteService>("http://localhost:44375/api/");

        //    return await remoteService.CreateDetail(valor);
        //}

        ///*Resource*/

        //public async Task<List<Resource>> GetResources()
        //{
        //    var remoteService = RestService.For<IRemoteService>("http://localhost:44375/api/");

        //    return await remoteService.GetAllResources();


        //}

        //public async Task<Resource> GetResourceId(int Id)
        //{

        //    var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
        //    return await remoteService.GetResource(Id);

        //}



        //public async Task<Resource> SaveDetail(Resource valor)
        //{
        //    var remoteService = RestService.For<IRemoteService>("http://localhost:44375/api/");

        //    return await remoteService.CreateResource(valor);


        //}
    }
}
