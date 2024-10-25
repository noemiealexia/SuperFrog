using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverUI;


    private void Start()
    {
            gameOverUI.SetActive(false);
    }

    public void GameOver()
    {

        gameOverUI.SetActive(true);
        PlayerController.speed = 0;

    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
