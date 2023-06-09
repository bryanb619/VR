using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPickerTrigger : MonoBehaviour
{
    [SerializeField] private int levelNumber;
    private TriggerLoadScene triggerLoadScene;
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            triggerLoadScene = FindObjectOfType<TriggerLoadScene>();
            triggerLoadScene.GetLevelNumber(levelNumber);
        }
    }
}
