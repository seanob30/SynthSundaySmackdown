using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthSundaySmackdown
{
    class Foot_Soldier : Synth
    {
        public Foot_Soldier(string name, int health, int attack)
        {
            this.name = "Foot Soldier";
            this.health = 175;
            this.attack = 20;
        }
    }
}
