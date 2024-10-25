using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{

    public GameObject spike;
    public float spawnRate = 4;
    private float timer = 0;



    void Start()
    {

        SpawnSpike();
        
    }

    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnSpike();
            timer = 0;
        }





    }

    void SpawnSpike()
    {
        Instantiate(spike, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
