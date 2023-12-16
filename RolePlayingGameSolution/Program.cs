int heroLife = 10;
int monsterLife = 10;

Random dice = new Random();

do
{
    int attack = dice.Next(1, 11);
    monsterLife -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterLife} health.");

    if (monsterLife <= 0) continue;

    attack = dice.Next(1, 11);
    heroLife -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroLife} health.");

} while (heroLife > 0 && monsterLife > 0);

Console.WriteLine(heroLife > monsterLife ? "Hero Wins" : "Monster Wins");