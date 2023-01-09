// using System;

// public class Program
// {
//     private double tambah(double a, double b)
//     {

//         return (a + b);
//     }

//     private double kurang(double a, double b)
//     {
//         return (a - b);
//     }

//     private double kali(double a, double b)
//     {
//         return (a * b);
//     }

//     private double bagi(double a, double b)
//     {
//         return (a / b);
//     }

//     public void Main()
//     {

//         double bil1, bil2;
//         char pilihan;
//         Console.WriteLine(" ========================================");
//         Console.WriteLine(" |	Program Kalkulator Sederhana	");
//         Console.WriteLine(" ========================================");
//         Console.WriteLine("\n");
//         Console.WriteLine(" ========================================");
//         Console.WriteLine(" |	     Masukan Pilihan		");
//         Console.WriteLine(" ========================================");
//         Console.WriteLine(" |					");
//         Console.WriteLine(" |	(A) Tambah  (B) Kurang	");
//         Console.WriteLine(" |	(C) Kali	(D) Bagi	");
//         Console.WriteLine(" |					");
//         Console.WriteLine(" ========================================");
//         Console.WriteLine(" Masukan Pilihan		: ");
//         pilihan = Convert.ToChar(Console.ReadLine());
//         Console.WriteLine("\n");

//         if (pilihan == 'A' || pilihan == 'a')
//         {
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" |	     Masukan Bilangan		");
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" |					");
//             Console.WriteLine(" | Masukan Bilangan pertama : ");
//             bil1 = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine(" | Masukan Bilangan kedua : ");
//             bil2 = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine(" |					");
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" | Hasilnya Adalah : " + tambah(bil1, bil2) + "			");
//             Console.WriteLine(" ========================================");

//         }

//         else if (pilihan == 'B' || pilihan == 'b')
//         {
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" |	     Masukan Bilangan		");
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" |					");
//             Console.WriteLine(" | Masukan Bilangan pertama : ");
//             bil1 = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine(" | Masukan Bilangan kedua : ");
//             bil2 = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine(" |					");
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" | Hasilnya Adalah : " + kurang(bil1, bil2) + "			");
//             Console.WriteLine(" ========================================");
//         }

//         else if (pilihan == 'c' || pilihan == 'C')
//         {
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" |	     Masukan Bilangan		");
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" |					");
//             Console.WriteLine(" | Masukan Bilangan pertama : ");
//             bil1 = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine(" | Masukan Bilangan kedua : ");
//             bil2 = Convert.ToDouble(Console.ReadLine()); ;
//             Console.WriteLine(" |					");
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" | Hasilnya Adalah : " + kali(bil1, bil2) + "			|");
//             Console.WriteLine(" ========================================");

//         }

//         else if (pilihan == 'D' || pilihan == 'd')
//         {
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" |	     Masukan Bilangan		");
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" |					");
//             Console.WriteLine(" | Masukan Bilangan pertama : ");
//             bil1 = Convert.ToDouble(Console.ReadLine());

//             Console.WriteLine(" | Masukan Bilangan kedua : ");
//             bil2 = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine(" |					|");
//             Console.WriteLine(" ========================================");
//             Console.WriteLine(" | Hasilnya Adalah : " + bagi(bil1, bil2) + "			|");
//             Console.WriteLine(" ========================================");
//         }

//         Console.WriteLine("\n");
//         Console.WriteLine(" ========================================");
//         Console.WriteLine(" | Learn more @ idcsharp.com 		");
//         Console.WriteLine(" ========================================");
//         Console.WriteLine(" ");

//     }
// }




// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Kalkulator
// {
//     public class Kalkulator_Sederhana
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter the action to be performed");
//             Console.WriteLine("Press 1 for Addition");
//             Console.WriteLine("Press 2 for Substraction");
//             Console.WriteLine("Press 3 for Multiplication");
//             Console.WriteLine("Press 4 for Division");
//             Console.WriteLine();
//             int act = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Enter 1st input");
//             int num1 = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Enter 2nd input");
//             int num2 = Convert.ToInt32(Console.ReadLine());
//             Console.Write("The result is ");
//             if (act == 1) Console.Write(num1 + num2);
//             else if (act == 2) Console.Write(num1 - num2);
//             else if (act == 3) Console.Write(num1 * num2);
//             else if (act == 4)
//             {
//                 if (num1 % num2 == 0) Console.Write(num1 / num2);
//                 else Console.Write(Convert.ToDouble(num1) / Convert.ToDouble(num2));
//             }
//         }
//     }
// }




// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Tugas_Lab_2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Title = "Aplikasi Calculator";

//             Console.WriteLine("1.Penambahan");
//             Console.WriteLine("2.Pengurangan");
//             Console.WriteLine("3.Perkalian");
//             Console.WriteLine("4.Pembagian");


//             Console.Write("Masukan Menu pilihan Operator [1, 2, 3, 4]:");
//             int angka1;
//             int angka2;
//             int total = 0;
//             int pilihan = Int32.Parse(Console.ReadLine());

//             if (pilihan == 1)
//             {
//                 Console.Write("Masukan Nilai Angka A = ");
//                 int a = int.Parse(Console.ReadLine());
//                 Console.Write("Masukan Nilai Angka B = ");
//                 int b = Convert.ToInt32(Console.ReadLine());
//                 total = a + b;
//                 Console.WriteLine("Jumlah = {0}", total);
//             }
//             else if (pilihan == 2)
//             {
//                 Console.Write("Masukan Nilai Angka A = ");
//                 int a = int.Parse(Console.ReadLine());
//                 Console.Write("Masukan Nilai Angka B = ");
//                 int b = Convert.ToInt32(Console.ReadLine());
//                 total = a - b;
//                 Console.WriteLine("Jumlah = {0}", total);
//             }
//             else if (pilihan == 3)
//             {
//                 Console.Write("Masukan Nilai Angka A = ");
//                 int a = int.Parse(Console.ReadLine());
//                 Console.Write("Masukan Nilai Angka B = ");
//                 int b = Convert.ToInt32(Console.ReadLine());
//                 total = a * b;
//                 Console.WriteLine("Jumlah = {0}", total);
//             }
//             else if (pilihan == 4)
//             {
//                 Console.Write("Masukan Nilai Angka A = ");
//                 int a = int.Parse(Console.ReadLine());
//                 Console.Write("Masukan Nilai Angka B = ");
//                 int b = Convert.ToInt32(Console.ReadLine());
//                 total = a / b;
//                 Console.WriteLine("Jumlah = {0}", total);
//             }
//             else
//             {
//                 Console.WriteLine("Maaf Pilihan Anda Tidak Ada");
//             }

//             Console.WriteLine("\nTekan sembarang key untuk keluar");
//             Console.ReadKey();

//         }
//     }
// }




// using System;
// namespace Program
// {
//     class Calculator
//     {
//         static void Main(String[] args)
//         {
//             int a, b, menu, result;
//             Console.WriteLine("Enter the action to be performed");
//             pilihan();
//             menu = Convert.ToInt32(Console.ReadLine());

//             switch (menu)
//             {
//                 case 1:
//                     Console.WriteLine("Enter 1st input");
//                     a = Convert.ToInt32(Console.ReadLine());
//                     Console.WriteLine("Enter 2st input");
//                     b = Convert.ToInt32(Console.ReadLine());
//                     result = a + b;
//                     Console.WriteLine($"The result is {result}");
//                     break;

//                 case 2:
//                     Console.WriteLine("Enter 1st input");
//                     a = Convert.ToInt32(Console.ReadLine());
//                     Console.WriteLine("Enter 2st input");
//                     b = Convert.ToInt32(Console.ReadLine());
//                     result = a - b;
//                     Console.WriteLine($"The result is {result}");
//                     break;

