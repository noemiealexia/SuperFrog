using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{

    public int deadZone = -10;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Health.currentHealth -= 20;

            Destroy(gameObject);

        }
    }

    void Update()
    {
        if (transform.position.y < deadZone)
        {
            Destroy(gameObject);
        }

    }
}
