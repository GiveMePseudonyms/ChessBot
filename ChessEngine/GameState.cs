namespace ChessEngine
{
    public class GameState
    {
        public Board Board { get; }
        public Player CurrentPlayer { get; private set; }
        public GameState(Player player, Board board)
        {
            CurrentPlayer = player;
            Board = board;
        }

        public IEnumerable<Move> LegalMovesforPiece(Position position)
        {
            if (Board.IsEmpty(position)|| Board[position].Colour != CurrentPlayer)
            {
                return Enumerable.Empty<Move>();
            }
            Piece piece = Board[position];
            return piece.GetMoves(position, Board);
        }

        public void MakeMove(Move move)
        {
            move.ExecuteMove(Board);
            CurrentPlayer = CurrentPlayer.GetOpponent();
        }
    }
}
