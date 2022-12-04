// namespace Belajar1 {
//   class Program {// class Hewan {
//     public int kaki {get; set;}
//     public string jenis {get; set;}
// }
// class Kucing : Hewan {
//     public Kucing() {
//         kaki = 4;
//         jenis = "Mamalia";
//     }
//     public void Makan() {
//         Console.Write("Suka Makan Ikan");
//     }
// }//     static void Main(string[] args) {
//       Kucing k = new Kucing();
//   Console.WriteLine(k.jenis);
//   k.Makan();
//     }
//   }
// }// namespace belajar1
// {
//     class Program{
//         static void Main(string[] args){//         }
//     }
// }

// namespace Belajar1 {
//   class Program {
//     class GameDevice {
//     public virtual void Deskripsi() {
//         Console.Write("Ini adalah Base Class Game");
//     }
// }
// class Playstation5 : GameDevice{
//     public override void Deskripsi() {
//         Console.WriteLine("Bermain Playstation 5");
//     }
// }
// class NintendoSwitch : GameDevice{
//     public override void Deskripsi() {
//         Console.WriteLine("Bermain Nintendo Switch");
//     }
// }
//     static void Main(string[] args) {
//         GameDevice devicel = new Playstation5();
//         GameDevice device2 = new NintendoSwitch();
//         devicel.Deskripsi();
//         device2.Deskripsi();
//     }
//   }
// }

// using System;
// namespace SkilvulLearning
// {
//     class MenggunakanMethod
//     {
//         static void Main(string[] args)
//         {
//             MencetakLimaGaris();
//             for (int i = 0; i < 5; i++)
//             {
//                 if (i % 2 == 0)
//                 {
//                     MencetakTigaBintang();
//                 }
//                 else
//                 {
//                     MencetakDuaPagar();
//                 }
//             }
//             MencetakLimaGaris();
//         }
//         static void MencetakTigaBintang()
//         {
//             Console.WriteLine("* * *");
//         }
//         static void MencetakDuaPagar()
//         {
//             Console.WriteLine(" # # ");
//         }
//         static void MencetakLimaGaris()
//         {
//             Console.WriteLine("-----");
//         }
//     }
// }
// using System;
// namespace SkilvulLearning
// {
//     class MenggunakanMethod
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("3! = " + FaktorialTiga());
//         }
//         static int FaktorialEmpat()
//         {
//             int hasil = 1;
//             for (int i = 1; i <= 4; i++)
//             {
//                 hasil = hasil * i;
//             }
//             return hasil;
//         }
//         static int FaktorialTiga()
//         {
//             int hasil = 1;
//             for (int i = 1; i <= 3; i++)
//             {
//                 hasil = hasil * i;
//             }
//             return hasil;
//         }
//     }
// }


// using System;
// namespace SkilvulLearning
// {
//     class MenggunakanMethod
//     {
//         static void Main(string[] args)
//         {
//             if (perbandinganNilai())
//             {
//                 Console.WriteLine("nilaiA() lebih besar dari nilaiB()");
//             }
//             else
//             {
//                 Console.WriteLine("nilaiA() lebih kecil atau sama dengan nilaiB()");
//             }
//         }
//         static int nilaiA()
//         {
//             return 5 + 4 * 6 - 3 + 15;
//         }
//         static int nilaiB()
//         {
//             return 5 / 4 * 3 - 3 + 50;
//         }
//         static bool perbandinganNilai()
//         {
//             if (nilaiA() > nilaiB())
//             {
//                 return true;
//             }
//             return false;
//         }
//     }
// }

// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Rata - rata skor kecepatan pelari");
//             Console.Write("Total pelari : ");
//             int totalPelari = Convert.ToInt32(Console.ReadLine());
//             int[] kecepatanPelari = new int[totalPelari];
//             for (int i = 0; i < totalPelari; i++)
//             {
//                 Console.Write("Kecepatan pelari " + i + " : ");
//                 kecepatanPelari[i] = Convert.ToInt32(Console.ReadLine());
//             }
//             Console.WriteLine("Rata - rata kecepatan pelari : " + hitungRataRata(kecepatanPelari));
//         }
//         static int hitungRataRata(int[] kecepatanPelari)
//         {
//             int ratarata = 0, total = 0;
//             for (int i = 0; i < kecepatanPelari.Length; i++)
//             {
//                 total += kecepatanPelari[i];
//             }
//             ratarata = total / kecepatanPelari.Length;
//             return ratarata;
//         }
//     }
// }

// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int angka = 6;
//             int hasilAngka = hitungKurangTiga(
//                 hitungKaliDua(
//                     hitungTambahLima(angka)
//                     )
//                 );

