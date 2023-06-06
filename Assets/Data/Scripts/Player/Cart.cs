using UnityEngine;
using UnityEngine.AI;

public class Cart : MonoBehaviour
{
    [SerializeField] private float _normalSpeed = 5f;
    private NavMeshAgent _agent;

    [SerializeField] private Transform _target;

    private Vector3 _destination; 



    private void Awake()
    {
        _agent                  = GetComponent<NavMeshAgent>();  
        _agent.speed            = _normalSpeed;    
        _agent.updateRotation   = true;
    }

    // Start is called before the first frame update
    void Start()
    {
       //_agent.SetDestination(_target.position); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destination(Transform dest) 
    {
        if (Vector3.Distance(_destination, dest.position) > 1.0f) // if true set new position
        {
            _destination = dest.position;
            _agent.destination = _destination;
        }
        else // if false set destination to current position    
        {
#if UNITY_EDITOR
            Debug.Log("Destination reached");
#endif
            _agent.SetDestination(dest.position);
            _agent.destination = dest.position;
        }
    }

    public void RotateAround(Quaternion newRotation)
    {
      
        //transform.rotation = newRotation;

    }
}
