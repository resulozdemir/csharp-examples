namespace inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("bitkiler fotosentez yapar");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
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