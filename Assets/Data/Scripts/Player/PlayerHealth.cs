using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]    private int health = 3; 
                        private GameManager _gameManager;
                        
    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>(); 
    }
    
    public void DeadOnScene1()
    {
#if UNITY_EDITOR
        Debug.Log("Player is dead in level 1");
#endif
        _gameManager.RestartLevel();
    }
    
    public void DeadOnScene2()
    {
#if UNITY_EDITOR
        Debug.Log("Player is dead in level 2");
#endif
        _gameManager.RestartLevel2();
    }
}
