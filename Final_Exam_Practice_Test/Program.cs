using System;

namespace Final_Exam_Practice_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello Fabio Veiga - 924IT!");

            /*
             * 1. Implement a method that prompts the user to input three integer values and find the greatest value of the three values.
             */

            bool flagSystem = true;
            
            while (flagSystem)
            {
                bool flagContinue = true;
                Console.Clear();
                Console.WriteLine("Choose the number to do a operation");
                Console.WriteLine("0. To Exit");
                Console.WriteLine("1. The greatest number between 3 number");
                Console.WriteLine("2. Student’s grade");
                Console.WriteLine("3. Counts the number of digits");
                Console.WriteLine("4. ASCII codes from 1 to 122");
                Console.WriteLine("5. Counts the number of spaces in the string");
                Console.WriteLine("");

                try
                {
                    int itemMenu;
                    Console.Write("What is your option: ");
                    itemMenu = int.Parse(Console.ReadLine());

                    //Switch
                    switch (itemMenu)
                    {
                        case 0:
                            flagSystem = false;
                            break;
                        case 1:
                            while (flagContinue)
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("1. The greatest number between 3 number\n");
                                    int n1;
                                    int n2;
                                    int n3;
                                    int greatestNumber;
                                    Console.Write("Enter with firt number: ");
                                    n1 = int.Parse(Console.ReadLine());
                                    Console.Write("Enter with second number: ");
                                    n2 = int.Parse(Console.ReadLine());
                                    Console.Write("Enter with third number: ");
                                    n3 = int.Parse(Console.ReadLine());

                                    greatestNumber = GreatestNumberBetweenThree(n1, n2, n3);
                                    Console.WriteLine("\nThe greatest number between " + n1 + ", " + n2 + ", " + n3 + " is " + greatestNumber + "\n");
                                    Console.WriteLine("\nType yes or y to do the operation again.");
                                    Console.WriteLine("Type anything to leave.");
                                    Console.Write("What do you want? ");
                                    string stay = Console.ReadLine();
                                    if (stay.ToLower() == "yes" || stay.ToLower() == 'y'.ToString())
                                    {
                                        flagContinue = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        flagContinue = false;
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("\nSome mistake was detected! Please, could you repeat the operation!\nPress some key to back for operation.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            break;
                        case 2:
                            while (flagContinue)
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("2. Student’s grade\n");
                                    decimal n1;
                                    decimal n2;
                                    decimal n3;
                                    char finelGrade;
                                    Console.Write("What is the quiz score: ");
                                    n1 = decimal.Parse(Console.ReadLine());
                                    Console.Write("What is the mid-term score: ");
                                    n2 = decimal.Parse(Console.ReadLine());
                                    Console.Write("What is the final score: ");
                                    n3 = decimal.Parse(Console.ReadLine());

                                    finelGrade = CalculateGradesStudents(n1, n2, n3);
                                    Console.WriteLine("\nThe scores are " + n1 + ", " + n2 + ", " + n3 + ". The final grade is " + finelGrade + "\n");
                                    Console.WriteLine("\nType yes or y to do the operation again.");
                                    Console.WriteLine("Type anything to leave.");
                                    Console.Write("What do you want? ");
                                    string stay = Console.ReadLine();
                                    if (stay.ToLower() == "yes" || stay.ToLower() == 'y'.ToString())
                                    {
                                        flagContinue = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        flagContinue = false;
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("\nSome mistake was detected! Please, could you repeat the operation!\nPress some key to back for operation.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            break;
                        case 3:
                            while (flagContinue)
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("3. Counts the number of digits\n");
                                    int input;
                                    int output;
                                    Console.Write("Write your number: ");
                                    input = int.Parse(Console.ReadLine());

                                    output = HowManyNumberHasInt(input);
                                    Console.WriteLine("\nYour number is " + input + " and it has " + output + " digit(s).\n");
                                    Console.WriteLine("\nType yes or y to do the operation again.");
                                    Console.WriteLine("Type anything to leave.");
                                    Console.Write("What do you want? ");
                                    string stay = Console.ReadLine();
                                    if (stay.ToLower() == "yes" || stay.ToLower() == 'y'.ToString())
                                    {
                                        flagContinue = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        flagContinue = false;
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("\nSome mistake was detected! Please, could you repeat the operation!\nPress some key to back for operation.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            break;
                        case 4:
                            while (flagContinue)
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("4. ASCII codes from 1 to 122\n");

                                    Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
                                    PrintTableASCII();

                                    Console.WriteLine("Please, press any key to came back to menu...");
                                    Console.ReadKey();
                                    flagContinue = false;
                                }
                                catch
                                {
                                    Console.WriteLine("\nSome mistake was detected! Please, could you repeat the operation!\nPress some key to back for operation.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            break;
                        case 5:
                            while (flagContinue)
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("5. Counts the number of spaces in the string\n");

                                    string input;
                                    int totalSpace;
                                    Console.Write("Write your phrase: ");
                                    input = Console.ReadLine();

                                    totalSpace = CountSpaceString(input);

                                    Console.WriteLine("\nYour phrase is " + input + " total spaces " + totalSpace + ".\n");
                                    Console.WriteLine("\nType yes or y to do the operation again.");
                                    Console.WriteLine("Type anything to leave.");
                                    Console.Write("What do you want? ");
                                    string stay = Console.ReadLine();
                                    if (stay.ToLower() == "yes" || stay.ToLower() == 'y'.ToString())
                                    {
                                        flagContinue = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        flagContinue = false;
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("\nSome mistake was detected! Please, could you repeat the operation!\nPress some key to back for operation.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("This item doesn't exit! Try again!");
                    }
                }
                catch
                {
                    Console.WriteLine("\nSome mistake was detected! Please, could you choose again your item!\nPress some key to back for operation.");
                    Console.ReadKey();
                }

            }
        }

        public static int GreatestNumberBetweenThree(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > n3)
            {
                return n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }

        public static char CalculateGradesStudents(decimal quiz, decimal mid, decimal final)
        {
            decimal result = 0;
            result = (quiz + mid + final) / 3;
            if(result >= 90)
            {
                return 'A';
            }else if(result >= 70 && result < 90)
            {
                return 'B';
            }else if (result >= 50 && result < 70)
            {
                return 'C';
            }
            else
            {
                return 'F';
            }
        }

        public static int HowManyNumberHasInt(int number)
        {
            string convertNumber = "";
            convertNumber = number.ToString();
            return convertNumber.Length;
        }

        public static void PrintTableASCII()
        {
            int aux = 10;
            int limit = 123;
            for (int i = 1; i < limit; i++)
            {
                for (int j = i; j < aux; j++)
                {
                    Console.Write((char)j + " ");
                    if (j == limit)
                    {
                        i = limit;
                        break;
                    }
                    if (j == aux-1)
                    {
                        i += 9;
                    }
                    
                }
                aux = i + 11;
                Console.WriteLine("");
            }
        }

        public static int CountSpaceString(string input)
        {
            int count = input.Split(' ').Length - 1;
            return count;
        }
    }
}
