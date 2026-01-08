namespace InterfaceSegregation
{
    public class Arquitect : IActivities
    {
        public Arquitect()
        {
        }

        public void Plan() 
        {
            Console.WriteLine("I'm planning the tasks to be done");
        }

        public void Comunicate()
        { 
            Console.WriteLine("I'm talking to the team user");
        }
        
        public void Design() 
        {
            Console.WriteLine("I'm designing new futures");
        }

        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

        public void Test() 
        {
            throw new ArgumentException();
        }
    }   
    

}
