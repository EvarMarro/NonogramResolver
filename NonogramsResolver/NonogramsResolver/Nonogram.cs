namespace NonogramsResolver
{
    public class Nonogram
    {
        public readonly int NUMBER_OF_ROWS;
        public readonly int NUMBER_OF_COLUMNS;
        bool[,] grid;
        public short[] CELLS_TO_PAINT_IN_ROW;
        public short[] CELLS_TO_PAINT_IN_COLUMN; 
        public Nonogram(int numberOfRows ,int numberOfColumns, short[] cellsToPaintInRow, short[] cellstoPaintInColumn)
        {
            NUMBER_OF_ROWS = numberOfRows;
            NUMBER_OF_COLUMNS = numberOfColumns;
            CELLS_TO_PAINT_IN_ROW = cellstoPaintInColumn;
            CELLS_TO_PAINT_IN_COLUMN = cellstoPaintInColumn;
            grid = new bool[numberOfRows, numberOfColumns];
        }

        public int PaintedCellsInRow(int rowNumber)
        {
            var paintedCells = 0;
            for(int i = 0;i < NUMBER_OF_COLUMNS; i++)
            {
                if(grid[rowNumber, i])
                {
                    paintedCells++;
                }
            }
            return paintedCells;
        }
        public int PaintedCellsInColumn(int columnNumber)
        {
            var paintedCells = 0;
            for (int i = 0; i < NUMBER_OF_ROWS; i++)
            {
                if (grid[i, columnNumber])
                {
                    paintedCells++;
                }
            }
            return paintedCells;
        }        

    }
}
