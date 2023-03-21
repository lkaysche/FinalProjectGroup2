using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private int gameState;
    private int previousGameState;
    public static GameController instance;
    public int score = 0;
    public GameObject gameHud;
    public GameObject title;
    public GameObject endUI;
    public GameObject winUI;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (!GameController.instance)
        {
            GameController.instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState == 0)
        {
            if (previousGameState != 0)
            {
                gameHud.SetActive(false);
                endUI.SetActive(false);
                winUI.SetActive(false);
                title.SetActive(true);
                previousGameState = 0;
            }
        }
        else if (gameState == 1)
        {
            if (previousGameState != 1)
            {
                title.SetActive(false);
                gameHud.SetActive(true);
                previousGameState = 1;
            }
        }
        else if (gameState == -1)
        {
            if (previousGameState != -1)
            {
                gameHud.SetActive(false);
                endUI.SetActive(true);
                previousGameState = -1;
            }
        }
        else if (gameState == -2)
        {
            if (previousGameState != -2)
            {
                gameHud.SetActive(false);
                winUI.SetActive(true);
                previousGameState = -1;
            }
        }
        else
        {
            Debug.Log("Game state Error");
        }
    }

    public void StartGame()
    {
        Debug.Log("Game Started");
        SceneManager.LoadScene("HouseLevel");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void ReturnToMenu()
    {
        gameState = 0;
    }

    public void GameOver()
    {
        gameState = -1;
        SceneManager.LoadScene("Main_Menu");
    }

    public void win()
    {
        gameState = -2;
        SceneManager.LoadScene("Main_Menu");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void EndGame()
    {
        Application.Quit();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (previousGameState == 0)
        {
            gameState = 1;
        }
    }
}
