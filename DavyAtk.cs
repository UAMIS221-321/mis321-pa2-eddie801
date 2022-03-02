using System;
using System.IO;
using System.Collections.Generic;

namespace pa2_EddiePhelps
{
    public class DavyAtk : IAttack
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
            if (p2.type == "Distract")
            {
                dmg *= 1.2;//dmg modifier

            }
            else
            {
                dmg *= 1;
            }
            Console.WriteLine("Davy Jones hit you with cannon fire  and did {0} damage!", dmg);
            p2.health -= dmg;
        }
    }
}