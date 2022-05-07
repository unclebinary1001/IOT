using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auddelay : MonoBehaviour
{
    public AudioSource notifys;
    // Start is called before the first frame update
    void Start()
    {
        notifys = GetComponent<AudioSource>();
        notifys.PlayDelayed(10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