//                 case 3:
//                     Console.WriteLine("Enter 1st input");
//                     a = Convert.ToInt32(Console.ReadLine());
//                     Console.WriteLine("Enter 2st input");
//                     b = Convert.ToInt32(Console.ReadLine());
//                     result = a * b;
//                     Console.WriteLine($"The result is {result}");
//                     break;

//                 case 4:
//                     Console.WriteLine("Enter 1st input");
//                     a = Convert.ToInt32(Console.ReadLine());
//                     Console.WriteLine("Enter 2st input");
//                     b = Convert.ToInt32(Console.ReadLine());
//                     result = a / b;
//                     Console.WriteLine($"The result is {result}");
//                     break;
//                 default:
//                     Console.WriteLine("Input is not valid");
//                     break;
//             }
//             void pilihan()
//             {
//                 Console.WriteLine("Press 1 for Addiction");
//                 Console.WriteLine("Press 2 for Substraction");
//                 Console.WriteLine("Press 3 for Multiplication");
//                 Console.WriteLine("Press 4 for Division\n");
//             }
//         }
//     }
// }






// using System;

// namespace kalkulator
// {
//     class kalkulator
//     {

//         static void Main(String[] args)
//         {
//             Console.WriteLine("Kalkulator sederhana 2 bilangan");
//             Console.WriteLine(" ");
//             Console.WriteLine("1.Penjumlahan");
//             Console.WriteLine("2.Pengurangan");
//             Console.WriteLine("3.perkalian");
//             Console.WriteLine("4.Pembagian");
//             Console.WriteLine(" ");
//             Console.WriteLine("SIlahkan Pilih (1/2/3/4)");
//             int pilih = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("masukkan angka pertama:");
//             Double angka1 = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine("masukkan angka kedua:");
//             Double angka2 = Convert.ToDouble(Console.ReadLine());
//             double hasil = 0;
//             switch (pilih)
//             {
//                 case 1:
//                     {
//                         hasil = tambah(angka1, angka2);
//                         break;
//                     }
//                 case 2:
//                     {
//                         hasil = kurang(angka1, angka2);
//                         break;
//                     }
//                 case 3:
//                     {
//                         hasil = kali(angka1, angka2);
//                         break;
//                     }
//                 case 4:
//                     {
//                         hasil = bagi(angka1, angka2);
//                         break;
//                     }
//                 default:
//                     Console.WriteLine("pilihan tidak ada, silahkan coba lagi !!!");
//                     break;
//             }




//             if (pilih == 1)
//             {
//                 Console.WriteLine("hasil dari penjumlahan " + angka1 + " dan " + angka2 + " adalah " + hasil);
//             }

//             else if (pilih == 2)
//             {
//                 Console.WriteLine("hasil dari pengurangan " + angka1 + " dan " + angka2 + " adalah " + hasil);
//             }

//             else if (pilih == 3)
//             {
//                 Console.WriteLine("hasil dari pembagian " + angka1 + " dan " + angka2 + " adalah " + hasil);
//             }
//             else if (pilih == 4)
//             {
//                 Console.WriteLine("hasil dari perkalian " + angka1 + " dan " + angka2 + " adalah " + hasil);
//             }
//             else
//             {
//                 Console.WriteLine("inputan salah, silahkan coba lagi !!!");
//             }
//         }



//         public static double tambah(double angka1, double angka2)
//         {
//             double hasil = angka1 + angka2;
//             return hasil;
//         }
//         public static double kurang(double angka1, double angka2)
//         {
//             double hasil = angka1 - angka2;
//             return hasil;
//         }
//         public static double kali(double angka1, double angka2)
//         {
//             double hasil = angka1 * angka2;
//             return hasil;
//         }
//         public static double bagi(double angka1, double angka2)
//         {
//             double hasil = angka1 / angka2;
//             return hasil;
//         }
//     }

// }



