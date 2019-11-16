using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {


            /*  Console.WriteLine("Welcome to Tic-Tac-Toe!");
              Console.WriteLine("");
              Console.WriteLine(" ___|___|___ ");
              Console.WriteLine(" ___|___|___ ");
              Console.WriteLine("    |   |    ");
              Console.WriteLine("");

              int[,] myArray = new int[3, 3];
              myArray[2,2]  = 5;
              Console.WriteLine(myArray[2, 2]); */



            /*  
               */

            PrintBoard();

            string[] pos = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            pos[0] = "X";
            pos[3] = "O";
            pos[5] = "!";
            int x;
            for (x = 0; x < pos.Length; x++)
                Console.WriteLine("Value: " + pos[x]);

            /* for (x = 0; x < pos.Length; x++)
                 ReceiverMethod(pos[x]);
                 Console.Read(); */

            ReceiverMethod(pos[3]);
            Console.Read();


            Console.ReadLine();
            
         /*   CreateGrid();
            Console.ReadLine();

            }

        static void CreateGrid()
        {
/*
            int width = 4;
            int height = 4;

            string[,] grid = new string[width, height];
            grid[1, 1] = "x";
            grid[1, 2] = "x";
            grid[1, 3] = "x";
            grid[2, 1] = "x";
            grid[2, 2] = "x";
            grid[2, 3] = "x";
            grid[3, 1] = "x";
            grid[3, 2] = "x";
            grid[3, 3] = "x";


            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write(grid[x, y] + "|");
                }
                Console.WriteLine();
            }
*/
        }
        /*
        static string GetPos(int PosNum)
        {
            string boardPos;

            switch (PosNum)
            {

                case 0:
                        boardPos = "not a board position";
                        break;

                    case 1:
                        boardPos = myArray[0, 0];
                        break;

                    case 2:
                        boardPos = myArray[0, 1];
                        break;

                    case 3:
                        boardPos = myArray[0, 2];
                        break;

                    case 4:
                        boardPos = myArray[1, 0];
                        break;

                    case 5:
                        boardPos = myArray[1, 1];
                        break;

                    case 6:
                        boardPos = myArray[1, 2];
                        break;

                    case 7:
                        boardPos = myArray[2, 0];
                        break;

                    case 8:
                        boardPos = myArray[2, 1];
                        break;

                    case 9:
                        boardPos = myArray[2, 2];
                        break;
        */

static void ReceiverMethod(string oneVal)
        {
            Console.WriteLine("Value in the method: " + oneVal);
        }
            

        static void PrintBoard()
        {
            string[] pos = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " "};
            
            
            
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  "+pos[0]+ "  |  "+ pos[1] + "  |  " + pos[2]);
            Console.WriteLine(" ____|_____|____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  "+ pos[3]+ "  |  "+ pos[4] + "  |  " + pos[5]);
            Console.WriteLine(" ____|_____|____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  "+ pos[6]+ "  |  "+ pos[7] + "  |  " + pos[8]);
            Console.WriteLine("     |     |    ");
            Console.WriteLine("");

           


        }  
        
        
    }
}
