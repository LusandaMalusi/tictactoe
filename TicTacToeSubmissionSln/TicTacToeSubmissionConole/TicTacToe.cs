using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(34, 6);
            _boardRenderer.Render();
        }


        public void Run()
        {
            char[] playerXpos = new char[9];
            char[] playerOpos = new char[9];

            for (int i = 0; i < 9; i++)
            {
                // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

                Console.SetCursorPosition(2, 19);

                Console.Write("Player X");

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                var row = Console.ReadLine();

                Console.SetCursorPosition(2, 22);


                Console.Write("Please Enter Column: ");
                var column = Console.ReadLine();

                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

                
                
                if (int.Parse(row) == 0 && int.Parse(column) == 0)
                {
                    playerXpos[0] = 'x';
                }
                if (int.Parse(row) == 0 && int.Parse(column) == 1)
                {
                    playerXpos[1] = 'x';
                }
                if (int.Parse(row) == 0 && int.Parse(column) == 2)
                {
                    playerXpos[2] = 'x';
                }
                if (int.Parse(row) == 1 && int.Parse(column) == 0)
                {
                    playerXpos[3] = 'x';
                }
                if (int.Parse(row) == 1 && int.Parse(column) == 1)
                {
                    playerXpos[4] = 'x';
                }
                if (int.Parse(row) == 1 && int.Parse(column) == 2)
                {
                    playerXpos[5] = 'x';
                }
                if (int.Parse(row) == 2 && int.Parse(column) == 0)
                {
                    playerXpos[6] = 'x';
                }
                if (int.Parse(row) == 2 && int.Parse(column) == 1)
                {
                    playerXpos[7] = 'x';
                }
                if (int.Parse(row) == 2 && int.Parse(column) == 2)
                {
                    playerXpos[8] = 'x';
                }


                 if (playerXpos[0] =='x' && playerXpos[4] == 'x' && playerXpos[8]=='x')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player X win");
                    break;
                }
                if (playerXpos[6] == 'x' && playerXpos[4] == 'x' && playerXpos[2] == 'x')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player X win");
                    break;
                }
                if (playerXpos[0] == 'x' && playerXpos[1] == 'x' && playerXpos[2] == 'x')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player X win");
                    break;
                }
                if (playerXpos[3] == 'x' && playerXpos[4] == 'x' && playerXpos[5] == 'x')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player X win");
                    break;
                }
                if (playerXpos[6] == 'x' && playerXpos[7] == 'x' && playerXpos[8] == 'x')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player X win");
                    break;
                }
                if (playerXpos[0] == 'x' && playerXpos[3] == 'x' && playerXpos[6] == 'x')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player X win");
                    break;
                }
                if (playerXpos[1] == 'x' && playerXpos[4] == 'x' && playerXpos[7] == 'x')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player X win");
                    break;
                }
                if (playerXpos[2] == 'x' && playerXpos[5] == 'x' && playerXpos[8] == 'x')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player X win");
                    break;
                }
































                Console.SetCursorPosition(2, 24);
                Console.Write(" Now its your turn  player O");
                Console.SetCursorPosition(2, 25);
                Console.Write("Please Enter Row: ");
                row = Console.ReadLine();
                Console.SetCursorPosition(2, 26);

                Console.Write("Please Enter Column: ");
                column = Console.ReadLine();

                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);

                
                
                if (int.Parse(row) == 0 && int.Parse(column) == 0)
                {
                    playerOpos[0] = 'O';
                }
                if (int.Parse(row) == 0 && int.Parse(column) == 1)
                {
                    playerOpos[1] = 'O';
                }
                if (int.Parse(row) == 0 && int.Parse(column) == 2)
                {
                    playerOpos[2] = 'O';
                }
                if (int.Parse(row) == 1 && int.Parse(column) == 0)
                {
                    playerOpos[3] = 'O';
                }
                if (int.Parse(row) == 1 && int.Parse(column) == 1)
                {
                    playerOpos[4] = 'O';
                }
                if (int.Parse(row) == 1 && int.Parse(column) == 2)
                {
                    playerOpos[5] = 'O';
                }
                if (int.Parse(row) == 2 && int.Parse(column) == 0)
                {
                    playerOpos[6] = 'O';
                }
                if (int.Parse(row) == 2 && int.Parse(column) == 1)
                {
                    playerOpos[7] = 'O';
                }
                if (int.Parse(row) == 2 && int.Parse(column) == 2)
                {
                    playerOpos[8] = 'O';
                }


                if (playerOpos[0] == 'O' && playerOpos[4] == 'O' && playerOpos[8] == 'O')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player O win");
                    break;
                }
                if (playerOpos[6] == 'O' && playerOpos[4] == 'O' && playerOpos[2] == 'O')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player O win");
                    break;
                }
                if (playerOpos[0] == 'O' && playerOpos[1] == 'O' && playerOpos[2] == 'O')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player O win");
                    break;
                }
                if (playerOpos[3] == 'O' && playerOpos[4] == 'O' && playerOpos[5] == 'O')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player O win");
                    break;
                }
                if (playerOpos[6] == 'O' && playerOpos[7] == 'O' && playerOpos[8] == 'O')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player O win");
                    break;
                }
                if (playerOpos[0] == 'O' && playerOpos[3] == 'O' && playerOpos[6] == 'O')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player O win");
                    break;
                }
                if (playerOpos[1] == 'O' && playerOpos[4] == 'O' && playerOpos[7] == 'O')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player O win");
                    break;
                }
                if (playerOpos[2] == 'O' && playerOpos[5] == 'O' && playerOpos[8] == 'O')
                {
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("Player O win");
                    break;
                }



            }


        }

        
    }
}
       




















































































































































































































































































































































































































































 

















































































































































































































































































































































































































