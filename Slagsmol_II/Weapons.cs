public class Weapon
{
    public string weaponName;

    private List<string> weapons = new List<string>() {"Sword", "Axe", "Shovel", "Mace"};

    private Random Generator = new Random();

    //---------------------------------------------------

    public Weapon()
    {
        int i = Generator.Next(weapons.Count);
        weaponName = weapons[i];
    }

    public int WeaponDamage()
    {
        return Generator.Next(5, 25);
    }
}
