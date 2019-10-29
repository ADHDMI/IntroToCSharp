using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD57Korbin_Prgm_Assignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Decleration of initial variables and arrays
            string opChoice;
            int opType = 0;
            string[] numbersStr = new string[2];
            string[] operators = { "-", "+", "*", "/", "%" };
            float[] numbersFloat = new float[2];
            bool firstNumAttempt = true;

            //Intro sequence
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Winblows calc V0.3");
            typeInput();

            void typeInput()
            {
                //Asks the user for an operator, checks if the user imputed something else and if nessicary asks them to try again
                Console.WriteLine("Enter the operator you would like to use below");
                Console.WriteLine("- + * / %");
                opType = 0;
                opChoice = Console.ReadLine();
                while (opType <= 4 && ((opChoice == operators[opType]) != true))
                {
                    opType++;
                }

                if (opType > 4)
                {
                    Console.WriteLine("I don't quite understand, could you try speaking more clearly?");
                    typeInput();
                }

                //if the user inputed a valid string the num input funtion is started
                else
                {
                    Console.WriteLine(opChoice + ", not my first choice but its your call I guess...");
                    numInput();
                }
            }

            //Lets try this again

            void numInput()
            {
                //Takes input from the user and loads the numbersfloat array with values
                if (firstNumAttempt)
                {
                    Console.WriteLine("Can you give me a couple of numbers? One at a time of course, I'm a little daft");
                }
                numbersStr[0] = Console.ReadLine();
                parse(0, 0);
                void parse(int num0, int num1)
                {
                    bool isUserDaft = float.TryParse(numbersStr[num0], out numbersFloat[num1]);
                    if(isUserDaft == false)
                    {
                        Console.WriteLine("Alright nice try, next time try giving me an actual whole number");
                        firstNumAttempt = false;
                        numInput();
                    }
                }
                Console.WriteLine("Aaannd a second number please and thankyou");
                numbersStr[1] = Console.ReadLine();
                parse(1, 1);
            }

            if (opType == 0)
            {
                Console.WriteLine(("So if I'm doing this right the awnswer you're looking for is ") + (numbersFloat[0] - numbersFloat[1]));
                Console.ReadLine();
                typeInput();
            }

            if (opType == 1)
            {
                Console.WriteLine(("So if I'm doing this right the awnswer you're looking for is ") + (numbersFloat[0] + numbersFloat[1]));
                Console.ReadLine();
                typeInput();
            }

            if (opType == 2)
            {
                Console.WriteLine(("So if I'm doing this right the awnswer you're looking for is ") + (numbersFloat[0] * numbersFloat[1]));
                Console.ReadLine();
                typeInput();
            }

            if (opType == 3)
            {
                Console.WriteLine(("So if I'm doing this right the awnswer you're looking for is ") + (numbersFloat[0] / numbersFloat[1]));
                Console.ReadLine();
                typeInput();
            }

            if (opType == 4)
            {
                Console.WriteLine(("So if I'm doing this right the awnswer you're looking for is ") + (numbersFloat[0] % numbersFloat[1]));
                Console.ReadLine();
                typeInput();
            }
        }
    }
}
