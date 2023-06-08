using UnityEngine;
using UnityEngine.AI;
using FMODUnity; 

public class Cart : MonoBehaviour
{
    [Header("Cart Speed")]
    [Range(0, 10)]
    [SerializeField]    private float normalSpeed = 4f;
    [Range(0.1f,100f)]
    [SerializeField]    private float acceleration = 1f;
                        private NavMeshAgent _agent;

    [Header("Destination List")]
    [SerializeField]    private Transform _target;

                        private Vector3 _destination;

    [SerializeField]    private StudioEventEmitter soundWheels, soundCrackling;
    [SerializeField]    private StudioEventEmitter[] soundsMove;


    private void Awake()
    {
        _agent                  = GetComponent<NavMeshAgent>();  
        _agent.speed            = normalSpeed;    
        _agent.acceleration     = acceleration;
        _agent.updateRotation   = true;
        
        

    }

    private void Start()
    {
        _agent.destination = _target.position;

    }

    private void Update()
    {
        //if (_agent.velocity.magnitude > 0.1f)
        if(Input.GetKeyDown(KeyCode.H))
        {
            foreach (StudioEventEmitter emitter in soundsMove)
            {
                emitter.EventInstance.setPaused(false);
            }
        }
       
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

            _agent.SetDestination(dest.position);
            _agent.destination = dest.position;
        }

        

    }

    public void RotateAround(Quaternion newRotation)
    {
        //transform.rotation = newRotation;
    }
}
