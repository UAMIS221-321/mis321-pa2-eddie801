using System;
using System.IO;
using System.Collections.Generic;

namespace pa2_EddiePhelps
{
    public class willAtk : IAttack
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
            if (p2.type == "Cannon fire")
            {
                dmg *= 1.2;//dmg modifier

            }
            else
            {
                dmg *= 1;
            }
            Console.WriteLine("Will Turner hit you with their sword and did {0} damage!", dmg);
            p2.health -= dmg;
        }
    }
}