namespace ChessEngine
{
    public class Rook : Piece
    {
        public override PieceType Type => PieceType.Rook;
        public override Player Colour { get; }

        public Rook(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            return new Rook(Colour) { HasMoved = this.HasMoved };
        }
    }
}