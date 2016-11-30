using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthSundaySmackdown
{
    class Grim_Reaper : Synth
    {
        public Grim_Reaper()

        {
            this.name = "Grim Reaper";
            this.health = 125;
            this.attack = 25;
        }

        public override void SecondaryAttack(Synth synth)
        {
            synth.health -= (this.attack * 2);
            this.health -= (synth.attack / 2);

        }
    }
}
