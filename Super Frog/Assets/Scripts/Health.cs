using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{

    public int maxHealth = 100;
    static public int currentHealth;

    public TextMeshProUGUI healthText;

    private bool stop = false;

    public GameManager gameManager;

    void Start()
    {

        currentHealth = maxHealth;
        StartCoroutine(TakeDamageEverySecond());
        
    }


    void Update()
    {

        if (currentHealth <= 0)
        {
            gameManager.GameOver();
        }

        if (currentHealth > 100)
        {
            currentHealth = 100;
        }


        if (currentHealth >= 0)
        {
            healthText.text = currentHealth.ToString();
        }
        else
        {
            healthText.text = "0";
        }

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
