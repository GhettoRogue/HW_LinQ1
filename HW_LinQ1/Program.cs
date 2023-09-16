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

ShowNameAndRank();

return;


var nameAndLifeTime = from n in squad
    select new { n.Name, n.LifeTime };

IEnumerable<Soldier> NameAndRank(IEnumerable<Soldier> soldier, string name, string rank)
{
    var nameAndRank =
        from s in soldier
        where s.Name == name && s.Rank == rank
        select s;

    return nameAndRank;
}

void ShowNameAndRank()
{
    Console.WriteLine("List names and ranks of soldiers in squad: ");
    Console.ForegroundColor = ConsoleColor.Green;
    var nameAndRank = NameAndRank(squad, name, rank);
    foreach (var item in squad)
    {
        Console.WriteLine($"{item.Name} : {item.Rank}");
    }

    Console.ResetColor();
}