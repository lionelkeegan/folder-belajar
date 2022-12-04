using System;
namespace SkilvulLearning {
   
class Hewan {
    public int kaki {get; set;}
    public string jenis {get; set;}
}
class Kucing : Hewan {
    public Kucing : Hewan() {
        kaki = 4;
        jenis = "Mamalia";
    }
    public void Makan : Hewan() {
        Console.Write("Suka Makan Ikan");
    }
}
}