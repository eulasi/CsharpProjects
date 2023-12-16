// Random Number Set
Random random = new Random();
// Attack random
int attack = random.Next(1, 10);
// Hero and Monster
int heroHp = 10;
int monsterHp = 10;

int monsterAttackRes = 0;

do
{
    attack = random.Next(1, 10);

    if (heroHp >= monsterHp) {
         monsterAttackRes = attack - monsterHp;
    }

    Console.WriteLine($"Monster was damaged and lost {monsterAttackRes} health and now has {monsterHp}");
} while (heroHp != 0);

// The hero continues to beat the life out of the Monster, but the Monster is un bothered, causing a continued fight.