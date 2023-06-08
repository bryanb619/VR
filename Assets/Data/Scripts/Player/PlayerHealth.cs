using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health = 3; 
    private GameManager _gameManager;

    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>(); 
    }


    public void ApplyHit()
    {
        Death(); 
    }

    private void Death()
    {
#if UNITY_EDITOR
        Debug.Log("Player is dead");
#endif
        _gameManager.TerminateLevel();
    }
}
