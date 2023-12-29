namespace ChessEngine
{
    public abstract class Piece
    {
        public abstract PieceType Type { get; }
        public abstract Player Colour { get; }
        public bool HasMoved { get; set; }

        public abstract Piece Copy();
    }
}
