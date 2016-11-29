using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthSundaySmackdown
{
    class Grim_Reaper : Synth
    {
        public Grim_Reaper(string name, int health, int attack)

        {
            this.name = "Grim Reaper";
            this.health = 130;
            this.attack = 25;
        }
    }
}
