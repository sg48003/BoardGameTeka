namespace BoardGameTeka.BaseLib.IView
{
    public interface IAddNewBoardGameView
    {
        bool ShowViewModal();

        string BoardGameName { get; }
        int MinPlayers { get;}
        int MaxPlayers { get; }
        int PlayingTimeInMinutes { get; }
        decimal Rating { get; }
        decimal Complexity { get; }
        int AvailableCopies { get; }
        int ReleaseYear { get; }
        string GameType { get; }
    }
}
