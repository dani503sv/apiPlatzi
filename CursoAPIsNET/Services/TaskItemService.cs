using CursoAPIsNET.Data;
using CursoAPIsNET.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CursoAPIsNET.Services
{
    public class TaskItemService : ITaskItemService
    {
        //Se recibe unicamente a través del constructor
        private readonly AppDbContext _context;

        public TaskItemService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TaskItem> CreateAsync(TaskItem taskItem)
        {
            //Agrega un nuevo taskItem al contexto de la base de datos.
            _context.TaskItems.Add(taskItem);
            //Guarda los cambios realizados en el contexto de la base de datos.
            //SaveChangesAsync es un método asíncrono que guarda los cambios en la base de datos.
            await _context.SaveChangesAsync();
            return taskItem;
        }

        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            //AsNoTracking mejora el rendimiento al evitar el seguimiento de cambios en las entidades recuperadas.
            return await _context.TaskItems.AsNoTracking().ToListAsync();
        }


        public async Task<TaskItem?> GetByTaskItemAsync(int id)
        {
            //AsNoTracking mejora el rendimiento al evitar el seguimiento de cambios en las entidades recuperadas.
            return await _context.TaskItems.FirstOrDefaultAsync(e => e.Id == id);

        }

        public async Task<TaskItem> UpdateAsync(TaskItem taskItem) {

            //Marca la entidad taskItem como modificada en el contexto de la base de datos.
            _context.TaskItems.Update(taskItem);

            //Guarda los cambios realizados en el contexto de la base de datos.
            await _context.SaveChangesAsync();
            return taskItem;
        }

        public async Task<TaskItem?> DeleteAsync(int id) {

            //Busca el primer TaskItem en la base de datos que coincida con el id proporcionado.
            var taskItem = await _context.TaskItems.FirstOrDefaultAsync(e => e.Id == id);

            //Si se encuentra el taskItem, se procede a eliminarlo.
            if (taskItem!=null) { 
                _context.TaskItems.Remove(taskItem);
                await _context.SaveChangesAsync();
                return taskItem;
            }

            //Si no se encuentra el taskItem, se lanza una excepción.
            throw new Exception("TaskItem not found");
        }

       


    }
}
