using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignHit : MonoBehaviour
{

    [SerializeField]private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if(animator == null)
            animator = GetComponentInParent<Animator>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("ThrowableObject"))
            animator.SetTrigger("GetHit");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
            animator.SetTrigger("Activate");
    }
}
