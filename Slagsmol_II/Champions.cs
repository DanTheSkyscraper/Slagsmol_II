public class Champions
{
    public string playerName;

    public string enemyName;

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
        Console.WriteLine($"\n{playerName} attacks with {weapon.weaponName}");
        int hitDamagePlayer = weapon.WeaponDamage();
        target.hp =- hitDamagePlayer;
        target.hp = Math.Max(0, target.hp);
        Console.WriteLine($"\n{playerName} dealt {hitDamagePlayer} damage!");
    }

    //public void AttackPlayer(Champions enemy)
    //{
        //Console.WriteLine($"\n{playerName} attacks with {weapon.weaponName}");
        //int hitDamagePlayer = weapon.WeaponDamage();
        //enemy.hp =- hitDamagePlayer;
        //enemy.hp = Math.Max(0, enemy.hp);
        //Console.WriteLine($"\n{playerName} dealt {hitDamagePlayer} damage!");
    //}

    //public void AttackEnemy(Champions player)
    //{
        //Console.WriteLine($"{enemyName} attacks with {weapon.weaponName}");
        //int hitDamageEnemy = weapon.WeaponDamage();
        //player.hp =- hitDamageEnemy;
        //player.hp = Math.Max(0, player.hp);
        //Console.WriteLine($"\n{enemyName} dealt {hitDamageEnemy} damage!");
    //}

    public bool GetPlayerAlive()
    {
        return playerAlive;
    }

    public bool GetEnemyAlive()
    {
        return enemyAlive;
    }

    public void PlayerPrintStats()
    {
        if(playerAlive == true)
        {
            Console.WriteLine($"\nChampion {playerName} status: Alive");
        }
        else
        {
            Console.WriteLine($"\nChampion {playerName} status: Dead");
        }

        //Console.WriteLine($"\nChampion {playerName} Health: {}");
        //Console.WriteLine($"Champion {playerName} Weapon: {}");
    }

    public void EnemyPrintStats()
    {
        if(enemyAlive == true)
        {
            Console.WriteLine($"\nEnemy Champion {enemyName} status: Alive");
        }
        else
        {
            Console.WriteLine($"\nEnemy Champion {enemyName} status: Dead");
        }

        //Console.WriteLine($"\nEnemy Champion {enemyName} Health: {}");
        //Console.WriteLine($"Enemy Champion {enemyName} Weapon: {}");
    }
}
