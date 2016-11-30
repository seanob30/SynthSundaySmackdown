using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthSundaySmackdown
{
    class Shadow_Scout : Synth
    {
        public Shadow_Scout()
        {
            this.name = "Shadow Scout";
            this.health = 95;
            this.attack = 30;
        }

        public override void SecondaryAttack(Synth synth)
        {
            this.health += synth.attack;
            this.health -= 20;
            synth.health -= this.attack + (this.attack / 2);

        }
    }
}