//             Console.WriteLine("Hasil akhir angka : " + hasilAngka);
//         }

//         static int hitungTambahLima(int angka)
//         {
//             return angka + 5;
//         }

//         static int hitungKaliDua(int angka)
//         {
//             return angka * 2;
//         }
//         static int hitungKurangTiga(int angka)
//         {
//             return angka - 3;
//         }
//     }
// }

// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             long totalBelanja = 10000;
//             bool statusBerlangganan = true;

//             if (statusBerlangganan)
//             {
//                 if (totalBelanja > 10000)
//                 {
//                     Console.WriteLine("mendapatkan diskon 75%");
//                 }
//                 else
//                 {
//                     Console.WriteLine("mendapatkan diskon 50%");
//                 }
//             }
//             else
//             {
//                 if (totalBelanja > 10000)
//                 {
//                     Console.WriteLine("mendapatkan diskon 25%");
//                 }
//                 else
//                 {
//                     Console.WriteLine("tidak mendapatkan diskon");
//                 }
//             }
//         }
//     }
// }

// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int level = 29;
//             string jenisSerangan = "Serangan Berat";

//             if (jenisSerangan == "Serangan Jarak Jauh")
//             {
//                 if (level >= 50)
//                 {
//                     Console.WriteLine("Menghindar dan Melompat");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Menahan Serangan");
//                 }
//             }
//             else if (jenisSerangan == "Serangan Berat")
//             {
//                 if (level >= 30)
//                 {
//                     Console.WriteLine("Menyerang dengan Serangan Cepat");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Menghindar dan Mundur");
//                 }
//             }
//             else
//             {
//                 if (level >= 70)
//                 {
//                     Console.WriteLine("Menghindar dan Mundur");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Menahan Serangan");
//                 }
//             }
//         }
//     }
// }


// using System;
// namespace SkilvulLearning
// {

//     class StatemenIf
//     {
//         static void Main(String[] args)
//         {
//             int angka = 25;

//             if ((angka % 2) == 0)
//             {
//                 Console.WriteLine("Faktor terkecil dari " + angka + " adalah 2.");
//             }
//             else if ((angka % 3) == 0)
//             {
//                 Console.WriteLine("Faktor terkecil dari " + angka + " adalah 3.");
//             }
//             else if ((angka % 5) == 0)
//             {
//                 Console.WriteLine("Faktor terkecil dari " + angka + " adalah 5.");
//             }
//             else if ((angka % 7) == 0)
//             {
//                 Console.WriteLine("Faktor terkecil dari " + angka + " adalah 7.");
//             }
//             else
//             {
//                 Console.WriteLine(angka + " tidak bisa dibagi 2, 3, 5, atau 7.");
//             }
//         }
//     }
// }


// using System;
// namespace SkilvulLearning
// {

//     class StatemenIf
//     {
//         static void Main(String[] args)
//         {
//             string role = Console.ReadLine();

//             switch (role)
//             {
//                 case "Knight": Console.WriteLine("Serangan Langsung"); break;
//                 case "Archer": Console.WriteLine("Serangan Ranged Attack"); break;
//                 case "Mage": Console.WriteLine("Serangan AOE"); break;
//                 default: Console.WriteLine("Serangan Tidak Diketahui"); break;
//             }
//         }
//     }
// }



// using System;
// namespace SkilvulLearning
// {

//     class StatemenIf
//     {
//         static void Main(String[] args)
//         {
//             string role = Console.ReadLine();

//             switch (role)
//             {
//                 case "Knight": Console.WriteLine("Serangan Langsung"); break;
//                 case "Archer": Console.WriteLine("Serangan Ranged Attack"); break;
//                 case "Mage": Console.WriteLine("Serangan AOE"); break;
//                 default: Console.WriteLine("Serangan Tidak Diketahui"); break;
//             }
//         }
//     }
// }


// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (int i = 1; i <= 11; i++)
//             {
//                 if (i % 2 != 0)
//                 {
//                     Console.WriteLine(i);
//                 }
//             }
//         }
//     }
// }


// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (int i = 1; i <= 5; i++)
//             {
//                 if (i % 3 == 0)
//                 {
//                     Console.WriteLine("@ @ @ @ @");
//                 }
//                 else if (i % 2 == 0)
//                 {
//                     Console.WriteLine("x x x");
//                 }
//                 else
//                 {
//                     Console.WriteLine("- - - - - -");
//                 }
//             }
//         }
//     }
// }


// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (; ; )
//             {
//                 Console.WriteLine("Hello");
//             }
//         }
//     }
// }


// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for (int i = 1; i <= 16; i + 3)
//             {
//                 Console.Write(i + " ");
//             }
//         }
//     }
// }

// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i = 1;

//             for (; i <= 30;)
//             {

//                 Console.Write(i + " ");
//                 i = i + 3;
//             }
//         }
//     }
// }



// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int increment = 0;
//             bool loopStatus = true;

//             while (loopStatus)
//             {

//                 if (increment > 10)
//                 {
//                     increment -= 1;
//                     loopStatus = false;
//                     Console.WriteLine(increment);
//                 }
//                 else
//                 {
//                     increment += 4;
//                     Console.WriteLine(increment);
//                 }
//             }
//         }
//     }
// }


// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             while (false)
//             {
//                 Console.WriteLine("Halo");
//             }
//         }
//     }
// }

// using System;

// class DemoDoWhile
// {
//     static void Main()
//     {
//         int increment = 10;
//         do
//         {
//             increment += 1;
//             Console.WriteLine(increment);
//             increment -= 2;
//         } while (increment > 0);
//     }
// }


// using System;

// class DemoDoWhile
// {
//     static void Main()
//     {
//         int increment = 0;
//         while (true)
//         {
//             increment++;
//             if (increment % 2 == 0)
//                 continue;

//             if (increment > 10)
//                 break;
//             else
//                 Console.WriteLine(increment);
//         }
//     }
// }


// using System;

// class DemoDoWhile
// {
//     static void Main()
//     {
//         int x = 0;
//         int y = 0;

//         for (int i = 0; i < 20; i++)
//         {
//             x = i * 2;
//             y = i * 3;

//             if (x * y >= 100)
//                 break;

//             Console.WriteLine(x + " " + y);
//         }
//     }
// }


// using System;

// class DemoDoWhile
// {
//     static void Main()
//     {
//         for (int i = 0; i < 5; i++)
//         {
//             for (int j = i; j >= 0; j--)
//             {
//                 Console.Write("* ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// using System;

// class DemoDoWhile
// {
//     static void Main()
//     {

//         int x, y;
//         x = 0;
//         while (x < 3)
//         {
//             x++;

//             y = 0;
//             while (y < x)
//             {
//                 Console.Write("* ");
//                 y++;
//             }
//             Console.WriteLine();
//         }
//     }
// }


// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] namaSiswa = new string[] { "Sari", "Ade", "Mira", "Akbar" };
//             int[] nilaiSiswa = new int[] { 100, 80, 100, 60 };

//             Console.WriteLine("Daftar nilai siswa");

//             for (int i = namaSiswa.Length - 1; i >= 0; i--)
//             {
//                 Console.WriteLine(namaSiswa[i] + " : " + nilaiSiswa[i].ToString());
//             }
//         }
//     }
// }


// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] arrayAngka = new int[] { 100, 80, 100, 60 };

//             for (int i = 0; i <= arrayAngka.Length; i++)
//             {
//                 arrayAngka[i] = arrayAngka[i] * (arrayAngka.Length - i);
//                 Console.WriteLine("new arrayAngka[" + i + "] = " + arrayAngka[i]);
//             }
//         }
//     }
// }



// namespace Belajar1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[,] duaDimensi =
// {
//     {1, 2, 3},  // Baris ke-0
//     {4, 5, 6},  // Baris ke-1
//     {7, 8, 9}   // Baris ke-2
// };
//             int[,] reversedVersion = new int[3, 3];
//             int arrayLength = 3;

//             for (int i = 0; i < arrayLength; i++)
//             {
//                 for (int j = 0; j < arrayLength; j++)
//                 {
//                     reversedVersion[arrayLength - 1 - i, arrayLength - 1 - j] = duaDimensi[i, j];
//                 }
//             }

//             for (int i = 0; i < arrayLength; i++)
//             {
//                 for (int j = 0; j < arrayLength; j++)
//                 {
//                     Console.Write(reversedVersion[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }



namespace Belajar1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] arrayXO = new char[3, 3];

            for (int i = 0; i < arrayXO.GetLength(0); i++)
            {
                for (int j = 0; j < arrayXO.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            arrayXO[i, j] = 'x';
                        }
                        else
                        {
                            arrayXO[i, j] = 'o';
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            arrayXO[i, j] = 'o';
                        }
                        else
                        {
                            arrayXO[i, j] = 'x';
                        }
                    }
                }
            }

            for (int i = 0; i < arrayXO.GetLength(0); i++)
            {
                for (int j = 0; j < arrayXO.GetLength(1); j++)
                {
                    Console.Write(arrayXO[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}