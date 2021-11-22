using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenuScript : MonoBehaviour
{
    public void PlayGameScene01()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void PlayGameScene02()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    
    public void PlayGameScene03()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void ScoreBoardScene() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
}
