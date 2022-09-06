namespace ArayüzOrnek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
             return Marka.Corolla; 
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }
             

        public Renk StandartRengiNe()
        {
             return Renk.beyaz;
        }


    }
    
}