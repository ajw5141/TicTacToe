using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!!!\n"+
            "\nComing soon...\n" +
            // positions to align with numpad: DONE
            "change statement after repeatLoop=True\n"+
            "collison for non-empty spaces\n"+ 
            "randomizer for who goes first\n"+
            "add win conditions\n"+
            "add A.I. and program it to be 'smart'\n"+
            "add score tally for players\n"+
            "ask players if they want to play best of format or until they are ready to stop\n");



            string[] pos = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            Console.WriteLine("Player 1: What is your name?");
            string Player1 = (Console.ReadLine());
            Console.WriteLine("\nPlayer 2: What is your name?");
            string Player2 = (Console.ReadLine());

            string playerMark = "X";
            for (int turn = 1; turn <= 9; turn++)
            {
                if (turn % 2 == 0)
                {
                    string CurrentPlayer = Player2;
                    playerMark = "O";
                    UserInput(pos, playerMark, CurrentPlayer, turn);

                }
                else
                {
                    string CurrentPlayer = Player1;
                    playerMark = "X";
                    UserInput(pos, playerMark, CurrentPlayer, turn);

                }
            }
        }


        static void UserInput(string[] pos, string playerMark, string CurrentPlayer, int turn)
        {



            
            bool repeatLoop;
            Console.WriteLine("\nTurn: " + turn + "\nYo " + CurrentPlayer + ", pick a position for your " + playerMark + ", \ntype 'help' to see which position is which.");
            do
            {
                repeatLoop = false;
                string answer = (Console.ReadLine());
                
                if (answer == "1") { pos[0] = playerMark; }
                else if (answer == "2") { pos[1] = playerMark; }
                else if (answer == "3") { pos[2] = playerMark; }
                else if (answer == "4") { pos[3] = playerMark; }
                else if (answer == "5") { pos[4] = playerMark; }
                else if (answer == "6") { pos[5] = playerMark; }
                else if (answer == "7") { pos[6] = playerMark; }
                else if (answer == "8") { pos[7] = playerMark; }
                else if (answer == "9") { pos[8] = playerMark; }
                else if (answer == "help")
                {
                    PositionKey();
                    repeatLoop = true;
                    Console.WriteLine("Ok, now pick a position for your " + playerMark);
                }
                else { Console.WriteLine("\ninvalid position, try again"); repeatLoop = true; }

            } while (repeatLoop == true);

            PrintBoard(pos);
        }

        static void PrintBoard(string[] pos)
        {

            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", pos[6], pos[7], pos[8]);
            Console.WriteLine(" ____|_____|____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", pos[3], pos[4], pos[5]);
            Console.WriteLine(" ____|_____|____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", pos[0], pos[1], pos[2]);
            Console.WriteLine("     |     |    ");
            Console.WriteLine("");

        }

        static void PositionKey()
        {
            Console.WriteLine("\nUse your NumPad!!!");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("   7 |  8  | 9  ");
            Console.WriteLine(" ____|_____|____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("   4 |  5  | 6  ");
            Console.WriteLine(" ____|_____|____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("   1 |  2  | 3  ");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("");

        }
    }
}