using System;
namespace kalkulator;
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Title = "Kalkulator Sederhana";

        //header
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("=== SELAMAT MENGGUNAKAN KALKULATOR SEDERHANA! ===");

        //list operasi matematika
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Berikut list operasi yang tersedia:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("1. (+) Penjumlahan\n2. (-) Pengurangan\n3. (*) Perkalian\n4. (/) Pembagian");

        //memilih operasi matematika
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ketik nomor operasi matematika yang ingin kamu gunakan:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int operasi = Convert.ToInt32(Console.ReadLine());

        //deklarasi variabel bilangan 1 dan 2
        float bil1, bil2 = 0.0f;

        //inisialiasi bilangan 1 dan 2
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ketik bilangan pertama:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        bil1 = float.Parse(Console.ReadLine() ?? "");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ketik bilangan kedua:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        bil2 = float.Parse(Console.ReadLine() ?? "");

        //menampilkan hasil operasi matematika
        switch (operasi)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil penjumlahan dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 + bil2) + "\n");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil pengurangan dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 - bil2) + "\n");
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil perkalian dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 * bil2) + "\n");
                break;
            case 4:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil pembagian dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 / bil2) + "\n");
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operasi yang kamu pilih tidak tersedia!\n");
                break;
        }

        //user memilih apakah ingin menghitung ulang
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Apakah kamu ingin menghitung lagi? (y/n)");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        string ulang = Console.ReadLine() ?? "";
        if (ulang == "y")
        {
            Main(args);
        }
        else
        {
            //program keluar
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Terima kasih telah mencoba kalkulator sederhana!\nTekan tombol apapun untuk keluar...");
            Console.ReadKey();
        }
    }
}



// using System;
// namespace SkilvulTugas
// {

//     class CalculatorSederhana
//     {
//         static void Main(String[] args)
//         {
//             // Pembuka
//             Console.WriteLine("========================================");
//             Console.WriteLine("-------- CALCULATOR SEDERHANA ----------");
//             Console.WriteLine("========================================");

//             int ulang = 1; //kunci perulangan

//             do
//             {
//                 // Menerima input user
//                 Console.WriteLine("\nOperator Aritmatika");
//                 Console.WriteLine("1. + (Penjumlahan)\n2. - (Pengurangan)\n3. * (Perkalian)\n4. / (Pembagian)");
//                 Console.Write("\nPilih metode yang Anda inginkan: ");
//                 string Metode = Console.ReadLine() ?? "";
//                 int metode = int.Parse(Metode);

//                 //Operasi
//                 switch (metode)
//                 {
//                     case 1:
//                         float a, b, hasil;

//                         Console.WriteLine("\n------------- PENJUMLAHAN --------------");
//                         Console.Write("Masukkan angka ke-1 : ");
//                         String A = MengambilInput();
//                         a = float.Parse(A);
//                         Console.Write("Masukkan angka ke-2 : ");
//                         String B = MengambilInput();
//                         b = float.Parse(B);

//                         hasil = a + b;
//                         Console.Write($"\nHasil dari penjumlahan {a} + {b} = {hasil}");

//                         Console.Write("\nApakah Anda akan melakukan perhitungan kembali? Tekan [Y] untuk melanjutkan : ");
//                         string Pilihan = Console.ReadLine() ?? "";
//                         char pilihan = char.Parse(Pilihan);

//                         ulang = UlangProgram(pilihan);
//                         break;
//                     case 2:
//                         Console.WriteLine("\n------------- PENGURANGAN --------------");
//                         Console.Write("Masukkan angka ke-1 : ");
//                         A = MengambilInput();
//                         a = float.Parse(A);
//                         Console.Write("Masukkan angka ke-2 : ");
//                         B = MengambilInput();
//                         b = float.Parse(B);

//                         hasil = a - b;
//                         Console.Write($"\nHasil dari penjumlahan {a} - {b} = {hasil}");

//                         Console.Write("\nApakah Anda akan melakukan perhitungan kembali? Tekan [Y] untuk melanjutkan : ");
//                         Pilihan = Console.ReadLine() ?? "";
//                         pilihan = char.Parse(Pilihan);

