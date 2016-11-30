using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthSundaySmackdown
{
    class Foot_Soldier : Synth
    {
        public Foot_Soldier()
        {
            this.name = "Foot Soldier";
            this.health = 140;
            this.attack = 20;
        }

        public override void SecondaryAttack(Synth synth)
        {
            this.health -= 25;
            this.attack += 5;
            PrimaryAttack(synth);
        }
    }
}
