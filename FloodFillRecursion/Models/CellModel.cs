/*
 * Elijah Hodge
 * CST - 250
 * 07/12/2026
 * Flood Fill Recursion
 * Activity 3
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FloodFillRecursion.Models
{
    internal class CellModel
    {
        // Cell Model Properties
        public int Row { get; set; }
        public int Column { get; set; }
        public string Contents { get; set; }

        /// <summary>
        /// Parameterized constructor for CellModel
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="contents"></param>
        public CellModel(int row, int column, string contents)
        {
            Row = row;
            Column = column;
            Contents = contents;
        }
    }
}