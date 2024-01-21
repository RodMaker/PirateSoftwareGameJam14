using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Scene1EN");
    }

    public void Jogar()
    {
        SceneManager.LoadScene("Scene1PT");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
