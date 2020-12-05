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

        

        public async Task<Resource> GetResourceID(int Id)
        {


            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetResource(Id);



        }

        public static async Task<List<Resource>> GetResources()
        {
        

            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetAllResources();

        }

        public async Task<Resource> SaveResource(Resource valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");

            return await remoteService.CreateResource(valor);
        }


        public async Task<bool> Delete(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            await remoteService.DeleteResource(id);
            return true;
        }


        public async Task<List<User>> GetUser()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetAllUsers();
        }



    }
}
