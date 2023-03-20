Console.ForegroundColor= ConsoleColor.Cyan;

string[] predmetyPrvak = {
    "ALP," + "AJ, " + "ČJ, " + "D," + "HW," + "ZE," + "OPŘ," + "ZEL," + "CH," + "M," + "IKT," + "F" + "OS" + "TV" };

string[] predmetyDruhak = {
    "ALP," + "AJ, " + "ČJ, " + "D," + "HW," + "ZE," + "OPŘ," + "ZEL,"  + "M," + "IKT," + "F" + "OS" + "TV" + "ZSV" +"AS" };

string[] predmetyTretak = {
    "ALP," + "AJ, " + "ČJ, " + "D," + "HW," + "DA"  + "M" + "R" + "OS" + "TV" + "PS" + "ZSV" + "F"};

string[] predmetyCtvrtak = {
    "AJ" + "ČJ" + "ZSV" + "M" + "E"  + "M" + "R" + "DA" + "TV" + "POS"+ "VR"};


Console.WriteLine("vyber ročník 1 - 4");

string vyberUzivatele = Console.ReadLine();

switch(vyberUzivatele)
{
case "1":
        Console.ForegroundColor = ConsoleColor.Magenta;
        foreach (var item in predmetyPrvak) 
        { 
            Console.WriteLine(item); 
        }
        break;

case "2":
        Console.ForegroundColor = ConsoleColor.Blue;
        foreach (var item in predmetyDruhak)
        {
            Console.WriteLine(item);
        }
        break;
 
case "3":
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var item in predmetyTretak)
        {
            Console.WriteLine(item);
        }
        break;

case "4":
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        foreach (var item in predmetyCtvrtak)
        {
            Console.WriteLine(item);
        }
        break;

default:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Coming soon :)");
        break;
}
