using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Cart : MonoBehaviour
{
    [SerializeField] private float _normalSpeed = 5f;
    private NavMeshAgent _agent;

    [SerializeField] private Transform _target; 



    private void Awake()
    {
        _agent                  = GetComponent<NavMeshAgent>();  
        _agent.speed            = _normalSpeed;    
        _agent.updateRotation   = false;
    }

    // Start is called before the first frame update
    void Start()
    {
       _agent.SetDestination(_target.position); 
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void Destination(Transform dest) 
    {
        _agent.SetDestination(dest.position);
    }

    public void RotateAround(Quaternion newRotation)
    {
      transform.rotation = newRotation;

    }
}
