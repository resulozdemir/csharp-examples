namespace inheritance
{
    public class Canlilar //    bir sinifin baska sınıflar tarafından turetilmesini kalıtım verilmesini engellemek istiyorsan sealed anahtar kelimesi kullanılır publicten sonra classdan once
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlilar beslenir");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlilar solunum yapar");
        }

        protected void Bosaltim()
        {
            Console.WriteLine("Canlilar bosaltım yapar");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("canlilar uyarilara tepki verir");
        }
    }
}