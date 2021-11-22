using UnityEngine;
using System.IO;


namespace Humannize.Scoreboard 
{
    public class Scoreboard : MonoBehaviour
    {
        [SerializeField] private int maxScoreboardEntries = 5;
        [SerializeField] private Transform highscoreHolderTransform = null;
        [SerializeField] private GameObject scoreboardEntryObject = null;

        [Header("TEST")]
        [SerializeField] ScoreboardEntryData testEntrydata = new ScoreboardEntryData();

        private string SavePath => $"{Application.persistentDataPath}/highscore.json";

        private void Start()
        {
            ScoreboardSaveData saveScores = GetSavedScores();

            UpdateUI(saveScores);

            SaveScores(saveScores);
        }

        [ContextMenu(" Add Test Entry ")]
        public void AddTestEntry() 
        {
            AddEntry(testEntrydata);
        }

        

        public void AddEntry(ScoreboardEntryData scoreboardEntryData) 
        {
            ScoreboardSaveData savedScores = GetSavedScores();

            bool scoreAdded = false;

            for (int i = 0; i < savedScores.highscores.Count; i++)
            {
                if (scoreboardEntryData.entryScore > savedScores.highscores[i].entryScore)
                {
                    savedScores.highscores.Insert(i, scoreboardEntryData);
                    scoreAdded = true;
                    break;
                }
            }

            if (!scoreAdded && savedScores.highscores.Count < maxScoreboardEntries)
            {
                savedScores.highscores.Add(scoreboardEntryData);
            }

            if (savedScores.highscores.Count > maxScoreboardEntries)
            {
                savedScores.highscores.RemoveRange(maxScoreboardEntries,
                    savedScores.highscores.Count - maxScoreboardEntries);
            }

            UpdateUI(savedScores);
            
            SaveScores(savedScores);
        }

        private void UpdateUI(ScoreboardSaveData savedScores) 
        {
            foreach (Transform child in highscoreHolderTransform)
            {
                Destroy(child.gameObject);
            }
            foreach (ScoreboardEntryData highscore in savedScores.highscores)
            {
                Instantiate(scoreboardEntryObject, highscoreHolderTransform).
                    GetComponent<ScoreEntryUI>().Initialise(highscore);
            }
        }

        private ScoreboardSaveData GetSavedScores() 
        {
            if (!File.Exists(SavePath))
            {
                File.Create(SavePath).Dispose();
                return new ScoreboardSaveData();
            }

            using (StreamReader stream = new StreamReader(SavePath)) 
            {
                string json = stream.ReadToEnd();

                return JsonUtility.FromJson<ScoreboardSaveData>(json);
            }
        }


        private void SaveScores(ScoreboardSaveData scoreboardSaveData) 
        {
            using (StreamWriter stream = new StreamWriter(SavePath)) 
            {
                string json = JsonUtility.ToJson(scoreboardSaveData, true);
                
                stream.Write(json);
            }
        }
    }
}

