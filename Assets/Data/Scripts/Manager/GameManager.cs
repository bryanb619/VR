using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState{
    Gameplay,
    Paused,
    StartMenu
}

public class GameManager : MonoBehaviour
{
    [SerializeField] private string startMenu;
    public GameState state;
    public static GameManager Instance;
    public static event Action<GameState> OnGameStateChanged;

    private void Awake()
    {
        //DontDestroyOnLoad(this);

        Instance = this;

        GameManager[] otherManagers = FindObjectsOfType<GameManager>();

        for (int i = 1; i < otherManagers.Length; i++)
        {
            Destroy(otherManagers[i].gameObject);
        }

        UpdateGameState(GameState.Gameplay);

    }
    
    public void UpdateGameState(GameState newGamestate)
    {
        state = newGamestate;

        switch (newGamestate)
        {
            case GameState.Gameplay:
                {
                    HandleGameplay();
                    break;
                }
            case GameState.Paused:
                {
                    HandlePaused();
                    break;
                }

            case GameState.StartMenu:
                {
                    print("start menu");
                    break;
                }
            default: { throw new ArgumentOutOfRangeException(nameof(newGamestate), newGamestate, null); }
        }
        OnGameStateChanged?.Invoke(newGamestate);
    }


    private void HandleGameplay()
    {
        Time.timeScale = 1;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void HandlePaused()
    {
        Time.timeScale = 0;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    #region Level Management
    public void NextLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
    
    public void StartScene()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level1_Gameover"); 
    }
    
    public void RestartLevel2()
    {
        SceneManager.LoadScene("Level2_Gameover"); 
    }
    
    public void EndGame()
    {
        Application.Quit();
    }
    #endregion
}