//                         ulang = UlangProgram(pilihan);
//                         break;
//                     case 3:
//                         Console.WriteLine("\n-------------- PERKALIAN ---------------");
//                         Console.Write("Masukkan angka ke-1 : ");
//                         A = MengambilInput();
//                         a = float.Parse(A);
//                         Console.Write("Masukkan angka ke-2 : ");
//                         B = MengambilInput();
//                         b = float.Parse(B);

//                         hasil = a * b;
//                         Console.Write($"\nHasil dari penjumlahan {a} * {b} = {hasil}");

//                         Console.Write("\nApakah Anda akan melakukan perhitungan kembali? Tekan [Y] untuk melanjutkan : ");
//                         Pilihan = Console.ReadLine() ?? "";
//                         pilihan = char.Parse(Pilihan);

//                         ulang = UlangProgram(pilihan);
//                         break;
//                     case 4:
//                         Console.WriteLine("\n-------------- PEMBAGIAN ---------------");
//                         Console.Write("Masukkan angka ke-1 : ");
//                         A = MengambilInput();
//                         a = float.Parse(A);
//                         Console.Write("Masukkan angka ke-2 : ");
//                         B = MengambilInput();
//                         b = float.Parse(B);

//                         if (b == 0)
//                         {
//                             b = 0; //syarat
//                             while (b == 0)
//                             {
//                                 Console.Write("Masukkan angka ke-2 (selain 0): ");

//                                 B = MengambilInput();
//                                 b = float.Parse(B);
//                             }
//                         }

//                         hasil = a / b;
//                         Console.Write($"\nHasil dari penjumlahan {a} / {b} = {hasil}");

//                         Console.Write("\nApakah Anda akan melakukan perhitungan kembali? Tekan [Y] untuk melanjutkan : ");
//                         Pilihan = Console.ReadLine() ?? "";
//                         pilihan = char.Parse(Pilihan);

//                         ulang = UlangProgram(pilihan);
//                         break;
//                     default:
//                         Console.WriteLine("\n----------------------------------------");
//                         Console.WriteLine("Pilih metode dengan benar!");
//                         ulang = 1;
//                         break;
//                 }
//             } while (ulang == 1);
//         }

//         // Method yang berfungsi mengulang program
//         static int UlangProgram(char pil)
//         {
//             if (pil == 'y' || pil == 'Y')
//             {
//                 return 1;
//             }
//             else
//             {
//                 return 0;
//             }
//         }

//         // Method yang berfungsi mengambil input dari user
//         static string MengambilInput()
//         {
//             string Input = Console.ReadLine() ?? "";
//             return Input;
//         }
//     }
// }



// using System;

// namespace Simple_Csharp_Calculator
// {
//     class Operator
//     {
//         static void Main(String[] args)
//         {
//             string loop;
//             do
//             {
//                 Console.WriteLine("KALKULATOR SEDERHANA");
//                 Console.WriteLine("===============");
//                 Console.WriteLine("Inputkan 1 untuk melakukan operasi penambahan");
//                 Console.WriteLine("Inputkan 2 untuk melakukan operasi pengurangan");
//                 Console.WriteLine("Inputkan 3 untuk melakukan operasi perkalian");
//                 Console.WriteLine("Inputkan 4 untuk melakukan operasi pembagian");

//                 int rumus;
//                 //menginputkan angka pertama
//                 Console.Write("Input angka pertama :");
//                 int angka1 = Convert.ToInt32(Console.ReadLine());
//                 //menginputkan angka kedua
//                 Console.Write("Input angka kedua :");
//                 int angka2 = Convert.ToInt32(Console.ReadLine());
//                 /*menginputkan operasi sesuai dengan yang dipilih
//                     1 = penambahan
//                     2 = pengurangan
//                     3 = perkalian
//                     4 = pembagian
//                 */
//                 Console.Write("Inputkan operator yang dipilih (1/2/3/4) :");
//                 string inputan = Console.ReadLine();

