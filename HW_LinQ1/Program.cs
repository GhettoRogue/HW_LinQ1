var squad = new List<Soldier>
{
    new("John", "Desert Eagle", "Second lieutenant", 6),
    new("Mike", "Desert Eagle", "Second lieutenant", 6),
    new("Tobias", "M4-A1", "Captain", 12),
    new("Mark", "M4-S", "Captain", 18),
    new("Noah", "Sniper riffle", "Major", 24),
    new("Ethan", "Sniper riffle", "Major", 30),
};

var nameAndRank = from n in squad
    select new { n.Name, n.Rank };

Console.ForegroundColor = ConsoleColor.Green;
foreach (var item in squad)
{
    Console.WriteLine($"{item.Name} : {item.Rank}");
}

Console.ResetColor();

internal record class Soldier(string Name, string Weapon, string Rank, int LifeTime);