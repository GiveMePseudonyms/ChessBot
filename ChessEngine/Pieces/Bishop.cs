namespace ChessEngine
{
    public class Bishop : Piece
    {
        public override PieceType Type => PieceType.Bishop;
        public override Player Colour { get; }

        public Bishop(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            return new Bishop(Colour) { HasMoved = this.HasMoved};
        }
    }
}
