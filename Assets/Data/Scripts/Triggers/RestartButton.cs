using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField]private bool isThisExitButton;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isThisExitButton)
        {
            EndGame();
        }
        else
        {
            RestartLevel();
        }
    }

    public void RestartLevel()
    {
        gameManager.StartScene();
    }
    
    public void EndGame()
    {
        gameManager.EndGame();
    }
}
