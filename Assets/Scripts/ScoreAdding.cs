using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdding : MonoBehaviour
{
    
    public AudioSource pointSound;

    public void OnTriggerEnter2D(Collider2D collision) 
    {
        Difficulty.score += 1;
        pointSound.Play();
    }
}
