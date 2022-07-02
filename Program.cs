namespace _60_Dinozorlar
{

    class Canlilar
    {

        public void Öl()
        {
            Console.WriteLine(Turu + "Öldü ");
        }

        public string Adi { get; set; }
        public string YasamSuresi { get; set; }
        public string Turu { get; set; }
        public string Dayaniklik { get; set; }

      


        public Canlilar(string Adi, string YasamSuresi)
        {
           

        }

    }

    class Dinozorlar : Canlilar
    {
        public Dinozorlar(string Adi, string YasamSuresi) : base(Adi, YasamSuresi)
        {

        }

        public string Uzunlugu { get; set; }
        public string Renk { get; set; }
        public string Ucabilme { get; set; }
        public string Tanit
        {
            get
            {
                return "Adi : "+ Adi + " Yasam Suresi : " + YasamSuresi + " Uzunlugu : " + Uzunlugu + " Renk : "+ Renk + " Ucabilme : "+ Ucabilme;
            }
        }




    }

    class Bakteriler : Canlilar
    {
        public Bakteriler(string Adi, string YasamSuresi, string Turu, string Dayaniklik) : base(Adi , YasamSuresi)
        {


        }

        public string Turu { get; set; }
        public string Dayaniklik { get; set; }

        public string Tanit
        {
            get
            {
                return "Adi : " + Adi + " Yasam Suresi : " + YasamSuresi + " Turu : " + Turu + " Dayaniklik : " + Dayaniklik;
            }
        }
    }

  

    

    internal class Program
    {

        static void Main(string[]args)
        {
            int i = 110; 

            Console.WriteLine("Yaşam Döngüsü Oluşturuldu. " + "Şu an bulunulan yıl : " +Yıl);

            Dinozorlar dinozorTrex = new Dinozorlar("Trex", "YasamSuresi");
            Dinozorlar dinozorTitanozor = new Dinozorlar("Titanozor", "YasamSuresi");
            Dinozorlar dinozorBrontozor = new Dinozorlar("brontozor", "YasamSuresi");

            Bakteriler bakteriSu = new Bakteriler("Adi" , "YasamSuresi" , "Turu" , "Dayaniklik");
            Bakteriler bakteriKara = new Bakteriler("Adi", "YasamSuresi", "Turu", "Dayaniklik");
            Bakteriler bakteriHava = new Bakteriler("Adi", "YasamSuresi" , "Turu", "Dayaniklik");


            dinozorTrex.Adi = "Trex";
            dinozorTitanozor.Adi = "Titanozor";
            dinozorBrontozor.Adi = "Brontozor";

            dinozorTrex.YasamSuresi = "90 YIL";
            dinozorTitanozor.YasamSuresi = "70 YIL";
            dinozorBrontozor.YasamSuresi = "50 YIL";

            dinozorTrex.Ucabilme = "Hayır";
            dinozorTitanozor.Ucabilme = "Hayır";
            dinozorBrontozor.Ucabilme = "Evet";

            dinozorTrex.Uzunlugu = "6 Metre";
            dinozorTitanozor.Uzunlugu = "10 Metre";
            dinozorBrontozor.Uzunlugu = "15 Metre";

            dinozorTrex.Renk = "Yeşil";
            dinozorTitanozor.Renk = "Turuncu";
            dinozorBrontozor.Renk = "Gri";



            bakteriSu.Adi = "Su Bakterisi";
            bakteriKara.Adi = "Kara Bakterisi";
            bakteriHava.Adi = "Hava Bakterisi";

            bakteriSu.YasamSuresi = "100 YIL";
            bakteriKara.YasamSuresi = "80 YIL";
            bakteriHava.YasamSuresi = "60 YIL";

            bakteriSu.Turu = "Ölümcül";
            bakteriKara.Turu = "Zararsız";
            bakteriHava.Turu = "Ölümcül";

            bakteriSu.Dayaniklik = "Güçlü";
            bakteriKara.Dayaniklik = "Zayif";
            bakteriHava.Dayaniklik = "Orta";

            


            Console.WriteLine(dinozorTrex.Tanit);

            
            //burada olabilecek senaryoları ekledim. 
            bool HerkesMutlu = true;
            bool AsitYagmuru = true;
            bool MeteorYagmuru = true;
            bool Kış = true;
            bool Kıtlık = true;

            if (HerkesMutlu =true)
            {
                Console.WriteLine("Herkes mutlu, yaşam döngüsü devam ediyor.");
            }

            else
            {
                Console.WriteLine();
            }

            if (AsitYagmuru = true)
            {
                Console.WriteLine("Asit Yağmuru başladı. Maalesef bütün canlıların asitte eridi :( ");

            }
            else
            {
                Console.WriteLine();

            }

            if (MeteorYagmuru = true)
            {
                Console.WriteLine("Meteor Yağmuru başladı. Maalesef bütün dinozorların ve Kara Bakterilerin öldü :( ");
            }

            else
            {
                Console.WriteLine();
            }

            if (Kış = true)
            {
                Console.WriteLine("Kış geldi. Bakterilerinin bir kısmı soğuk havaya dayanamayıp öldü. Yaşam döngüsü devam ediyor. İşte sonuçlar: ");
                Console.WriteLine("Trex : Yaşıyor");
                Console.WriteLine("Titanozor : Yaşıyor");
                Console.WriteLine("Brontozor : Yaşıyor");
                Console.WriteLine("Su Bakterisi : Bir kısmı öldü :( ");
                Console.WriteLine("Kara Bakterisi : Bir kısmı öldü :( ");
                Console.WriteLine("Hava Bakterisi : Yaşıyor");
                
            }

            else
            {
                Console.WriteLine();
            }

            if (Kıtlık = true)
            {
                Console.WriteLine(" Kıtlık başladı, besinler tükeniyor. Açlıktan ölen canlıların sonuçları : ");
                Console.WriteLine("Trex : Bir kısmı öldü :( ");
                Console.WriteLine("Titanozor : Yaşıyor");
                Console.WriteLine("Brontozor : Bir kısmı öldü :( ");
                Console.WriteLine("Su Bakterisi : Yaşıyor ");
                Console.WriteLine("Kara Bakterisi : Bir kısmı öldü :( ");
                Console.WriteLine("Hava Bakterisi : Yaşıyor");
            }

            else
            {
                Console.WriteLine();
            }

            if (Kıtlık && Kış)
            {
                Console.WriteLine("Canlılar hem açlık hem de kış ile mücadele ediyor. Mutlu değiller");
            }

            else
            {
                Console.WriteLine();
            }



            //burada .YasamSuresi komutunu int yapamadığım için mecburen manuel olarak girmek zorunda kaldım.

            int Yıl = 10;

            if (Yıl > 90)
            {
                Console.WriteLine("Trex öldü, yaşam süresi doldu.");
                Console.WriteLine("Titanozor öldü, yaşam süresi doldu.");
                Console.WriteLine("Brontozor öldü, yaşam süresi doldu.");
                Console.WriteLine("Kara Bakteri öldü, yaşam süresi doldu.");
            }

            else
            {
                Console.WriteLine();
            }

           

        }




    }




}
//dinozorTrex.YasamSuresi = "90 YIL";
//dinozorTitanozor.YasamSuresi = "70 YIL";
//dinozorBrontozor.YasamSuresi = "50 YIL";

//bakteriSu.YasamSuresi = "100 YIL";
//bakteriKara.YasamSuresi = "80 YIL";
//bakteriHava.YasamSuresi = "60 YIL";
