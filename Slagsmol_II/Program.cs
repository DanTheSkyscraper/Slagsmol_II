string restartGame = "y";
while(restartGame == "y")
{
    Console.WriteLine("Greetings Player! I will keep it short. You are the Warden of our little fighting ring here, so it falls to you to make sure everything works as it should. That includes managing the competitors. With that said, good luck.");
    Console.WriteLine("\nWhat is with that reaction? I said I'd keep it short.");

    Champions champion = new();
    Champions enemy = new();

    Console.WriteLine("\nBefore the games starts, what is your name?");
    champion.playerName = Champions.PlayerName();

    Console.WriteLine($"\nNow, to prepare for the games. Before they enter the arena, you must first meet your champion, {champion.playerName}");
    champion.name = Champions.ChampionName();

    enemy.name = Champions.EnemyChampionName();


    Console.WriteLine($"\nVery well. Before we begin, a random weapon will now be selected for your champion. We assure you, this is simply to prevent you from only choosing something that will give your chapmion the upper hand deliberately");
    





}