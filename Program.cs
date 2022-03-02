using System;
using System.IO;
using System.Collections.Generic;

namespace pa2_EddiePhelps
{
    class Program
    {
        static void Main(string[] args)
        {
            character p1 = new character();
            character p2 = new character();

            character jack = new character() { atkBehavior = new jackAtk(), name = "Jack Sparrow", type = "Distract" };
            character will = new character() { atkBehavior = new willAtk(), name = "Will Turner", type = "Sword" };
            character davy = new character() { atkBehavior = new DavyAtk(), name = "Davy Jones", type = "Cannon fire" };
            character barbossa = new character() { atkBehavior = new CaptAtk(), name = "Barbossa", type = "Sword" };


            List<character> characterList = new List<character>();
            characterList.Add(jack);
            characterList.Add(will);
            characterList.Add(davy);
            characterList.Add(barbossa);

            character jackp2 = new character() { atkBehavior = new jackAtk(), name = "Jack Sparrow", type = "Distract" };
            character willp2 = new character() { atkBehavior = new willAtk(), name = "Will Turner", type = "Sword" };
            character davyp2 = new character() { atkBehavior = new DavyAtk(), name = "Davy Jones", type = "Cannon fire" };
            character barbossap2 = new character() { atkBehavior = new CaptAtk(), name = "Barbossa", type = "Sword" };

            List<character> p2characterList = new List<character>();
            p2characterList.Add(jackp2);
            p2characterList.Add(willp2);
            p2characterList.Add(davyp2);
            p2characterList.Add(barbossap2);

            Console.WriteLine("Player 1 Enter your Name and hit enter");
            string p1name = Console.ReadLine();
            Console.WriteLine("Player 2 Enter your Name and hit enter");
            string p2name = Console.ReadLine();

            Console.WriteLine("\n");
            Console.WriteLine("These are the player 1 playable characters");

            foreach (character showCharacters in characterList)
            {
                Console.WriteLine(showCharacters.name + " is a " + showCharacters.type + " type, max power: " + showCharacters.MaxPower + " attack strength: " + showCharacters.atkStrength + " defensive power: " + showCharacters.defPower);
            }

            Console.WriteLine("\n");

            Console.WriteLine(p1name + " enter the name of the character you want to use and hit enter");
            string p1CharacterSelect = Console.ReadLine();

            Console.WriteLine("\t");

            Console.WriteLine("These are the player 2 playable characters");

            foreach (character p2showCharacters in p2characterList)
            {
                Console.WriteLine(p2showCharacters.name + " is a " + p2showCharacters.type + " type, max power: " + p2showCharacters.MaxPower + " attack strength: " + p2showCharacters.atkStrength + " defensive power: " + p2showCharacters.defPower);
            }
            Console.WriteLine("\n");


            Console.WriteLine(p2name + " enter the name of the character you want to use and hit enter");
            string p2CharacterSelect = Console.ReadLine();

            if (p1CharacterSelect == "Jack Sparrow")
            {
                p1 = jack;
            }
            else if (p1CharacterSelect == "Will Turner")
            {
                p1 = will;
            }
            else if (p1CharacterSelect == "Barbossa")
            {
                p1 = barbossa;
            }
            else
            {
                p1 = davy;
            }

            if (p2CharacterSelect == "Jack Sparrow")
            {
                p2 = jackp2;
            }
            else if (p2CharacterSelect == "Will Turner")
            {
                p2 = willp2;
            }
            else if (p2CharacterSelect == "Barbossa")
            {
                p2 = barbossap2;
            }
            else
            {
                p2 = davyp2;
            }


            Console.WriteLine("\n");




            while (p1.health > 0 && p2.health > 0)
            {
                Console.WriteLine(p1.name + " type 'A' to choose to attack or type 'D' deffend and hit enter");
                string p1choice = Console.ReadLine().ToUpper();

                Console.WriteLine(p2.name + " type 'A' to choose to attack or type 'D' deffend and hit enter");
                string p2choice = Console.ReadLine().ToUpper();

                if (p1choice == "A" && p2choice == "A")
                {
                    Console.WriteLine("\t");
                    p1.atkBehavior.atkBehavior(p1, p2);
                    p2.atkBehavior.atkBehavior(p2, p1);
                    Console.WriteLine("\n");
                    p1.stats();
                    Console.WriteLine("\t");
                    p2.stats();
                    Console.WriteLine("\t");
                }
                if (p1choice == "D" && p2choice == "A")
                {
                    p1.NormDef(p1);
                    Console.WriteLine(p2.name + " attacked for " + p2.atkStrength + " strength");
                    p1.stats();
                    Console.WriteLine("\t");
                    p2.stats();
                    Console.WriteLine("\t");
                }
                if (p1choice == "A" && p2choice == "D")
                {
                    Console.WriteLine(p1.name + " attacked for " + p1.atkStrength + " strength");
                    p2.NormDef(p2);
                    p1.stats();
                    Console.WriteLine("\t");
                    p2.stats();
                    Console.WriteLine("\t");
                }
                if (p1choice == "D" && p2choice == "D")
                {
                    Console.WriteLine("Both players blocked and no damage was dealt");
                    p1.stats();
                    Console.WriteLine("\t");
                    p2.stats();
                    Console.WriteLine("\t");
                }

            }

            if ((p2.health > 0) && (p1.health <= 0))
            {
                Console.WriteLine(p1name + " has died! " + p2name + " killed you and won the battle!");
            }
            if ((p1.health > 0) && (p2.health <= 0))
            {
                Console.WriteLine(p2name + " has died! " + p1name + " killed you and won the battle!");
            }
        }
    }
}
