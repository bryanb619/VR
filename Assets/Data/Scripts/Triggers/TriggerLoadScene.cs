using UnityEngine;
public class TriggerLoadScene : MonoBehaviour
{ 
   private GameManager _gameManager;
   private int _levelNumber;
   
   private void Awake()
   {
      _gameManager = FindObjectOfType<GameManager>(); 
   }
   
   public void GetLevelNumber(int levelNumber)
   {
      _levelNumber = levelNumber;
   }

   void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
         _gameManager.NextLevel(_levelNumber);
      }
   }
}
