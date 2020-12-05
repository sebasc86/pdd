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

        [Get("/Tasks/{id}")]
        Task<Tasks> GetTasks(int id);

        [Post("/Tasks")]
        Task<Tasks> CreateTasks(Tasks valor);

        [Delete("/Tasks/{id}")]
        Task<Tasks> DeleteTasks(int id);



        [Get("/User")]
        Task<List<User>> GetAllUsers();

        [Get("/User/{id}")]
        Task<User> GetUser(int id);

        [Post("/User")]
        Task<User> CreateUser(User valor);

        [Delete("/User/{id}")]
        Task<User> DeleteUser(int id);


        [Get("/Detail")]
        Task<List<Detail>> GetAllDetails();

        [Get("/Detail/{id}")]
        Task<Detail> GetDetail(int id);

        [Post("/Detail")]
        Task<Detail> CreateDetail(Detail valor);

        [Delete("/Detail/{id}")]
        Task<Detail> DeleteDetail(int id);



        [Get("/Resource")]
        Task<List<Resource>> GetAllResources();

        [Get("/Resource/{id}")]
        Task<Resource> GetResource(int id);

        [Post("/Resource")]
        Task<Resource> CreateResource(Resource valor);

        [Delete("/Resource/{id}")]
        Task<Resource> DeleteResource(int id);


    }
}
