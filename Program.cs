using System;

namespace deneme19_NameHiding
{

    class Program
    {
        public static void OzGoster(Memeli memeli)
        {
            Console.WriteLine("Boy = " + memeli.Boy);
            Console.WriteLine("Ağırlık = " + memeli.Agirlik + "\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Tureyen nesne = new Tureyen(5, 6);
            nesne.Goster();


            Kedi kedi1 = new Kedi("Van", 25, 3);
            Kedi kedi2;

            kedi2 = kedi1;

            kedi2.OzellikGoster();
            kedi2.TurGoster();

            Memeli memeli = new Memeli(23.5, 2.5);

            memeli = kedi1;
            memeli.OzellikGoster();

            Memeli memeli1 = new Memeli(55.5, 60.6);

            Koyun koyun = new Koyun("Ankara", 52, 60);
            Console.WriteLine();
            OzGoster(memeli1);
            OzGoster(kedi2);
            OzGoster(koyun);







        }
    }
}