//                 switch (inputan)
//                 {
//                     //operasi penambahan
//                     case "1":
//                         rumus = angka1 + angka2;
//                         Console.WriteLine("Hasil penambahan adalah " + rumus);
//                         break;
//                     //operasi pengurangan
//                     case "2":
//                         rumus = angka1 - angka2;
//                         Console.WriteLine("Hasil pengurangan adalah " + rumus);
//                         break;
//                     //operasi perkalian
//                     case "3":
//                         rumus = angka1 * angka2;
//                         Console.WriteLine("Hasil perkalian adalah " + rumus);
//                         break;
//                     //operasi pembagian
//                     case "4":
//                         rumus = angka1 / angka2;
//                         Console.WriteLine("Hasil pembagian adalah " + rumus);
//                         break;
//                     //operasi tidak ditemukan
//                     default:
//                         Console.WriteLine("Tidak ada pilihan operator");
//                         break;
//                 }

//                 Console.ReadLine();
//                 //inputan perulangan
//                 Console.Write("Lanjutkan perhitungan? (Ketik 'y' untuk melanjutkan");
//                 loop = Console.ReadLine();
//             }
//             //nilai y untuk melanjutkan perulangan
//             while (loop == "y");
//         }
//     }
// }




// using System;
// public class Calculator
// {
//     static void Main(string[] args)
//     {
//         float num1, num2 = 0.0f;

//         Console.WriteLine("Enter action to be performed");
//         Console.WriteLine("=============================");
//         Console.WriteLine("Press 1 for Addition");
//         Console.WriteLine("Press 2 for Subtraction");
//         Console.WriteLine("Press 3 for Multiplication");
//         Console.WriteLine("Press 4 for Division");
//         int proses = int.Parse(Console.ReadLine() ?? "");

//         Console.WriteLine("Enter 1st Input");
//         num1 = float.Parse(Console.ReadLine() ?? "");

//         Console.WriteLine("Enter 2nd Input");
//         num2 = float.Parse(Console.ReadLine() ?? "");

//         switch (proses)
//         {
//             case 1:
//                 Console.WriteLine($"Result : {num1} + {num2} = " + (num1 + num2));
//                 break;

//             case 2:
//                 Console.WriteLine($"Result : {num1} - {num2} = " + (num1 - num2));
//                 break;

//             case 3:
//                 Console.WriteLine($"Result : {num1} * {num2} = " + (num1 * num2));
//                 break;

//             case 4:
//                 Console.WriteLine($"Result : {num1} / {num2} = " + (num1 / num2));
//                 break;
//         }
//     }
// }

// class Kalkulator
// {
//     static void Main(string[] args)
//     {
//         char ulangi;
//         do
//         {
//             Console.WriteLine(" ");
//             Console.WriteLine("Enter the action to be performed");
//             string[] arrayOperator = {
//                 "Addition","Substraction","Multiplication","Division"
//             };

//             for (int i = 0; i < arrayOperator.Length; i++)
//             {
//                 Console.WriteLine("Press " + i + " for : " + arrayOperator[i]);
//             }
//             Console.WriteLine(" ");

//             Console.Write("Press (0/1/2/3): ");
//             int press = Convert.ToInt32(Console.ReadLine());

//             if (press == 0)
//             {
//                 Console.Write("Enter 1st input : ");
//                 double one = Convert.ToDouble(Console.ReadLine());
//                 Console.Write("Enter 2nd input : ");
//                 double two = Convert.ToDouble(Console.ReadLine());

//                 double hasilTambah = tambah(one, two);

//                 Console.WriteLine("Hasil Penambahan : " + hasilTambah);

//             }
//             if (press == 1)
//             {
//                 Console.Write("Enter 1st input : ");
//                 double one = Convert.ToDouble(Console.ReadLine());
//                 Console.Write("Enter 2nd input : ");
//                 double two = Convert.ToDouble(Console.ReadLine());

