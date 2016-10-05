using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeStarter
{
    class Program
    {

        static string[] board = { " ", " ", " ",
                                  " ", " ", " ",
                                  " ", " ", " " };
        static void Main(string[] args)
        {
            Console.WriteLine("> Let's play a game.");
            PrintBoard();

            Play();
            PrintBoard();
            Console.ReadLine();
        }

        static void Play()
        {
            int counter = 0;

            Console.WriteLine("> Enter a spot. \"x,y\"");
            char[] delim = { ',' };
            string[] positions = Console.ReadLine().Split(delim); // --> "1,2" -> ["1", "2"]
            int x = Int32.Parse(positions[0]);
            int y = Int32.Parse(positions[1]);
            int index = GetIndex(x, y);
            checkSpace(index);
            board[index] = "X";
            
            checkWin();
            computerTurn();
            Play();
            
            counter++;
             
        }

        static int GetIndex(int x, int y)
        {
            return (x - 1) + (y - 1) * 3;
        }

        static void PrintBoard()
        {
            Console.WriteLine("---------");
            Console.WriteLine("| {0} | {1} | {2} |", board[0], board[1], board[2]);
            Console.WriteLine("| {0} | {1} | {2} |", board[3], board[4], board[5]);
            Console.WriteLine("| {0} | {1} | {2} |", board[6], board[7], board[8]);
            Console.WriteLine("---------");
        }

        static void checkSpace(int i)
        {


            if (board[i] == "X")
            {
                Console.WriteLine("Try again");
                Play();
            }
            else if(board[i] == "O") {

            }
           
        }
        static void checkCatscratch(int counter)
        {
            if (counter == 9) { }
        }
        static void checkWin()
        {
            if (board[0] == board[1] && board[2]==board[1] && board[0] != " ")
            {
                Console.WriteLine("You Win");
                boardReset();
                PrintBoard();
            } 

        }
        static void boardReset()
        {
            for(int i = 0; i<9; i++)
            {
                board[i] = " ";
            }
        }

        static void computerTurn()
        {
            Random r = new Random();
            int randInRange = r.Next(0, 8);
            checkSpace(randInRange);
            board[randInRange] = "O";
            PrintBoard();
            


        }
        


        static void PromptForInput()
        {
 
        }
    }
}
