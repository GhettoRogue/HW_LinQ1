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

NameAndRank();

return;


var nameAndLifeTime = from n in squad
    select new { n.Name, n.LifeTime };

IEnumerable<Soldier> LifeTime()
{
    var nameAndRank = from s in squad
        where s.LifeTime <= 6
        select s;
    return nameAndRank;
}

IEnumerable<Soldier> NameAndRank()
{
    var nameAndRank = from s in squad;
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