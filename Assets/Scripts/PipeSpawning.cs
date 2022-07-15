using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawning : MonoBehaviour
{

    public float maxTime = 1.5f;
    private float timer = 0;
    public GameObject normalPipes;
    public GameObject tightPipes;
    public GameObject slowlyMovingNormalPipes;
    public GameObject slowlyMovingTightPipes;
    public GameObject movingNormalPipes;
    public GameObject movingTightPipes;
    public GameObject piranhaPipes;
    public GameObject movingPiranhaPipes;
    public float height;
    public float destroyTime = 4;
    public float accOverSec = 0.05f;
    public float accEndGame = 0.005f;

    //public float getUpDownSpeed;
    //public float getMovingSpeed;

    private int diff1 = 10;           // 10             tight 
    private int diff2 = 25;           // 25             slowly normal 
    private int diff3 = 40;           // 40             slowly tight
    private int diff4 = 55;           // 55             fast normal
    private int diff5 = 75;           // 75             fast tight
    private int diff6 = 100;          // 100            piranha
    private int diff7 = 150;          // 150            fast piranha
    private int diff8 = 200;          // 200            fast piranha


    public void SpawnPipe(GameObject pipe) {
        if (timer > maxTime) 
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, destroyTime);
            timer = 0;
        }

        timer += Time.deltaTime;

    }

    void Update()
    {
        if(Difficulty.score < diff1) { 
            SpawnPipe(normalPipes); 
            PipeMoving.movingSpeed = 0.6f;
        }

        if(Difficulty.score >= diff1 && Difficulty.score < diff2) { 
            SpawnPipe(tightPipes); 
            PipeMoving.movingSpeed = 0.6f;
        }
        
        if(Difficulty.score >= diff2 && Difficulty.score < diff3) { 
            SpawnPipe(slowlyMovingNormalPipes); 
            PipeMoving.movingSpeed = 0.6f;
            PipeMovingUpDown.upDownSpeed = 0.3f;
        }

        if(Difficulty.score >= diff3 && Difficulty.score < diff4) {
            SpawnPipe(slowlyMovingTightPipes); 
            PipeMoving.movingSpeed = 0.6f;
            PipeMovingUpDown.upDownSpeed = 0.3f;
        }

        if(Difficulty.score >= diff4 && Difficulty.score < diff5) { 
            SpawnPipe(movingNormalPipes); 

            if (PipeMoving.movingSpeed < 0.8f) {
                PipeMoving.movingSpeed += accOverSec * Time.deltaTime;
            }
            else{
                PipeMoving.movingSpeed = 0.8f;
            }


            if (PipeMovingUpDown.upDownSpeed < 0.6f) {
                PipeMovingUpDown.upDownSpeed += accOverSec * Time.deltaTime;
            }
            else{
                PipeMovingUpDown.upDownSpeed = 0.6f;
            }

            if (maxTime > 1.25f) {
                maxTime -= accOverSec * Time.deltaTime;
            }
            else {
                maxTime = 1.25f;
            }
            
        }

        if(Difficulty.score >= diff5 && Difficulty.score < diff6) {               
            SpawnPipe(movingTightPipes);                                       
            PipeMoving.movingSpeed = 0.8f;
            PipeMovingUpDown.upDownSpeed = 0.6f;
            maxTime = 1.25f;
        }

        if(Difficulty.score >= diff6 && Difficulty.score < diff7)  {                   
            SpawnPipe(piranhaPipes);                                           
            PipeMoving.movingSpeed = 0.8f;
            PipeMovingUpDown.upDownSpeed = 0.6f;
            maxTime = 1.25f;
            }
        
        if(Difficulty.score >= diff7 && Difficulty.score < diff8) {                
            SpawnPipe(movingPiranhaPipes);                                   
            PipeMoving.movingSpeed = 0.8f;
            PipeMovingUpDown.upDownSpeed = 0.6f;
            maxTime = 1.25f; 
            }     


        if(Difficulty.score >= diff8) {                                          
            SpawnPipe(movingPiranhaPipes);                                     

            if (PipeMoving.movingSpeed < 3.0f) {
                PipeMoving.movingSpeed += accEndGame * Time.deltaTime;
            }
            else{
                PipeMoving.movingSpeed = 3.0f;
            }

            if (maxTime > 0.25f) {
                maxTime -= accEndGame * Time.deltaTime;
            }
            else {
                maxTime = 0.25f;
            }
        }

    }
}
