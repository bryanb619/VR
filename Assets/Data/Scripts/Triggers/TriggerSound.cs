using System;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    
    private BoxCollider _boxCollider;
    // Start is called before the first frame update

    private void Awake()
    {
        _boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _boxCollider.enabled = false;
            audio.Play();
        }
    }
}
