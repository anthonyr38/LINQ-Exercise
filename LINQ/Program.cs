namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {                 

            var vidGames = new List<string> { "Fall Guys", "Rocket League", "Paladins", "GTA-V", "Jurrasic Park", "Forza" };
            
            var byLength = vidGames.OrderBy(vidG => vidG.Length).ThenBy(vidG => vidG);

            foreach(var vidG in byLength) 
            {
                Console.WriteLine(vidG);
            }

        }
        
    }
}
