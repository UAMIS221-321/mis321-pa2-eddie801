using System;
using System.IO;
using System.Collections.Generic;

namespace pa2_EddiePhelps
{
    public class jackAtk : IAttack
    {
        public void atkBehavior(character p1, character p2)
        {

            double dmg;
            if (p2.defPower >= p1.atkStrength)
            {
                dmg = (p1.atkStrength / p2.defPower) * p1.atkStrength;
            }
            else
            {
                dmg = p1.atkStrength - p2.defPower;
            }
            if (p2.type == "Sword")
            {
                dmg *= 1.2;//dmg modifier

            }
            else
            {
                dmg *= 1;
            }

            Console.WriteLine("Jack Sparrow hit you with a bottle of rum and did {0} damage!", dmg);

            p2.health -= dmg;
        }
    }
}