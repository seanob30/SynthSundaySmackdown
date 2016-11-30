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
        public void ChooseAttackType(Synth synth)
        {
            Console.WriteLine(name + " Type attack or ability to fight..");
            string playerInput = Console.ReadLine().ToLower();
            if (playerInput == "attack")
            {
                PrimaryAttack(synth);
            }
            else if (playerInput == "ability")
            {
                SecondaryAttack(synth);
            }
            else
            {
                Console.WriteLine("?SYNTAX ERROR");
                Console.WriteLine("Please enter a valid input..");
                ChooseAttackType(synth);
            }
        }
    }
}
