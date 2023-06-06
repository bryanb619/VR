using UnityEngine;

public class TriggerHit : MonoBehaviour
{

    private BoxCollider _boxCollider;

    private void Awake()
    {
        _boxCollider = GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ThrowObject")
        {
            Debug.Log("ThrowObject hit trigger");
            PerformTriggerAction();
        }
    }

    private void PerformTriggerAction()
    {
        _boxCollider.enabled = false;

        Debug.Log("Trigger has been hit");
    }
}
