using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevel(int index)
    {

        switch(index)
        {
            case 2:
                {
                    SceneManager.LoadScene(index);

#if UNITY_EDITOR
                    Debug.Log("Loading Level 2");
#endif
                    break;
                }
                
            case 3:
                {
                    SceneManager.LoadScene(index);

#if UNITY_EDITOR
                    Debug.Log("Loading Level 3");
#endif
                    break;
                }
            case 4:
                {

                    SceneManager.LoadScene(index);

#if UNITY_EDITOR
                    Debug.Log("Loading Level 4");
#endif
                    break;
                }

        }

    }
}
