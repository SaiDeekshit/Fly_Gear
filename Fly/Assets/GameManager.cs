using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameTitle,gameOverCanvas,replayCanvas;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    public void Start()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        gameTitle.SetActive(true);
        gameOverCanvas.SetActive(true);
        replayCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
