class Enemy
{
    public string Name;

    public float Health;

    public Enemy(string name, float health)
    {
        this.Name = name;
        this.Health = health;

    }
}

class Program
{
    static void Main()
    {
        Enemy Abenk = new Enemy("Abenk", 24);
        Enemy Budi = new Enemy("Budi", 35);
        Enemy Coki = new Enemy("Coki", 17);
        Enemy Dipa = new Enemy("Dipa", 83);
        Enemy Erlangga = new Enemy("Erlangga", 72);
        
        Enemy[] enemyArray = {
            Abenk,
            Budi,
            Coki,
            Dipa,
            Erlangga,
        };

        Console.WriteLine(enemyArray);
        Console.WriteLine(enemyArray.ToString());
        // Console.WriteLine(Abenk.Name);

    }
}