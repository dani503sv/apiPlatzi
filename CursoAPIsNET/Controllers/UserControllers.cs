using CursoAPIsNET.Models;
using CursoAPIsNET.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CursoAPIsNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserControllers : ControllerBase
    {
        //Inyección de dependencia del servicio de usuario
        //Interfaz creado por IUserService
        private readonly IUserService _userService;

        //Constructor que recibe una instancia de IUserService
        public UserControllers(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL() 
        {
            //Llamada al servicio para obtener todos los usuarios
            var user = await _userService.GetUsersAsync();
            //Devuelve una respuesta HTTP 200 OK con la lista de usuarios obtenida
            return Ok(user);
        }

        //Obtiene un usuario por su ID
        [HttpGet]
        [Route("{id:int}")]
        //se IActionResult para devolver diferentes tipos de respuestas HTTP
        public async Task<IActionResult> GetUserId(int id) 
        {
            //Llamada al servicio para obtener un usuario por su ID
            var user = await _userService.GetByAsync(id);
            //Devuelve una respuesta HTTP 200 OK con el usuario obtenido
            if(user is null)
                //si es nulo devuelve un 404 Not Found
                return NotFound();
            return Ok(user);
        }

        //Crea un nuevo usuario
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user) {

            //Llamada al servicio para crear un nuevo usuario
            var createUser = await _userService.CreateAsync(user);
            //Devuelve una respuesta HTTP 200 OK con el usuario creado
            //CreatedAtAction permite devolver una respuesta HTTP 201 Created
            //nameof se utiliza para obtener el nombre del método Created
            return CreatedAtAction(nameof(GetUserId), new {id = createUser.Id }, createUser);
        }

        //Actualiza un usuario existente
        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] User user) 
        {
            //Llamada al servicio para actualizar un usuario existente
            var update = await _userService.UpdateAsync(user);
            //Devuelve una respuesta HTTP 200 OK con el usuario actualizado
            return Ok(update);
            
        }

        //Elimina un usuario por su ID
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUser(int id) 
        {
            //Llamada al servicio para eliminar un usuario por su ID
            var delete = await _userService.DeleteAsync(id);
            //Devuelve una respuesta HTTP 200 OK con el resultado de la eliminación
            return Ok(delete);
        }

    }
}
