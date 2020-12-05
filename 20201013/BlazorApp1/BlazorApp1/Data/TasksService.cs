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



        public static async Task<Tasks> GetTaskID(int Id)
        {

            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetTasks(Id);


        }

        public static async Task<List<Tasks>> GetTasks()
        {
    
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetAllTasks();


        }




        public async Task<Tasks> SaveTasks(Tasks valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            

            return await remoteService.CreateTasks(valor);
        }



             

        public async Task<List<Resource>> GetResource()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetAllResources();
        }


        public async Task<bool> Delete(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            await remoteService.DeleteTasks(id);
            return true;
        }


    }
}
