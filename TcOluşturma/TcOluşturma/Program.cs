using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Baslangic();
        Cikti();
    }

    static void Baslangic()
    {
        string prompt = "Adınızı girin: ";
        Console.Write(prompt);
        string ad = Console.ReadLine();

        Console.WriteLine(new string('-', prompt.Length));

        Console.WriteLine($"\nMerhaba {ad.ToUpper()}! TC kimlik numarası oluşturma sistemine hoşgeldiniz.");
        Console.WriteLine("TC kimlik numaranız oluşturuluyor...");
        Thread.Sleep(5000);
    }

    static int IlkDeger()
    {
        Random rand = new Random();
        return rand.Next(1, 10);
    }

    static string TcOlustur(int ilkDeger)
    {
        int[] tcDizi = new int[11];
        tcDizi[0] = ilkDeger;

        Random rand = new Random();
        for (int i = 1; i < 10; i++)
        {
            tcDizi[i] = rand.Next(0, 10);
        }

        int toplam = 0;
        for (int i = 0; i < 10; i++)
        {
            toplam += tcDizi[i];
        }

        tcDizi[10] = toplam % 10;

        if (tcDizi[10] % 2 != 0)
        {
            return TcOlustur(ilkDeger);
        }

        return string.Join("", tcDizi);
    }

    static void Cikti()
    {
        Console.WriteLine($"TC Kimlik Numaranız: {TcOlustur(IlkDeger())}");
    }
}

