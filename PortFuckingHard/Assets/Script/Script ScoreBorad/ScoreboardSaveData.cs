using System;
using System.Collections.Generic;

namespace Humannize.Scoreboard 
{
    [Serializable]
    public class ScoreboardSaveData
    {
        public List<ScoreboardEntryData> highscores = new List<ScoreboardEntryData>();
    }
}

