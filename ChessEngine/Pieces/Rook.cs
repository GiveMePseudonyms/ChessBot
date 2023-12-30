namespace ChessEngine
{
    public class Rook : Piece
    {
        public override PieceType Type => PieceType.Rook;
        public override Player Colour { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.North,
            Direction.South,
            Direction.East,
            Direction.West,
        };

        public Rook(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            return new Rook(Colour) { HasMoved = this.HasMoved };
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMove(from, to));
        }
    }
}