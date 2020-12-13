using System;

namespace StudentDiary
{
    class Program
    {
        static void GiveName(Diary diary)
        {
            diary.Name = "Dzienniczek Marcina";
        }
        static void Main(string[] args)
        {
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(d1);
        }
    }
}
