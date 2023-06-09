using UnityEngine;
using FMODUnity;

public class SoundPlay : MonoBehaviour
{
    [SerializeField] private EventReference sound;
    
    // Start is called before the first frame update
    private void Start()
    {
        RuntimeManager.PlayOneShot(sound, transform.position);
    }
}
