using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    [SerializeField]private GameObject objectToSpawn, spawnPoint;

    private void Start()
    {
        SpawnObject();
    }

    private void SpawnObject()
    {
        Instantiate(objectToSpawn, spawnPoint.transform.position, Quaternion.identity);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Untagged"))
        {
            other.gameObject.tag = "ThrowableObject";
            StartCoroutine(SpawnTimer());
            SpawnObject();
        }
    }
    
    private IEnumerator SpawnTimer()
    {
        yield return new WaitForSeconds(5f);
    }

}
