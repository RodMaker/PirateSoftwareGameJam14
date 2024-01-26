using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject gameOverUI;
    private GameObject playerObj;
    [SerializeField] private GameObject heartContainer, staminaContainer, goldCoinContainer, levelContainer, passiveContainer, activeInventory;
    private bool firstTime = true;
    public bool isOnMenu = false;

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        heartContainer.SetActive(false);
        staminaContainer.SetActive(false);
        goldCoinContainer.SetActive(false);
        levelContainer.SetActive(false);
        passiveContainer.SetActive(false);
        activeInventory.SetActive(false);
        Debug.Log("Game Over");
    }

    public void RestartEasy()
    {
        firstTime = false;
        gameOverUI.SetActive(false);
        heartContainer.SetActive(true);
        staminaContainer.SetActive(true);
        goldCoinContainer.SetActive(true);
        levelContainer.SetActive(true);
        passiveContainer.SetActive(true);
        activeInventory.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Scene1ENEasy");
        playerObj.SetActive(true);
        playerObj.transform.position = Vector2.zero;
        playerObj.GetComponent<PlayerController>().StartPlayer();
    }

    public void RestartMedium()
    {
        firstTime = false;
        gameOverUI.SetActive(false);
        heartContainer.SetActive(true);
        staminaContainer.SetActive(true);
        goldCoinContainer.SetActive(true);
        levelContainer.SetActive(true);
        passiveContainer.SetActive(true);
        activeInventory.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Scene1ENMedium");
        playerObj.SetActive(true);
        playerObj.transform.position = Vector2.zero;
        playerObj.GetComponent<PlayerController>().StartPlayer();
    }

    public void RestartHard()
    {
        firstTime = false;
        gameOverUI.SetActive(false);
        heartContainer.SetActive(true);
        staminaContainer.SetActive(true);
        goldCoinContainer.SetActive(true);
        levelContainer.SetActive(true);
        passiveContainer.SetActive(true);
        activeInventory.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Scene1ENHard");
        playerObj.SetActive(true);
        playerObj.transform.position = Vector2.zero;
        playerObj.GetComponent<PlayerController>().StartPlayer();
    }

    public void RecomeçarFácil()
    {
        firstTime = false;
        gameOverUI.SetActive(false);
        heartContainer.SetActive(true);
        staminaContainer.SetActive(true);
        goldCoinContainer.SetActive(true);
        levelContainer.SetActive(true);
        passiveContainer.SetActive(true);
        activeInventory.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Scene1PTEasy");
        playerObj.SetActive(true);
        playerObj.transform.position = Vector2.zero;
        playerObj.GetComponent<PlayerController>().StartPlayer();
    }

    public void RecomeçarMédio()
    {
        firstTime = false;
        gameOverUI.SetActive(false);
        heartContainer.SetActive(true);
        staminaContainer.SetActive(true);
        goldCoinContainer.SetActive(true);
        levelContainer.SetActive(true);
        passiveContainer.SetActive(true);
        activeInventory.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Scene1PTMedium");
        playerObj.SetActive(true);
        playerObj.transform.position = Vector2.zero;
        playerObj.GetComponent<PlayerController>().StartPlayer();
    }

    public void RecomeçarDifícil()
    {
        firstTime = false;
        gameOverUI.SetActive(false);
        heartContainer.SetActive(true);
        staminaContainer.SetActive(true);
        goldCoinContainer.SetActive(true);
        levelContainer.SetActive(true);
        passiveContainer.SetActive(true);
        activeInventory.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Scene1PTHard");
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
        if (!firstTime && scene.buildIndex == 1 || !firstTime && scene.buildIndex == 2 || !firstTime && scene.buildIndex == 3 ||
            !firstTime && scene.buildIndex == 4 || !firstTime && scene.buildIndex == 5 || !firstTime && scene.buildIndex == 6)
        {
            playerObj.SetActive(true);
            heartContainer.SetActive(true);
            staminaContainer.SetActive(true);
            goldCoinContainer.SetActive(true);
            levelContainer.SetActive(true);
            passiveContainer.SetActive(true);
            activeInventory.SetActive(true);
        }
    }
}
