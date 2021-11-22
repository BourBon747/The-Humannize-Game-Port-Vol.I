using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreboardBackButton : MonoBehaviour
{
    public void BackToMenu()
    {
        Debug.Log("Loading menu. . .");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }
}
