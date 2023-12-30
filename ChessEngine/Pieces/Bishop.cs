namespace ChessEngine
{
    public class Bishop : Piece
    {
        public override PieceType Type => PieceType.Bishop;
        public override Player Colour { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.NorthWest,
            Direction.NorthEast,
            Direction.SouthWest,
            Direction.SouthEast
        };

        public Bishop(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            return new Bishop(Colour) { HasMoved = this.HasMoved};
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMove(from,to));
        }
    }
}
