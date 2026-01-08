using CursoAPIsNET.Models;

namespace CursoAPIsNET.Services
{
    public interface ITaskItemService
    {
        //Task es para operaciones asincronas realizadas en segundo plano
        //IEnumerable es una colección que se puede recorrer
        Task<IEnumerable<TaskItem>> GetTaskItemsAsync();

        //Devuelve un TaskItem o null si no lo encuentra
        Task<TaskItem?> GetByTaskItemAsync(int id);

        //Crea un nuevo TaskItem
        Task<TaskItem> CreateAsync(TaskItem tasks);

        //Update y Delete podrían ser añadidos aquí en el futuro

        Task<TaskItem> UpdateAsync(TaskItem taskItem);

        Task<TaskItem?> DeleteAsync(int id);
    }
}
