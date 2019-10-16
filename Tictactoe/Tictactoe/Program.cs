using System;

namespace Tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean player = true;
            string[,] board = new string[,]
            {
              {"1", "|","2","|","3"},
              {"-", "|","-","|","-"},
              {"4", "|","5","|","6"},
              {"-", "|","-","|","-"},
              {"7", "|","8","|","9"}
            };
            for (int i = 0; i < 5; i++)
            {
                string ans = board[i, 0] + board[i, 1] + board[i, 2] + board[i, 3] + board[i, 4];
                Console.WriteLine(ans);

            }
            for (int p = 0; p < 10; p++)
            {
                if (win(board) == false)
                {
                    if (player == true)
                    {
                        Console.WriteLine("Player 1 (x) enter the postition you would like to place your move:");
                        string t = Console.ReadLine();
                        board = position(t, board, player);
                        player = false;
                    }
                    else
                    {
                        Console.WriteLine("Player 2 (o) enter the postition you would like to place your move:");
                        string l = Console.ReadLine();
                        board = position(l, board, player);
                        player = true;
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        string ans = board[i, 0] + board[i, 1] + board[i, 2] + board[i, 3] + board[i, 4];
                        Console.WriteLine(ans);
                    }
                }
            }
            static Boolean win(string[,] table)
            {
                if (string.Equals(table[0, 0], table[0, 2]) && string.Equals(table[0, 0], table[0, 4]) && string.Equals(table[0, 2], table[0, 4]))
                {
                    return true;
                }
                else if (string.Equals(table[2, 0], table[2, 2]) && string.Equals(table[2, 0], table[2, 4]) && string.Equals(table[2, 2], table[2, 4]))
                {
                    return true;
                }
                else if (string.Equals(table[4, 0], table[4, 2]) && string.Equals(table[4, 0], table[4, 4]) && string.Equals(table[4, 2], table[4, 4]))
                {
                    return true;
                }
                else if (string.Equals(table[0, 0], table[2, 0]) && string.Equals(table[0, 0], table[4, 0]) && string.Equals(table[2, 0], table[4, 0]))
                {
                    return true;
                }
                else if (string.Equals(table[0, 2], table[2, 2]) && string.Equals(table[0, 2], table[4, 2]) && string.Equals(table[2, 2], table[4, 2]))
                {
                    return true;
                }
                else if (string.Equals(table[0, 4], table[2, 4]) && string.Equals(table[0, 4], table[4, 4]) && string.Equals(table[2, 4], table[4, 4]))
                {
                    return true;
                }
                else if (string.Equals(table[0, 0], table[2, 2]) && string.Equals(table[0, 0], table[4, 4]) && string.Equals(table[2, 2], table[4, 4]))
                {
                    return true;
                }
                else if (string.Equals(table[0, 4], table[2, 2]) && string.Equals(table[0, 4], table[4, 0]) && string.Equals(table[2, 2], table[4, 0]))
                {
                    return true;
                }
                else return false;
            }
            static string[,] position(string input, string[,] table, Boolean first)
            {
                if (string.Equals(input,"1") && first == true)
                {
                    table[0, 0] = "x";
                    return table;
                }
                else if (string.Equals(input, "1") && first == false)
                {
                    table[0, 0] = "o";
                    return table;
                }
                else if (string.Equals(input, "2") && first == true)
                {
                    table[0, 2] = "x";
                    return table;
                }
                else if (string.Equals(input, "2") && first == false)
                {
                    table[0, 2] = "o";
                    return table;
                }
                else if (string.Equals(input, "3") && first == true)
                {
                    table[0, 4] = "x";
                    return table;
                }
                else if (string.Equals(input, "3") && first == false)
                {
                    table[0, 4] = "o";
                    return table;
                }
                else if (string.Equals(input, "4") && first == true)
                {
                    table[2, 0] = "x";
                    return table;
                }
                else if (string.Equals(input, "4") && first == false)
                {
                    table[2, 0] = "o";
                    return table;
                }
                else if (string.Equals(input, "5") && first == true)
                {
                    table[2, 2] = "x";
                    return table;
                }
                else if (string.Equals(input, "5") && first == false)
                {
                    table[2, 2] = "o";
                    return table;
                }
                else if (string.Equals(input, "6") && first == true)
                {
                    table[2, 4] = "x";
                    return table;
                }
                else if (string.Equals(input, "6") && first == false)
                {
                    table[2, 4] = "o";
                    return table;
                }
                else if (string.Equals(input, "7") && first == true)
                {
                    table[4, 0] = "x";
                    return table;
                }
                else if (string.Equals(input, "7") && first == false)
                {
                    table[4, 0] = "o";
                    return table;
                }
                else if (string.Equals(input, "8") && first == true)
                {
                    table[4, 2] = "x";
                    return table;
                }
                else if (string.Equals(input, "8") && first == false)
                {
                    table[4, 2] = "o";
                    return table;
                }
                else if (string.Equals(input, "9") && first == true)
                {
                    table[4, 4] = "x";
                    return table;
                }
                else if (string.Equals(input, "9") && first == false)
                {
                    table[4, 4] = "o";
                    return table;
                }
                return table;
            }

        }
    }
}
