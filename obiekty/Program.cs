using System;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            for (; ; )
            {
                Console.WriteLine("Dodawanie ocen do dzienniczka : ");
                float rating;
                bool result = float.Parse(Console.ReadLine() , out rating);

                if (rating == 11)
                {
                    break;
                }

                if(result == true)
                {
                    if(rating > 0 && rating <=10)
                    {
                    diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba podaj liczbe z zakresu 1 do 10");
                    }
                }
            }

            Console.WriteLine("Srednia :" + diary.CalculateAverage());
            Console.WriteLine("Najwyzsza ocena : " + diary.GiveMaxRating());
            Console.WriteLine($"Najnizsza ocena : " + diary.GiveMINRating());
            Console.ReadKey();
        }
    }
}
