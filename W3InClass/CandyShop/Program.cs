using System;
using System.IO;
using System.Text;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        6{

            Console.OutputEncoding = Encoding.UTF8;
            int smiley = 1001;
            Console.WriteLine((char)smiley);

           //Console.WriteLine($"Candy for {fullName}!");


            string[] lines = File.ReadAllLines(@"C:\Users\fmi\Desktop\WorkFolder\PU_IntroCSharp_1801681019\W3InClass\CandyShop\files\students.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of students.txt = ");
            foreach(string line in lines)  
            {
                string[] currentElements = line.Split(' ');
                string firstName = currentElements[1];
                string lastName = currentElements[3];
                string fullName = $"{firstName} {lastName}";



                int sum = 0;
                for (int i = 0; i < firstName.Length; i++)
                {
                    sum += (int)firstName[i];
                }

                Console.WriteLine($"Candy for {fullName} => {sum}!");
            }
            


        }
    }
}
