using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    [SerializeField] private Transform objectToSpawn;
    [SerializeField]private Transform spawnPoint;

    private void Start()
    {
        SpawnObject();
    }

    private void SpawnObject()
    {
        Transform newObject = Instantiate(objectToSpawn, spawnPoint.transform.position, spawnPoint.rotation) as Transform;
        newObject.parent = this.gameObject.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            other.gameObject.tag = "ThrowableObject";
            StartCoroutine(SpawnTimer());
        }
    }
    
    private IEnumerator SpawnTimer()
    {
        yield return new WaitForSeconds(1f);
        SpawnObject();
    }

}
