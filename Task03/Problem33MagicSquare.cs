using System;

namespace Task33
{
    //Implement a function, called magic_square(matrix) that checks if the given array of arrays matrix is a magic square.
    //A magic square is a square matrix, where the numbers in each row, and in each column, and the numbers in the forward and backward main diagonals, all add up to the same number.
    class Problem33MagicSquare
    {
        public static bool magic_square(int[,] matrix)
        {
            int sum = 0;
            int currentSum = 0;
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                currentSum = 0;
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    currentSum += matrix[row, col];
                }
                if ((sum==0) && (sum<=currentSum))
                {
                    sum = currentSum;
                }
                if (sum != currentSum)
                {
                    return false;
                }
            }
            currentSum = 0;
            for (int diagLeft = 0; diagLeft < matrix.GetLength(1); diagLeft++)
            {
                currentSum += matrix[diagLeft, diagLeft];
            }
            if (sum != currentSum)
            {
                return false;
            }
            currentSum = 0;
            for (int diagRight = 0; diagRight < matrix.GetLength(1); diagRight++)
            {
                currentSum += matrix[diagRight, diagRight];
            }
            if (sum != currentSum)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] array1 = {{1,2,3}, {4,5,6}, {7,8,9}};
            int[,] array2 = {{4,9,2}, {3,5,7}, {8,1,6}};
            int[,] array3 = {{7,12,1,14}, {2,13,8,11}, {16,3,10,5}, {9,6,15,4}};
            int[,] array4 = {{23, 28, 21}, {22, 24, 26}, {27, 20, 25}};
            int[,] array5 = {{16, 23, 17}, {78, 32, 21}, {17, 16, 15}};

            Console.WriteLine(magic_square(array1));
            Console.WriteLine(magic_square(array2));
            Console.WriteLine(magic_square(array3));
            Console.WriteLine(magic_square(array4));
            Console.WriteLine(magic_square(array5));
        }
    }
}
