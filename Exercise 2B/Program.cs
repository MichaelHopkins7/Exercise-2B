using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Syntactic Sugar is when a shorter, clearer, and easier to understand(for humans) 
            //      version of syntax exist that does not decrease the functionality.


            void MemeSound(String animal = "Doge", string sound = "WOW!")
            {
                Console.WriteLine($"The {animal} goes \"{sound}\"!");
            }




            void MemeSound(string animal, string sound)
            {
                Console.WriteLine($"The {animal} goes \"{sound}\"!");
            }
            
            void MemeSound(string animal)
            {
                MemeSound(animal, "WOW!");
            }
            
            void MemeSound()
            {
                MemeSound("Doge");
            }


        }
        
    }
}
