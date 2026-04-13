using Task6.Game;
namespace Task6.Game
{

public class Announce
{
        public Score score;


        public Announce()
        {
            score = new Score(4);
            score.AchievementUnlockedEvent += Congratulate;
        }
        public static void Congratulate(int score)
        {
            Console.WriteLine($"Yayy you scored {score}");
        }
    }
    
}