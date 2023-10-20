public class Champions
{
    public string playerName;

    public string championName;

    public Weapon weapon;

    public int hp = 100;

    private bool Alive = true;

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
    }


    public static string PlayerName()
    {
        string playerName;

        Console.WriteLine("\nInsert name:");
        playerName = Console.ReadLine();

        return playerName;
    }

    public void Attack(Champions target)
    {
        Console.WriteLine($"{championName} attacks with {weapon.weaponName}");
    }
}
