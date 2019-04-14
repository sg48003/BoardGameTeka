using System.Collections.Generic;

namespace BoardGameTeka.Model.Enums_Dictionaries
{
    public static class GameTypeList
    {
        public enum GameTypeEnum
        {
            CardGame = 1,
            StoryTelling = 2,
            DiceRolling = 3,
            PartyGame = 4,
            SetCollection = 5,
            RolePlaying = 6,
            WorkerPlacement = 7,
            AreaControl = 8,
            Deckbuilding = 9,
            TilePlacement = 10,
            PatternRecognition = 11
        }

        public static Dictionary<GameTypeEnum, string> GameTypeDictionary = new Dictionary<GameTypeEnum, string>
        {
            { GameTypeEnum.CardGame, "Card game"},
            { GameTypeEnum.StoryTelling, "Story telling"},
            { GameTypeEnum.DiceRolling, "Dice rolling"},
            { GameTypeEnum.PartyGame, "Party game"},
            { GameTypeEnum.SetCollection, "Set collection"},
            { GameTypeEnum.RolePlaying, "Role playing"},
            { GameTypeEnum.WorkerPlacement, "Worker placement"},
            { GameTypeEnum.AreaControl, "Area control"},
            { GameTypeEnum.Deckbuilding, "Deckbuilding"},
            { GameTypeEnum.TilePlacement, "Tile placement"},
            { GameTypeEnum.PatternRecognition, "Pattern recognition"},

        };
    }

}

