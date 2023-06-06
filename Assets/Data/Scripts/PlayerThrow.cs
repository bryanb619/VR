using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{

    private float _time;
    private float _throwRate = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckForKey(); 
    }

    private void CheckForKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed");
            PerformThrowAction(); 
        }
    }


    private void PerformThrowAction()
    {
        if(Time.time > _time)
        {
            
            ThrowObject();
            _time = Time.time + _throwRate;
        }

        Debug.Log("Throwing the object");
    }

    private void ThrowObject()
    {
        // Instantiate(_spawnObject, transform.position, Quaternion.identity);
    }

 
}
