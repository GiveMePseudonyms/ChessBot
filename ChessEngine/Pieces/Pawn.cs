namespace ChessEngine
{
    public class Pawn : Piece
    {
        public override PieceType Type => PieceType.Pawn;
        public override Player Colour { get; }
        public Pawn(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            return new Pawn(Colour) { HasMoved = HasMoved };
        }
    }
}
