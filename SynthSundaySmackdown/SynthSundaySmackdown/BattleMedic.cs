﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthSundaySmackdown
{
    class Battle_Medic : Synth
    {
        public Battle_Medic()
        {
            this.name = "Battle Medic";
            this.health = 175;
            this.attack = 15;
        }

        public override void SecondaryAttack(Synth synth)
        {
            this.health += 40;
        }
    }
}
