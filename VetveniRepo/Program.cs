Console.ForegroundColor= ConsoleColor.Cyan;

string[] predmetyPrvak = {
    "ALP," + "AJ, " + "ČJ, " + "D," + "HW," + "ZE," + "OPŘ," + "ZEL," + "CH," + "M," + "IKT," + "F" + "OS" + "TV" };

Console.WriteLine("vyber ročník 1 - 4");
string vyberUzivatele = Console.ReadLine();

switch(vyberUzivatele)
{
    case "1":
        foreach (var item in predmetyPrvak) 
        { 
            Console.WriteLine(item); 
        }
        break;
    default: 
        Console.WriteLine("Coming soon :)");
        break;
}
