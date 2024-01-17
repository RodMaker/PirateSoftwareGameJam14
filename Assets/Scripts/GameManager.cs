using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject gameOverUI;
    private GameObject playerObj;

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        Debug.Log("Game Over");
    }

    public void Restart()
    {
        gameOverUI.SetActive(false);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Scene1");
        playerObj.SetActive(true);
        playerObj.GetComponent<PlayerController>().StartPlayer();
    }

    public void MainMenu()
    {
        gameOverUI.SetActive(false);
        SceneManager.LoadScene("Main Menu");
        playerObj.SetActive(true);
        playerObj.GetComponent<PlayerController>().StartPlayer();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OnEnable() => PlayerController.OnStart += SetPlayer;

    public void OnDestroy() => PlayerController.OnStart -= SetPlayer;

    private void SetPlayer(GameObject player) => playerObj = player;
}
