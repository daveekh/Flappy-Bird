using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{

    public static int score = 0;
    public Text scoreText;
    public Text scoreTextGameOver;


    void Start()
    {
        score = 0;        // 0 - default
    }

    void Update()
    {
        scoreText.text = score.ToString();
        scoreTextGameOver.text = score.ToString();
        //Debug.Log("Score: " + score);
    }
}
