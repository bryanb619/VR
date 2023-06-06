using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackFlow : MonoBehaviour
{
    private Cart _cart;
    private BoxCollider _boxCollider;


    private void Awake()
    {
        //_cart = GameObject.Find("Cart").GetComponent<Cart>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        _cart = other.GetComponent<Cart>();

        if(_cart != null)
        {
            Debug.Log("Cart has entered the trigger"); 
            _boxCollider.enabled = false;   
            PerformTriggerAction();
        }
    }

    private void PerformTriggerAction()
    {
        Quaternion rotation = transform.rotation;
        Debug.Log(rotation);
        _cart.RotateAround(rotation);

    }
}
