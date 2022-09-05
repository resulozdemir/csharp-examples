namespace inheritance
{
    public class Hayvanlar:Canlilar 
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("hayvanlar adaptasyon kurabilir");
        }
    }

    public class Sürüngenler:Hayvanlar
    {
         public Sürüngenler() //default consturactorun icerisine bu sekilde yazarsan her yeni nesne olusturmada cagrılır
         {
            base.Adaptasyon();      //base miras veren ust sınıfların protected metotlarına erisim saglar
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
         }
         
         public void SurunerekHareketEtme()
         {
            Console.WriteLine("surungenler surunerek hareket eder");
         }
    }
    public class Kuslar:Hayvanlar
    {
        public Sürüngenler() //default consturactorun icerisine bu sekilde yazarsan her yeni nesne olusturmada cagrılır
         {
            base.Adaptasyon();      //base miras veren ust sınıfların protected metotlarına erisim saglar
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
         }
         
         public void Ucmak()
         {
            Console.WriteLine("kuslar ucar");
         }
    }
}