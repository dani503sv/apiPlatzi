using CursoAPIsNET.Data;
using CursoAPIsNET.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoAPIsNET.Services
{
    public class UserService : IUserService
    {
        //IUserService es la interfaz que define los métodos para gestionar usuarios.
        //readonly indica que la variable solo puede ser asignada en el constructor de la clase.
        //AppDbContext es el contexto de la base de datos que permite interactuar con los datos almacenados.
        private readonly AppDbContext _context;

        //Se recibe unicamente a través del constructor
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> CreateAsync(User user)
        {
            //Agrega un nuevo usuario al contexto de la base de datos.
            _context.Users.Add(user);

            //Guarda los cambios realizados en el contexto de la base de datos.
            //SaveChangesAsync es un método asíncrono que guarda los cambios en la base de datos.
            await _context.SaveChangesAsync();

            return user;
        }
        public async Task<User?> GetByAsync(int id)
        {
            //AsNoTracking mejora el rendimiento al evitar el seguimiento de cambios en las entidades recuperadas.
            //FirstOrDefault devuelve el primer elemento que cumple con la condición o null si no se encuentra ninguno.
            return await _context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            //AsNoTracking mejora el rendimiento al evitar el seguimiento de cambios en las entidades recuperadas.
            return await _context.Users.AsNoTracking().ToListAsync();
        }

        public async Task<User> UpdateAsync(User user) {

            //Update marca la entidad como modificada en el contexto de la base de datos.
            _context.Users.Update(user);
            //Guarda los cambios realizados en el contexto de la base de datos.
            await _context.SaveChangesAsync();
            //retorna el usuario actualizado.
            return user;
        }

        public async Task<User?> DeleteAsync(int id) {

            //Es para buscar el primer resultado que devuelva el mismo id
            var users = await _context.Users.FirstOrDefaultAsync(e => e.Id == id);

            //Buscamos que usuario buscado se encuentre en la base
            if (users != null)
            {
                //Removemos el usuario
                _context.Users.Remove(users);
                //Realizamos cambios en la data
                await _context.SaveChangesAsync();
                return users;
            }

            //Si no se encuentra el taskItem, se lanza una excepción.
            throw new Exception("TaskItem not found");
        }
    }
}
