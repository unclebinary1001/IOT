using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartScreen : MonoBehaviour
{ 
    public void home()
    {
        SceneManager.LoadScene("StartScreen");
    }
    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }
    public void play()
    {
        SceneManager.LoadScene("Play");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
