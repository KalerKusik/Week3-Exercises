using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            /*programm küsib mitu kraadi õues on
            kui õues on rohkem kui 35 kraadi, programm kuvab "boiling hot"
            kui õues on 30-35 kraadi programm kuvab "hot"
            kui õues on 20 kuni 30 kraadi, programm kuvab "nice"
            kui õues on 10 kuni 20 kraadi, programm kuvab "chilly"
            kui õues on 0 kuni 10 kraadi, programm kuvab "cold"
            kui õues on alla 0 kraadi, programm kuvab "holy mary christ on a pogo stick my balls are freezing off please send help"*/

            Console.WriteLine("What Is The Temperature?");
            int Temp = Convert.ToInt32(Console.ReadLine());

            /*Doesnt Work
             
            switch (Temp)
            {
                case >35:
                    Console.WriteLine("Bro You Are Dying");
                    break;

                case > 30:
                    Console.WriteLine("Hot");
                    break;

                case 20:
                    Console.WriteLine("Nice");
                    break;

                case 10:
                    Console.WriteLine("Chilly");
                    break;

                case 0:
                    Console.WriteLine("Cold");
                    break;

                case <0:
                    Console.WriteLine("Freezing Cold");
                    break;*/

            if (Temp >= 35)
            {
                Console.WriteLine("Bro You Are Dying");
            }

           else if (Temp >= 30 && Temp < 35)
            {
                Console.WriteLine("Hot");
            }

           else if (Temp >= 20 && Temp < 30)
            {
                Console.WriteLine("Nice");
            }

           else if (Temp >= 10 && Temp < 20)
            {
                Console.WriteLine("Chilly");
            }

            else if (Temp >= 0 && Temp < 10)
            {
                Console.WriteLine("Cold");
            }

            else
            {
                Console.WriteLine("Holy Mary Christ On a Pogo Stick My Balls Are Freezing Off Please Send He...");
            }
        }
    }
}

