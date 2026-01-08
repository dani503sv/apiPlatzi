namespace CursoAPIsNET.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Title { get; set; } = default;

        // Indica si la tarea está completada o no
        public bool IsCompleted { get; set; }

        public int UserId { get; set; }

        // Propiedad de navegación para la relación con el usuario
        public User? User { get; set; }
    }
}
