using System;

namespace QuizApp
{
    class QuizApp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========= WELCOME TO C# QUIZ ========\n");

            Console.WriteLine("Are you ready, please enter Y or N : ");
            char c = Char.ToUpper(char.Parse(Console.ReadLine().Trim()));

            int count = 0;

            if (Char.ToUpper(c) == 'Y')
            {
                char ans1 = 'A';
                Console.WriteLine("\n1. What is the correct syntax to declare a variable in C#?");
                Console.WriteLine("A) int x = 10;");
                Console.WriteLine("B) x = int 10;");
                Console.WriteLine("C) int = x 10;");
                Console.WriteLine("D) 10 = int x;");
             Console.WriteLine();


                while (true)
                {
                    Console.Write("Answer : ");
                    char a1 = Char.ToUpper(char.Parse(Console.ReadLine().Trim()));
                    Console.WriteLine();


                    if (a1 == 'A' || a1 == 'B' || a1 == 'C' || a1 == 'D')
                    {
                        if (a1 == ans1)
                        {

                          Console.WriteLine("Correct !!");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong !!, correct answer is : " + ans1);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid option!! please enter A, B, C, D\n");
                    }

                }


                char ans2 = 'B';
                Console.WriteLine("\n2. Which of the following is the entry point of a C# console application?");
                Console.WriteLine("A) Start()");
                Console.WriteLine("B) Main");
                Console.WriteLine("C) Run");
                Console.WriteLine("D) Init");
                Console.WriteLine();

                while (true)
                {
                    Console.Write("Answer : ");
                    char a2 = Char.ToUpper(char.Parse(Console.ReadLine().Trim()));
                    Console.WriteLine();



                    if (a2 == 'A' || a2 == 'B' || a2 == 'C' || a2 == 'D')
                    {
                        if (a2 == ans2)
                        {
                            Console.WriteLine("Correct !!");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong !!, correct answer is : " + ans2);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid option!! please enter A, B, C, D\n");
                    }
                }

                char ans3 = 'B';
                Console.WriteLine("\n3. What is the default value of a bool variable in C#?");
                Console.WriteLine("A) true");
                Console.WriteLine("B) false");
                Console.WriteLine("C) 0");
                Console.WriteLine("D) null");
                Console.WriteLine();

                while (true)
                {
                    Console.Write("Answer : ");
                    char a3 = Char.ToUpper(char.Parse(Console.ReadLine().Trim()));
                    Console.WriteLine();




                    if (a3 == 'A' || a3 == 'B' || a3 == 'C' || a3 == 'D')
                    {
                        if (a3 == ans3)
                        {
                            Console.WriteLine("Correct !!");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong !!, correct answer is : " + ans3);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid option!! please enter A, B, C, D\n");
                    }
                }

                char ans4 = 'C';
                Console.WriteLine("\n4. Which keyword is used to create an object in C#?");
                Console.WriteLine("A) create");
                Console.WriteLine("B) object");
                Console.WriteLine("C) new");
                Console.WriteLine("D) class");
                Console.WriteLine();


                while (true)
                {
                    Console.Write("Answer : ");
                    char a4 = Char.ToUpper(char.Parse(Console.ReadLine().Trim()));
                    Console.WriteLine();




                    if (a4 == 'A' || a4 == 'B' || a4 == 'C' || a4 == 'D')
                    {
                        if (a4 == ans4)
                        {
                            Console.WriteLine("Correct !!");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong !!, correct answer is : " + ans4);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid option!! please enter A, B, C, D\n");
                    }
                }

                char ans5 = 'B';
                Console.WriteLine("\n5. What does the using keyword do in C#?");
                Console.WriteLine("A) Declares a variable");
                Console.WriteLine("B) Imports a namespace");
                Console.WriteLine("C) Creates a loop");
                Console.WriteLine("D) Defines a class");
                Console.WriteLine();


                while (true)
                {
                    Console.Write("Answer : ");
                    char a5 = Char.ToUpper(char.Parse(Console.ReadLine().Trim()));
                    Console.WriteLine();




                    if (a5 == 'A' || a5 == 'B' || a5 == 'C' || a5 == 'D')
                    {
                        if (a5 == ans5)
                        {
                            Console.WriteLine("Correct !!");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong !!, correct answer is : " + ans5);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid option!! please enter A, B, C, D\n");
                    }
                }


                if (count == 5)
                {
                    Console.WriteLine("\nCongratulations !! Your score is : " + count);
                }
                else
                {
                    Console.WriteLine($"\nYour score is : {count}, You need to improve!!");
                }
            }
            Console.WriteLine("\n=========== THANK YOU!! ===========");

            Console.ReadKey();

        }
    }

}