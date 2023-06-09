using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField]private RailSystem railSystem;
    [SerializeField]private int changeDestinationNumber;
    [SerializeField]private GameObject[] otherButtons;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Untagged"))
        {
            railSystem.ChangeDestination();

            foreach (GameObject button in  otherButtons)
            {
                button.gameObject.GetComponent<Rigidbody>().detectCollisions = false;
                button.gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }
}
