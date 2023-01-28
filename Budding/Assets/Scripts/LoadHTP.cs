using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHTP : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string HowToPlay)
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
