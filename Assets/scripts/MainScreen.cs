using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("Levels");

    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {

    }

}
