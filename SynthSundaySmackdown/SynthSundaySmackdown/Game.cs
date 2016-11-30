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
            DisplayUIMenu();
            ChoosePlayerNames();
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
        public void DisplayUIMenu()
        {
            Console.WriteLine("                       **SYNTH SUNDAY SMACKDOWN**");
            Console.WriteLine();
            Console.WriteLine("Type 1 for PLAY NOW or type 2 for CLASS INFORMATION.");
            Console.Write("What would you like to do?: ");
            string menuinput = Console.ReadLine();
            Console.Clear();

            if (menuinput == "1")
            {
                playerOne = ChooseClass();
                playerTwo = ChooseClass();
            }
            else if (menuinput == "2")
            {
                Console.Write("LOADING..");
                TakeOneSecondBreak();
                Console.Clear();
                PullUpClassInfo();
            }
            else
            {
                Console.WriteLine("?SYNTAX ERROR");
                Console.WriteLine("Please enter a valid input..");
                TakeOneSecondBreak();
                Console.Clear();
            }
        }

        private Synth ChooseClass()
        {
            Synth player;
            Console.WriteLine("CHOOSE YOUR COMBATANT!");
            InsertClassText();
            Console.WriteLine();
            Console.Write("WHICH CLASS WOULD YOU LIKE TO BE?: ");
            string option = Console.ReadLine().ToLower();
            Console.Clear();

            switch(option)
            {
                case ("grim reaper"):
                    player = new Grim_Reaper();
                    Console.Clear();
                    break;
                case ("battle medic"):
                    player = new Battle_Medic();
                    Console.Clear();
                    break;
                case ("foot soldier"):
                    player = new Foot_Soldier();
                    Console.Clear();
                    break;
                case ("shadow scout"):
                    player = new Shadow_Scout();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    Console.WriteLine("Please enter a valid input..");
                    TakeOneSecondBreak();
                    Console.Clear();
                    return ChooseClass();
                   
            }
            return player;

        }
        private void ChoosePlayerNames()
        {
            Console.Write("PLAYER 1 NAME: ");
            playerOne.name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("PLAYER 2 NAME: ");
            playerTwo.name = Console.ReadLine();
            Console.Clear();
        }

        private void BeginSmackdown()
        {
            while (playerOne.health >= 0 && playerTwo.health >= 0)
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
            InsertClassText();
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
                    DisplayUIMenu();
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

        public void InsertClassText()
        {
            Console.WriteLine("#Grim Reaper");
            Console.WriteLine("#Battle Medic");
            Console.WriteLine("#Foot Soldier");
            Console.WriteLine("#Shadow Scout");
            Console.WriteLine();
        }

        public void TakeOneSecondBreak()
        {
            System.Threading.Thread.Sleep(1500);
        }
    }
}

