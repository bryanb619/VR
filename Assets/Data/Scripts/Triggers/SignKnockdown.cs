using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignKnockdown : MonoBehaviour
{
    private int totalSigns;
    private bool signsGotUp;
    [SerializeField] private RailSystem railSystem;
    private GameManager gameManager;
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

    private IEnumerator DeathTimer()
    {
        yield return new WaitForSeconds(20f);
        gameManager.EndScene();
    }
}
