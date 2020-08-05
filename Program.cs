using System;

namespace deneme19_NameHiding
{
    class Temel
    {
        protected int a;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public void Goster()
        {
            Console.WriteLine("Temel.a =" + a);
        }
    }

    class Tureyen : Temel
    {
        new int a;

        public Tureyen(int aTemel, int aTureyen)
        {
            a = aTureyen;
            base.a = aTemel;
        }
        new public void Goster()
        {
            base.Goster();
            Console.WriteLine("Türeyen.a = " + a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Tureyen nesne = new Tureyen(5, 6);
            nesne.Goster();

        }
    }
}
