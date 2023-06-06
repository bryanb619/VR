using UnityEngine;

public class TriggerEnter : MonoBehaviour
{

    [SerializeField] private GameObject _spawnObject;


    private void Awake()
    {   
       
    }

    private void Start()
    {
        
    }

    private void OndTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player has entered the trigger");
            PerformTriggerAction(); 
        }
    }  


    private void PerformTriggerAction()
    {
        Instantiate(_spawnObject, transform.position, Quaternion.identity);
    }
    
}
