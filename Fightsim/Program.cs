
int hpH = 100;
int hpV = 100;

string H = "Hero";
string V = "Villain";

while (hpH > 0 && hpV > 0)
{
    Console.WriteLine();
    Console.WriteLine("------====={ NY RUNDA }=====------");
    Console.WriteLine($"{H}: {hpH}  {V}: {hpV}");

    int damageV = Random.Shared.Next(8, 20);
    hpH -= damageV;
    hpH = Math.Max(0, hpH);
    Console.WriteLine($"{V} gör {damageV} skada på {H}");

    int damageH = Random.Shared.Next(8, 20);
    hpV -= damageH;
    hpV = Math.Max(0, hpV);
    Console.WriteLine($"{H} gör {damageH} skada på {V}");

    Console.WriteLine("tryck på valfri knapp");
    Console.ReadKey();
}
Console.WriteLine("Rundan är nu över");

if (hpH == 0 && hpV == 0)
{
    Console.WriteLine("Oavgjort");
}
else if (hpH == 0)
{
    Console.WriteLine($"{V} Segrade!");
}
else
{
    Console.WriteLine($"{H} Segrade!");
}
Console.WriteLine("Tryck på en knapp för att förtsätta för fan");
Console.ReadKey();

