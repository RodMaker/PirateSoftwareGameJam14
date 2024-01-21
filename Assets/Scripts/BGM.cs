using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM : MonoBehaviour
{
    public static BGM Instance;

    [SerializeField] AudioSource audioSource;

    public AudioClip background1;
    public AudioClip background2;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Start()
    {
        audioSource.Play();
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Main Menu")
        {
            //audioSource.Pause();
            Destroy(gameObject);
        }

        /* If I want to change songs
        if (SceneManager.GetActiveScene().name == "Scene1")
        {
            audioSource.Pause();
            audioSource.clip = background1;
            audioSource.Play();
        }
        

        if (SceneManager.GetActiveScene().name == "Scene2")
        {
            audioSource.Pause();
            audioSource.clip = background2;
            audioSource.Play();
        }
        */
    }

    public void PauseMusic()
    { 
        audioSource.Pause();
        Destroy(gameObject);
    }
}
