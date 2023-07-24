using System;

namespace LinkedList
{
    public class Program
    {

        public class Halka
        {
            public int Sıra { get; set; }
            public Halka Sonraki { get; set; }

            public Halka(int sira)
            {
                Sıra = sira;
                Sonraki = null;
            }
        }


        public class Zincir
        {
            public Halka Bas { get; set; }


            public void Ekle(int sira)
            {
                var halka = new Halka(sira);
                if (Bas == null)
                {
                    Bas = halka;
                }
                else
                {
                    var guncel = Bas;

                    while (guncel.Sonraki != null)
                    {
                        guncel = guncel.Sonraki;
                    }
                    guncel.Sonraki = halka;
                }
            }
            public void Sil(int sira)
            {
                if (Bas == null)
                {
                    return;
                }
                else
                {           // 10 20 30 40 50      ---> 30  

                    var halka = Bas;
                    //while (halka.Sıra != sira)
                    //{
                    //    if (sira == halka.Sonraki.Sıra)
                    //    {
                    //        if (halka.Sonraki.Sonraki == null)
                    //        {
                    //            halka.Sonraki = null;
                    //            return;
                    //        }
                    //        halka.Sonraki = halka.Sonraki.Sonraki;
                    //        return;
                    //    }
                    //    halka=halka.Sonraki;
                    //}

                    while (halka.Sonraki != null)
                    {

                        if (halka.Sonraki.Sıra == sira)
                        {
                            halka.Sonraki = halka.Sonraki.Sonraki;
                            return;
                        }
                        halka = halka.Sonraki;
                    }

                }
            }
            public void Yazdir()
            {
                while (Bas.Sonraki != null)
                {
                    Console.Write(Bas.Sıra + " ");
                    Bas = Bas.Sonraki;
                }
                Console.Write(Bas.Sıra);
            }

        }


        static void Main(string[] args)
        {
            Zincir zincir = new Zincir();
            zincir.Ekle(10);
            zincir.Ekle(20);
            zincir.Ekle(30);
            zincir.Ekle(40);
            zincir.Ekle(50);

            //zincir.Yazdir();


            zincir.Sil(50);
            zincir.Sil(30);
            zincir.Sil(10);
            zincir.Sil(20);
            zincir.Yazdir();

            Console.ReadLine();
        }
    }
}
