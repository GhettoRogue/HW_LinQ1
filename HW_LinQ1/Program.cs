var squad = new List<Soldier>
{
    new Soldier("John", "Desert Eagle", "Second lieutenant", 6),
    new Soldier("Mike", "Desert Eagle", "Second lieutenant", 6),
    new Soldier("Tobias", "M4-A1", "Captain", 12),
    new Soldier("Mark", "M4-S", "Captain", 18),
    new Soldier("Noah", "Sniper riffle", "Major", 24),
    new Soldier("Ethan", "Sniper riffle", "Major", 30),
};

var nameAndRank = from n in squad
    select new { n.Name , n.Rank };

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
foreach (var item in squad)
{
    Console.WriteLine($"{item.Name} : {item.Rank}");
}
Console.ResetColor();
Console.WriteLine();

internal record class Soldier(string Name, string Weapon, string Rank, int LifeTime);