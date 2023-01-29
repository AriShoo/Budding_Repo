using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject firstSelectedGameObject;

   // private void OnEnable()
   //{
  //  PlayerHealth.OnPlayerDeath += EnableGameOverMenu;
    
  // }

  // private void OnDisable()
  // {
    //PlayerHealth.OnPlayerDeath -= EnableGameOverMenu;
    
  // }

   public void EnableGameOverMenu()
   {
    gameOverMenu.SetActive(true);

   }

   public void GoToMainMenu()
    {
        
        SceneManager.LoadScene("MainMenu");
        
    }

    public void ReloadLevel()
    {
         SceneManager.GetActiveScene(); 
         SceneManager.LoadScene("Level1");
    }
}
