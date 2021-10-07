using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    private int health = 200;
    [SerializeField] GameObject bullet, panel;
    Rigidbody2D rb;
    BoxCollider2D box;
    AudioSource aud;
    Transform trans;
    Animator anim;
    public float speed, attackRate =2f;
    float nextAttackTime = 0;
    // Start is called before the first frame update
    void Start()
    {    
         rb = GetComponent<Rigidbody2D>();
         box = GetComponent<BoxCollider2D>();
         trans = GetComponent<Transform>();
         anim = GetComponent<Animator>();
         aud = GetComponent<AudioSource>();
        trans.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = touchPos;

        

        if (Time.time >= nextAttackTime)
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z), Quaternion.identity);
            nextAttackTime = Time.time + 1f / attackRate;
        }

        if(health <= 0)
        {
            anim.SetTrigger("die");
            aud.Play();
            Destroy(gameObject, 1f);
            panel.SetActive(true);
            
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            health -= 101;
        }

        if (collision.gameObject.tag == "fireball")
        {
            health -= 20;
        }

    }

}