//                 double hasilKurang = kurang(one, two);

//                 Console.WriteLine("Hasil Pengurangan : " + hasilKurang);

//             }
//             if (press == 2)
//             {
//                 Console.Write("Enter 1st input : ");
//                 double one = Convert.ToDouble(Console.ReadLine());
//                 Console.Write("Enter 2nd input : ");
//                 double two = Convert.ToDouble(Console.ReadLine());

//                 double hasilPerkalian = kali(one, two);

//                 Console.WriteLine("Hasil Perkalian : " + hasilPerkalian);

//             }
//             if (press == 3)
//             {
//                 Console.Write("Enter 1st input : ");
//                 double one = Convert.ToDouble(Console.ReadLine());
//                 Console.Write("Enter 2nd input : ");
//                 double two = Convert.ToDouble(Console.ReadLine());

//                 double hasilPembagian = bagi(one, two);

//                 Console.WriteLine("Hasil Pembagian : " + hasilPembagian);

//             }
//             Console.Write("Ulangi Operator (y/n) : ");
//             ulangi = char.Parse(Console.ReadLine() ?? "");
//         } while (ulangi == 'y' || ulangi == 'Y');
//     }
//     class Kalkulator
//     {
//         static void Main(string[] args)
//         {
//             char ulangi;
//             do
//             {
//                 Console.WriteLine(" ");
//                 Console.WriteLine("Enter the action to be performed");
//                 string[] arrayOperator = {
//                 "Addition","Substraction","Multiplication","Division"
//             };

//                 for (int i = 0; i < arrayOperator.Length; i++)
//                 {
//                     Console.WriteLine("Press " + i + " for : " + arrayOperator[i]);
//                 }
//                 Console.WriteLine(" ");

//                 Console.Write("Press (0/1/2/3): ");
//                 int press = Convert.ToInt32(Console.ReadLine());

//                 if (press == 0)
//                 {
//                     Console.Write("Enter 1st input : ");
//                     double one = Convert.ToDouble(Console.ReadLine());
//                     Console.Write("Enter 2nd input : ");
//                     double two = Convert.ToDouble(Console.ReadLine());

//                     double hasilTambah = tambah(one, two);

//                     Console.WriteLine("Hasil Penambahan : " + hasilTambah);

//                 }
//                 if (press == 1)
//                 {
//                     Console.Write("Enter 1st input : ");
//                     double one = Convert.ToDouble(Console.ReadLine());
//                     Console.Write("Enter 2nd input : ");
//                     double two = Convert.ToDouble(Console.ReadLine());

//                     double hasilKurang = kurang(one, two);

//                     Console.WriteLine("Hasil Pengurangan : " + hasilKurang);

//                 }
//                 if (press == 2)
//                 {
//                     Console.Write("Enter 1st input : ");
//                     double one = Convert.ToDouble(Console.ReadLine());
//                     Console.Write("Enter 2nd input : ");
//                     double two = Convert.ToDouble(Console.ReadLine());

//                     double hasilPerkalian = kali(one, two);

//                     Console.WriteLine("Hasil Perkalian : " + hasilPerkalian);

//                 }
//                 if (press == 3)
//                 {
//                     Console.Write("Enter 1st input : ");
//                     double one = Convert.ToDouble(Console.ReadLine());
//                     Console.Write("Enter 2nd input : ");
//                     double two = Convert.ToDouble(Console.ReadLine());

//                     double hasilPembagian = bagi(one, two);

//                     Console.WriteLine("Hasil Pembagian : " + hasilPembagian);

//                 }
//                 Console.Write("Ulangi Operator (y/n) : ");
//                 ulangi = char.Parse(Console.ReadLine() ?? "");
//             } while (ulangi == 'y' || ulangi == 'Y');
//         }
//         static double tambah(double one, double two) => one + two;
//         static double kurang(double one, double two) => one - two;
//         static double kali(double one, double two) => one * two;
//         static double bagi(double one, double two) => one / two;
//     }
// }
