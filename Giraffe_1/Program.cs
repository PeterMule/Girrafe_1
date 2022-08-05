using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Giraffe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("|                      |");
            Console.WriteLine("------------------------");
            Console.WriteLine("odirfnosnfine");
            double number = 0.2;
            variables();
            workingwithstring();
            workingwithnumbers();
            //gettinguserinput();
            //primitivecalculator();
            //madlibs();
            //arrays();
            //methods();
            Console.WriteLine("The cube of " + number + " is " + cube(number));
            Console.WriteLine("th forth day of the week is a " + getDay(3));
            guessingGame();
        }

        static void variables()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------");
            Console.WriteLine("|      Variables       |");
            Console.WriteLine("------------------------");

            string characterName = "Alex";
            int characterAge;
            characterAge = 90;

            Console.WriteLine("On his left he felt a presence.");
            Console.WriteLine("He surreptitiously turned his head and noticed a well-worn set of leather shoes");
            Console.WriteLine("He only knew one man who wore those shoes.");
            Console.WriteLine("And looking up his hunch was proven right.");
            Console.WriteLine(characterName + " age " + characterAge + ", the loneliest man on the Island");
            /*
            char grade = 'B';
            string phrase = "Multiple characters";
            
            //negative or positive no decimal point
            int nodecimals = -90902;


            float semi;
            double prec = 0.001;
            //this is the most precious decimal
            decimal vprecise;
            bool hasFallen = true;
            */

        }

        static void workingwithstring()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------");
            Console.WriteLine("| Working With String  |");
            Console.WriteLine("------------------------");

            string phrase = "Plain\nText" + " concatinating";
            Console.WriteLine(phrase);

            Console.WriteLine("The string phrase is of length " + phrase.Length);

            Console.WriteLine("The string has a substring method that extracts a piece of the string " + phrase.Substring(3, 12));
            Console.WriteLine("the string to lower case is " + phrase.ToLower());
            Console.WriteLine("The string contains a 'con'? " + phrase.Contains("con"));
            Console.WriteLine("String Indexing phrase[9] = " + phrase[9]);

        }
        static void workingwithnumbers()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------");
            Console.WriteLine("| Working with Numbers  |");
            Console.WriteLine("------------------------");

            Console.WriteLine(5 + 8);
            Console.WriteLine(5 / 2);
            Console.WriteLine(8.4 / 5);
            Console.WriteLine(5 % 2);
            Console.WriteLine(Math.Log(3.14, 0.2));
        }
        static void gettinguserinput()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------");
            Console.WriteLine("|  Getting User Input  |");
            Console.WriteLine("------------------------");

            Console.Write("How did you get here, Alex?");
            string modeofTransaport = Console.ReadLine();
            Console.WriteLine(modeofTransaport + "!!??");
            Console.Write("Why are you here?");
            string reason = Console.ReadLine();
        }
        static void primitivecalculator()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------");
            Console.WriteLine("|      Calculator      |");
            Console.WriteLine("------------------------");


            try
            {
                Console.Write("Enter the 1st number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the character operation: ");
                char operation = Console.ReadLine()[0];
                Console.Write("Enter the 2nd number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());


                switch (operation)
                {
                    case ('+'):
                        {
                            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                            break;
                        }
                    case ('-'):
                        {
                            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                            break;
                        }
                    case ('*'):
                        {
                            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                            break;
                        }
                    case ('/'):
                        {
                            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                            break;
                        }
                    case ('%'):
                        {
                            Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
                            break;
                        }
                    case ('^'):
                        {
                            Console.WriteLine(num1 + " ^ " + num2 + " = " + Math.Pow(num1, num2));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Unkown operation");
                            break;
                        }

                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.ToString());
            }


            
        }
        static void madlibs()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------");
            Console.WriteLine("|       Mad Libs       |");
            Console.WriteLine("------------------------");

            string color, pluralNoun, celebrity;
            Console.WriteLine("Enter a color");
            color = Console.ReadLine();

            Console.WriteLine("Enter a plural noun");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Enter a celebrity");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("A simple clue,");
            Console.WriteLine("My love for " + celebrity + " is true");
        }
        static void arrays()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------");
            Console.WriteLine("|        Arrays        |");
            Console.WriteLine("------------------------");
            int[] myNumbers = { 0x20, 43, 232, 43, 0x34 };

            string[] mystrings = new string[20];

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
            mystrings[0] = "Dwight";
            Console.WriteLine(mystrings[0]);
        }
        static int methods(string name, int number)
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------");
            Console.WriteLine("|       Methods       |");
            Console.WriteLine("------------------------");
            Console.WriteLine("Hello there Mister "+ number);
            return number;
        }
        static double cube(double number)
        {
            return number * number * number;
        }
        static int cube(int number)
        {
            return number * number * number;
        }
        static double getMax(double n1, double n2, double n3)
        {
            return n1>=n2 ? (n1>=n3?n1:n3) : (n2 >= n3 ? n2 : n3);
        }
        static string getDay(int dayNum)
        {
            string dayName;
            switch(dayNum)
            {
                case (0):
                    {
                        dayName = "Sunday";
                        break;
                    }
                case (1):
                    {
                        dayName = "Monday";
                        break;
                    }
                case (2):
                    {
                        dayName = "Tuesday";
                        break;
                    }
                case (3):
                    {
                        dayName = "Wednesday";
                        break;
                    }
                case (4):
                    {
                        dayName = "Thursday";
                        break;
                    }
                case (5):
                    {
                        dayName = "Friday";
                        break;
                    }
                case (6):
                    {
                        dayName = "Saturday";
                        break;
                    }
                default:
                    {
                        dayName = "Invalid Day";
                        break;
                    }
            }
            return dayName;
        }
        static bool guessingGame()
        {
            Console.WriteLine("\n");
            Console.WriteLine("------------------------");
            Console.WriteLine("|     Guessing Game     |");
            Console.WriteLine("------------------------");
            string secretWord = "Alucard", guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            while(guess!=secretWord && guessLimit>guessCount)
            {
                Console.Write("Enter guess (" + (guessLimit - guessCount) + " left) :");
                guess = Console.ReadLine();
                guessCount++;
            }
            if(guess == secretWord)
            {
                Console.WriteLine("You Win!");
                return true;
            }
            else
            {
                Console.WriteLine("You Lose!");
                return false;
            }
        }
        static double GetPow(double baseNum, double powNum)
        {
            if(powNum > 0)
            {
                return baseNum * GetPow(baseNum, powNum-1);
            }
            else
            {
                return baseNum;
            }
        }
    }
}

