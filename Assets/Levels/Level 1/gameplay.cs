using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay : MonoBehaviour
{
    public AudioSource notify;
    // Start is called before the first frame update
    void Start()
    {
        notify = GetComponent<AudioSource>();
        notify.PlayDelayed(10.0f);
        Invoke("Next", 5);

    }
    public void Next()
    {
        //create button
    }
    public void start()
    {
        notify.Pause();
        //destroy sound
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
