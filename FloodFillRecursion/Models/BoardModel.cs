using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elijah Hodge
 * CST - 250
 * 07/12/2026
 * Flood Fill Recursion
 * Activity 3
*/

namespace FloodFillRecursion.Models
{
    internal class BoardModel
    {
        // BoardModel Properties
        public int Size { get; set; }
        public CellModel[,] Grid { get; set; }
        public int NumShapes { get; set; }

        /// <summary>
        /// Parameterized constructor for BoardModel
        /// </summary>
        /// <param name="size"></param>
        public BoardModel(int size, int numShapes)
        {
            Size = size;
            NumShapes = numShapes;
            Grid = new CellModel[Size, Size];
            // Set up the grid
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    Grid[row, col] = new CellModel(row, col, "E");
                }
            }
            // Place random shapes on the board
            PlaceShapes();
        }

        /// <summary>
        /// Create shapes to place on the board
        /// </summary>
        public void PlaceShapes()
        {
            // Declare and initialze
            // Random object to generate numbers
            Random random = new Random();
            int shapeSize = Size / 2, row = 0, col = 0;

            // Create three shapes
            for (int shapes = 0; shapes < NumShapes; shapes++)
            {
                // Generate the row and col for the
                // top left corner of the triangle
                row = random.Next(0, Size - shapeSize + 1);
                col = random.Next(0, Size - shapeSize + 1);

                for (int i = 0; i < shapeSize; i++)
                {
                    // Calculate the left and right edges of the triangle at this row
                    int leftCol = col + (shapeSize - 1 - i) / 2;
                    int rightCol = col + shapeSize - 1 - (shapeSize - 1 - i) / 2;

                    // Left edge wall
                    Grid[row + i, leftCol].Contents = "W";
                    // Right edge wall
                    Grid[row + i, rightCol].Contents = "W";

                    // Close diagonal gaps so flood fill doesn't enter the triangle
                    if (i < shapeSize - 1)
                    {
                        int nextLeftCol = col + (shapeSize - 1 - (i + 1)) / 2;
                        int nextRightCol = col + shapeSize - 1 - (shapeSize - 1 - (i + 1)) / 2;

                        // Add extra wall to close the diagonal gap
                        if (nextLeftCol != leftCol)
                        {
                            Grid[row + i, nextLeftCol].Contents = "W";
                        }
                        // Add extra wall to close the diagonal gap
                        if (nextRightCol != rightCol)
                        {
                            Grid[row + i, nextRightCol].Contents = "W";
                        }
                    }

                    // Bottom row, fill in the entire row with walls to make the bottom of the triangle
                    if (i == shapeSize - 1)
                    {
                        for (int c = leftCol; c <= rightCol; c++)
                        {
                            Grid[row + i, c].Contents = "W";
                        }
                    }
                }
            }

        } // End of PlaceShapes method
    }
}
