
int HeroHp = 100;
int VillanHp = 100;


Console.WriteLine("""
  __       __          __                                               
|  \  _  |  \        |  \                                              
| $$ / \ | $$ ______ | $$ _______  ______  ______ ____   ______        
| $$/  $\| $$/      \| $$/       \/      \|      \    \ /      \       
| $$  $$$\ $|  $$$$$$| $|  $$$$$$|  $$$$$$| $$$$$$\$$$$|  $$$$$$\      
| $$ $$\$$\$| $$    $| $| $$     | $$  | $| $$ | $$ | $| $$    $$      
| $$$$  \$$$| $$$$$$$| $| $$_____| $$__/ $| $$ | $$ | $| $$$$$$$$      
| $$$    \$$$\$$     | $$\$$     \\$$    $| $$ | $$ | $$\$$     \      
 \$$      \$$ \$$$$$$$\$$ \$$$$$$$ \$$$$$$ \$$  \$$  \$$ \$$$$$$$      
                                                                                                                                 
""");
Console.WriteLine("""
    __                       __     __                                                               
   |  \                     |  \   |  \                                                              
  _| $$_    ______         _| $$_  | $$____   ______          ______   ______  ______ ____   ______  
 |   $$ \  /      \       |   $$ \ | $$    \ /      \        /      \ |      \|      \    \ /      \ 
  \$$$$$$ |  $$$$$$\       \$$$$$$ | $$$$$$$|  $$$$$$\      |  $$$$$$\ \$$$$$$| $$$$$$\$$$$|  $$$$$$\
   | $$ __| $$  | $$        | $$ __| $$  | $| $$    $$      | $$  | $$/      $| $$ | $$ | $| $$    $$
   | $$|  | $$__/ $$        | $$|  | $$  | $| $$$$$$$$      | $$__| $|  $$$$$$| $$ | $$ | $| $$$$$$$$
    \$$  $$\$$    $$         \$$  $| $$  | $$\$$     \       \$$    $$\$$    $| $$ | $$ | $$\$$     \
     \$$$$  \$$$$$$           \$$$$ \$$   \$$ \$$$$$$$       _\$$$$$$$ \$$$$$$$\$$  \$$  \$$ \$$$$$$$
                                                            |  \__| $$                               
                                                             \$$    $$                               
                                                              \$$$$$$                         
                
 """);

Console.ReadLine();

Console.WriteLine("Skriv till användarnamn: ");
string HeroName = Console.ReadLine();

string VillanName = "THE VILLAN";

Random generator = new Random();

while (HeroHp > 0 && VillanHp > 0)
{
    Console.Clear();
    Console.WriteLine("""
        _   __                ____                        __
       / | / /__ _      __   / __ \____  __  ______  ____/ /
      /  |/ / _ \ | /| / /  / /_/ / __ \/ / / / __ \/ __  / 
     / /|  /  __/ |/ |/ /  / _, _/ /_/ / /_/ / / / / /_/ /  
    /_/ |_/\___/|__/|__/  /_/ |_|\____/\__,_/_/ /_/\__,_/   
                                                      
    """);
    Console.ReadLine();
    
    Console.Clear();
    Console.WriteLine($"{HeroName}: {HeroHp}       {VillanName}: {VillanHp}");
    int HeroDamage = generator.Next(20);
    VillanHp -= HeroDamage;

    Console.WriteLine($"{HeroName} gjorde {HeroDamage} skada mot {VillanName}");
    Console.ReadLine();

    Console.Clear();

    int VillanDamage = generator.Next(20);
    HeroHp -= VillanDamage;
    Console.WriteLine($"{HeroName}: {HeroHp}       {VillanName}: {VillanHp}");
    Console.WriteLine($"{VillanName} gjorde {VillanDamage} skada mot {HeroName}");
    Console.WriteLine("");
    Console.WriteLine("Tryck på <Enter> för att fortsätta");
    Console.ReadLine();
}

Console.WriteLine("""
  ________  ________   __________________  ________   
 /_  __/ / / / ____/  / ____/  _/ ____/ / / /_  __/   
  / / / /_/ / __/    / /_   / // / __/ /_/ / / /      
 / / / __  / /___   / __/ _/ // /_/ / __  / / /       
/_/ /_/ /_/_____/  /_/   /___/\____/_/ /_/ /_/    
""");

Console.WriteLine("""
    _________
   /  _/ ___/
   / / \__ \ 
 _/ / ___/ / 
/___//____/  
""");

Console.WriteLine("""
   ____ _    ____________ 
  / __ \ |  / / ____/ __ \
 / / / / | / / __/ / /_/ /
/ /_/ /| |/ / /___/ _, _/ 
\____/ |___/_____/_/ |_|  
""");
Console.ReadLine();

if (HeroHp == 0 && VillanHp == 0)
{
  Console.Clear();
  Console.WriteLine("""
     ____  ___ _    ________    ______  ____  ______
    / __ \/   | |  / / ____/   / / __ \/ __ \/_  __/
   / / / / /| | | / / / ____  / / / / / /_/ / / /   
  / /_/ / ___ | |/ / /_/ / /_/ / /_/ / _, _/ / /    
  \____/_/  |_|___/\____/\____/\____/_/ |_| /_/
  """);
  Console.ReadLine();
}

else if (HeroHp > 0)
{
  Console.Clear();
  Console.WriteLine("""
      ____  __  __   _    _____    _   ___   __
     / __ \/ / / /  | |  / /   |  / | / / | / /
    / / / / / / /   | | / / /| | /  |/ /  |/ / 
   / /_/ / /_/ /    | |/ / ___ |/ /|  / /|  /  
  /_____/\____/     |___/_/  |_/_/ |_/_/ |_/  
  """);
  Console.ReadLine();
}

else
{
  Console.Clear();
  Console.WriteLine("""
        ____  __  __   _______   _ ____  __    ____  ____  ___ 
       / __ \/ / / /  / ____(_)_(_) __ \/ /   / __ \/ __ \/   |
      / / / / / / /  / /_  / __ \/ /_/ / /   / / / / /_/ / /| |
     / /_/ / /_/ /  / __/ / /_/ / _, _/ /___/ /_/ / _, _/ ___ |
    /_____/\____/  /_/    \____/_/ |_/_____/\____/_/ |_/_/  |_|
  """);
  Console.ReadLine();
}
