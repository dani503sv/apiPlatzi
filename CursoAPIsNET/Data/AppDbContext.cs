using CursoAPIsNET.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoAPIsNET.Data
{
    public class AppDbContext : DbContext
    {
        //Propiedad que representa la tabla de tareas en la base de datos
        //DbSet es una colección de entidades que se pueden consultar desde la base de datos
        public DbSet<User> Users => Set<User>();
        public DbSet<TaskItem> TaskItems => Set<TaskItem>();

        //Constructor que recibe opciones de configuración para el contexto de la base de datos
        //DbContextOptions permite configurar aspectos como la cadena de conexión y el proveedor de base de datos
        public AppDbContext(DbContextOptions option) : base(option) { 
            
        }

        //Método que se utiliza para configurar el modelo de datos
        //ModelBuilder proporciona una forma de configurar las entidades y sus relaciones
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //realiza configuraciones adicionales para las entidades si es necesario
            //OnModelCreating se llama cuando se crea el modelo de datos
            base.OnModelCreating(modelBuilder);

            //Configuración para la entidad User
            modelBuilder.Entity<User>(entity =>
            {
                //ToTable especifica el nombre de la tabla en la base de datos
                entity.ToTable("Users");
                //HasKey define la clave primaria de la entidad
                entity.HasKey(e => e.Id);
                //Property configura las propiedades de la entidad
                //e es una instancia de la entidad User
                entity.Property(e => e.Email).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Username).IsRequired().HasMaxLength(100);

            });

            //Configuración para la entidad TaskItem

            modelBuilder.Entity<TaskItem>(entity => {

                //Definir la tabla 
                entity.ToTable("TaskItems");
                //Definir la clave primaria
                entity.HasKey(e => e.Id);
                //Configurar las propiedades
                entity.Property(e => e.Title).IsRequired().HasMaxLength(300);
                entity.Property(e => e.IsCompleted).IsRequired().HasDefaultValue(false);

                //Configurar la relación entre TaskItem y User
                //HasOne indica que TaskItem tiene una relación con una entidad User
                //WithMany indica que un User puede tener muchas TaskItems
                //DeleteBehavior.Cascade significa que si se elimina un User, también se eliminarán sus TaskItems asociadas
                entity.HasOne(e => e.User).WithMany(w => w.Tasks).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Cascade);
            });
        }


    }
}
