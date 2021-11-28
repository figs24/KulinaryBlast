using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioSource lagu1, lagu2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown()
    {
        if (gameObject.name == "lag1")
        {
            lagu1.Play();
            lagu2.Stop();
        }
        else
        {
            lagu1.Stop();
            lagu2.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
