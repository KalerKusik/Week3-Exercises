using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks:
            //miinimum matemaatikas 85 punkti
            //miinimum keemias 90 punkti
            //miinimum bioloogias 95 punkti
            //programm küsib kasutajal sisestada tema eksami punktid ja otsustab, kas kasutaja saab arstiks õppida

            Console.WriteLine("Sisesta Matemaatika Eksami Punktide Arv:");
            int Math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta Keemia Eksami Punktide Arv:");
            int BreakingBad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta Bioloogia Eksami Punktide Arv:");
            int Biology = Convert.ToInt32(Console.ReadLine());

            if (Math >= 85 && BreakingBad >= 90 && Biology >= 95)
            {
                Console.WriteLine("Teil On Küllalt Punkte Et Arstiks Õppida");
            }    

            else
            {
                Console.WriteLine("Teil Ei Ole Küllalt Punte Et Arstiks Õppida");
            }
        }
    }
}
