using System.Text;

namespace DependencyInversion
{
    public class Logbook : ILookbook
    {
        public void Add(string description)
        {
            File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logbook.txt"), $"{description}\n", Encoding.Unicode);
        }
    }

    //Interfaz para el logbook
    //Sirve para abstraer la implementación del logbook
    public interface ILookbook
    {
        void Add(string description);
    }
}