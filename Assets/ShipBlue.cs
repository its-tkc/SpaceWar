using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBlue : MonoBehaviour
{
    Animator anim;
    SpriteRenderer rend;
    //[SerializeField] GameObject fireball;
    private int health = 100;
    float attacktime;
    public float attackRate = 3;
   
    void Start()
    {
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
        }

       /* if(Time.time >= attacktime)
        {
            Instantiate(fireball , new Vector3(transform.position.x + 1f, transform.position.y - 1.5f, transform.position.z), Quaternion.identity);
            attacktime = Time.time + 1f / attackRate;
        }*/

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "laser")
        {
            health -= 3;
            //rend.color = new Color("red");
            
        }
    }
}
