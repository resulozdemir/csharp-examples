try
{
    Console.WriteLine("Bir sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
} 
catch (Exception ex)
{
    string hata = "Hata: " + (string)ex.Message;
    Console.WriteLine(hata);
} 
finally
{
    Console.WriteLine("İşlem tamamlandı");
}

try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a = int.Parse("20000000000");
}
catch (FormatException ex)
{
    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine(ex);
}
catch (OverflowException ex)
{
    Console.WriteLine("Çok küçük veya çok büyük değer girdiniz!");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("İşlem Başarıyla tamamlandı.");
}