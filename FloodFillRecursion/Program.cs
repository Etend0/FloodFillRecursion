/*
 * Elijah Hodge
 * CST - 250
 * 07/12/2026
 * Flood Fill Recursion
 * Activity 3
*/

using FloodFillRecursion.Models;

//--------------------------------------------------------
// Start of the Main Method
//--------------------------------------------------------

// Declare and initialize
// Create a new BoardModel
BoardModel board = new BoardModel(20, 20);

// Print the board to the console
Utility.PrintBoard(board);

//--------------------------------------------------------
// End of the Main Method
//--------------------------------------------------------

//--------------------------------------------------------
// Define a Utility Class
//--------------------------------------------------------

static class Utility
{
    /// <summary>
    /// Print the board to the console
    /// </summary>
    /// <param name="board"></param>
    internal static void PrintBoard(BoardModel board)
    {
        // Make sure the color of the column numbers is white
        Console.ForegroundColor = ConsoleColor.White;
        // Start the column numbers row with a spcae to keep the nunbers aligned
        Console.Write(" ");
        // Loop to add column numbers for the board
        for (int colNum = 0; colNum < board.Size; colNum++)
        {
            // Print the colNum with a 2-character width
            Console.Write($" {colNum + 1,2}");
        }
        Console.WriteLine();

        // Loop through the rows of the board
        for (int row = 0; row < board.Size; row++)
        {
            // Print each row number in white
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{row + 1,2}");

            // Loop through the columns of the board
            for (int col = 0; col < board.Size; col++)
            {
                // Check if the current cell is a wall
                if (board.Grid[row, col].Contents == "W")
                {
                    // Change the text color to red
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" W ");
                }
                else if (board.Grid[row, col].Contents == "E")
                {
                    // Change the text color to white
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" . ");
                }
                else
                {
                    Console.Write("   ");
                }
            }
            // Use a WriteLine to start a new row
            Console.WriteLine();
        }
    } // End of PrintBoard Method
}