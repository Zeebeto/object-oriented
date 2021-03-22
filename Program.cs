using System;

namespace object_oriented
{
    class Program
    {

        static void Main(string[] args)
        {
            helpText();
            var userInput = Console.ReadLine();
            if (userInput == "h" || userInput == "a" || userInput == "t")
            { 
                match m1 = new match(true, userInput.ToUpper());
                while (m1.isMatchrunning) { playMatch(m1); showResult(m1); }
            }
            else
            {
                helpText();
            }
        }
        private static void playMatch(match m1)
        {
            Random rng = new Random();
            int chance = rng.Next(1, 11);
            for (int i = 0; i< chance;i++) 
            {
                int hundred = rng.Next(1, 101);
                var goals = hundred < 33 ? m1.homeScore++ : hundred > 66 ? m1.awayScore++ : m1.misses++;
            }
            m1.isMatchrunning = false;
        }
        private static void showResult(match m1)
        {
            var calcResult = m1.homeScore == m1.awayScore ? "T" : m1.homeScore > m1.awayScore ? "H" : "A";
            if (calcResult == "H") m1.endResult = "home team wins";
            if (calcResult == "A") m1.endResult = "away team wins";
            if (calcResult == "T") m1.endResult = "its a tie";
            Console.WriteLine("final score:");
            Console.WriteLine($"  {m1.homeScore}:{m1.awayScore}");
            Console.WriteLine(m1.endResult);
            Console.WriteLine($"you bet: {m1.userBet}");
            if (m1.userBet == calcResult) Console.WriteLine("you was right");
            else Console.WriteLine("you was wrong, unlucky");
            
        }
        private static void helpText()
        {
            Console.WriteLine(@"
valid bets:
    - H (home team victory)
    - A (away team victory)
    - T (both teams tied)
");
        }
        private static void showObj(match m1)
        {
            Console.Write($@"
object contains:
        {m1.isMatchrunning}
        {m1.homeScore}
        {m1.awayScore}
        {m1.userBet}
        {m1.endResult}
        ");
        }
    }
}
