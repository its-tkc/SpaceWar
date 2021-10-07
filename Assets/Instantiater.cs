using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiater : MonoBehaviour
{
    [SerializeField] GameObject heli, ships, bossShip;
    public float timetoSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateEnemy", timetoSpawn, timetoSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiateEnemy()
    {
        Vector2 pos = new Vector2(Random.Range(-2.5f, 2.5f), Random.Range(5f, 8f));
        Instantiate(heli, pos, Quaternion.identity);
    }
}
