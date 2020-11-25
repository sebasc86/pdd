using System;
using Refit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface IRemoteService
    {

        [Get("/Tasks")]
        Task<List<Tasks>> GetAllTasks();

        [Get("/User")]
        Task<List<User>> GetAllUsers();

        [Get("/Detail")]
        Task<List<Detail>> GetAllDetails();

        [Get("/Resource")]
        Task<List<Resource>> GetAllResources();
    }
}
