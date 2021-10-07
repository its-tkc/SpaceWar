using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBlue : MonoBehaviour
{
    Animator anim;
    SpriteRenderer rend;
    private int health = 100;
    public float attackRate = 3;
    AudioSource aud;
   
    void Start()
    {
        aud = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            anim.SetTrigger("blast");
            Destroy(gameObject, 1f);
            ScoreHandler.score += 20;
            aud.Play();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "laser")
        {
            health -= 3;
           
        }
    }
}
