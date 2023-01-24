using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMain(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);
    }

    public void LoadSettings(string Settings)
    {
        SceneManager.LoadScene(Settings);
    }

    public void LoadLevel1(string Level1)
    {
        SceneManager.LoadScene(Level1);
    }

    public void LoadHS(string HighScores)
    {
        SceneManager.LoadScene(HighScores);
    }
}
