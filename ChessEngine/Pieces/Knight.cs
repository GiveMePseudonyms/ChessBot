namespace ChessEngine
{
    public class Knight : Piece
    {
        public override PieceType Type => PieceType.Knight;
        public override Player Colour { get; }

        public Knight(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            return new Knight(Colour) { HasMoved = this.HasMoved };
        }
    }
}