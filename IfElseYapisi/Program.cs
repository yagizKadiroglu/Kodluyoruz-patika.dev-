using System;

namespace IfElseYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            // if else çalışma


            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
                Console.WriteLine("Günaydın!");
            if (time <= 18)
                Console.WriteLine("İyi Günler!");
            else
                Console.WriteLine("İyi Akşamlar!");

            string zaman = (time >= 6 && time < 11 ? "Günaydın!" : time <= 18 ? "İyi Günler!" : "İyi Akşamlar!");

            Console.WriteLine(zaman);

            Console.ReadLine();
        }
    }
}
