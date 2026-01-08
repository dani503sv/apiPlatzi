using CursoAPIsNET.Models;
using CursoAPIsNET.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CursoAPIsNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemController : ControllerBase
    {
        //Inyección de dependencia del servicio de TaskItem
        private readonly ITaskItemService _taskItemService;

        //Constructor que recibe una instancia de ITaskItemService
        public TaskItemController(ITaskItemService taskItemService) {
            _taskItemService = taskItemService;
        }

        //Obtiene todos los TaskItems
        [HttpGet]
        public async Task<IActionResult> GetALL() 
        {
            //Llamada al servicio para obtener todos los TaskItems
            var taskItem = await _taskItemService.GetTaskItemsAsync();
            //Devuelve una respuesta HTTP 200 OK con la lista de TaskItems obtenida
            return Ok(taskItem);
        }

        //Obtiene el UserId asociado a un TaskItem específico por su id
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetTaskItemId(int id) 
        {
            //Llamada al servicio para obtener el UserId asociado al TaskItem con el id proporcionado
            var taskItemId = await _taskItemService.GetByTaskItemAsync(id);
           
            //Devuelve una respuesta HTTP 200 OK con el UserId obtenido
            if(taskItemId is null)
                //si es nulo devuelve un 404 not found
                return NotFound();  
            return Ok(taskItemId);

        }

        //Crea un nuevo TaskItem
        [HttpPost]
        public async Task<IActionResult> CreateTaskItem([FromBody] TaskItem task) 
        {
            //Llamada al servicio para crear un nuevo TaskItem
            var created = await _taskItemService.CreateAsync(task);
            //Devuelve una respuesta HTTP 201 Created con la ubicación del nuevo TaskItem creado
            return CreatedAtAction(nameof(GetALL), new{id = created.Id }, created);
        }

        //Actualiza un TaskItem existente
        [HttpPut]
        public async Task<IActionResult> UpdateTaskItem([FromBody] TaskItem task) 
        {
            //Llamada al servicio para actualizar un TaskItem existente
            var update = await _taskItemService.UpdateAsync(task);
            //Devuelve una respuesta HTTP 200 OK con el TaskItem actualizado
            return Ok(update);
        }

        //Elimina un TaskItem por su id
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteTaskItem(int id) 
        {
            //Llamada al servicio para eliminar el TaskItem con el id proporcionado
            var delete = await _taskItemService.DeleteAsync(id);
            //Devuelve una respuesta HTTP 200 OK con el resultado de la eliminación
            return Ok(delete);
        }
        
    }
}
