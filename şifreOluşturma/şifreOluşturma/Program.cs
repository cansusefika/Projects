using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Program başlatılıyor...");
        await Task.Delay(5000);


        Console.WriteLine("Şifreniz oluşturuluyor");

        Random random = new Random();
        string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789?*_-,";
        int randomLength = random.Next(6, 13);

        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            await Task.Delay(1000);


            Console.WriteLine();

            string password = "";
            for (int j = 0; i < randomLength; i++)
            {
                char randomChar = characters[random.Next(characters.Length)];
                password += randomChar;
                Console.WriteLine(randomChar);
                await Task.Delay(1000);
            }

            Console.WriteLine("\nŞifre oluşturma tamamlandı.");

            if (password.Length >= 10)
            {
                Console.WriteLine("Güvenilir bir şifre oluşturuldu");
            }
            else if (password.Length >= 8)
            {
                Console.WriteLine("Orta düzey bir şifre oluşturuldu");
            }
            else
            {
                Console.WriteLine("Zayıf bir şifre oluşturuldu");
            }

            Console.WriteLine("Tekrar denemek isterseniz 'E' yazınız");

        }
    }
}
