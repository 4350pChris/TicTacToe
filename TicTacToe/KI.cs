using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class KI
    {
        public static void KiTurn(int[,] arr, out int col, out int row)
        {
            col = -1;
            row = -1;

            if (MainForm.count == 3 && MainForm.level == 0)
            {
                if (CounterCorner(arr, out col, out row))
                {
                    return;
                }
                else if (CounterWinPlay(arr, out col, out row))
                {
                    return;
                }
            }
            if (OneTurnWin(arr, out col, out row))
            {
                return;
            }
            else if (arr[(arr.GetLength(0) - 1) / 2, (arr.GetLength(0) - 1) / 2] == 0)
            {
                col = row = (arr.GetLength(0) - 1) / 2;
                return;
            }
            else if (Corner(arr, out col, out row))
            {
                return;
            }
            else
            {
                Side(arr, out col, out row);
                return;
            }
        }

        private static bool OneTurnWin(int[,] arr, out int col, out int row)
        {
            col = -1;
            row = -1;
            string kiChar = "X";
            string playerChar = "O";

            if (CheckForWin(arr, kiChar, out col, out row))
            {
                return true;
            }
            return CheckForWin(arr, playerChar, out col, out row);
        }

        private static bool CheckForWin(int[,] arr, string kiChar, out int col, out int row)
        {
            col = -1;
            row = -1;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int n = 0; n < arr.GetLength(0); n++)
                {
                    if (arr[n, i] == 0)
                    {
                        int[,] testArr = new int[3, 3];
                        Array.Copy(arr, 0, testArr, 0, arr.Length);

                        Logic.WriteToArray(testArr, n, i, kiChar);
                        if (Logic.Win(testArr))
                        {
                            col = n;
                            row = i;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private static bool Corner(int[,] arr, out int col, out int row)
        {
            if (arr[0,0] == 0)
            {
                col = row = 0;
                return true;
            }
            else if (arr[arr.GetLength(0) - 1, arr.GetLength(0) - 1] == 0)
            {
                col = row = arr.GetLength(0) - 1;
                return true;
            }
            else if (arr[0, arr.GetLength(0) - 1] == 0)
            {
                col = 0;
                row = arr.GetLength(0) - 1;
                return true;
            }
            else if (arr[arr.GetLength(0) - 1, 0] == 0)
            {
                col = arr.GetLength(0) - 1;
                row = 0;
                return true;
            }
            else
            {
                row = -1;
                col = -1;
                return false;
            }
        }

        private static bool CounterCorner(int[,] arr, out int col, out int row)
        {
            if (arr[0, 0] == 2 && arr[arr.GetLength(0) - 1, arr.GetLength(0) - 1] == 2)
            {
                col = 1;
                row = 0;
                return true;
            }
            else if (arr[arr.GetLength(0) - 1, 0] == 2 && (arr[0, arr.GetLength(0) - 1] == 2))
            {
                col = 1;
                row = 0;
                return true;
            }
            col = -1;
            row = -1;
            return false;
        }

        private static bool CounterWinPlay(int[,] arr, out int col, out int row)
        {
            if (arr[2,1] == 2 && arr[0,2] == 2)
            {
                col = 2;
                row = 2;
                return true;
            }
            else if (arr[1,2] == 2 && arr[2,0] == 2)
            {
                col = 2;
                row = 2;
                return true;
            }
            else if (arr[1,2] == 2 && arr[2,1] == 2)
            {
                col = 2;
                row = 2;
                return true;
            }
            col = -1;
            row = -1;
            return false;
        }

        private static bool Side(int[,] arr, out int col, out int row)
        {
            col = -1;
            row = -1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int n = 0; n < arr.GetLength(0); n++)
                {
                    if (arr[i, n] == 0)
                    {
                        col = i;
                        row = n;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
