using System;

struct Location
{
    public int x, y;

    public Location(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class Progra
{
    static void Main(string[] args)
    {
        Location a = new Location(20, 20);
        Location b = a;
        a.x = 100;

        // Print the value of b.x
        Console.WriteLine(b.x);

        // Output: 20
    }
}