using BoardGameTeka.Model.Entities;

namespace BoardGameTeka.Model.Factory
{
    public class BoardGameFactory
    {
        public static BoardGame CreateBoardGame(string inName, int inMinPlayers, int inMaxPlayers, int inPlayingTime, decimal inRating, decimal inComplexity, int inAvailableCopies, int inReleaseYear, GameType inGameType)
        {
            return new BoardGame
            {
                Name =  inName,
                MinPlayers = inMinPlayers,
                MaxPlayers = inMaxPlayers,
                PlayingTimeInMinutes = inPlayingTime,
                Rating = inRating,
                Complexity = inComplexity,
                AvailableCopies = inAvailableCopies,
                ReleaseYear = inReleaseYear,
                GameType = inGameType
            };
        }
    }
}
