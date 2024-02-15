
int playerHP = 10;
int monsterHp = 10;

Random playerAttack  = new Random();
Random monsterAttack = new Random();


Random criticalChance = new Random();

int luminarAttackDamage = 0;
int monsterAttackDamage = 0;

Boolean critActivated;

string LuminaryStatus = "The Luminary's current HP:";
string monsterStatus = " The Slime's current HP:";


Console.WriteLine("A slime draws near");
Console.WriteLine("The Luminary prepares to fight!!");
do
{
    Console.WriteLine("The Luminary Attacks!");
    critActivated = criticalChance.Next(1,64) == 64;
    if (critActivated)
    {
        Console.WriteLine("The Luminary slips on a banana peel and lands a powerful blow!!!");

        luminarAttackDamage = playerAttack.Next(1,10) * 3;
        Console.WriteLine("The Luminary deals a lucky " + luminarAttackDamage + " points of damage to the Slime");
    }
    else
    {
        luminarAttackDamage = playerAttack.Next(1,10);
        if (luminarAttackDamage <= 4)
        {
            Console.WriteLine("The Luminary does a typical sword swing");
            Console.WriteLine("The Luminary deals " + luminarAttackDamage + "points of damge to the Slime");
        }
        else if (luminarAttackDamage >= 5 && luminarAttackDamage != 10)
        {
            Console.WriteLine("The Luminary does a mighty slash attack");
            Console.WriteLine("The Luminary deals a whopping " + luminarAttackDamage + " points of damge to the Slime");
        }
        else
        {
            Console.WriteLine("The Luminary deals a finishing blow to the slime");
            Console.WriteLine("The Luminary finishes off the slime with " + luminarAttackDamage + " points of damage");
            Console.WriteLine("Woah, I think you got em, it was a beginning enemy mate.");
            Console.WriteLine("You didn't have to split the world itself in two, sheeesh");
            Console.WriteLine("You win I guess.");
            Console.WriteLine("[The Narrator is visibly terrified of your actions]");
            break;
        }
    }
    
        
    monsterHp = monsterHp - luminarAttackDamage;
    if (monsterHp > 0) 
    {
        Console.WriteLine(monsterStatus + monsterHp);
        Console.WriteLine(LuminaryStatus + playerHP);
    }
    else 
    {
        Console.WriteLine("The Luminary successfully managed to fell the slimple Slime");
        Console.WriteLine("Personally, not that impressive, but we all start somewhere.");
        Console.WriteLine("The Luminary gains 2 EXP points and 3 gold coins");
        break;
    }
    
    Console.WriteLine("The Slime prepares to attack");
    monsterAttackDamage = monsterAttack.Next(1,10);
    if (monsterAttackDamage == 10)
    {
        Console.WriteLine("The Slime channels the power of the dark Lord.");
        Console.WriteLine("The Slime spews a beam of pure dark energy");
        Console.WriteLine("The Slime deals " + monsterAttack + " damage points to the Luminary");
        Console.WriteLine("Talk about unbelievable bad luck.");
        Console.WriteLine("The Luminary is vaporized by the blast and only the smell of burning flesh remains");
        Console.WriteLine("Try again\n");
        break;
    }
    else if (monsterAttackDamage > 4)
    {
        Console.WriteLine("The Slime tries to smother the Luminary with all their might");
        Console.WriteLine("The Slime deals " + monsterAttackDamage + " damage points to the Luminary");
    }
    else
    {
        Console.WriteLine("The Slime tackles the player with their gooeyness");
        Console.WriteLine("The Slime deals " + monsterAttackDamage + " damage points to the Luminary");
    }
    

    playerHP = playerHP - monsterAttackDamage;
    if (playerHP > 0)  
    {
        Console.WriteLine(monsterStatus + monsterHp);
        Console.WriteLine(LuminaryStatus + playerHP);
    }
    else
    {
        Console.WriteLine("The Luminary was unable to defeat a simple slime.");
        Console.WriteLine("The world slowly was absorbed by the Dark Lord's army and humans perished");
        Console.WriteLine("Try again, brave hero!");
        break;
    };
}while (playerHP > 0);

