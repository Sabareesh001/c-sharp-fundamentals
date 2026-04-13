namespace Task6.Game
{
    public class Score(int point)
    {
        private int points = point;

        public delegate void AchievementUnlocked(int point);
        public event AchievementUnlocked? AchievementUnlockedEvent;
        public async Task UpdateScore()
        {
            await Task.Delay(1000);
            points += 20;
            Console.WriteLine("Scored 20 more points");
            await Task.Delay(1000);
            points += 30;
            Console.WriteLine("Scored 30 more points");
            await Task.Delay(1000);
            points += 30;
            Console.WriteLine("Scored 30 more points");
            if (points > 50)
            {
                AchievementUnlockedEvent?.Invoke(points);
            }
        }
    }
}