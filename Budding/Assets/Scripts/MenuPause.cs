using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MenuPause : MonoBehaviour
{
    public GameObject pauseMenu;
   // public GameObject pauseFirstButton;
    public static bool isPaused;

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
        //EventSystem.current.SetSelectedGameObject(null);
       // EventSystem.current.SetSelectedGameObject(pauseFirstButton);

    }

    public void resumeGame()
    {
        
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
       // EventSystem.current.SetSelectedGameObject(null);
    
    }

}
