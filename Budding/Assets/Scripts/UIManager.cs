using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   public GameObject gameOverMenu;
   public GameObject pauseMenu;

// ------------------------------------------------------------------- //

   private void OnEnable()
   {
    PlayerHealth.OnPlayerDeath += EnableGameOverMenu;
   }

   private void OnDisable()
   {
    PlayerHealth.OnPlayerDeath -= EnableGameOverMenu;
   }

   public void EnableGameOverMenu()
   {
    gameOverMenu.SetActive(true);
   }
   
   // ------------------------------------------------------------------- //

   private void GamePaused()
   {
    pauseMenu.SetActive(true);
   }

   private void GameUnpaused()
   {
    pauseMenu.SetActive(false);
   }

// ------------------------------------------------------------------- //

   public void GoToMainMenu()
   {
    SceneManager.LoadScene("MainMenu");
   }

// ------------------------------------------------------------------- //

   public void GoToSettings()
   {
    SceneManager.LoadScene("Settings");
   }

// ------------------------------------------------------------------- //

   public void HighScores()
   {
    SceneManager.LoadScene("HighScores");
   }
}
