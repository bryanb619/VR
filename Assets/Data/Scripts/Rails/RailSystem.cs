using System;
using System.Collections;
using UnityEngine;

public class RailSystem : MonoBehaviour
{
    [SerializeField] private Transform[] target;

    private Cart _cart;
    
    private int _i = 0;  

    private void Awake()
    {
        _cart = FindObjectOfType<Cart>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartPoint(); 
    }

    // Update is called once per frame
    void Update()
    {
        // test 

        #if UNITY_EDITOR
        if(Input.GetKeyDown(KeyCode.K))
        {
            ChangeDestination();
            // DestroyPoints(_target[0]); destruction for safety
        }   
        #endif
    }
    
    private void StartPoint()
    {
        _cart.Destination(target[0]);
    }

    public void ChangeDestination()
    {
        _i++; 
        
        switch (_i)
        {
            case 1:
            {
                if (target[0] != null)
                {
                    DestroyPoints(target[0]);
                }
                
                _cart.Destination(target[1]);
                break;
            }
            case 2:
            {
                
                if (target[1] != null)
                {
                    DestroyPoints(target[1]);
                }
                _cart.Destination(target[2]);

                break;
            }
            case 3:
            {
                
                if (target[2] != null)
                {
                    DestroyPoints(target[2]);
                }
                
                _cart.Destination(target[3]);
                
                break;
            }
            case 4:
            {
                _cart.Destination(target[4]);
                
                if (target[3] != null)
                {
                    DestroyPoints(target[3]);
                }
                
                break;
            }
            case 5:
            {
                
                if (target[4] != null)
                {
                    DestroyPoints(target[4]);
                }
                _cart.Destination(target[5]);
                break;
            }
        }

        
    }

    private void DestroyPoints(Transform destroyTarget)
    {
        Destroy(destroyTarget.gameObject);

#if UNITY_EDITOR

        Debug.Log("Destroying " + destroyTarget.name);
#endif
    }
}
