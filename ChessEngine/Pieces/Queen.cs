namespace ChessEngine
{
    public class Queen : Piece
    {
        public override PieceType Type => PieceType.Queen;
        public override Player Colour { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.North,
            Direction.South,
            Direction.East,
            Direction.West,
            Direction.NorthEast,
            Direction.SouthEast,
            Direction.NorthWest,
            Direction.SouthWest,
        };

        public Queen(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            return new Queen(Colour) { HasMoved = this.HasMoved };
        }
        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMove(from, to));
        }
    }
}