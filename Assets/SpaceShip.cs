using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    private int health = 200;
    [SerializeField] GameObject bullet;
    Rigidbody2D rb;
    BoxCollider2D box;
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
    }

    // Update is called once per frame
    void Update()
    {
        if(moveRight.moveRyt == true)
        {
            trans.position += new Vector3(speed*Time.deltaTime, 0, 0);
        }

        if (MoveLeft.moveLft == true)
        {
            trans.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

        if (moveUp.moveUP == true)
        {
            trans.position += new Vector3(0, speed * Time.deltaTime, 0);
        }

        if (moveDown.moveDOWN == true)
        {
            trans.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }

        if (Time.time >= nextAttackTime)
        {
            if (shootBtn.shoot == true)
            {
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z), Quaternion.identity);
            }
            nextAttackTime = Time.time + 1f / attackRate;
        }

        if(health <= 0)
        {
            anim.SetTrigger("die");
            Destroy(gameObject, 2f);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            health -= 15;
        }

        if (collision.gameObject.tag == "fireball")
        {
            health -= 20;
        }

    }

}
