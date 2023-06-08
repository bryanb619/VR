using System;
using UnityEngine;

public class Pause : MonoBehaviour
{
    
    [SerializeField] private GameObject pauseMenu;
    
    private GameState _state;
    private GameManager _gameManager;

    private void Awake()
    {
        _gameManager                    = FindObjectOfType<GameManager>(); 
        GameManager.OnGameStateChanged  += GameManager_OnGameStateChanged;
        pauseMenu.SetActive(false);
    }

    void Start()
    {
        
    }

    private void GameManager_OnGameStateChanged(GameState state)
    {
        switch (state)
        {
            case GameState.Paused:
            {
                HandlePause(); 
                break;
            }
                
            case GameState.Gameplay:
            {
                HandlePlay(); 
                break;
            }
                
            default:
                throw new ArgumentOutOfRangeException(nameof(state), state, null);
        }
    }


    private void HandlePause()
    {
        
    }

    private void HandlePlay()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            switch (_state)
            {
                case GameState.Paused:
                {
                    if (pauseMenu.activeSelf)
                    {
                        pauseMenu.SetActive(false);
                        _gameManager.UpdateGameState(GameState.Gameplay);
#if UNITY_EDITOR
                        Debug.Log("Game Resumed");           
#endif
                    }
                    break;
                }
                case GameState.Gameplay:
                {
                    if (!pauseMenu.activeSelf)
                    {
                        pauseMenu.SetActive(true);
                        _gameManager.UpdateGameState(GameState.Paused);
#if UNITY_EDITOR
                        Debug.Log("Game Paused");        
#endif
                    }
                    break;
                }
            }
        }
        
    }
}
