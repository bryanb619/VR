using System;
using System.Collections;
using UnityEngine;

public class RailSystem : MonoBehaviour
{
    [SerializeField] private Transform[] target;

    private Cart _cart;

    private void Awake()
    {
        _cart = FindObjectOfType<Cart>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _cart.Destination(target[0]);
    }

    // Update is called once per frame
    void Update()
    {
        // test 

        if(Input.GetKeyDown(KeyCode.K))
        {
            ChangeDestination(); 

            // DestroyPoints(_target[0]); destruction for safety
        }   
    }

    public void ChangeDestination()
    {
        int i = 0;

        for (i = 0; i < 10; i++)
        {
            switch (i)
            {
                case 1:
                    {
                        _cart.Destination(target[1]);
                        DestroyPoints(target[0]);
                        break;
                    }
                case 2:
                    {
                        _cart.Destination(target[1]);

                        //DestroyPoints(target[0]);
                        break;
                    }
                case 3:
                    {
                        _cart.Destination(target[1]);

                        //DestroyPoints(target[0]);
                        break;
                    }
                case 4:
                    {
                        _cart.Destination(target[1]);

                        //DestroyPoints(target[0]);
                        break;
                    }
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
