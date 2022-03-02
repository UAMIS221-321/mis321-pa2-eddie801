using System;
using System.IO;
using System.Collections.Generic;

namespace pa2_EddiePhelps
{
    public class character //abstract
    {
        public string name { get; set; }
        public string type { get; set; }
        public int MaxPower { get; set; }
        public double health { get; set; }
        public double atkStrength { get; set; }
        public double defPower { get; set; }
        public IAttack atkBehavior;
        public IDefend defBehavior;


        public character()
        {
            MaxPower = new Random().Next(1, 101);
            health = 100;
            atkStrength = new Random().Next(1, MaxPower + 1);
            defPower = new Random().Next(1, MaxPower + 1);
        }
        public character(string n, string t, int mp, double h, double a, double d)
        {
            name = n;
            type = t;
            MaxPower = new Random().Next(1, 101);
            health = 100;
            atkStrength = new Random().Next(1, MaxPower + 1);
            defPower = new Random().Next(1, MaxPower + 1);
        }

        public void SetAtkBehavior(IAttack value)
        {
            atkBehavior = value;
        }
        public void SetDefBehavior(IDefend value)
        {
            defBehavior = value;
        }

        // public void defense(double dPower)
        // {
        //     dPower = defend.defMethod(dPower);
        //     health -= dPower;
        //     Console.WriteLine(dPower + " done to " + this.name);
        // }

        public void NormAttack(character target)
        {
            double dmg = atkStrength - defPower;
            target.health -= dmg;
        }

        public void NormDef(character target)//normal defend agaisnt attack weakens defenders defensive power
        {
            if (defPower > 0)
            {
                Console.WriteLine(target.name + " blocked the attack and has sustained minimal damage");
                defPower -= atkStrength / 4;
            }
            else
            {
                Console.WriteLine(target.name + " your defensive power has been depleted and you took full damage");
                target.health -= atkStrength; //if defending player has no more defensive power it hits for full value of the attackers strength 
            }
            Console.WriteLine("\t");

        }

        public void stats()
        {
            Console.WriteLine("{0} stats", name);
            //Console.WriteLine("{0} type", type);
            // Console.WriteLine("Power: {0}", MaxPower);
            Console.WriteLine("Attack value is: {0}", atkStrength);
            Console.WriteLine("Defend value is: {0}", defPower);
            Console.WriteLine("Health value is: {0}", health);
        }

    }

    // public class Jack : character
    // {
    //     public Jack(string n, string t, int mp, double a, double d, double h)
    //         : base(n, t, mp, a, d, h)
    //     {

    //     }

    //     public void dirtThrow(player2 target)//jacks special hit
    //     {
    //         double dmg = (atkStrength - defPower);//small damage to player 1 but jack gets option to heal
    //         target.health -= dmg * 2;
    //     }
    //     //  Battle methods ---------------------------------------------

    //     public void JacksTurn(string Choice, player2 target)
    //     {
    //         if (Choice == "N")
    //         {
    //             NormAttack(target);
    //             Console.WriteLine("Jack Sparrow hit you with a bottle of rum!");

    //         }

    //         if (Choice == "S")
    //         {
    //             dirtThrow(target);
    //             Console.WriteLine("Jack Sparrow threw dirt in your eye!");

    //         }

    //         if(Choice == "D")
    //         {
    //             NormDef(target);
    //             Console.WriteLine("Jack Sparrow defended against the attack and didn't take any injuries");
    //         }

    //         Console.ReadLine();
    //         Console.Clear();
    //     }
    // }

    // public class Will : character
    // {
    //     public Will(string n, string t, int mp, double a, double d, double h)
    //         : base(n, t, mp, a, d, h)
    //     {

    //     }

    //     //  Battle methods ---------------------------------------------

    //     public void CritHit(player2 target)//wills special hit
    //     {
    //         double dmg = (atkStrength - defPower);//direct dmg for wills special
    //         target.health -= dmg * 2;
    //     }

    //     public void WillsTurn(string Choice, player2 target)
    //     {
    //         if (Choice == "N")
    //         {
    //             NormAttack(target);
    //             Console.WriteLine("Will Turner punched you!");

    //         }

    //         if (Choice == "S")
    //         {
    //             CritHit(target);
    //             Console.WriteLine("Will Turner cut off your hand! Critical hit bonus");

    //         }
    //         if(Choice == "D")
    //         {
    //             NormDef(target);
    //             Console.WriteLine("Will Turner defended against the attack and didn't take any injuries");
    //         }

    //         Console.ReadLine();
    //         Console.Clear();
    //     }
    // }

    // public class Davy : character
    // {
    //     public Davy(string n, string t, int mp, double a, double d, double h)
    //         : base(n, t, mp, a, d, h)
    //     {

    //     }

    //     //  Battle methods ---------------------------------------------

    //     public void Kraken(player2 target)//davys special hit
    //     {
    //         double dmg = (atkStrength - defPower);//maybe weakens the defPower of player1 doesnt do direct dmg
    //         target.health -= dmg * 2;
    //     }

    //     public void DavysTurn(string Choice, player2 target)
    //     {
    //         if (Choice == "N")
    //         {
    //             NormAttack(target);
    //             Console.WriteLine("Davy Jones shot the hull of your ship!");

    //         }

    //         if (Choice == "S")
    //         {
    //             Kraken(target);
    //             Console.WriteLine("Davy Jones Kraken hit your ship! Critical damage bonus");
    //         }
    //         if(Choice == "D")
    //         {
    //             NormDef(target);
    //             Console.WriteLine("Davy Jones defended against the attack and didn't take any injuries");
    //         }

    //         Console.ReadLine();
    //         Console.Clear();
    //     }
    // }

}