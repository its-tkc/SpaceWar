using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    float attacktime;
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
        if (Time.time >= attacktime)
        {
            spawnprojectile(numberofprojectiles);
            attacktime = Time.time + 1f / attackRate;
        }
        
    }

    void spawnprojectile(int numberofprojectilesrof)
    {
        float angleStep = 360f / numberofprojectiles;
        float angle = 0f;

        for (int i = 0; i <= numberofprojectiles - 1; i++)
        {
            float DirX =  Mathf.Sin((angle * Mathf.PI) / 180) * radius;
            float DirY =  Mathf.Cos((angle * Mathf.PI) / 180) * radius;


            Vector2 vec = new Vector2(DirX, DirY);
            Vector2 vecDir = (vec - startpoint).normalized * moveSpeed;

            var proj = Instantiate(projectile, transform.position, Quaternion.identity);
            proj.GetComponent<Rigidbody2D>().velocity = new Vector2(vecDir.x, vecDir.y);

            angle += angleStep;

        }
    }

}
