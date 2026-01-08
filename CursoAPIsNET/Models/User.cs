namespace CursoAPIsNET.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; } = default;
        public string? Email { get; set; } = default;

        // Propiedad de navegación para la relación con las tareas
        //ICollection permite representar una colección de objetos TaskItem asociados a este usuario
        public ICollection<TaskItem> Tasks = new List<TaskItem>();
    }
}
