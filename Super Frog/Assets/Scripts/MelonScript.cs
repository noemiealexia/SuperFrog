using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonScript : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Health.currentHealth += 20;

            Destroy(gameObject);

        }
    }


}
