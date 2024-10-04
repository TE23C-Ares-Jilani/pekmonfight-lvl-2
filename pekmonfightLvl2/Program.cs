string gamerestart = "yes";
while (gamerestart.ToLower() == "yes")
{
  Console.Clear();
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
      Console.WriteLine("max 12 characters dumbass");
      HeroName = Console.ReadLine();
    }
  }
  // --------------------------------------------------------
  Console.Clear();
  Console.WriteLine($"ight well too bad u get Pikachu!");
  Console.WriteLine("""
       \:.             .:/
        \``._________.''/ 
         \             / 
 .--.--, / .':.   .':. \
/__:  /  | '::' . '::' |
   / /   |`.   ._.   .'|
  / /    |.'         '.|
 /___-_-,|.\  \   /  /.|
      // |''\.;   ;,/ '|
      `==|:=         =:|
         `.          .'
           :-._____.-:
          `''       `''
""");
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
      Console.WriteLine("max 12 characters dumbass");
      VillainName = Console.ReadLine();
    }
    else if (VillainName == "Charmander")
    {
      Console.Clear();
      Console.WriteLine("Enemy uses Charmander!");
      Console.WriteLine(""" 
              _.--""`-..
            ,'          `.
          ,'          __  `.
         /|          " __   \
        , |           / |.   .
        |,'          !_.'|   |
      ,'             '   |   |
     /              |`--'|   |
    |                `---'   |
     .   ,                   |                       ,".
      ._     '           _'  |                    , ' \ `
  `.. `.`-...___,...---""    |       __,.        ,`"   L,|
  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \
-:..     `. `-..--_.,.<       `"      / `.        `-/ |   .
  `,         "" "'     `.              ,'         |   |  ',,
    `.      '            '            /          '    |'. |/
      `.   |              \       _,-'           |       ''
        `._'               \   '"\                .      |
           |                '     \                `._  ,'
           |                 '     \                 .'|
           |                 .      \                | |
           |                 |       L              ,' |
           `                 |       |             /   '
            \                |       |           ,'   /
          ,' \               |  _.._ ,-..___,..-'    ,'
         /     .             .      `!             ,j'
        /       `.          /        .           .'/
       .          `.       /         |        _.'.'
        `.          7`'---'          |------"'_.'
       _,.`,_     _'                ,''-----"'
   _,-_    '       `.     .'      ,\
   -" /`.         _,'     | _  _  _.|
    ""--'---"" ""'        `' '! |! /
                            `" " -' 
""");
    }
  }
  // ----------------------------------------------
  Console.Clear();
  Console.WriteLine($"ight well too bad, enemy uses Charmander!");
  Console.WriteLine(""" 
              _.--""`-..
            ,'          `.
          ,'          __  `.
         /|          " __   \
        , |           / |.   .
        |,'          !_.'|   |
      ,'             '   |   |
     /              |`--'|   |
    |                `---'   |
     .   ,                   |                       ,".
      ._     '           _'  |                    , ' \ `
  `.. `.`-...___,...---""    |       __,.        ,`"   L,|
  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \
-:..     `. `-..--_.,.<       `"      / `.        `-/ |   .
  `,         "" "'     `.              ,'         |   |  ',,
    `.      '            '            /          '    |'. |/
      `.   |              \       _,-'           |       ''
        `._'               \   '"\                .      |
           |                '     \                `._  ,'
           |                 '     \                 .'|
           |                 .      \                | |
           |                 |       L              ,' |
           `                 |       |             /   '
            \                |       |           ,'   /
          ,' \               |  _.._ ,-..___,..-'    ,'
         /     .             .      `!             ,j'
        /       `.          /        .           .'/
       .          `.       /         |        _.'.'
        `.          7`'---'          |------"'_.'
       _,.`,_     _'                ,''-----"'
   _,-_    '       `.     .'      ,\
   -" /`.         _,'     | _  _  _.|
    ""--'---"" ""'        `' '! |! /
                            `" " -' 
""");

  int HeroHp = 100;
  int VillainHp = 100;


  Random generator = new Random();

  Console.Clear();
  Console.WriteLine("You have 10 munny, before every round you can use a the power up (gambling adiction)  to get a chance of getting a more powerful attack against the enemy pekmon. However, there is also a chance that it backfires and ends up hurting your own pekmon. use at your own risk.");
  Console.ReadKey();
  Console.WriteLine("Battle commencing!");
  Console.WriteLine($" Pikachu: {HeroHp} Charmander: {VillainHp}");
  Console.ReadKey();
  while (HeroHp > 0 && VillainHp > 0)
  {
    ConsoleKey key = Console.ReadKey().Key;
  if (key == ConsoleKey.Spacebar)
{

}
    Console.WriteLine("-========NY RUNDA========-");
    int HeroDamage = generator.Next(20);
    VillainHp -= HeroDamage;
    VillainHp = Math.Max(0, VillainHp);
    Console.WriteLine($" Pikachu deals {HeroDamage} damage to Charmander.");

    int VillainDamage = generator.Next(20);
    HeroHp -= VillainDamage;
    HeroHp = Math.Max(0, HeroHp);
    Console.WriteLine($"Charmander deals {VillainDamage} damage to Pikachu.");
    Console.ReadLine();
    Console.WriteLine($"Pikachu: {HeroHp} Charmander: {VillainHp}");

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
    Console.WriteLine($"Pikachu WINS");
  }
  else
  {
    Console.Clear();
    Console.WriteLine($"Charmander WINS");
  }
  Console.WriteLine("Would you like to restart?");
  gamerestart = Console.ReadLine();
}
