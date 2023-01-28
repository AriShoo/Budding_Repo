using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string Level1)
    {
        SceneManager.LoadScene("Level1");
    }

}
