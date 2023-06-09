using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");

#if UNITY_EDITOR
        Debug.Log("Loading Game");
#endif
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}
