namespace WebAppDETAug2022.Services
{
    public interface IHelo
    {
        string SayHelo(string name); 
    }
    public class Helo1 : IHelo
    {
        public string SayHelo(string name)
        {
            return $"Helo {name},welcome to ASP.net core";
        }
    }
    public class Helo2 : IHelo
    {
        public string SayHelo(string name)
        {
            return $"Helo,How are you{name}";
        }
    }

}
