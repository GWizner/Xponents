public class Program
{
    public static void Main(string[] parameters)
    {
        Console.WriteLine("Try my calulator.");
        bool keepOn = true;
        
        int userInt = 0;
        string yes = "yes";
        string y = "y";
        string userAns;

        while (keepOn)
        {

            Console.WriteLine("SQUARES AND CUBES");
            Console.WriteLine();
            Console.WriteLine("Input an integer (We can calculate up to the cube of 1,290. Please don't go above that):");
            string userIn = Console.ReadLine();
            bool userInput = false;
            userInput = int.TryParse(userIn, out userInt);

            if (userInt > 0 && userInt < 1291)
            {


                if (userInput)
                {
                    Console.WriteLine();
                    Console.WriteLine("Number          Squared          Cubed");
                    Console.WriteLine("======          =======          =====");

                    for (int currInt = 1; currInt <= userInt; currInt++)
                    {
                        string strFormat = String.Format("{0, 6} {1, 16} {2, 14}", currInt, SquareInput(currInt), CubeInput(currInt));
                        Console.WriteLine(strFormat);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Continue (y/n)? ");
                userAns = Console.ReadLine().ToLower();
                userAns.Trim();
                userAns = userAns.Trim();
                Console.WriteLine();

                if (userAns == y || userAns == yes)
                {
                    keepOn = true;
                }
                else
                {
                    keepOn = false;
                }
            }
            else
            {
                Console.WriteLine($"Unrecognized input {userIn}. Please enter an integer between 1 and 1,290.");
            }

            
        }

    }
    public static int SquareInput(int input)
    {
        int square;
        square = input * input;

        return square;
    }

    public static int CubeInput(int input)
    {
        int cube;
        cube = (int)Math.Pow(input, 3);

        return cube;
    }
}