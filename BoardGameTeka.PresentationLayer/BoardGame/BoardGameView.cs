using System.Drawing;

namespace BoardGameTeka.PresentationLayer.BoardGame
{
    public class BoardGameView
    {
        public int BoardGameId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string PlayingTime { get; set; }
        public string Players { get; set; }
        public string Rating { get; set; }
        public string Complexity { get; set; }
        public int ReleaseYear { get; set; }
        public int AvailableCopies { get; set; }
    }
}
