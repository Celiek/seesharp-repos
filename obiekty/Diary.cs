using System.Collections.Generic;
using System;
using System.Linq;

namespace StudentDiary
{
    public class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        //Stan (zmienne w tym przypadku pola)
        List<float> ratings;


        //Zachowania

        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();

            return avg;
        }

        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        public float GiveMINRating()
        {
            return ratings.Min();
        }
    }
}