using System;
namespace belajar{
    class GameDevice {
    public virtual void Deskripsi() {
        Console.Write("Ini adalah Base Class Game");
    }
}

class Playstation5 : GameDevice{
    public override void Deskripsi() {
        Console.WriteLine("Bermain Playstation 5");
    }
}
class NintendoSwitch : GameDevice{
    public override void Deskripsi() {
        Console.WriteLine("Bermain Nintendo Switch");
    }
}
    
class Program {
    static void Main(string[] args) {
        GameDevice devicel = new Playstation5();
        GameDevice device2 = new NintendoSwitch();

        devicel.Deskripsi();
        device2.Deskripsi();
    }
}
}