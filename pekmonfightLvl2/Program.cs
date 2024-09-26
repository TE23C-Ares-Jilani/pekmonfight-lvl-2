Console.WriteLine("Welcome to pekmon fight!");
Console.WriteLine("Write your pekmon:");
string HeroName = Console.ReadLine();
// -----------------------------------------------------------
while (HeroName.Length == 0 || HeroName.Length > 12)
{
    if (HeroName.Length == 0)
    {
        Console.Clear();
        Console.WriteLine("write a Pekmon dickhead!");
        HeroName = Console.ReadLine();
    }
    else if (HeroName.Length > 12)
    {
        Console.Clear();
        Console.WriteLine("max 20 characters dumbass");
        HeroName = Console.ReadLine();
    }
}
// --------------------------------------------------------
Console.Clear();
Console.WriteLine($"U use {HeroName}!");
Console.ReadKey();
// ----------------------------------------------------------
Console.WriteLine("Write enemy pekmon:");
string VillainName = Console.ReadLine();

while (VillainName.Length == 0 || VillainName.Length > 12)
{
    if (VillainName.Length == 0)
    {
        Console.Clear();
        Console.WriteLine("write a Pekmon dickhead!");
        VillainName = Console.ReadLine();
    }
    else if (VillainName.Length > 12)
    {
        Console.Clear();
        Console.WriteLine("max 20 characters dumbass");
        VillainName = Console.ReadLine();
    }
}
// ----------------------------------------------
int HeroHp = 100;
int VillainHp = 100;


Random generator = new Random();

Console.Clear();
Console.WriteLine("Why so solemn?");
Console.ReadKey();
Console.WriteLine($"{HeroName}: {HeroHp} {VillainName}: {VillainHp}");
Console.ReadKey();
while (HeroHp > 0 && VillainHp > 0)
{
    Console.WriteLine("-========NY RUNDA========-");
    int HeroDamage = generator.Next(20);
    VillainHp -= HeroDamage;
    VillainHp = Math.Max(0, VillainHp);
    Console.WriteLine($"{HeroName} deals {HeroDamage} damage to {VillainName}.");

    int VillainDamage = generator.Next(20);
    HeroHp -= VillainDamage;
    HeroHp = Math.Max(0, HeroHp);
    Console.WriteLine($"{VillainName} deals {VillainDamage} damage to {HeroName}.");
    Console.ReadLine();
    Console.WriteLine($"{HeroName}: {HeroHp} {VillainName}: {VillainHp}");

    Console.WriteLine("Kilck a button to continue.");
    Console.ReadKey();
}
Console.WriteLine("-=========FIGHT OVER========-");
Console.ReadKey();
if (HeroHp == 0 && VillainHp == 0)
{
    Console.Clear();
    Console.WriteLine("TIE, NOBODY WINS.");
}
else if (HeroHp == 0)
{
    Console.Clear();
    Console.WriteLine($"{HeroName} WINS");
}
else
{
    Console.Clear();
    Console.WriteLine($"{VillainName} WINS");
}
Console.WriteLine("Kilck a button to continue.");
Console.ReadKey();
