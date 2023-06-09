using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPickerTrigger : MonoBehaviour
{
    [SerializeField] private int levelNumber;
    private TriggerLoadScene triggerLoadScene;
    [SerializeField]private RailSystem railSystem;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Untagged"))
        {
            triggerLoadScene = FindObjectOfType<TriggerLoadScene>();
            triggerLoadScene.GetLevelNumber(levelNumber);
            railSystem.ChangeDestination();
        }
    }
}
