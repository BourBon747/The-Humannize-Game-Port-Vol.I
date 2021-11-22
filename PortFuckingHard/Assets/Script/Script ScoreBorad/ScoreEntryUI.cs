using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


namespace Humannize.Scoreboard 
{
    public class ScoreEntryUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI entryNameText = null;
        [SerializeField] private TextMeshProUGUI entryScoreText = null;

        public void Initialise(ScoreboardEntryData scoreboradEntryData) 
        {
            entryNameText.text = scoreboradEntryData.entryName;
            entryScoreText.text = scoreboradEntryData.entryScore.ToString();
        }
    }
}

