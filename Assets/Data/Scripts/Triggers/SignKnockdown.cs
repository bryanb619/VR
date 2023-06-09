using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignKnockdown : MonoBehaviour
{
    [SerializeField] private int totalSigns;
    private bool signsGotUp;
    [SerializeField] private RailSystem railSystem;
    private GameManager gameManager;
    [SerializeField]private bool thisLevel1;
    private void Start()
    {
        totalSigns = 0;
        signsGotUp = false;
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (signsGotUp && totalSigns == 0)
        {
            StopCoroutine(DeathTimer());
            railSystem.ChangeDestination();
            signsGotUp = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sign"))
        {
            totalSigns += 1;
            signsGotUp = true;
            StartCoroutine(DeathTimer());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sign"))
        {
            totalSigns -= 1;
        }
    }

    private void DeathCheck()
    {
        if (totalSigns > 0 && thisLevel1)
        {
            gameManager.RestartLevel();
        }
        else if (totalSigns > 0 && !thisLevel1)
        {
            gameManager.RestartLevel2();
        }
    }
    
    private IEnumerator DeathTimer()
    {
        yield return new WaitForSeconds(20f);
        DeathCheck();
    }
}
