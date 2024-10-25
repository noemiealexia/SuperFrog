using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// help from this tutorial: https://www.youtube.com/watch?v=N8whM1GjH4w

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

    public AudioClip background;


    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }


}
