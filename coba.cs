using System;
namespace belajar{
class Program {
    static void Main(string[] args) {
        BangunRuang bangunRuang1 = new BangunRuang("persegi panjang", 4, 10);

        Console.WriteLine("Luas " + bangunRuang1.nama + " : " + bangunRuang1.HitungLuas());
        Console.WriteLine("Keliling " + bangunRuang1.nama + " : " + bangunRuang1.HitungKeliling());
    }
}

public class BangunRuang {
    public string nama;
    public double variabel1;
    public double variabel2;

    public BangunRuang(string nama, double variabel1, double variabel2) {
        this.nama = nama;
        this.variabel1 = variabel1;
        this.variabel2 = variabel2;
    }
    public double HitungLuas() {
        if(nama == "persegi")
            return variabel1 * variabel1;
        else if(nama == "persegi panjang")
            return variabel1 * variabel2;
            
        return 0;
    }
    public double HitungKeliling() {
        if(nama == "persegi")
            return variabel1 * 4;
        else if(nama == "persegi panjang")
            return (variabel1 + variabel2) * 2;
            
        return 0;
    }
}
}
//class ProgramInput
//{
//    static void Main(String[] args)
//    {
//double myDouble = 9.78;
//int myInt = (int) myDouble;
//int myOtherInt = Convert.ToInt32(myDouble);

//Console.WriteLine(myDouble);
//Console.WriteLine(myInt);
//Console.WriteLine(myOtherInt);
//    }
//}