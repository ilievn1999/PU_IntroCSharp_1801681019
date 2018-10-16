using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            string answer = Console.ReadLine();

            if (answer=="Yes")
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\fmi\Desktop\W3\PU_IntroCSharp_1801681019\W3InClass\MusicFactory\Music\574241539693511.wav"))
                {
                    Console.WriteLine("Now playing...");
                    player.PlaySync();
                    while (true)
                    {
                        
                    }
                }
            }
            else if(answer=="Fuck")
            {
                Console.WriteLine("Yes, fuck you too :) ");
            }
            else if (answer == "No")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }


        }
    }
}
