using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartMenu : MonoBehaviour
{
    public void RestartLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Game");
    }
    public void ExitToStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

}
