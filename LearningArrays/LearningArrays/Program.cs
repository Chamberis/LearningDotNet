using System;

namespace LearningArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] newArray = { "Jimmy", "Tom", "Charles", "Eve", "Tim" };


            foreach (string name in newArray)
            {                                          
                Console.WriteLine(name);
            }
                Console.ReadLine();


            int[] otherArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

            for (var i = otherArray.Length - 1 ; i > -1; i--)
            {
                Console.WriteLine(i);
            }
                Console.ReadLine();
            }
            
    }
}
