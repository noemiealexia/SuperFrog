using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public TextMeshProUGUI healthText;

    private bool stop = false;

    void Start()
    {

        currentHealth = maxHealth;
        StartCoroutine(TakeDamageEverySecond());
        
    }


    void Update()
    {

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(1);
        }

        healthText.text = currentHealth.ToString();

    }

    public IEnumerator TakeDamageEverySecond()
    {
        while (stop == false)
        {
            yield return new WaitForSeconds(1F);
            currentHealth -= 1;
        }
    }
}
