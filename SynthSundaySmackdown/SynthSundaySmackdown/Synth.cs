using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthSundaySmackdown
{
    class Synth
    {
        public string name;
        public int health;
        public int attack;
        public Synth()
        {

        }
        public void PrimaryAttack(Synth synth)
        {
            synth.health -= this.attack;
        }

        public virtual void SecondaryAttack(Synth synth)
        {

        }
    }
}
