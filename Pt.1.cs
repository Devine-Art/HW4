namespace Hunting_The_Manticore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable to keep track of city health
            int consolasHealth = 0;
            //variable to keep track of manticore health
            int manticoreHealth = 0;

            //ask manticore pilot for manticore position
            Console.WriteLine("Manticore, Enter your # between 1-100");
            int manitcorePos = int.Parse(Console.ReadLine());

            //determine if valid
            while (manitcorePos <= 0 || manitcorePos >= 100)
            {
                //ask user1 for new variable and assign it
                Console.WriteLine("Manticore, Enter your # between 1-100");
                int manitcorePosre = int.Parse(Console.ReadLine());

                //determine if new variable is valid
                if (manitcorePosre >= 0 || manitcorePosre <= 100)
                {
                    manitcorePos = manitcorePosre;
                }
            }

            //clear console for user two
            Console.Clear();

            //Loop to define game parameters
            while (consolasHealth <= 15 || manticoreHealth >= 15)
            {

            //ask user2 for guess
            Console.WriteLine("Hunter, Enter your # between 1-100");
            int Hunternum = int.Parse(Console.ReadLine());



                //check if correct
                if (manitcorePos == Hunternum)
                {
                    Console.WriteLine("You got the #!");
                    break;
                }
                //check if lower
                if (manitcorePos > Hunternum)
                {
                    Console.WriteLine("Your # is too low");
                }
                //check if higher
                if (manitcorePos < Hunternum)
                {
                    Console.WriteLine("Your # is too high");
                }







                {
                    //check if double shot
                    if (consolasHealth % 3 == 0 && consolasHealth % 5 == 0)
                    {
                        //change color of text for double shot
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Beep();
                        Console.WriteLine("ELECTRIC & FIRE SHOT!");
                    }

                    //check if fire shot
                    else if (consolasHealth % 3 == 0)
                    {
                        //change color of text for double shot
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fire Shot");
                    }

                    //check if electric shot
                    else if (consolasHealth % 5 == 0)
                    {
                        //change color of text for double shot
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Electric Shot");
                    }

                    //check if normal shot
                    else if (consolasHealth % 3 != 0 && consolasHealth % 5 != 0)
                    {
                        Console.ResetColor();
                        Console.WriteLine("Normal Shot");
                    }

                    //add one to city damage
                    consolasHealth++;
                }
            }
        }
    }
}

