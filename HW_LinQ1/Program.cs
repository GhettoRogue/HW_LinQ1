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

ShowNameAndRank();

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
        Console.WriteLine($"Lifetime: {s.LifeTime} - Rank: {s.Rank}");
    }

    Console.ResetColor();
}

void ShowNameAndRank()
{
    Console.WriteLine("List names and ranks of soldiers in squad: ");
    Console.ForegroundColor = ConsoleColor.Green;
    foreach (var soldier in squad!)
    {
        Console.WriteLine($"{soldier.Name} - {soldier.Rank}");
    }

    Console.ResetColor();
}

/*IEnumerable<Soldier> NameAndRank(string name, string rank)
{
    var nameAndRank = from s in squad
        where s.Name == name && s.Rank == rank
        select s;
    return nameAndRank;
}

void ShowNameAndRank(string name, string rank)
{
    Console.WriteLine("List names and ranks of soldiers in squad: ");
    Console.ForegroundColor = ConsoleColor.Green;
    var nameAndRank = NameAndRank(name, rank);
    foreach (var s in nameAndRank!)
    {
        Console.WriteLine($"{s.Name} : {s.Rank}");
    }

    Console.ResetColor();
}*/