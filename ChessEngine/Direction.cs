namespace ChessEngine
{
    public class Direction
    {
        public static readonly Direction North = new Direction(-1, 0);
        public static readonly Direction South = new Direction(1, 0);
        public static readonly Direction East = new Direction(0, 1);
        public static readonly Direction West = new Direction(0, -1);
        public static readonly Direction NorthEast = North+East;
        public static readonly Direction SouthEast = South+East;
        public static readonly Direction NorthWest = North+West;
        public static readonly Direction SouthWest = South+West;


        public int RowDelta { get; }
        public int ColumnDelta { get; }

        public Direction(int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            ColumnDelta = columnDelta;
        }

        public static Direction operator +(Direction a, Direction b)
        {
            return new Direction(a.RowDelta + b.RowDelta, a.ColumnDelta + b.ColumnDelta);
        }

        public static Direction operator *(Direction a, int b)
        {
            return new Direction(a.RowDelta * a.RowDelta, a.ColumnDelta * a.ColumnDelta);
        }

        public static Direction operator *(int a, Direction b)
        {
            return new Direction(b.RowDelta * b.RowDelta, b.ColumnDelta * b.ColumnDelta);
        }

    }
}
