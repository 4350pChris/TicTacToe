using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Logic
    {
        public static bool Win(int[,] arr)
        {
            int dim = arr.GetLength(0);

            for (int i = 0; i < dim; i++)
            {
                if (((arr[i, 0] == arr[i, 1]) && (arr[i, 1] == arr[i, 2]) && (arr[i, 0] != 0))
                    || ((arr[0, i] == arr[1, i]) && (arr[1, i] == arr[2, i]) && (arr[0, i] != 0)))
                {
                    return true;
                }
                else if (((arr[0, 0] == arr[1, 1]) && (arr[1, 1] == arr[2, 2]) && (arr[0, 0] != 0))
                        || ((arr[0, 2] == arr[1, 1]) && (arr[1, 1] == arr[2, 0]) && (arr[0, 2] != 0)))
                {
                    return true;
                }
            }
            return false;
        }

        public static void WriteToArray(int [,] arr, int col, int row, string play)
        {
            arr[col, row] = (play == "X") ? 1 : 2;
        }
    }
}
