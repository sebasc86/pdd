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


        public  async Task<Detail> GetDetailID(int Id)
        {


            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetDetail(Id);


        }

        public async Task<List<Detail>> GetDetails()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            return await remoteService.GetAllDetails();


        }

        public async Task<Detail> SaveDetail(Detail valor)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");


            return await remoteService.CreateDetail(valor);
        }




        public async Task<bool> Delete(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44375/api/");
            await remoteService.DeleteTasks(id);
            return true;
        }


    }
}
