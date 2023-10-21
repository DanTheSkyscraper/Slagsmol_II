string restartGame = "y";
while(restartGame == "y")
{
    Console.WriteLine("Greetings Player! I will keep it short. You are the Warden of our little fighting ring here, so it falls to you to make sure everything works as it should. That includes managing the competitors. With that said, good luck.");
    Console.WriteLine("\nWhat is with that reaction? I said I'd keep it short.");

    Champions champion = new();
    Champions enemy = new();


    Console.WriteLine($"\nNow, to prepare for the games. Before they enter the arena, you must first meet your champion, {champion.playerName}");
    champion.playerName = Champions.ChampionName();

    Console.WriteLine("\nVery well. This is who your champion will be fighting against.");
    enemy.enemyName = Champions.EnemyChampionName();

    Console.WriteLine($"\nBefore we begin, a random weapon will now be selected for your champion and the enemy champion.");

    Console.WriteLine("\n With all of that done, let the games begin!");

    while(champion.hp > 0 && enemy.hp > 0)
    {
        Console.WriteLine("\n\n--------------------------");
        Console.WriteLine("A new round has started!");

        champion.PlayerPrintStats();
        enemy.EnemyPrintStats();

        champion.AttackTarget(enemy);
        enemy.AttackTarget(champion);


    }

    Console.WriteLine("\n\n--------------------------");
    Console.WriteLine("The battle is over!");

    if(champion.GetPlayerAlive() == true && enemy.GetEnemyAlive() == false)
    {
        Console.WriteLine($"\n\nEnemy Champion {enemy.enemyName} has been defeated! Your champion has won!");
    }
    else if(champion.GetPlayerAlive() == false && enemy.GetEnemyAlive() == true)
    {
        Console.WriteLine($"\n\nPlayer Champion {champion.playerName} has been defeated! THe enemy champion wins!");
    }
    else
    {
        Console.WriteLine($"\n\nPlayer Champion {champion.playerName} and Enemy Champion {enemy.enemyName} have been defeated! It's a draw!");
    }

    Console.WriteLine("\nD you want to play again? [y/n]");
    restartGame = Console.ReadLine();
}
Console.ReadLine();