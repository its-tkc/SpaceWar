using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    /* float attacktime;
     public float attackRate = 2f;
     [SerializeField] int numberofprojectiles;

     [SerializeField] GameObject projectile;
     Vector2 startpoint;
     float radius, moveSpeed;
     private void Start()
     {
         radius = 5f;
         moveSpeed = 5f;

     }
     private void Update()
     {
         spawnprojectile(numberofprojectiles);
         attacktime = Time.time + 1f / attackRate;
     }

     void spawnprojectile(int numberofprojectilesrof)
     {
         float angleStep = 360f / numberofprojectiles;
         float angle = 0f;

         for (int i = 0; i <= numberofprojectiles -1; i++)
         {
             float DirX = startpoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
             float DirY = startpoint.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;


             Vector2 vec = new Vector2(DirX, DirY);
             Vector2 vecDir = (vec - startpoint).normalized * moveSpeed;

             var proj = Instantiate(projectile, startpoint, Quaternion.identity);
             proj.GetComponent<Rigidbody2D>().velocity = new Vector2(vecDir.x, vecDir.y);

             angle += angleStep;

         }
     }





     public float speed;
     //int rand;
     //Rigidbody2D rb;
     // Start is called before the first frame update
     void Start()
     {
         //rand = Random.Range(1, 4);
         Destroy(gameObject, 3f);
         //rb = GetComponent<Rigidbody2D>();
     }

     // Update is called once per frame
     void Update()
     {

         transform.position += new Vector3(0, -speed * Time.deltaTime, 0);

     }*/

    private void Start()
    {
        Destroy(gameObject, 0.5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "laser")
        {
            Destroy(gameObject);
        }
    }

}
