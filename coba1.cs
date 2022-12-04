using System;
namespace SkilvulLearning {
    class PropertyTest
    {
        private string materi;
        
        public string Materi
        {
            get { return materi; }
            set { 
                if (value == "pemrograman")
                    materi = "mari belajar C#";
                else {
                    materi = value + " tidak terdaftar";
                } 
            }
        }
    }
        
    class Program {
        static void Main(string[] args) {
            PropertyTest p = new PropertyTest();
            p.Materi = "pemrograman";
            Console.WriteLine(p.Materi);
            p.Materi = "matematika";
            Console.WriteLine(p.Materi);
        }
    }
}