using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject gameOverUI;
    private GameObject playerObj;
    [SerializeField] private GameObject heartContainer, staminaContainer, goldCoinContainer, activeInventory;
    private bool firstTime = true;

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        heartContainer.SetActive(false);
        staminaContainer.SetActive(false);
        goldCoinContainer.SetActive(false);
        activeInventory.SetActive(false);
        Debug.Log("Game Over");
    }

    public void Restart()
    {
        firstTime = false;
        gameOverUI.SetActive(false);
        heartContainer.SetActive(true);
        staminaContainer.SetActive(true);
        goldCoinContainer.SetActive(true);
        activeInventory.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Scene1");
        playerObj.SetActive(true);
        playerObj.transform.position = Vector2.zero;
        playerObj.GetComponent<PlayerController>().StartPlayer();
    }

    public void MainMenu()
    {
        firstTime = false;
        gameOverUI.SetActive(false);
        SceneManager.LoadScene("Main Menu");
        playerObj.GetComponent<PlayerController>().StartPlayer();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OnEnable()
    {
        PlayerController.OnStart += GetPlayer;
        SceneManager.sceneLoaded += SetPlayer;    
    }

    public void OnDestroy() => PlayerController.OnStart -= GetPlayer;

    private void GetPlayer(GameObject player) => playerObj = player;
    private void SetPlayer(Scene scene, LoadSceneMode mode)
    {
        if (!firstTime && scene.buildIndex == 1)
        {
            playerObj.SetActive(true);
            heartContainer.SetActive(true);
            staminaContainer.SetActive(true);
            goldCoinContainer.SetActive(true);
            activeInventory.SetActive(true);
        }
    }
}
