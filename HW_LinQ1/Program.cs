using HW_LinQ1;

var squad = new List<Soldier>
{
    new("John", "Desert Eagle", "Second lieutenant", 6),
    new("Mike", "Desert Eagle", "Second lieutenant", 6),
    new("Tobias", "M4-A1", "Captain", 12),
    new("Mark", "M4-S", "Captain", 18),
    new("Noah", "Sniper riffle", "Major", 24),
    new("Ethan", "Sniper riffle", "Major", 30),
};

ShowLifeTime();

return;

IEnumerable<Soldier> LifeTime()
{
    var lifeTime = from s in squad
        where s.LifeTime <= 6
        where s.Rank == "Second lieutenant"
        select s;
    return lifeTime;
}

void ShowLifeTime()
{
    Console.WriteLine("Lifetime and ranks of soldiers in squad: ");
    Console.ForegroundColor = ConsoleColor.Green;
    var lifeTime = LifeTime();
    foreach (var s in lifeTime!)
    {
        Console.WriteLine($"Lifetime: {s.LifeTime} " +
                          $"Rank: {s.Rank}");
    }

    Console.ResetColor();
}

IEnumerable<Soldier> NameAndRank()
{
    var nameAndRank = from s in squad
        select $"{s.Name} ({s.Rank})";
    return nameAndRank;

}

void ShowNameAndRank()
{
    Console.WriteLine("List names and ranks of soldiers in squad: ");
    Console.ForegroundColor = ConsoleColor.Green;
    var nameAndRank = NameAndRank();
    foreach (var s in nameAndRank!)
    {
        Console.WriteLine($"{s.Name} : {s.Rank}");
    }

    Console.ResetColor();
}