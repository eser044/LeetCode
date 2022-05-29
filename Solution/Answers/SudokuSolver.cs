using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class SudokuSolver
    {
        public static void Run()
        {
            Solution();
        }
        
        public static void Solution()
        {
            //var board = new char[][]
            //{
            //    new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
            //    new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
            //    new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            //    new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            //    new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            //    new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            //    new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            //    new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            //    new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            //};

            var board = new char[][]
            {
                new char[] {'.', '.', '.', '4', '7', '.', '6', '8', '.'},
                new char[] {'.', '5', '.', '6', '.', '.', '9', '.', '1'},
                new char[] {'.', '.', '.', '.', '.', '.', '4', '.', '.'},
                new char[] {'.', '.', '4', '1', '.', '.', '.', '5', '.'},
                new char[] {'.', '6', '.', '.', '8', '.', '.', '.', '7'},
                new char[] {'.', '3', '.', '.', '.', '.', '.', '.', '.'},
                new char[] {'5', '.', '.', '.', '.', '.', '2', '.', '.'},
                new char[] {'.', '.', '7', '.', '9', '.', '.', '.', '.'},
                new char[] {'.', '9', '8', '.', '6', '.', '.', '.', '.'}
            };

            Solve(board);

            foreach(var row in board)
            {
                foreach (var c in row)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool Solve(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                    {
                        for (char c = '1'; c <= '9'; c++)
                        {
                            if (IsValid(board, i, j, c))
                            {
                                board[i][j] = c;
                                if (Solve(board))
                                    return true;
                                else
                                    board[i][j] = '.';
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool IsValid(char[][] board, int row, int col, char c)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i][col] != '.' && board[i][col] == c)
                    return false;
                
                if (board[row][i] != '.' && board[row][i] == c)
                    return false;
            }
            
            int r = row / 3 * 3;
            int c1 = col / 3 * 3;
            for (int i = r; i < r + 3; i++)
            {
                for (int j = c1; j < c1 + 3; j++)
                {
                    if (board[i][j] != '.' && board[i][j] == c)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
