using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayEasy()
    {
        SceneManager.LoadScene("Scene1ENEasy");
    }

    public void PlayMedium()
    {
        SceneManager.LoadScene("Scene1ENMedium");
    }

    public void PlayHard()
    {
        SceneManager.LoadScene("Scene1ENHard");
    }

    public void JogarF�cil()
    {
        SceneManager.LoadScene("Scene1PTEasy");
    }

    public void JogarM�dio()
    {
        SceneManager.LoadScene("Scene1PTMedium");
    }

    public void JogarDif�cil()
    {
        SceneManager.LoadScene("Scene1PTHard");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
