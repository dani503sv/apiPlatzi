using CursoAPIsNET.Models;

namespace CursoAPIsNET.Services
{
    public interface IUserService
    {
        //Task es para operaciones asincronas realizadas en segundo plano}
        //IEnumerable es una colección que se puede recorrer
        //GetUsersAsync devuelve una colección de usuarios de forma asincrona
        Task<IEnumerable<User>> GetUsersAsync();

        //GetByAsync devuelve un usuario por su id de forma asincrona
        Task<User?> GetByAsync(int id);

        //CreateAsync crea un nuevo usuario de forma asincrona
        //User es el usuario que se va a crear
        Task<User> CreateAsync(User user);

        //Update y Delete podrían ser añadidos aquí en el futuro

        Task<User> UpdateAsync(User user);

        Task<User?> DeleteAsync(int id);
    }
}
