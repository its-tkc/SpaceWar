using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour
{
    public float speed, height;
    public bool tig;
    [SerializeField] GameObject bg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed* Time.deltaTime, 0);
        if (tig)
        {
            Instantiate(bg, new Vector3(0, height, 0), Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "BGCR")
        {
            tig = true;
        }
    }
}
