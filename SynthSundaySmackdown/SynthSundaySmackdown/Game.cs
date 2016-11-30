using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthSundaySmackdown
{
    class Game
    {
        Synth playerOne;
        Synth playerTwo;
        public void RunGame()
        {
            Console.WindowWidth = 75;

            WelcomeScreen();
            ChooseClass();
            //BeginSmackdown();
            //AcknowledgeWinner();
            //ShowRematchScreen();
        }

        private void WelcomeScreen()
        {
            Console.WriteLine("                  WELCOME TO SYNTH SUNDAY SMACKDOWN!");
            Console.WriteLine("                     Press any key to smackdown..");
            Console.ReadKey();
            Console.Clear();
        }

        private void ChooseClass()
        {
            Console.WriteLine("CHOOSE YOUR COMBATANT!");
            Console.WriteLine("#Grim Reaper");
            Console.WriteLine("#Battle Medic");
            Console.WriteLine("#Foot Soldier");
            Console.WriteLine("#Shadow Scout");
            Console.WriteLine();
            Console.WriteLine("or type info for information on the classes..");
            Console.WriteLine();
            Console.Write("WHICH CLASS WOULD YOU LIKE TO BE?: ");
            string option = Console.ReadLine().ToLower();
            Console.Clear();

            switch(option)
            {
                case ("grim reaper"):
                    this.playerOne = new Grim_Reaper();
                    Console.Clear();
                    break;
                case ("battle medic"):
                    this.playerOne = new Battle_Medic();
                    Console.Clear();
                    break;
                case ("foot soldier"):
                    this.playerOne = new Foot_Soldier();
                    Console.Clear();
                    break;
                case ("shadow scout"):
                    this.playerOne = new Shadow_Scout();
                    Console.Clear();
                    break;
                case ("info"):
                    Console.Write("LOADING..");
                    TakeOneSecondBreak();
                    Console.Clear();
                    PullUpClassInfo();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    Console.WriteLine("Please enter a valid input..");
                    TakeOneSecondBreak();
                    Console.Clear();
                    ChooseClass();
                    break;
            }
        }

        private void BeginSmackdown()
        {
            while (playerOne.health >= 0)
            {

            }
        }

        private void AcknowledgeWinner()
        {
            throw new NotImplementedException();
        }

        private void ShowRematchScreen()
        {
            throw new NotImplementedException();
        }

        private void PullUpClassInfo()
        {
            Console.WriteLine("WHAT CLASS DO YOU WANT TO KNOW MORE ABOUT?");
            Console.WriteLine("#Grim Reaper");
            Console.WriteLine("#Battle Medic");
            Console.WriteLine("#Foot Soldier");
            Console.WriteLine("#Shadow Scout");
            Console.WriteLine();
            Console.WriteLine("or type exit to go back..");
            Console.WriteLine();
            Console.Write("ENTER CLASS NAME FOR MORE INFORMATION: ");
            string classInfo = Console.ReadLine().ToLower();
            Console.Clear();

            switch (classInfo)
            {
                case "grim reaper":
                    Console.WriteLine("HEALTH: 130 Hit Points");
                    Console.WriteLine("ATTACK: 25 Damage");
                    Console.WriteLine("ABILITY: Can inflict double damage, but then is incapacitated for a turn.");
                    Console.ReadKey();
                    Console.Clear();
                    PullUpClassInfo();
                    break;
                case "battle medic":
                    Console.WriteLine("HEALTH: 200 Hit Points");
                    Console.WriteLine("ATTACK: 15 Damage");
                    Console.WriteLine("ABILITY: Heal 30 health points.");
                    Console.ReadKey();
                    Console.Clear();
                    PullUpClassInfo();
                    break;
                case "foot soldier":
                    Console.WriteLine("HEALTH: 175 Hit Points");
                    Console.WriteLine("ATTACK: 20 Damage");
                    Console.WriteLine("ABILITY: Does not have an ability.");
                    Console.ReadKey();
                    Console.Clear();
                    PullUpClassInfo();
                    break;
                case "shadow scout":
                    Console.WriteLine("HEALTH: 110 Hit Points");
                    Console.WriteLine("ATTACK: 30 Damage");
                    Console.WriteLine("ABILITY: Goes \"invisible\" for one turn; inflict 150% damage the following");
                    Console.WriteLine("turn."); 
                    Console.ReadKey();
                    Console.Clear();
                    PullUpClassInfo();
                    break;
                case "exit":
                    ChooseClass();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    Console.WriteLine("Please enter a valid class..");
                    TakeOneSecondBreak();
                    Console.Clear();
                    PullUpClassInfo();
                    break;
            }
        }

        public void TakeOneSecondBreak()
        {
            System.Threading.Thread.Sleep(1500);
        }
    }
}

