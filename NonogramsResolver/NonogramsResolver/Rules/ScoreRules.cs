using System;
using System.Linq;

namespace NonogramsResolver.Rules
{
    public class ScoreRules
    {
        readonly Nonogram nonogram;
        int score;

        public ScoreRules(Nonogram nonogram)
        {
            this.nonogram = nonogram;
            score = nonogram.CELLS_TO_PAINT_IN_COLUMN.ToList().Sum(x => x) 
                    + nonogram.CELLS_TO_PAINT_IN_ROW.ToList().Sum(x => x);
        }

        public int Score()
        {
            for(int i = 0; i < nonogram.NUMBER_OF_ROWS; i++)
            {
                score -= ScoreRow(i);
            }
            for (int i = 0; i < nonogram.NUMBER_OF_COLUMNS; i++)
            {
                score -= scoreColumn(i);
            }
            return score;
        }

        int ScoreRow(int rowNumber)
        {
            int dif = nonogram.CELLS_TO_PAINT_IN_ROW[rowNumber] - nonogram.PaintedCellsInRow(rowNumber);
            return Math.Abs(dif);

        }
        int scoreColumn(int columnNumber)
        {
            int dif = nonogram.CELLS_TO_PAINT_IN_COLUMN[columnNumber] - nonogram.PaintedCellsInColumn(columnNumber);
            return Math.Abs(dif);
        }
    }
}
