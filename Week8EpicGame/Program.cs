string filePath = @"/Users/.../projects/";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(filePath,heroFile));
string[] villains = File.ReadAllLines(Path.Combine(filePath, villainFile));


//string[] heroes = { "Geralt", "Doctor Strange", "Severus Snape", "Bilbo Baggins" };
//string[] villains = { "Vaas Montenegro", "John Seed", "Twisted Fate", "Joker", "Voldemort" };
string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "rubber duck" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}


