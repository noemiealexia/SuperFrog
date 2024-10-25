using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxyBox : MonoBehaviour
{

    private bool stop = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Oxygen();

        }
    }

    public IEnumerator Oxygen()
    {
        while (stop == false)
        {
            yield return new WaitForSeconds(1F);
            Health.currentHealth += 10;
        }
    }
}
