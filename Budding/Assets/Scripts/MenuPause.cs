using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuPause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject pauseFirstButton;
    public static bool isPaused;
    public GameObject firstSelectedGameObject;
    public Button Resume;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Pause"))
        {
            if (isPaused)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }
    }

    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }

    public void resumeGame()
    {
        Input.GetButtonDown("Jump");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    
    }

    public void GoToMainMenu()
    {
        Input.GetButtonDown("Jump");
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        
    }

    public void QuitGame()
    {
        Input.GetButtonDown("Jump");
        Application.Quit();
        
    }

}
