public class Champions
{
    public string name;

    public Weapon weapon;

    public int hp = 100;

    private bool playerAlive = true;

    private bool enemyAlive = true;

    //------------------------------

    public Champions()
    {
        weapon = new();
    }

    public static string ChampionName()
    {
        string championName;

        Console.WriteLine("\nInsert the name of your champion:");
        championName = Console.ReadLine();

        return championName;
    }

    public static string EnemyChampionName()
    {
        string enemyChampionName;

        Console.WriteLine($"\nThe name of your champions opponent is:");
        enemyChampionName = Console.ReadLine();

        return enemyChampionName;
    }

    public void AttackTarget(Champions target)
    {
        Console.WriteLine($"\n{name} attacks with {weapon.weaponName}");
        int hitDamage = weapon.WeaponDamage();
        target.hp -= hitDamage;
        target.hp = Math.Max(0, target.hp);
        Console.WriteLine($"\n{name} dealt {hitDamage} damage!");
    }

    public bool GetPlayerAlive()
    {
        return playerAlive;
    }

    public bool GetEnemyAlive()
    {
        return enemyAlive;
    }

    public void PlayerHealthStatusCheck()
    {
        if (hp <= 0)
        {
            playerAlive = false;
        }
    }

    public void EnemyHealthStatusCheck()
    {
        if (hp <= 0)
        {
            enemyAlive = false;
        }
    }

    public void PlayerPrintStats()
    {
        if(playerAlive == true)
        {
            Console.WriteLine($"\nChampion {name} status: Alive");
        }
        else
        {
            Console.WriteLine($"\nChampion {name} status: Dead");
        }

        Console.WriteLine($"\nChampion {name} Health: {hp}");
        Console.WriteLine($"Champion {name} Weapon: {weapon.weaponName}");
    }

    public void EnemyPrintStats()
    {
        if(enemyAlive == true)
        {
            Console.WriteLine($"\nEnemy Champion {name} status: Alive");
        }
        else
        {
            Console.WriteLine($"\nEnemy Champion {name} status: Dead");
        }

        Console.WriteLine($"\nEnemy Champion {name} Health: {hp}");
        Console.WriteLine($"Enemy Champion {name} Weapon: {weapon.weaponName}");
    }
}
