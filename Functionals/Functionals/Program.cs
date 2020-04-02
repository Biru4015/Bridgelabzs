using System;

namespace Functionals
{
    /// <summary>
    /// This class containd the main method which is holding the control follow of this project
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 For replacing with username in sentence");
            Console.WriteLine("Press 2 For flipping the coins");
            Console.WriteLine("Press 3 For Finding the leap year for given year greater than 4 digits");
            Console.WriteLine("Press 4 For Finding the power of two upto given number");
            Console.WriteLine("Press 5 For Finding the nth harmonic number for a given number");
            Console.WriteLine("Press 6 For Finding prime factors of a given number");
            Console.WriteLine("Press 7 For Printing 2 dimension matrix");
            Console.WriteLine("Press 8 For Finding the distinct triplets in an given array");
            Console.WriteLine("Press 9 For Calculating distance between any coordinate to origin");
            Console.WriteLine("Press 10 For Calculating roots of quadratic equations");
            Console.WriteLine("Press 11 For Calculating wind chill of given tempreture and speed");
            Console.WriteLine("Press 12 For Finding win and loss percentage is Gambler game");
            Console.WriteLine("Press 13 For Finding the n distinct coupan number");
            Console.WriteLine("Pres 14 For Find elapsed time in stop watch");
            Console.WriteLine("Pres 15 For Playing tictactoe game");

            Console.Write("Please enter the options: ");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    //For replacing with username in sentence
                    UserName uname = new UserName();
                    uname.UserName1();
                    break;

                case 2:
                    //For flipping the coins
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.flippingCoins();
                    break;

                case 3:
                    //Finding the leap year for given year greater than 4 digits
                    LeapYear ly = new LeapYear();
                    ly.leapYear();
                    break;

                case 4:
                    //Finding the power of two upto given number
                    PowerOfTwo pot = new PowerOfTwo();
                    pot.powerOfTwo();
                    break;

                case 5:
                    //Finding the nth harmonic number for a given number
                    HarmonicNumber hn = new HarmonicNumber();
                    hn.harmonicNumber();
                    break;

                case 6:
                    //Finding prime factors of a given number
                    PrimeFcators pf = new PrimeFcators();
                    pf.primeFactors();
                    break;

                case 7:
                    //Printing 2 dimension matrix
                    TwoDArray tdarray = new TwoDArray();
                    tdarray.twoDArray();
                    break;

                case 8:
                    //Finding the distinct triplets in an given array
                    DistinctTriplets distinct = new DistinctTriplets();
                    distinct.distinctTriplets();
                    break;

                case 9:
                    //Calculating distance between any coordinate to origin
                    Distance d = new Distance();
                    d.distance();
                    break;

                case 10:
                    //Calculating roots of quadratic equations
                    QuadraticRoots roots = new QuadraticRoots();
                    roots.quadraticRoots();
                    break;

                case 11:
                    //Calculating wind chill of given tempreture and speed
                    WindChill wind = new WindChill();
                    wind.windChill();
                    break;

                case 12:
                    //Finding win and loss percentage is Gambler game
                    Gambler game = new Gambler();
                    game.gambler();
                    break;

                case 13:
                    //Finding the n distinct coupan number
                    DistinctCoupan coupan = new DistinctCoupan();
                    coupan.distinctCoupan();
                    break;

                case 14:
                    //Find elapsed time in stop watch
                    StopWatch watch = new StopWatch();
                    watch.stopWatch();
                    break;

                case 15:
                    //Tictactoe Game simulation
                    Tictactoe tictac = new Tictactoe();
                    tictac.mainmethod();
                    break;

                default:
                    Console.WriteLine("Please enter the options between 1 to 15");
                    break;

            }
        }
    }
}