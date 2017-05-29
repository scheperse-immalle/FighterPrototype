using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fighterProtoType
{
    class Program
    {
        static void Main(string[] args)
        {
            FighterPrototype ninja = new Ninja("Blue");
            FighterPrototype samurai = new Samurai("Green");

            var copiedNinja = ninja;
            var copiedSamurai = samurai;

            var clonedNinja = ninja.Clone();
            var clonedSamurai = samurai.Clone();

            ninja.Name = "Gold";
            samurai.Name = "Silver";

            string oN = "Original Ninja";
            Console.WriteLine(oN);
            Console.WriteLine(new string('-', oN.Length));
            ninja.ShowFighter();
            Console.WriteLine();

            string cN = "Copied Ninja";
            Console.WriteLine(cN);
            Console.WriteLine(new string('-', cN.Length));
            copiedNinja.ShowFighter();
            Console.WriteLine();

            string clN = "Cloned Ninja";
            Console.WriteLine(clN);
            Console.WriteLine(new string('-', clN.Length));
            clonedNinja.ShowFighter();
            Console.WriteLine();

            string oS = "Original Samurai";
            Console.WriteLine(oS);
            Console.WriteLine(new string('-', oS.Length));
            samurai.ShowFighter();
            Console.WriteLine();

            string cS = "Copied Samurai";
            Console.WriteLine(cS);
            Console.WriteLine(new string('-', cS.Length));
            copiedSamurai.ShowFighter();
            Console.WriteLine();

            string clS = "Cloned Samurai";
            Console.WriteLine(clS);
            Console.WriteLine(new string('-', clS.Length));
            clonedSamurai.ShowFighter();
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
