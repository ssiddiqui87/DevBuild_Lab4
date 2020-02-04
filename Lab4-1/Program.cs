using System;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice roller!");
            Console.Write("How many sides do you want the dice to have? ");

            //Input validation to make sure an int is entered
            bool isValid = int.TryParse(Console.ReadLine(), out int diceSide);
            while (!isValid)
            {
                Console.WriteLine("That is not a valid entry. Please enter an integer.");
                isValid = int.TryParse(Console.ReadLine(), out diceSide);
            }
            //Flag to roll again
            bool flag = true;

            //While loop to run until user wants to exit
            while (flag == true)
            {

              

                //Calls RollDice method with diceSide passed
                int roll1 = RollDice(diceSide);
                int roll2 = RollDice(diceSide);

                //Output the roll and total
                Console.WriteLine($"You rolled a {roll1} and a {roll2} ({roll1 + roll2} total)");

                //If a 6 sided die, will call DiceCombos function
                if (diceSide == 6)
                {
                    DiceCombos(roll1, roll2);
                }

                //Check if user wants to roll again
                flag = RunAgainBool("Do you want to roll again? ");
            }

            Console.WriteLine("Thanks for playing!");
     }

        //method to roll dice
        static int RollDice(int diceSize)
        {
            //Use random class to generate random number between 1 and diceSize+1
            Random random = new Random();
            int diceValue = random.Next(1, diceSize + 1);
            //Return the dice roll value
            return diceValue;
        }

        //method to output message based on specific combos
        static void DiceCombos(int dice1, int dice2)
        {
            if (dice1 == 1 && dice2 == 1)
            {
                Console.WriteLine("Snake Eyes!");
            }
            if ((dice1 == 1 && dice2 == 2) || (dice1 == 2 && dice2 == 1))
            {
                Console.WriteLine("Ace Deuce!");
            }
            if (dice1 == 6 && dice2 == 6)
            {
                Console.WriteLine("Box Cars!");
            }
            if (dice1 + dice2 == 7 || dice1 + dice2 == 11)
            {
                Console.WriteLine("Win!");
            }
            if (dice1 + dice2 == 2 || dice1 + dice2 == 3 || dice1 + dice2 == 12)
            {
                Console.WriteLine("Craps!");
            }

        }

        //method to loop
        static bool RunAgainBool(string message)
        {
            Console.Write(message);
            char key = Console.ReadKey().KeyChar;

            while (key != 'y')
            {
                if (key == 'n')
                {
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    Console.Write("\nThat is an invalid entry. Please enter y or n: ");
                    key = Console.ReadKey().KeyChar;
                }
            }
            Console.WriteLine();
            return true;
        }
    }
}
