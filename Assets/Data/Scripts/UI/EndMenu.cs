using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void ExitToStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
