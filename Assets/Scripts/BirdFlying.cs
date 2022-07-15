using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlying : MonoBehaviour
{

    public float velocity = 1;
    public GameManager gm;
    public AudioSource jumpSound;
    public AudioSource deathSound;
    [SerializeField] private Rigidbody2D rb = null;
    [SerializeField] private Animator anim = null;

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space)){ 
            rb.velocity = Vector2.up * velocity;
            anim.SetTrigger("Pressing Space");
            jumpSound.Play();
        }

        if(Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began) {
                rb.velocity = Vector2.up * velocity;
                anim.SetTrigger("Pressing Space");
                jumpSound.Play();
            }
        }


        transform.eulerAngles = new Vector3 (0, 0, rb.velocity.y * 15f);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        deathSound.Play();
        gm.GameOver();
    }



}
