using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject bird;
    public GameObject startCanvas;
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    public GameObject pipeSpawner;

    void Start() {
        Time.timeScale = 1;
    }

    public void Play()
    {
        bird.SetActive(true);
        scoreCanvas.SetActive(true);
        pipeSpawner.GetComponent<PipeSpawning>().enabled = true;

        startCanvas.SetActive(false);
    }

    public void Replay() 
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver() 
    {
        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
        Time.timeScale = 0;
    }
}
