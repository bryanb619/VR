using System;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(BoxCollider))]
public class Button : MonoBehaviour
{
    [SerializeField]private RailSystem railSystem;
    [SerializeField]private int changeDestinationNumber;
    [SerializeField]private GameObject[] otherButtons;
    
    [SerializeField] private int levelNumber;
    private TriggerLoadScene _triggerLoadScene;
    
    [SerializeField] private bool useSound;
    private AudioSource _audioSource;

    private void Awake()
    {
        _triggerLoadScene   = FindObjectOfType<TriggerLoadScene>();
        _audioSource        = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Untagged"))
        {
            ApplyActions(); 

            if (useSound)
            {
                SoundEffect(); 
            }

            foreach (GameObject button in  otherButtons)
            {
                button.gameObject.GetComponent<Rigidbody>().detectCollisions = false;
                button.gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }

    private void ApplyActions()
    {
        railSystem.ChangeDestination(); // change destination of cart
            
        _triggerLoadScene.GetLevelNumber(levelNumber); // apply next level Number to trigger Load Scene
    }
    
    private void SoundEffect()
    {
        _audioSource.Play();
    }
}
