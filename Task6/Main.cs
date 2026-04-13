using Task6.Game;
namespace Task6
{
class MainClass
{
    public static async Task Main()
    {
            var announce = new Announce();
            await announce.score.UpdateScore();
    }
}
   
}