using System.Collections.Generic;
using System;
using System.Linq;

namespace StudentDiary
{
     class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        //Stan (zmienne w tym przypadku pola)
        List<float> ratings;

        public float MinGrade = 0;
        public float MaxGrade  = 10;

        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }


        //Zachowania

        public void AddRating(float rating)
        {
            ratings.Add(rating);
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