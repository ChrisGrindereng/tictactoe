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
        static int counter = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("> Let's play a game.");
            PrintBoard();
            Play();
            
            Console.ReadLine();
        }

        static void Play()
        {
            

            Console.WriteLine("> Enter a spot. \"x,y\"");
            char[] delim = { ',' };
            string[] positions = Console.ReadLine().Split(delim); // --> "1,2" -> ["1", "2"]
            int x = Int32.Parse(positions[0]);
            int y = Int32.Parse(positions[1]);
            int index = GetIndex(x, y);
            checkSpace(index);
            board[index] = "X";
            PrintBoard();
            checkWin();
            counter++;
            computerTurn();
            checkCatscratch();
            Console.WriteLine(counter);
            Play();
            
            
             
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
            if (board[i] == "X" || board[i] == "O")
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("Try again");
                    Play();
                }
                else
                {
                    computerTurn();
                }
            }
        }
        static void checkCatscratch()
        {
            if (counter == 9) {
                Console.WriteLine("Cat Scratch");
                boardReset();
            }
        }
        static void checkWin()
        {
            if (board[0] == board[1] && board[2] == board[1] && board[0] != " " ||
                board[0] == board[3] && board[0] == board[6] && board[0] != " " ||
                board[0] == board[4] && board[0] == board[8] && board[0] != " " ||
                board[3] == board[4] && board[3] == board[5] && board[3] != " " ||
                board[6] == board[7] && board[6] == board[8] && board[6] != " " ||
                board[6] == board[4] && board[6] == board[2] && board[6] != " " ||
                board[4] == board[1] && board[7] == board[1] && board[7] != " " ||
                board[2] == board[8] && board[2] == board[5] && board[8] != " ")
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("You Win");

                }
                else {
                    Console.WriteLine("Computer Wins");
                      }


                boardReset();
                PrintBoard();
            }
            

        }
        static void boardReset()
        {
            for(int i = 0; i<9; i++)
            {
                board[i] = " ";
                counter = 0;
            }
        }

        static void computerTurn()
        {
            Random r = new Random();
            int randInRange = r.Next(0, 8);
            checkSpace(randInRange);
            board[randInRange] = "O";
            PrintBoard();
            counter++;
         }
        


        static void PromptForInput()
        {
 
        }
    }
}
