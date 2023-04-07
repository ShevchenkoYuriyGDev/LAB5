using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isClear = false;
            bool state = true;
            string position = "Kitchen";
            string device;
            Plate plate = new Plate();
            Spoon spoon = new Spoon();
            Fork fork = new Fork();
            Cup cup = new Cup();
            while (true) 
            {
                Console.WriteLine("Choise the devise");
                device = Console.ReadLine();
                if (device == "Plate")
                {
                    PlateChangeOperator(ref isClear, plate, ref position);
                }
                if (device == "Cup")
                {
                    CupChangeOperator(ref isClear, cup, ref position);
                }
                if (device == "Fork")
                {
                    ForkChangeOperator(ref isClear, fork, ref position);
                }
                if (device == "Spoon")
                {
                    SpoonChangeOperator(ref isClear, spoon, ref position);
                }
            }
        }
        static void CupChangeOperator(ref bool isClear, Cup cup, ref string position)
        {
            string method;
            Console.WriteLine($"Choise the method{"\t"}Wash or Position");
            method = Console.ReadLine();
            Console.Clear();
            if (method == "Wash")
            {
                if (cup.IsClear(isClear) == false)
                {
                    Console.WriteLine("Cleaning...");
                    isClear = true;
                }
                else { Console.WriteLine("Device is already clean"); }
            }
            if (method == "Position")
            {
                Console.WriteLine(cup.Position(position) + "\n" + "You wanna change position this devise in house?");
                int TorF;
                TorF = int.Parse(Console.ReadLine());
                if (TorF == 1)
                {
                    string newposition; newposition = Console.ReadLine();
                    position = newposition;
                }

            }
        }
        static void ForkChangeOperator(ref bool isClear, Fork fork, ref string position)
        {
            string method;
            Console.WriteLine($"Choise the method{"\t"}Wash or Position");
            method = Console.ReadLine();
            Console.Clear();
            if (method == "Wash")
            {
                if (fork.IsClear(isClear) == false)
                {
                    Console.WriteLine("Cleaning...");
                    isClear = true;
                }
                else { Console.WriteLine("Device is already clean"); }
            }
            if (method == "Position")
            {
                Console.WriteLine(fork.Position(position) + "\n" + "You wanna change position this devise in house?");
                int TorF;
                TorF = int.Parse(Console.ReadLine());
                if (TorF == 1)
                {
                    string newposition; newposition = Console.ReadLine();
                    position = newposition;
                }

            }
        }
        static void PlateChangeOperator(ref bool isClear, Plate plate, ref string position)
        {
            string method;
            Console.WriteLine($"Choise the method{"\t"}Wash or Position");
            method = Console.ReadLine();
            Console.Clear();
            if (method == "Wash")
            {
                if (plate.IsClear(isClear) == false)
                {
                    Console.WriteLine("Cleaning...");
                    isClear = true;
                }
                else { Console.WriteLine("Device is already clean"); }
            }
            if (method == "Position")
            {
                Console.WriteLine(plate.Position(position) + "\n" + "You wanna change position this devise in house?");
                int TorF;
                TorF = int.Parse(Console.ReadLine());
                if (TorF == 1)
                {
                    string newposition; newposition = Console.ReadLine();
                    position = newposition;
                }
        
            }
        }
        static void SpoonChangeOperator(ref bool isClear, Spoon spoon, ref string position)
        {
            string method;
            Console.WriteLine($"Choise the method{"\t"}Wash or Position");
            method = Console.ReadLine();
            Console.Clear();
            if (method == "Wash")
            {
                if (spoon.IsClear(isClear) == false)
                {
                    Console.WriteLine("Cleaning...");
                    isClear = true;
                }
                else { Console.WriteLine("Device is already clean"); }
            }
            if (method == "Position")
            {
                Console.WriteLine(spoon.Position(position) + "\n" + "You wanna change position this devise in house?");
                int TorF;
                TorF = int.Parse(Console.ReadLine());
                if (TorF == 1)
                {
                    string newposition; newposition = Console.ReadLine();
                    position = newposition;
                }

            }
        }
    }
}
