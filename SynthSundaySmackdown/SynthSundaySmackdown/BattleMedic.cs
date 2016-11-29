using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthSundaySmackdown
{
    class Battle_Medic : Synth
    {
        public Battle_Medic(string name, int health, int attack)
        {
            this.name = "Battle Medic";
            this.health = 200;
            this.attack = 15;
        }
    }
}
