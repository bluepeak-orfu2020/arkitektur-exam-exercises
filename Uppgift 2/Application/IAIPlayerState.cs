namespace Application
{
    internal interface IAIPlayerState
    {
        GameBoardPosition PlayTurn();
        bool IsAlive();
        void PositionedBombed(GameBoardPosition position);
    }
}