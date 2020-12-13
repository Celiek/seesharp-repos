using System;

namespace odc10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3);
            diary.AddRating(5);

            Diary diary1 = new Diary();
            diary1.AddRating(8);
        }
    }
}
