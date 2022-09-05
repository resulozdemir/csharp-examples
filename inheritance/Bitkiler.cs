namespace inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("bitkiler fotosentez yapar");
        }
        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            Console.WriteLine("bitkiler gunese tepki verir");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler() //default consturactorun icerisine bu sekilde yazarsan her yeni nesne olusturmada cagrılır
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }

        public void TohumlaCogalma()
        {
            Console.WriteLine("tohumlu bitkiler tohumla cogalır");
        }
    }

    public class TohumlusuzBitkiler:Bitkiler
    {
        public TohumlusuzBitkiler()        //default consturactorun icerisine bu sekilde yazarsan her yeni nesne olusturmada cagrılır
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
 
        public void SporlaCogalma()     //bunu yazmamasının nedeni inheritancede cagırmamamız
        {
            Console.WriteLine("tohumlu bitkiler sporla cogalır");
        }
    }
    
}