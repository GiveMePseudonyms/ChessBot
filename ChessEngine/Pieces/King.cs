namespace ChessEngine
{
    public class King : Piece
    {
        public override PieceType Type => PieceType.King;
        public override Player Colour { get; }

        public King(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            return new King(Colour) { HasMoved = this.HasMoved };
        }
    }
}