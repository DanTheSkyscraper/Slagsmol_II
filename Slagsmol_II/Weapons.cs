public class Weapon
{
    public string weaponName;

    public string attackType;

    private List<string> weapons = new List<string>() {"Sword", "Axe", "Shovel", "Mace"};

    private Random Generator = new Random();

    //---------------------------------------------------

    public Weapon()
    {
        int i = Generator.Next(weapons.Count);
        weaponName = weapons[i];
    }
}
