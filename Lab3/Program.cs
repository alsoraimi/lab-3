using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool askToContinue = false;
            do
            {
                Console.WriteLine("Learn your squares and cubes!!");
                


                int num;


                do
                {
                    Console.WriteLine("Enter an integer");
                    num = int.Parse(Console.ReadLine());


                    Console.WriteLine("Number    Squared    Cubed\n======    =======    =====");     //format table

                    for (int i = 1; i <= num; i++)
                    {
                        Console.WriteLine("{0,0}{1,10}{2,11}", i, Square(i), Cube(i));


                    }
                    Console.WriteLine("do you wish to contine? " + "Y/N");
                    if (Console.ReadLine().ToUpper() == ("Y"))
                        askToContinue = true;
                    else
                    {
                        return;
                    }

                    //if (num < 0)
                    //{
                    //    Console.WriteLine("please enter number equal to or higher than 0");
                    //}

                    //if (!int.TryParse(input, out num))
                    //{
                    //    Console.WriteLine("Not an integer");
                    //}



                } while (askToContinue);
            } while (true);

        }


 //seperate methods for square and cube

    public static int Square(int n)


        {
            int square = n * n;
            return square;
        }

        public static int Cube (int n)

        {
            int cube = n * n * n;
            return cube;


        }

       


        }
    }




