using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    
    public float speed;
    AudioSource aud;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed* Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "laser")
        {
            ScoreHandler.score += 20;
            aud.Play();
            anim.SetTrigger("blast");
            Destroy(gameObject, 0.3f);
        }
    }
}
